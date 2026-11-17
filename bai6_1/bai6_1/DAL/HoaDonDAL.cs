using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_1.DTO;

namespace bai6_1.DAL
{
    public class HoaDonDAL
    {
        public List<HoaDonDTO> GetAll()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return DbHelper.MockDb.HoaDons.OrderByDescending(h => h.MaHD).ToList();
            }

            var list = new List<HoaDonDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT h.MaHD, h.NgayLap, h.MaNV, nv.TenNV, h.MaKH, kh.TenKH, h.TongTien
                    FROM HoaDon h
                    INNER JOIN NhanVien nv ON h.MaNV = nv.MaNV
                    LEFT JOIN KhachHang kh ON h.MaKH = kh.MaKH
                    ORDER BY h.MaHD DESC";
                using var cmd = new SqlCommand(query, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new HoaDonDTO
                    {
                        MaHD = Convert.ToInt32(reader["MaHD"]),
                        NgayLap = Convert.ToDateTime(reader["NgayLap"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        TenNV = reader["TenNV"].ToString() ?? "",
                        MaKH = reader["MaKH"] == DBNull.Value ? null : Convert.ToInt32(reader["MaKH"]),
                        TenKH = reader["TenKH"] == DBNull.Value ? "Khách lẻ" : (reader["TenKH"].ToString() ?? ""),
                        TongTien = Convert.ToDecimal(reader["TongTien"])
                    });
                }
            }
            return list;
        }

        /// <summary>
        /// Thực thi SqlTransaction bán hàng và thanh toán hóa đơn:
        /// 1. Chèn 1 bản ghi vào HoaDon (Lấy MaHD mới)
        /// 2. Chèn các bản ghi vào ChiTietHoaDon
        /// 3. Trừ SoLuongTon tương ứng trong SanPham (Rollback nếu SoLuongTon < SoLuong bán)
        /// 4. Cộng điểm tích lũy cho Khách hàng (DiemTichLuy += TongTien / 100000)
        /// 5. Gọi trans.Commit() khi hoàn tất
        /// </summary>
        public (bool Success, string Message, int MaHD) ThanhToanHoaDon(
            int maNV, 
            int? maKH, 
            decimal tongTien, 
            List<GioHangItemDTO> gioHang,
            bool forceSimulateRollback = false)
        {
            if (gioHang == null || gioHang.Count == 0)
            {
                return (false, "Giỏ hàng rỗng, không thể lập hóa đơn!", 0);
            }

            // Nếu DB không khả dụng, thực hiện mô phỏng giao dịch theo đúng chuẩn ACID
            if (!DbHelper.CheckDatabaseConnection())
            {
                return MockThanhToanHoaDon(maNV, maKH, tongTien, gioHang, forceSimulateRollback);
            }

            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                // Kiểm tra giả lập rollback nếu có yêu cầu kiểm thử
                if (forceSimulateRollback)
                {
                    throw new Exception("Thử nghiệm Rollback giao dịch: Phát hiện cố tình bán vượt tồn kho!");
                }

                // 1. Chèn 1 bản ghi vào bảng HoaDon và lấy MaHD vừa sinh
                string sqlInsertHD = @"
                    INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) 
                    OUTPUT INSERTED.MaHD
                    VALUES (@NgayLap, @MaNV, @MaKH, @TongTien)";

                int newMaHD = 0;
                using (var cmdHD = new SqlCommand(sqlInsertHD, conn, trans))
                {
                    cmdHD.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.DateTime) { Value = DateTime.Now });
                    cmdHD.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.Int) { Value = maNV });
                    cmdHD.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.Int) { Value = (object?)maKH ?? DBNull.Value });
                    cmdHD.Parameters.Add(new SqlParameter("@TongTien", SqlDbType.Decimal) { Value = tongTien });

                    newMaHD = Convert.ToInt32(cmdHD.ExecuteScalar());
                }

                // 2. Duyệt qua từng sản phẩm trong giỏ hàng để kiểm tra tồn kho và thêm ChiTietHoaDon
                foreach (var item in gioHang)
                {
                    // Kiểm tra tồn kho trước khi trừ
                    string sqlCheckTon = "SELECT SoLuongTon, TenSP FROM SanPham WHERE MaSP = @MaSP";
                    int currentTon = 0;
                    string tenSP = "";
                    using (var cmdCheck = new SqlCommand(sqlCheckTon, conn, trans))
                    {
                        cmdCheck.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 20) { Value = item.MaSP });
                        using var reader = cmdCheck.ExecuteReader();
                        if (reader.Read())
                        {
                            currentTon = Convert.ToInt32(reader["SoLuongTon"]);
                            tenSP = reader["TenSP"].ToString() ?? item.MaSP;
                        }
                        else
                        {
                            throw new Exception($"Không tìm thấy sản phẩm '{item.MaSP}' trong CSDL!");
                        }
                    }

                    // Nếu SoLuongTon < SoLuong bán -> gọi trans.Rollback() và báo lỗi
                    if (currentTon < item.SoLuong)
                    {
                        throw new Exception($"Sản phẩm '{tenSP}' không đủ hàng trong kho! (Tồn: {currentTon}, Yêu cầu bán: {item.SoLuong}). Giao dịch đã bị ROLLBACK hoàn toàn.");
                    }

                    // 2. Chèn vào bảng ChiTietHoaDon
                    string sqlInsertCT = @"
                        INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia)
                        VALUES (@MaHD, @MaSP, @SoLuong, @DonGia)";
                    using (var cmdCT = new SqlCommand(sqlInsertCT, conn, trans))
                    {
                        cmdCT.Parameters.Add(new SqlParameter("@MaHD", SqlDbType.Int) { Value = newMaHD });
                        cmdCT.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 20) { Value = item.MaSP });
                        cmdCT.Parameters.Add(new SqlParameter("@SoLuong", SqlDbType.Int) { Value = item.SoLuong });
                        cmdCT.Parameters.Add(new SqlParameter("@DonGia", SqlDbType.Decimal) { Value = item.DonGia });
                        cmdCT.ExecuteNonQuery();
                    }

                    // 3. Trừ SoLuongTon tương ứng trong bảng SanPham
                    string sqlUpdateTon = @"
                        UPDATE SanPham 
                        SET SoLuongTon = SoLuongTon - @SoLuong 
                        WHERE MaSP = @MaSP";
                    using (var cmdTon = new SqlCommand(sqlUpdateTon, conn, trans))
                    {
                        cmdTon.Parameters.Add(new SqlParameter("@SoLuong", SqlDbType.Int) { Value = item.SoLuong });
                        cmdTon.Parameters.Add(new SqlParameter("@MaSP", SqlDbType.VarChar, 20) { Value = item.MaSP });
                        cmdTon.ExecuteNonQuery();
                    }
                }

                // 4. Cộng điểm tích lũy cho Khách hàng (DiemTichLuy += TongTien / 100000)
                if (maKH.HasValue && maKH.Value > 0)
                {
                    int diemCong = (int)(tongTien / 100000m);
                    if (diemCong > 0)
                    {
                        string sqlUpdateDiem = "UPDATE KhachHang SET DiemTichLuy = DiemTichLuy + @DiemCong WHERE MaKH = @MaKH";
                        using var cmdDiem = new SqlCommand(sqlUpdateDiem, conn, trans);
                        cmdDiem.Parameters.Add(new SqlParameter("@DiemCong", SqlDbType.Int) { Value = diemCong });
                        cmdDiem.Parameters.Add(new SqlParameter("@MaKH", SqlDbType.Int) { Value = maKH.Value });
                        cmdDiem.ExecuteNonQuery();
                    }
                }

                // 5. Gọi trans.Commit() khi hoàn tất
                trans.Commit();
                return (true, $"Thanh toán thành công hóa đơn #{newMaHD}! Đã trừ kho và cập nhật điểm tích lũy.", newMaHD);
            }
            catch (Exception ex)
            {
                // Rollback giao dịch nếu có bất kỳ lỗi nào xảy ra
                try
                {
                    trans.Rollback();
                }
                catch { }

                return (false, $"[TRANSACTION ROLLBACK LỖI]: {ex.Message}", 0);
            }
        }

        private (bool Success, string Message, int MaHD) MockThanhToanHoaDon(
            int maNV,
            int? maKH,
            decimal tongTien,
            List<GioHangItemDTO> gioHang,
            bool forceSimulateRollback)
        {
            if (forceSimulateRollback)
            {
                return (false, "[TRANSACTION ROLLBACK THỬ NGHIỆM]: Phát hiện số lượng bán vượt tồn kho! Giao dịch SqlTransaction bị HỦY BỎ (Rollback), dữ liệu hoàn nguyên 100%.", 0);
            }

            // Kiểm tra tồn kho của tất cả sản phẩm
            foreach (var item in gioHang)
            {
                var sp = DbHelper.MockDb.SanPhams.FirstOrDefault(s => s.MaSP.Equals(item.MaSP, StringComparison.OrdinalIgnoreCase));
                if (sp == null)
                {
                    return (false, $"[TRANSACTION ROLLBACK]: Sản phẩm mã {item.MaSP} không tồn tại!", 0);
                }
                if (sp.SoLuongTon < item.SoLuong)
                {
                    return (false, $"[TRANSACTION ROLLBACK]: Sản phẩm '{sp.TenSP}' không đủ hàng tồn kho! (Tồn: {sp.SoLuongTon}, Bán: {item.SoLuong}). Toàn bộ giao dịch bị hủy bỏ.", 0);
                }
            }

            // Thực thi chèn và trừ kho
            int newMaHD = DbHelper.MockDb.HoaDons.Count > 0 ? DbHelper.MockDb.HoaDons.Max(h => h.MaHD) + 1 : 1;
            var nv = DbHelper.MockDb.NhanViens.FirstOrDefault(n => n.MaNV == maNV);
            var kh = maKH.HasValue ? DbHelper.MockDb.KhachHangs.FirstOrDefault(k => k.MaKH == maKH.Value) : null;

            var hd = new HoaDonDTO
            {
                MaHD = newMaHD,
                NgayLap = DateTime.Now,
                MaNV = maNV,
                TenNV = nv?.TenNV ?? $"NV #{maNV}",
                MaKH = maKH,
                TenKH = kh?.TenKH ?? "Khách lẻ",
                TongTien = tongTien
            };
            DbHelper.MockDb.HoaDons.Add(hd);

            foreach (var item in gioHang)
            {
                DbHelper.MockDb.ChiTietHoaDons.Add(new ChiTietHoaDonDTO
                {
                    MaHD = newMaHD,
                    MaSP = item.MaSP,
                    TenSP = item.TenSP,
                    SoLuong = item.SoLuong,
                    DonGia = item.DonGia
                });

                var sp = DbHelper.MockDb.SanPhams.First(s => s.MaSP.Equals(item.MaSP, StringComparison.OrdinalIgnoreCase));
                sp.SoLuongTon -= item.SoLuong;
            }

            if (kh != null)
            {
                int diemCong = (int)(tongTien / 100000m);
                kh.DiemTichLuy += diemCong;
            }

            return (true, $"Thanh toán thành công hóa đơn #{newMaHD}! Đã trừ kho và cộng điểm tích lũy.", newMaHD);
        }
    }
}
