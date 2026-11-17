-- ========================================================
-- CƠ SỞ DỮ LIỆU: HRMDB - HỆ THỐNG QUẢN LÝ NHÂN SỰ & TÍNH LƯƠNG
-- Tác giả: Nguyễn Hải Nam - MSV: 24810310617 - Lớp: D19CNPM3
-- ========================================================

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'HRMDB')
BEGIN
    CREATE DATABASE HRMDB;
END
GO

USE HRMDB;
GO

-- 1. Xóa các bảng cũ nếu đã tồn tại
IF OBJECT_ID('BangLuong', 'U') IS NOT NULL DROP TABLE BangLuong;
IF OBJECT_ID('BangChamCong', 'U') IS NOT NULL DROP TABLE BangChamCong;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('PhongBan', 'U') IS NOT NULL DROP TABLE PhongBan;
GO

-- 2. Tạo bảng PhongBan (Phòng ban)
CREATE TABLE PhongBan (
    MaPB INT IDENTITY(1,1) PRIMARY KEY,
    TenPB NVARCHAR(100) NOT NULL,
    Mota NVARCHAR(255) NULL
);
GO

-- 3. Tạo bảng NhanVien (Hồ sơ nhân viên)
CREATE TABLE NhanVien (
    MaNV INT IDENTITY(1,1) PRIMARY KEY,
    HoTen NVARCHAR(100) NOT NULL,
    NgaySinh DATETIME NULL,
    CCCD VARCHAR(20) UNIQUE NOT NULL,
    MaPB INT NOT NULL FOREIGN KEY REFERENCES PhongBan(MaPB),
    LuongCoBan DECIMAL(18,2) NOT NULL CHECK (LuongCoBan > 0),
    HeSoLuong FLOAT NOT NULL DEFAULT 1.0
);
GO

-- 4. Tạo bảng BangChamCong (Bảng chấm công tháng)
CREATE TABLE BangChamCong (
    MaCong INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7) NOT NULL, -- Ví dụ: "11/2026"
    SoNgayCong FLOAT NOT NULL CHECK (SoNgayCong <= 31),
    SoGioOT FLOAT NOT NULL DEFAULT 0,
    TrangThai NVARCHAR(50) NOT NULL DEFAULT N'Chưa chốt',
    CONSTRAINT UQ_ChamCong UNIQUE (MaNV, ThangNam)
);
GO

-- 5. Tạo bảng BangLuong (Bảng lương chi tiết)
CREATE TABLE BangLuong (
    MaLuong INT IDENTITY(1,1) PRIMARY KEY,
    MaNV INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
    ThangNam VARCHAR(7) NOT NULL,
    ThucLinh DECIMAL(18,2) NOT NULL,
    NgayChot DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT PK_BangLuong UNIQUE (MaNV, ThangNam)
);
GO

-- ========================================================
-- CHÈN DỮ LIỆU MẪU (SAMPLE DATA)
-- ========================================================

-- Phòng ban
INSERT INTO PhongBan (TenPB, Mota) VALUES
(N'Phòng Kỹ Thuật & Phần Mềm', N'Nghiên cứu & phát triển ứng dụng'),
(N'Phòng Kinh Doanh & Tiếp Thị', N'Bán hàng, phân phối và mở rộng thị trường'),
(N'Phòng Nhân Sự & Hành Chính', N'Tuyển dụng, đào tạo và chấm công tính lương'),
(N'Phòng Kế Toán & Tài Chính', N'Quản lý ngân sách và báo cáo tài chính');
GO

-- Nhân viên
INSERT INTO NhanVien (HoTen, NgaySinh, CCCD, MaPB, LuongCoBan, HeSoLuong) VALUES
(N'Nguyễn Hải Nam', '2001-05-15', '001201012345', 1, 15000000, 1.8),
(N'Trần Minh Tuấn', '1998-08-20', '001198034567', 1, 12000000, 1.5),
(N'Lê Thị Hương', '1999-11-10', '001199056789', 2, 9000000, 1.2),
(N'Phạm Hoàng Giang', '1995-03-25', '001195078901', 3, 10000000, 1.3),
(N'Vũ Bích Ngọc', '2000-09-02', '001200090123', 4, 11000000, 1.4);
GO

-- Bảng chấm công mẫu cho tháng 11/2026
INSERT INTO BangChamCong (MaNV, ThangNam, SoNgayCong, SoGioOT, TrangThai) VALUES
(1, '11/2026', 22.0, 15.0, N'Chưa chốt'),
(2, '11/2026', 21.5, 10.0, N'Chưa chốt'),
(3, '11/2026', 20.0, 5.0, N'Chưa chốt'),
(4, '11/2026', 22.0, 8.0, N'Chưa chốt'),
(5, '11/2026', 19.5, 0.0, N'Chưa chốt');
GO
