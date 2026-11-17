-- ========================================================
-- CƠ SỞ DỮ LIỆU: SalesDB - HỆ THỐNG BÁN HÀNG & SIÊU THỊ MINI
-- Tác giả: Nguyễn Hải Nam - MSV: 24810310617 - Lớp: D19CNPM3
-- ========================================================

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'SalesDB')
BEGIN
    CREATE DATABASE SalesDB;
END
GO

USE SalesDB;
GO

-- 1. Xóa các bảng cũ nếu đã tồn tại (theo thứ tự khóa ngoại)
IF OBJECT_ID('ChiTietHoaDon', 'U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon', 'U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('SanPham', 'U') IS NOT NULL DROP TABLE SanPham;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
GO

-- 2. Tạo bảng NhanVien (Nhân viên bán hàng)
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    TenNV NVARCHAR(100) NOT NULL,
    SoDienThoai VARCHAR(15) UNIQUE NOT NULL,
    ChucVu NVARCHAR(50) NOT NULL
);
GO

-- 3. Tạo bảng KhachHang (Khách hàng)
CREATE TABLE KhachHang (
    MaKH INT IDENTITY(1,1) PRIMARY KEY,
    TenKH NVARCHAR(100) NOT NULL,
    DienThoai VARCHAR(15) UNIQUE NOT NULL,
    DiemTichLuy INT NOT NULL DEFAULT 0
);
GO

-- 4. Tạo bảng SanPham (Sản phẩm / Hàng hóa)
CREATE TABLE SanPham (
    MaSP VARCHAR(20) PRIMARY KEY,
    TenSP NVARCHAR(150) NOT NULL,
    GiaBan DECIMAL(18,2) NOT NULL CHECK (GiaBan > 0),
    SoLuongTon INT NOT NULL CHECK (SoLuongTon >= 0)
);
GO

-- 5. Tạo bảng HoaDon (Hóa đơn bán hàng)
CREATE TABLE HoaDon (
    MaHD INT IDENTITY(1,1) PRIMARY KEY,
    NgayLap DATETIME NOT NULL DEFAULT GETDATE(),
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    MaKH INT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
    TongTien DECIMAL(18,2) NOT NULL DEFAULT 0
);
GO

-- 6. Tạo bảng ChiTietHoaDon (Chi tiết hóa đơn)
CREATE TABLE ChiTietHoaDon (
    MaHD INT NOT NULL FOREIGN KEY REFERENCES HoaDon(MaHD),
    MaSP VARCHAR(20) NOT NULL FOREIGN KEY REFERENCES SanPham(MaSP),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18,2) NOT NULL,
    CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (MaHD, MaSP)
);
GO

-- ========================================================
-- CHÈN DỮ LIỆU MẪU (SAMPLE DATA)
-- ========================================================

-- Nhân viên
INSERT INTO NhanVien (TenNV, SoDienThoai, ChucVu) VALUES
(N'Nguyễn Hải Nam', '0981234567', N'Quản lý'),
(N'Trần Thị Mai', '0912345678', N'Thu ngân'),
(N'Lê Hoàng Long', '0978901234', N'Thu ngân'),
(N'Phạm Thu Trang', '0934567890', N'Bán hàng');
GO

-- Khách hàng
INSERT INTO KhachHang (TenKH, DienThoai, DiemTichLuy) VALUES
(N'Khách vãng lai (Lẻ)', '0000000000', 0),
(N'Nguyễn Văn An', '0905111222', 15),
(N'Lê Thị Bích', '0905333444', 38),
(N'Hoàng Minh Đức', '0905555666', 5);
GO

-- Sản phẩm
INSERT INTO SanPham (MaSP, TenSP, GiaBan, SoLuongTon) VALUES
('SP001', N'Sữa tươi tiệt trùng Vinamilk 1L', 38000, 150),
('SP002', N'Bánh quy bơ Danisa 454g', 145000, 50),
('SP003', N'Nước ngọt Coca-Cola thùng 24 lon', 215000, 80),
('SP004', N'Mì Hảo Hảo tôm chua cay thùng 30 gói', 128000, 120),
('SP005', N'Dầu ăn Simply đậu nành 2L', 135000, 60),
('SP006', N'Gạo ST25 Ông Cua túi 5kg', 195000, 40),
('SP007', N'Cà phê hòa tan G7 3in1 hộp 20 gói', 58000, 95);
GO

-- Hóa đơn mẫu ban đầu
INSERT INTO HoaDon (NgayLap, MaNV, MaKH, TongTien) VALUES
(DATEADD(DAY, -2, GETDATE()), 2, 2, 388000),
(DATEADD(DAY, -1, GETDATE()), 3, 3, 505000),
(GETDATE(), 2, 4, 215000);
GO

-- Chi tiết hóa đơn mẫu
INSERT INTO ChiTietHoaDon (MaHD, MaSP, SoLuong, DonGia) VALUES
(1, 'SP001', 2, 38000),
(1, 'SP003', 1, 215000),
(1, 'SP004', 1, 128000),
(2, 'SP002', 2, 145000),
(2, 'SP003', 1, 215000),
(3, 'SP003', 1, 215000);
GO
