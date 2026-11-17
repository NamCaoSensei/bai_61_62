using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bai6_1.DTO
{
    public class NhanVienDTO : INotifyPropertyChanged
    {
        private int _maNV;
        private string _tenNV = string.Empty;
        private string _soDienThoai = string.Empty;
        private string _chucVu = string.Empty;

        public int MaNV
        {
            get => _maNV;
            set => Set(ref _maNV, value);
        }

        public string TenNV
        {
            get => _tenNV;
            set => Set(ref _tenNV, value);
        }

        public string SoDienThoai
        {
            get => _soDienThoai;
            set => Set(ref _soDienThoai, value);
        }

        public string ChucVu
        {
            get => _chucVu;
            set => Set(ref _chucVu, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public override string ToString() => $"{TenNV} ({ChucVu})";
    }

    public class KhachHangDTO : INotifyPropertyChanged
    {
        private int _maKH;
        private string _tenKH = string.Empty;
        private string _dienThoai = string.Empty;
        private int _diemTichLuy;

        public int MaKH
        {
            get => _maKH;
            set => Set(ref _maKH, value);
        }

        public string TenKH
        {
            get => _tenKH;
            set => Set(ref _tenKH, value);
        }

        public string DienThoai
        {
            get => _dienThoai;
            set => Set(ref _dienThoai, value);
        }

        public int DiemTichLuy
        {
            get => _diemTichLuy;
            set => Set(ref _diemTichLuy, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public override string ToString() => $"{TenKH} - {DienThoai} ({DiemTichLuy} điểm)";
    }

    public class SanPhamDTO : INotifyPropertyChanged
    {
        private string _maSP = string.Empty;
        private string _tenSP = string.Empty;
        private decimal _giaBan;
        private int _soLuongTon;

        public string MaSP
        {
            get => _maSP;
            set => Set(ref _maSP, value);
        }

        public string TenSP
        {
            get => _tenSP;
            set => Set(ref _tenSP, value);
        }

        public decimal GiaBan
        {
            get => _giaBan;
            set => Set(ref _giaBan, value);
        }

        public int SoLuongTon
        {
            get => _soLuongTon;
            set => Set(ref _soLuongTon, value);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        public override string ToString() => $"{MaSP} - {TenSP} ({GiaBan:N0} đ, Còn {SoLuongTon})";
    }

    public class HoaDonDTO
    {
        public int MaHD { get; set; }
        public DateTime NgayLap { get; set; } = DateTime.Now;
        public int MaNV { get; set; }
        public string TenNV { get; set; } = string.Empty;
        public int? MaKH { get; set; }
        public string TenKH { get; set; } = string.Empty;
        public decimal TongTien { get; set; }
    }

    public class ChiTietHoaDonDTO
    {
        public int MaHD { get; set; }
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }

    public class GioHangItemDTO : INotifyPropertyChanged
    {
        private string _maSP = string.Empty;
        private string _tenSP = string.Empty;
        private decimal _donGia;
        private int _soLuong;
        private int _soLuongTon;

        public string MaSP
        {
            get => _maSP;
            set => Set(ref _maSP, value);
        }

        public string TenSP
        {
            get => _tenSP;
            set => Set(ref _tenSP, value);
        }

        public decimal DonGia
        {
            get => _donGia;
            set
            {
                if (Set(ref _donGia, value))
                    OnPropertyChanged(nameof(ThanhTien));
            }
        }

        public int SoLuong
        {
            get => _soLuong;
            set
            {
                if (Set(ref _soLuong, value))
                    OnPropertyChanged(nameof(ThanhTien));
            }
        }

        public int SoLuongTon
        {
            get => _soLuongTon;
            set => Set(ref _soLuongTon, value);
        }

        public decimal ThanhTien => SoLuong * DonGia;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }

    public class TopSanPhamDTO
    {
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public int TongSoLuongBan { get; set; }
        public decimal TongDoanhThu { get; set; }
    }

    public class DoanhThuDTO
    {
        public decimal DoanhThuHomNay { get; set; }
        public decimal DoanhThuThangNay { get; set; }
        public int TongSoHoaDonHomNay { get; set; }
        public int TongSoHoaDonThangNay { get; set; }
    }
}
