using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_1.DTO;

namespace bai6_1.DAL
{
    public class BaoCaoDAL
    {
        /// <summary>
        /// Dùng ExecuteScalar tính tổng doanh thu trong ngày/tháng
        /// </summary>
        public DoanhThuDTO LayThongKeDoanhThu()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var today = DateTime.Today;
                var startOfMonth = new DateTime(today.Year, today.Month, 1);

                var listToday = DbHelper.MockDb.HoaDons.Where(h => h.NgayLap.Date == today).ToList();
                var listMonth = DbHelper.MockDb.HoaDons.Where(h => h.NgayLap >= startOfMonth).ToList();

                return new DoanhThuDTO
                {
                    DoanhThuHomNay = listToday.Sum(h => h.TongTien),
                    TongSoHoaDonHomNay = listToday.Count,
                    DoanhThuThangNay = listMonth.Sum(h => h.TongTien),
                    TongSoHoaDonThangNay = listMonth.Count
                };
            }

            var dto = new DoanhThuDTO();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();

                // 1. Dùng ExecuteScalar tính tổng doanh thu trong ngày
                string sqlDoanhThuNgay = @"
                    SELECT ISNULL(SUM(TongTien), 0) 
                    FROM HoaDon 
                    WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (var cmd1 = new SqlCommand(sqlDoanhThuNgay, conn))
                {
                    dto.DoanhThuHomNay = Convert.ToDecimal(cmd1.ExecuteScalar());
                }

                // 2. Dùng ExecuteScalar đếm số hóa đơn trong ngày
                string sqlCountNgay = @"
                    SELECT COUNT(*) 
                    FROM HoaDon 
                    WHERE CAST(NgayLap AS DATE) = CAST(GETDATE() AS DATE)";
                using (var cmd2 = new SqlCommand(sqlCountNgay, conn))
                {
                    dto.TongSoHoaDonHomNay = Convert.ToInt32(cmd2.ExecuteScalar());
                }

                // 3. Dùng ExecuteScalar tính tổng doanh thu trong tháng
                string sqlDoanhThuThang = @"
                    SELECT ISNULL(SUM(TongTien), 0) 
                    FROM HoaDon 
                    WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE())";
                using (var cmd3 = new SqlCommand(sqlDoanhThuThang, conn))
                {
                    dto.DoanhThuThangNay = Convert.ToDecimal(cmd3.ExecuteScalar());
                }

                // 4. Dùng ExecuteScalar đếm số hóa đơn trong tháng
                string sqlCountThang = @"
                    SELECT COUNT(*) 
                    FROM HoaDon 
                    WHERE MONTH(NgayLap) = MONTH(GETDATE()) AND YEAR(NgayLap) = YEAR(GETDATE())";
                using (var cmd4 = new SqlCommand(sqlCountThang, conn))
                {
                    dto.TongSoHoaDonThangNay = Convert.ToInt32(cmd4.ExecuteScalar());
                }
            }
            return dto;
        }

        /// <summary>
        /// Dùng SqlDataReader hiển thị danh sách Top 5 sản phẩm bán chạy nhất
        /// </summary>
        public List<TopSanPhamDTO> LayTop5SanPhamBanChay()
        {
            if (!DbHelper.CheckDatabaseConnection())
            {
                var query = DbHelper.MockDb.ChiTietHoaDons
                    .GroupBy(ct => new { ct.MaSP, ct.TenSP })
                    .Select(g => new TopSanPhamDTO
                    {
                        MaSP = g.Key.MaSP,
                        TenSP = g.Key.TenSP,
                        TongSoLuongBan = g.Sum(x => x.SoLuong),
                        TongDoanhThu = g.Sum(x => x.SoLuong * x.DonGia)
                    })
                    .OrderByDescending(x => x.TongSoLuongBan)
                    .Take(5)
                    .ToList();
                return query;
            }

            var list = new List<TopSanPhamDTO>();
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT TOP 5 
                        sp.MaSP, 
                        sp.TenSP, 
                        SUM(ct.SoLuong) AS TongSoLuongBan, 
                        SUM(ct.SoLuong * ct.DonGia) AS TongDoanhThu
                    FROM ChiTietHoaDon ct
                    INNER JOIN SanPham sp ON ct.MaSP = sp.MaSP
                    GROUP BY sp.MaSP, sp.TenSP
                    ORDER BY TongSoLuongBan DESC";

                using var cmd = new SqlCommand(query, conn);
                // Dùng SqlDataReader đọc tuần tự từng dòng
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new TopSanPhamDTO
                    {
                        MaSP = reader["MaSP"].ToString() ?? "",
                        TenSP = reader["TenSP"].ToString() ?? "",
                        TongSoLuongBan = Convert.ToInt32(reader["TongSoLuongBan"]),
                        TongDoanhThu = Convert.ToDecimal(reader["TongDoanhThu"])
                    });
                }
            }
            return list;
        }
    }
}
