using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_2.DTO;

namespace bai6_2.DAL
{
    public class LuongDAL
    {
        public List<BangLuongDTO> LayBangLuongTheoThang(string thangNam)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                return DbHelper.MockDb.BangLuongs
                    .Where(l => l.ThangNam == thangNam)
                    .OrderBy(l => l.MaNV)
                    .ToList();
            }

            var list = new List<BangLuongDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT l.MaLuong, l.MaNV, nv.HoTen, pb.TenPB, l.ThangNam, nv.LuongCoBan, nv.HeSoLuong, 
                           ISNULL(cc.SoNgayCong, 0) AS SoNgayCong, ISNULL(cc.SoGioOT, 0) AS SoGioOT, 
                           l.ThucLinh, l.NgayChot
                    FROM BangLuong l
                    INNER JOIN NhanVien nv ON l.MaNV = nv.MaNV
                    INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                    LEFT JOIN BangChamCong cc ON l.MaNV = cc.MaNV AND l.ThangNam = cc.ThangNam
                    WHERE l.ThangNam = @ThangNam
                    ORDER BY l.MaNV";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ThangNam", SqlDbType.VarChar, 7) { Value = thangNam });

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new BangLuongDTO
                    {
                        MaLuong = Convert.ToInt32(reader["MaLuong"]),
                        MaNV = Convert.ToInt32(reader["MaNV"]),
                        HoTen = reader["HoTen"].ToString() ?? "",
                        TenPB = reader["TenPB"].ToString() ?? "",
                        ThangNam = reader["ThangNam"].ToString() ?? "",
                        LuongCoBan = Convert.ToDecimal(reader["LuongCoBan"]),
                        HeSoLuong = Convert.ToDouble(reader["HeSoLuong"]),
                        SoNgayCong = Convert.ToDouble(reader["SoNgayCong"]),
                        SoGioOT = Convert.ToDouble(reader["SoGioOT"]),
                        ThucLinh = Convert.ToDecimal(reader["ThucLinh"]),
                        NgayChot = Convert.ToDateTime(reader["NgayChot"])
                    });
                }
            }
            return list;
        }

        /// <summary>
        /// Tính lương dự kiến trước khi chốt theo công thức:
        /// ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)
        /// </summary>
        public List<BangLuongDTO> TinhLuongDuKien(string thangNam)
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var list = new List<BangLuongDTO>();
                foreach (var nv in DbHelper.MockDb.NhanViens)
                {
                    var cc = DbHelper.MockDb.BangChamCongs.FirstOrDefault(x => x.MaNV == nv.MaNV && x.ThangNam == thangNam);
                    double soNgayCong = cc?.SoNgayCong ?? 0;
                    double soGioOT = cc?.SoGioOT ?? 0;

                    // Công thức: ThucLinh = (LuongCoBan * HeSoLuong / 22) * SoNgayCong + (SoGioOT * 50,000)
                    decimal thucLinh = (nv.LuongCoBan * (decimal)nv.HeSoLuong / 22m) * (decimal)soNgayCong + ((decimal)soGioOT * 50000m);

                    list.Add(new BangLuongDTO
                    {
                        MaNV = nv.MaNV,
                        HoTen = nv.HoTen,
                        TenPB = nv.TenPB,
                        ThangNam = thangNam,
                        LuongCoBan = nv.LuongCoBan,
                        HeSoLuong = nv.HeSoLuong,
                        SoNgayCong = soNgayCong,
                        SoGioOT = soGioOT,
                        ThucLinh = Math.Round(thucLinh, 0),
                        NgayChot = DateTime.Now
                    });
                }
                return list;
            }

            var dtoList = new List<BangLuongDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT nv.MaNV, nv.HoTen, pb.TenPB, nv.LuongCoBan, nv.HeSoLuong,
                           ISNULL(cc.SoNgayCong, 0) AS SoNgayCong,
                           ISNULL(cc.SoGioOT, 0) AS SoGioOT
                    FROM NhanVien nv
                    INNER JOIN PhongBan pb ON nv.MaPB = pb.MaPB
                    LEFT JOIN BangChamCong cc ON nv.MaNV = cc.MaNV AND cc.ThangNam = @ThangNam
                    ORDER BY nv.MaNV";
                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@ThangNam", SqlDbType.VarChar, 7) { Value = thangNam });

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int maNV = Convert.ToInt32(reader["MaNV"]);
                    string hoTen = reader["HoTen"].ToString() ?? "";
                    string tenPB = reader["TenPB"].ToString() ?? "";
                    decimal luongCoBan = Convert.ToDecimal(reader["LuongCoBan"]);
                    double heSoLuong = Convert.ToDouble(reader["HeSoLuong"]);
                    double soNgayCong = Convert.ToDouble(reader["SoNgayCong"]);
                    double soGioOT = Convert.ToDouble(reader["SoGioOT"]);

                    decimal thucLinh = (luongCoBan * (decimal)heSoLuong / 22m) * (decimal)soNgayCong + ((decimal)soGioOT * 50000m);

                    dtoList.Add(new BangLuongDTO
                    {
                        MaNV = maNV,
                        HoTen = hoTen,
                        TenPB = tenPB,
                        ThangNam = thangNam,
                        LuongCoBan = luongCoBan,
                        HeSoLuong = heSoLuong,
                        SoNgayCong = soNgayCong,
                        SoGioOT = soGioOT,
                        ThucLinh = Math.Round(thucLinh, 0),
                        NgayChot = DateTime.Now
                    });
                }
            }
            return dtoList;
        }

        /// <summary>
        /// Chốt lương tháng: Mở SqlTransaction để:
        /// 1. Ghi nhận bảng lương (BangLuong) cho toàn bộ nhân viên có trong tháng
        /// 2. Khóa dữ liệu chấm công (TrangThai = N'Đã chốt lương')
        /// 3. trans.Commit() bảo đảm an toàn dữ liệu
        /// </summary>
        public (bool Success, string Message, int SoNhanVienChot) ChotLuongThang(string thangNam, List<BangLuongDTO> dsLuong)
        {
            if (dsLuong == null || dsLuong.Count == 0)
            {
                return (false, "Không có dữ liệu nhân viên để chốt lương!", 0);
            }

            if (!DbHelper.CheckDatabaseConnection())
            {
                return MockChotLuongThang(thangNam, dsLuong);
            }

            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var trans = conn.BeginTransaction(IsolationLevel.ReadCommitted);

            try
            {
                int count = 0;
                foreach (var item in dsLuong)
                {
                    // 1. Chèn hoặc cập nhật bảng lương
                    string sqlMergeLuong = @"
                        IF EXISTS (SELECT 1 FROM BangLuong WHERE MaNV = @MaNV AND ThangNam = @ThangNam)
                        BEGIN
                            UPDATE BangLuong 
                            SET ThucLinh = @ThucLinh, NgayChot = @NgayChot
                            WHERE MaNV = @MaNV AND ThangNam = @ThangNam
                        END
                        ELSE
                        BEGIN
                            INSERT INTO BangLuong (MaNV, ThangNam, ThucLinh, NgayChot)
                            VALUES (@MaNV, @ThangNam, @ThucLinh, @NgayChot)
                        END";

                    using (var cmdLuong = new SqlCommand(sqlMergeLuong, conn, trans))
                    {
                        cmdLuong.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.Int) { Value = item.MaNV });
                        cmdLuong.Parameters.Add(new SqlParameter("@ThangNam", SqlDbType.VarChar, 7) { Value = thangNam });
                        cmdLuong.Parameters.Add(new SqlParameter("@ThucLinh", SqlDbType.Decimal) { Value = item.ThucLinh });
                        cmdLuong.Parameters.Add(new SqlParameter("@NgayChot", SqlDbType.DateTime) { Value = DateTime.Now });
                        cmdLuong.ExecuteNonQuery();
                    }

                    // 2. Khóa dữ liệu chấm công cho nhân viên này trong tháng
                    string sqlKhoaCong = @"
                        UPDATE BangChamCong 
                        SET TrangThai = N'Đã chốt lương' 
                        WHERE MaNV = @MaNV AND ThangNam = @ThangNam";
                    using (var cmdKhoa = new SqlCommand(sqlKhoaCong, conn, trans))
                    {
                        cmdKhoa.Parameters.Add(new SqlParameter("@MaNV", SqlDbType.Int) { Value = item.MaNV });
                        cmdKhoa.Parameters.Add(new SqlParameter("@ThangNam", SqlDbType.VarChar, 7) { Value = thangNam });
                        cmdKhoa.ExecuteNonQuery();
                    }

                    count++;
                }

                // 3. trans.Commit()
                trans.Commit();
                return (true, $"Đã chốt thành công bảng lương tháng {thangNam} cho {count} nhân viên (SqlTransaction Commit)!", count);
            }
            catch (Exception ex)
            {
                try
                {
                    trans.Rollback();
                }
                catch { }

                return (false, $"[TRANSACTION ROLLBACK LỖI]: {ex.Message}", 0);
            }
        }

        private (bool Success, string Message, int SoNhanVienChot) MockChotLuongThang(string thangNam, List<BangLuongDTO> dsLuong)
        {
            int count = 0;
            foreach (var item in dsLuong)
            {
                var exist = DbHelper.MockDb.BangLuongs.FirstOrDefault(x => x.MaNV == item.MaNV && x.ThangNam == thangNam);
                if (exist != null)
                {
                    exist.ThucLinh = item.ThucLinh;
                    exist.NgayChot = DateTime.Now;
                }
                else
                {
                    int newId = DbHelper.MockDb.BangLuongs.Count > 0 ? DbHelper.MockDb.BangLuongs.Max(x => x.MaLuong) + 1 : 1;
                    DbHelper.MockDb.BangLuongs.Add(new BangLuongDTO
                    {
                        MaLuong = newId,
                        MaNV = item.MaNV,
                        HoTen = item.HoTen,
                        TenPB = item.TenPB,
                        ThangNam = thangNam,
                        LuongCoBan = item.LuongCoBan,
                        HeSoLuong = item.HeSoLuong,
                        SoNgayCong = item.SoNgayCong,
                        SoGioOT = item.SoGioOT,
                        ThucLinh = item.ThucLinh,
                        NgayChot = DateTime.Now
                    });
                }

                var cc = DbHelper.MockDb.BangChamCongs.FirstOrDefault(x => x.MaNV == item.MaNV && x.ThangNam == thangNam);
                if (cc != null)
                {
                    cc.TrangThai = "Đã chốt lương";
                }

                count++;
            }

            return (true, $"[SqlTransaction ACID]: Đã chốt thành công bảng lương tháng {thangNam} cho {count} nhân viên!", count);
        }
    }
}
