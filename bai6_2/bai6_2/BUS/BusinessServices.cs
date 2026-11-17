using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using bai6_2.DAL;
using bai6_2.DTO;

namespace bai6_2.BUS
{
    public class PhongBanBUS
    {
        private readonly PhongBanDAL _dal = new();
        public List<PhongBanDTO> LayDanhSach() => _dal.GetAll();
    }

    public class NhanVienBUS
    {
        private readonly NhanVienDAL _dal = new();

        public List<NhanVienDTO> LayDanhSach() => _dal.GetAll();

        public List<NhanVienDTO> TimKiem(string keyword, int? maPB = null) => _dal.Search(keyword, maPB);

        public void Them(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                throw new ArgumentException("Họ tên nhân viên không được để trống!");
            if (string.IsNullOrWhiteSpace(nv.CCCD) || !Regex.IsMatch(nv.CCCD, @"^\d{12}$"))
                throw new ArgumentException("Số CCCD phải gồm đúng 12 chữ số!");
            if (nv.MaPB <= 0)
                throw new ArgumentException("Vui lòng chọn phòng ban trực thuộc!");
            if (nv.LuongCoBan <= 0)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 0!");
            if (nv.HeSoLuong <= 0)
                throw new ArgumentException("Hệ số lương phải lớn hơn 0!");

            _dal.Insert(nv);
        }

        public void CapNhat(NhanVienDTO nv)
        {
            if (nv.MaNV <= 0)
                throw new ArgumentException("Mã nhân viên không hợp lệ!");
            if (string.IsNullOrWhiteSpace(nv.HoTen))
                throw new ArgumentException("Họ tên nhân viên không được để trống!");
            if (string.IsNullOrWhiteSpace(nv.CCCD) || !Regex.IsMatch(nv.CCCD, @"^\d{12}$"))
                throw new ArgumentException("Số CCCD phải gồm đúng 12 chữ số!");
            if (nv.MaPB <= 0)
                throw new ArgumentException("Vui lòng chọn phòng ban trực thuộc!");
            if (nv.LuongCoBan <= 0)
                throw new ArgumentException("Lương cơ bản phải lớn hơn 0!");
            if (nv.HeSoLuong <= 0)
                throw new ArgumentException("Hệ số lương phải lớn hơn 0!");

            _dal.Update(nv);
        }

        public void Xoa(int maNV)
        {
            if (maNV <= 0)
                throw new ArgumentException("Vui lòng chọn nhân viên cần xóa!");
            _dal.Delete(maNV);
        }
    }

    public class ChamCongBUS
    {
        private readonly ChamCongDAL _dal = new();

        public DataTable NapBangChamCong(string thangNam)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                throw new ArgumentException("Tháng/Năm chấm công không hợp lệ!");
            return _dal.LoadBangChamCong(thangNam);
        }

        public (bool Success, string Message, int AffectedRows) LuuChamCong(DataTable dataTable)
        {
            return _dal.SaveBangChamCong(dataTable);
        }
    }

    public class LuongBUS
    {
        private readonly LuongDAL _dal = new();

        public List<BangLuongDTO> LayBangLuongTheoThang(string thangNam) => _dal.LayBangLuongTheoThang(thangNam);

        public List<BangLuongDTO> TinhLuongDuKien(string thangNam) => _dal.TinhLuongDuKien(thangNam);

        public (bool Success, string Message, int SoNhanVienChot) ChotLuong(string thangNam, List<BangLuongDTO> ds)
        {
            if (string.IsNullOrWhiteSpace(thangNam))
                return (false, "Tháng năm không hợp lệ!", 0);
            return _dal.ChotLuongThang(thangNam, ds);
        }
    }
}
