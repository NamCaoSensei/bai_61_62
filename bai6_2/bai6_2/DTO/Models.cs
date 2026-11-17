using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace bai6_2.DTO
{
    public class PhongBanDTO : INotifyPropertyChanged
    {
        private int _maPB;
        private string _tenPB = string.Empty;
        private string _moTa = string.Empty;

        public int MaPB
        {
            get => _maPB;
            set => Set(ref _maPB, value);
        }

        public string TenPB
        {
            get => _tenPB;
            set => Set(ref _tenPB, value);
        }

        public string MoTa
        {
            get => _moTa;
            set => Set(ref _moTa, value);
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

        public override string ToString() => TenPB;
    }

    public class NhanVienDTO : INotifyPropertyChanged
    {
        private int _maNV;
        private string _hoTen = string.Empty;
        private DateTime? _ngaySinh;
        private string _cccd = string.Empty;
        private int _maPB;
        private string _tenPB = string.Empty;
        private decimal _luongCoBan;
        private double _heSoLuong = 1.0;

        public int MaNV
        {
            get => _maNV;
            set => Set(ref _maNV, value);
        }

        public string HoTen
        {
            get => _hoTen;
            set => Set(ref _hoTen, value);
        }

        public DateTime? NgaySinh
        {
            get => _ngaySinh;
            set => Set(ref _ngaySinh, value);
        }

        public string CCCD
        {
            get => _cccd;
            set => Set(ref _cccd, value);
        }

        public int MaPB
        {
            get => _maPB;
            set => Set(ref _maPB, value);
        }

        public string TenPB
        {
            get => _tenPB;
            set => Set(ref _tenPB, value);
        }

        public decimal LuongCoBan
        {
            get => _luongCoBan;
            set => Set(ref _luongCoBan, value);
        }

        public double HeSoLuong
        {
            get => _heSoLuong;
            set => Set(ref _heSoLuong, value);
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

        public override string ToString() => $"{HoTen} ({CCCD})";
    }

    public class BangChamCongDTO : INotifyPropertyChanged
    {
        private int _maCong;
        private int _maNV;
        private string _hoTen = string.Empty;
        private string _tenPB = string.Empty;
        private string _thangNam = string.Empty;
        private double _soNgayCong;
        private double _soGioOT;
        private string _trangThai = "Chưa chốt";

        public int MaCong
        {
            get => _maCong;
            set => Set(ref _maCong, value);
        }

        public int MaNV
        {
            get => _maNV;
            set => Set(ref _maNV, value);
        }

        public string HoTen
        {
            get => _hoTen;
            set => Set(ref _hoTen, value);
        }

        public string TenPB
        {
            get => _tenPB;
            set => Set(ref _tenPB, value);
        }

        public string ThangNam
        {
            get => _thangNam;
            set => Set(ref _thangNam, value);
        }

        public double SoNgayCong
        {
            get => _soNgayCong;
            set => Set(ref _soNgayCong, value);
        }

        public double SoGioOT
        {
            get => _soGioOT;
            set => Set(ref _soGioOT, value);
        }

        public string TrangThai
        {
            get => _trangThai;
            set => Set(ref _trangThai, value);
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
    }

    public class BangLuongDTO : INotifyPropertyChanged
    {
        private int _maLuong;
        private int _maNV;
        private string _hoTen = string.Empty;
        private string _tenPB = string.Empty;
        private string _thangNam = string.Empty;
        private decimal _luongCoBan;
        private double _heSoLuong;
        private double _soNgayCong;
        private double _soGioOT;
        private decimal _thucLinh;
        private DateTime _ngayChot = DateTime.Now;

        public int MaLuong
        {
            get => _maLuong;
            set => Set(ref _maLuong, value);
        }

        public int MaNV
        {
            get => _maNV;
            set => Set(ref _maNV, value);
        }

        public string HoTen
        {
            get => _hoTen;
            set => Set(ref _hoTen, value);
        }

        public string TenPB
        {
            get => _tenPB;
            set => Set(ref _tenPB, value);
        }

        public string ThangNam
        {
            get => _thangNam;
            set => Set(ref _thangNam, value);
        }

        public decimal LuongCoBan
        {
            get => _luongCoBan;
            set => Set(ref _luongCoBan, value);
        }

        public double HeSoLuong
        {
            get => _heSoLuong;
            set => Set(ref _heSoLuong, value);
        }

        public double SoNgayCong
        {
            get => _soNgayCong;
            set => Set(ref _soNgayCong, value);
        }

        public double SoGioOT
        {
            get => _soGioOT;
            set => Set(ref _soGioOT, value);
        }

        public decimal ThucLinh
        {
            get => _thucLinh;
            set => Set(ref _thucLinh, value);
        }

        public DateTime NgayChot
        {
            get => _ngayChot;
            set => Set(ref _ngayChot, value);
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
    }
}
