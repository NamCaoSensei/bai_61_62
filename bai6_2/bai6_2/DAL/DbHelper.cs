using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_2.DTO;

namespace bai6_2.DAL
{
    public static class DbHelper
    {
        private static string _connectionString = "";
        private static bool? _isDbAvailable = null;

        public static class MockDb
        {
            public static List<PhongBanDTO> PhongBans = new()
            {
                new PhongBanDTO { MaPB = 1, TenPB = "Phòng Kỹ Thuật & Phần Mềm", MoTa = "Nghiên cứu & phát triển ứng dụng" },
                new PhongBanDTO { MaPB = 2, TenPB = "Phòng Kinh Doanh & Tiếp Thị", MoTa = "Bán hàng, phân phối và mở rộng thị trường" },
                new PhongBanDTO { MaPB = 3, TenPB = "Phòng Nhân Sự & Hành Chính", MoTa = "Tuyển dụng, đào tạo và chấm công tính lương" },
                new PhongBanDTO { MaPB = 4, TenPB = "Phòng Kế Toán & Tài Chính", MoTa = "Quản lý ngân sách và báo cáo tài chính" }
            };

            public static List<NhanVienDTO> NhanViens = new()
            {
                new NhanVienDTO { MaNV = 1, HoTen = "Nguyễn Hải Nam", NgaySinh = new DateTime(2001, 5, 15), CCCD = "001201012345", MaPB = 1, TenPB = "Phòng Kỹ Thuật & Phần Mềm", LuongCoBan = 15000000, HeSoLuong = 1.8 },
                new NhanVienDTO { MaNV = 2, HoTen = "Trần Minh Tuấn", NgaySinh = new DateTime(1998, 8, 20), CCCD = "001198034567", MaPB = 1, TenPB = "Phòng Kỹ Thuật & Phần Mềm", LuongCoBan = 12000000, HeSoLuong = 1.5 },
                new NhanVienDTO { MaNV = 3, HoTen = "Lê Thị Hương", NgaySinh = new DateTime(1999, 11, 10), CCCD = "001199056789", MaPB = 2, TenPB = "Phòng Kinh Doanh & Tiếp Thị", LuongCoBan = 9000000, HeSoLuong = 1.2 },
                new NhanVienDTO { MaNV = 4, HoTen = "Phạm Hoàng Giang", NgaySinh = new DateTime(1995, 3, 25), CCCD = "001195078901", MaPB = 3, TenPB = "Phòng Nhân Sự & Hành Chính", LuongCoBan = 10000000, HeSoLuong = 1.3 },
                new NhanVienDTO { MaNV = 5, HoTen = "Vũ Bích Ngọc", NgaySinh = new DateTime(2000, 9, 2), CCCD = "001200090123", MaPB = 4, TenPB = "Phòng Kế Toán & Tài Chính", LuongCoBan = 11000000, HeSoLuong = 1.4 }
            };

            public static List<BangChamCongDTO> BangChamCongs = new()
            {
                new BangChamCongDTO { MaCong = 1, MaNV = 1, HoTen = "Nguyễn Hải Nam", TenPB = "Phòng Kỹ Thuật & Phần Mềm", ThangNam = "11/2026", SoNgayCong = 22.0, SoGioOT = 15.0, TrangThai = "Chưa chốt" },
                new BangChamCongDTO { MaCong = 2, MaNV = 2, HoTen = "Trần Minh Tuấn", TenPB = "Phòng Kỹ Thuật & Phần Mềm", ThangNam = "11/2026", SoNgayCong = 21.5, SoGioOT = 10.0, TrangThai = "Chưa chốt" },
                new BangChamCongDTO { MaCong = 3, MaNV = 3, HoTen = "Lê Thị Hương", TenPB = "Phòng Kinh Doanh & Tiếp Thị", ThangNam = "11/2026", SoNgayCong = 20.0, SoGioOT = 5.0, TrangThai = "Chưa chốt" },
                new BangChamCongDTO { MaCong = 4, MaNV = 4, HoTen = "Phạm Hoàng Giang", TenPB = "Phòng Nhân Sự & Hành Chính", ThangNam = "11/2026", SoNgayCong = 22.0, SoGioOT = 8.0, TrangThai = "Chưa chốt" },
                new BangChamCongDTO { MaCong = 5, MaNV = 5, HoTen = "Vũ Bích Ngọc", TenPB = "Phòng Kế Toán & Tài Chính", ThangNam = "11/2026", SoNgayCong = 19.5, SoGioOT = 0.0, TrangThai = "Chưa chốt" }
            };

            public static List<BangLuongDTO> BangLuongs = new();
        }

        static DbHelper()
        {
            try
            {
                var connSettings = ConfigurationManager.ConnectionStrings["HRMDB"];
                if (connSettings != null && !string.IsNullOrWhiteSpace(connSettings.ConnectionString))
                {
                    _connectionString = connSettings.ConnectionString;
                }
                else
                {
                    _connectionString = "Server=.;Database=HRMDB;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=2;";
                }
            }
            catch
            {
                _connectionString = "Server=.;Database=HRMDB;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=2;";
            }
        }

        public static string ConnectionString => _connectionString;

        public static bool CheckDatabaseConnection()
        {
            if (_isDbAvailable.HasValue) return _isDbAvailable.Value;
            try
            {
                using var conn = new SqlConnection(_connectionString);
                conn.Open();
                _isDbAvailable = true;
                return true;
            }
            catch
            {
                _isDbAvailable = false;
                return false;
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
