using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using Microsoft.Data.SqlClient;
using bai6_1.DTO;

namespace bai6_1.DAL
{
    public static class DbHelper
    {
        private static string _connectionString = "";
        private static bool? _isDbAvailable = null;

        // In-memory fallback repository for offline/demo reliability
        public static class MockDb
        {
            public static List<NhanVienDTO> NhanViens = new()
            {
                new NhanVienDTO { MaNV = 1, TenNV = "Nguyễn Hải Nam", SoDienThoai = "0981234567", ChucVu = "Quản lý" },
                new NhanVienDTO { MaNV = 2, TenNV = "Trần Thị Mai", SoDienThoai = "0912345678", ChucVu = "Thu ngân" },
                new NhanVienDTO { MaNV = 3, TenNV = "Lê Hoàng Long", SoDienThoai = "0978901234", ChucVu = "Thu ngân" },
                new NhanVienDTO { MaNV = 4, TenNV = "Phạm Thu Trang", SoDienThoai = "0934567890", ChucVu = "Bán hàng" }
            };

            public static List<KhachHangDTO> KhachHangs = new()
            {
                new KhachHangDTO { MaKH = 1, TenKH = "Khách vãng lai (Lẻ)", DienThoai = "0000000000", DiemTichLuy = 0 },
                new KhachHangDTO { MaKH = 2, TenKH = "Nguyễn Văn An", DienThoai = "0905111222", DiemTichLuy = 15 },
                new KhachHangDTO { MaKH = 3, TenKH = "Lê Thị Bích", DienThoai = "0905333444", DiemTichLuy = 38 },
                new KhachHangDTO { MaKH = 4, TenKH = "Hoàng Minh Đức", DienThoai = "0905555666", DiemTichLuy = 5 }
            };

            public static List<SanPhamDTO> SanPhams = new()
            {
                new SanPhamDTO { MaSP = "SP001", TenSP = "Sữa tươi tiệt trùng Vinamilk 1L", GiaBan = 38000, SoLuongTon = 150 },
                new SanPhamDTO { MaSP = "SP002", TenSP = "Bánh quy bơ Danisa 454g", GiaBan = 145000, SoLuongTon = 50 },
                new SanPhamDTO { MaSP = "SP003", TenSP = "Nước ngọt Coca-Cola thùng 24 lon", GiaBan = 215000, SoLuongTon = 80 },
                new SanPhamDTO { MaSP = "SP004", TenSP = "Mì Hảo Hảo tôm chua cay thùng 30 gói", GiaBan = 128000, SoLuongTon = 120 },
                new SanPhamDTO { MaSP = "SP005", TenSP = "Dầu ăn Simply đậu nành 2L", GiaBan = 135000, SoLuongTon = 60 },
                new SanPhamDTO { MaSP = "SP006", TenSP = "Gạo ST25 Ông Cua túi 5kg", GiaBan = 195000, SoLuongTon = 40 },
                new SanPhamDTO { MaSP = "SP007", TenSP = "Cà phê hòa tan G7 3in1 hộp 20 gói", GiaBan = 58000, SoLuongTon = 95 }
            };

            public static List<HoaDonDTO> HoaDons = new()
            {
                new HoaDonDTO { MaHD = 1, NgayLap = DateTime.Now.AddDays(-2), MaNV = 2, TenNV = "Trần Thị Mai", MaKH = 2, TenKH = "Nguyễn Văn An", TongTien = 388000 },
                new HoaDonDTO { MaHD = 2, NgayLap = DateTime.Now.AddDays(-1), MaNV = 3, TenNV = "Lê Hoàng Long", MaKH = 3, TenKH = "Lê Thị Bích", TongTien = 505000 },
                new HoaDonDTO { MaHD = 3, NgayLap = DateTime.Now, MaNV = 2, TenNV = "Trần Thị Mai", MaKH = 4, TenKH = "Hoàng Minh Đức", TongTien = 215000 }
            };

            public static List<ChiTietHoaDonDTO> ChiTietHoaDons = new()
            {
                new ChiTietHoaDonDTO { MaHD = 1, MaSP = "SP001", TenSP = "Sữa tươi tiệt trùng Vinamilk 1L", SoLuong = 2, DonGia = 38000 },
                new ChiTietHoaDonDTO { MaHD = 1, MaSP = "SP003", TenSP = "Nước ngọt Coca-Cola thùng 24 lon", SoLuong = 1, DonGia = 215000 },
                new ChiTietHoaDonDTO { MaHD = 1, MaSP = "SP004", TenSP = "Mì Hảo Hảo tôm chua cay thùng 30 gói", SoLuong = 1, DonGia = 128000 },
                new ChiTietHoaDonDTO { MaHD = 2, MaSP = "SP002", TenSP = "Bánh quy bơ Danisa 454g", SoLuong = 2, DonGia = 145000 },
                new ChiTietHoaDonDTO { MaHD = 2, MaSP = "SP003", TenSP = "Nước ngọt Coca-Cola thùng 24 lon", SoLuong = 1, DonGia = 215000 },
                new ChiTietHoaDonDTO { MaHD = 3, MaSP = "SP003", TenSP = "Nước ngọt Coca-Cola thùng 24 lon", SoLuong = 1, DonGia = 215000 }
            };
        }

        static DbHelper()
        {
            try
            {
                var connSettings = ConfigurationManager.ConnectionStrings["SalesDB"];
                if (connSettings != null && !string.IsNullOrWhiteSpace(connSettings.ConnectionString))
                {
                    _connectionString = connSettings.ConnectionString;
                }
                else
                {
                    _connectionString = "Server=.;Database=SalesDB;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=2;";
                }
            }
            catch
            {
                _connectionString = "Server=.;Database=SalesDB;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=2;";
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
