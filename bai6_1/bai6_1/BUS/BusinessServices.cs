using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using bai6_1.DAL;
using bai6_1.DTO;

namespace bai6_1.BUS
{
    public class SanPhamBUS
    {
        private readonly SanPhamDAL _dal = new();

        public List<SanPhamDTO> LayDanhSachSanPham() => _dal.GetAll();

        public List<SanPhamDTO> TimKiem(string keyword) => _dal.Search(keyword);

        public void Them(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không được để trống!");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.GiaBan <= 0)
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn kho không được âm!");

            _dal.Insert(sp);
        }

        public void CapNhat(SanPhamDTO sp)
        {
            if (string.IsNullOrWhiteSpace(sp.MaSP))
                throw new ArgumentException("Mã sản phẩm không hợp lệ!");
            if (string.IsNullOrWhiteSpace(sp.TenSP))
                throw new ArgumentException("Tên sản phẩm không được để trống!");
            if (sp.GiaBan <= 0)
                throw new ArgumentException("Giá bán phải lớn hơn 0!");
            if (sp.SoLuongTon < 0)
                throw new ArgumentException("Số lượng tồn kho không được âm!");

            _dal.Update(sp);
        }

        public void Xoa(string maSP)
        {
            if (string.IsNullOrWhiteSpace(maSP))
                throw new ArgumentException("Vui lòng chọn sản phẩm cần xóa!");
            _dal.Delete(maSP);
        }
    }

    public class KhachHangBUS
    {
        private readonly KhachHangDAL _dal = new();

        public List<KhachHangDTO> LayDanhSach() => _dal.GetAll();

        public void Them(KhachHangDTO kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống!");
            if (!Regex.IsMatch(kh.DienThoai ?? "", @"^(0[0-9]{9,10})$"))
                throw new ArgumentException("Số điện thoại khách hàng phải từ 10 - 11 chữ số hợp lệ!");

            _dal.Insert(kh);
        }

        public void CapNhat(KhachHangDTO kh)
        {
            if (kh.MaKH <= 0)
                throw new ArgumentException("Mã khách hàng không hợp lệ!");
            if (string.IsNullOrWhiteSpace(kh.TenKH))
                throw new ArgumentException("Tên khách hàng không được để trống!");
            if (!Regex.IsMatch(kh.DienThoai ?? "", @"^(0[0-9]{9,10})$"))
                throw new ArgumentException("Số điện thoại khách hàng phải từ 10 - 11 chữ số hợp lệ!");

            _dal.Update(kh);
        }

        public void Xoa(int maKH)
        {
            if (maKH <= 1)
                throw new ArgumentException("Không được phép xóa khách vãng lai mặc định!");
            _dal.Delete(maKH);
        }
    }

    public class NhanVienBUS
    {
        private readonly NhanVienDAL _dal = new();

        public List<NhanVienDTO> LayDanhSach() => _dal.GetAll();

        public void Them(NhanVienDTO nv)
        {
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống!");
            if (!Regex.IsMatch(nv.SoDienThoai ?? "", @"^(0[0-9]{9,10})$"))
                throw new ArgumentException("Số điện thoại nhân viên phải từ 10 - 11 chữ số hợp lệ!");
            if (string.IsNullOrWhiteSpace(nv.ChucVu))
                throw new ArgumentException("Chức vụ không được để trống!");

            _dal.Insert(nv);
        }

        public void CapNhat(NhanVienDTO nv)
        {
            if (nv.MaNV <= 0)
                throw new ArgumentException("Mã nhân viên không hợp lệ!");
            if (string.IsNullOrWhiteSpace(nv.TenNV))
                throw new ArgumentException("Tên nhân viên không được để trống!");
            if (!Regex.IsMatch(nv.SoDienThoai ?? "", @"^(0[0-9]{9,10})$"))
                throw new ArgumentException("Số điện thoại nhân viên phải từ 10 - 11 chữ số hợp lệ!");

            _dal.Update(nv);
        }

        public void Xoa(int maNV)
        {
            if (maNV <= 0)
                throw new ArgumentException("Vui lòng chọn nhân viên cần xóa!");
            _dal.Delete(maNV);
        }
    }

    public class HoaDonBUS
    {
        private readonly HoaDonDAL _dal = new();

        public List<HoaDonDTO> LayDanhSachHoaDon() => _dal.GetAll();

        public (bool Success, string Message, int MaHD) ThanhToan(
            int maNV,
            int? maKH,
            decimal tongTien,
            List<GioHangItemDTO> gioHang,
            bool forceSimulateRollback = false)
        {
            if (maNV <= 0)
                return (false, "Vui lòng chọn nhân viên thu ngân lập hóa đơn!", 0);
            if (gioHang == null || gioHang.Count == 0)
                return (false, "Giỏ hàng hiện chưa có sản phẩm nào!", 0);
            if (tongTien <= 0)
                return (false, "Tổng tiền hóa đơn không hợp lệ!", 0);

            return _dal.ThanhToanHoaDon(maNV, maKH, tongTien, gioHang, forceSimulateRollback);
        }
    }

    public class BaoCaoBUS
    {
        private readonly BaoCaoDAL _dal = new();

        public DoanhThuDTO LayDoanhThu() => _dal.LayThongKeDoanhThu();

        public List<TopSanPhamDTO> LayTop5SanPham() => _dal.LayTop5SanPhamBanChay();
    }
}
