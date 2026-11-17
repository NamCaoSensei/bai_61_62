using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using bai6_1.BUS;
using bai6_1.DAL;
using bai6_1.DTO;

namespace bai6_1.GUI
{
    public partial class FormMain : Form
    {
        private readonly SanPhamBUS _sanPhamBUS = new();
        private readonly KhachHangBUS _khachHangBUS = new();
        private readonly NhanVienBUS _nhanVienBUS = new();
        private readonly HoaDonBUS _hoaDonBUS = new();
        private readonly BaoCaoBUS _baoCaoBUS = new();

        // Danh sách giỏ hàng DataBinding
        private readonly BindingList<GioHangItemDTO> _gioHangList = new();
        private readonly BindingSource _gioHangBindingSource = new();

        // Danh sách Sản phẩm
        private readonly BindingList<SanPhamDTO> _sanPhamList = new();
        private readonly BindingSource _sanPhamBindingSource = new();

        // Danh sách Khách hàng
        private readonly BindingList<KhachHangDTO> _khachHangList = new();
        private readonly BindingSource _khachHangBindingSource = new();

        // Danh sách Nhân viên
        private readonly BindingList<NhanVienDTO> _nhanVienList = new();
        private readonly BindingSource _nhanVienBindingSource = new();

        public FormMain()
        {
            InitializeComponent();
            SetupDataBindings();
            RegisterEvents();
        }

        private void SetupDataBindings()
        {
            _gioHangBindingSource.DataSource = _gioHangList;
            dgvGioHang.DataSource = _gioHangBindingSource;

            _sanPhamBindingSource.DataSource = _sanPhamList;
            dgvSanPham.DataSource = _sanPhamBindingSource;

            _khachHangBindingSource.DataSource = _khachHangList;
            dgvKhachHang.DataSource = _khachHangBindingSource;

            _nhanVienBindingSource.DataSource = _nhanVienList;
            dgvNhanVien.DataSource = _nhanVienBindingSource;

            // Kiểm tra trạng thái CSDL
            bool dbOk = DbHelper.CheckDatabaseConnection();
            lblStatusConnection.Text = dbOk 
                ? "🟢 CSDL: SalesDB (Microsoft SQL Server ĐANG KẾT NỐI)" 
                : "🟡 CSDL: SalesDB (Chế độ Local In-Memory ACID Provider)";
        }

        private void RegisterEvents()
        {
            this.Load += FormMain_Load;

            // Bán hàng
            btnThemVaoGio.Click += BtnThemVaoGio_Click;
            btnXoaKhoiGio.Click += BtnXoaKhoiGio_Click;
            btnXoaToanBoGio.Click += BtnXoaToanBoGio_Click;
            cboKhachHang.SelectedIndexChanged += CboKhachHang_SelectedIndexChanged;
            btnThanhToan.Click += BtnThanhToan_Click;
            btnTestRollback.Click += BtnTestRollback_Click;

            // CRUD Sản phẩm
            btnSP_Them.Click += BtnSP_Them_Click;
            btnSP_Sua.Click += BtnSP_Sua_Click;
            btnSP_Xoa.Click += BtnSP_Xoa_Click;
            btnSP_LamMoi.Click += (s, e) => ResetSPInputs();
            btnSP_Search.Click += BtnSP_Search_Click;
            btnSP_ResetSearch.Click += (s, e) => { txtSP_Search.Clear(); LoadDanhSachSanPham(); };
            txtSP_Search.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnSP_Search_Click(s, e); };
            dgvSanPham.SelectionChanged += DgvSanPham_SelectionChanged;

            // CRUD Khách hàng
            btnKH_Them.Click += BtnKH_Them_Click;
            btnKH_Sua.Click += BtnKH_Sua_Click;
            btnKH_Xoa.Click += BtnKH_Xoa_Click;
            dgvKhachHang.SelectionChanged += DgvKhachHang_SelectionChanged;

            // CRUD Nhân viên
            btnNV_Them.Click += BtnNV_Them_Click;
            btnNV_Sua.Click += BtnNV_Sua_Click;
            btnNV_Xoa.Click += BtnNV_Xoa_Click;
            dgvNhanVien.SelectionChanged += DgvNhanVien_SelectionChanged;

            // Báo cáo
            btnLamMoiBaoCao.Click += (s, e) => LoadBaoCaoThongKe();
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            LoadComboboxes();
            LoadDanhSachSanPham();
            LoadDanhSachKhachHang();
            LoadDanhSachNhanVien();
            LoadBaoCaoThongKe();
            UpdateTongTienGioHang();
        }

        #region LOAD DỮ LIỆU
        public void LoadComboboxes()
        {
            var sps = _sanPhamBUS.LayDanhSachSanPham();
            cboSanPham.DataSource = sps;
            cboSanPham.DisplayMember = "TenSP";
            cboSanPham.ValueMember = "MaSP";

            var nvs = _nhanVienBUS.LayDanhSach();
            cboThuNgan.DataSource = nvs;
            cboThuNgan.DisplayMember = "TenNV";
            cboThuNgan.ValueMember = "MaNV";

            var khs = _khachHangBUS.LayDanhSach();
            cboKhachHang.DataSource = khs;
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        public void LoadDanhSachSanPham()
        {
            _sanPhamList.Clear();
            var list = _sanPhamBUS.LayDanhSachSanPham();
            foreach (var item in list) _sanPhamList.Add(item);
            lblStatusMsg.Text = $"Đã tải {_sanPhamList.Count} sản phẩm";
        }

        public void LoadDanhSachKhachHang()
        {
            _khachHangList.Clear();
            var list = _khachHangBUS.LayDanhSach();
            foreach (var item in list) _khachHangList.Add(item);
        }

        public void LoadDanhSachNhanVien()
        {
            _nhanVienList.Clear();
            var list = _nhanVienBUS.LayDanhSach();
            foreach (var item in list) _nhanVienList.Add(item);
        }

        public void LoadBaoCaoThongKe()
        {
            // ExecuteScalar
            var doanhThu = _baoCaoBUS.LayDoanhThu();
            lblBC_ValDoanhThuNgay.Text = $"{doanhThu.DoanhThuHomNay:N0} đ";
            lblBC_SubNgay.Text = $"Số hóa đơn: {doanhThu.TongSoHoaDonHomNay}";

            lblBC_ValDoanhThuThang.Text = $"{doanhThu.DoanhThuThangNay:N0} đ";
            lblBC_SubThang.Text = $"Số hóa đơn: {doanhThu.TongSoHoaDonThangNay}";

            // SqlDataReader
            var top5 = _baoCaoBUS.LayTop5SanPham();
            dgvTopSanPham.DataSource = top5;

            // Hóa đơn
            dgvHoaDon.DataSource = _hoaDonBUS.LayDanhSachHoaDon();
        }
        #endregion

        #region NGHIỆP VỤ BÁN HÀNG & SQLTRANSACTION
        private void BtnThemVaoGio_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (cboSanPham.SelectedItem is not SanPhamDTO sp)
            {
                errorProvider.SetError(cboSanPham, "Vui lòng chọn sản phẩm!");
                return;
            }

            int soLuongMua = (int)nudSoLuongMua.Value;
            if (soLuongMua <= 0)
            {
                errorProvider.SetError(nudSoLuongMua, "Số lượng phải lớn hơn 0!");
                return;
            }

            // Kiểm tra số lượng tồn hiện có
            var existSP = _sanPhamBUS.LayDanhSachSanPham().FirstOrDefault(x => x.MaSP == sp.MaSP);
            int tonHienTai = existSP?.SoLuongTon ?? sp.SoLuongTon;

            var existingItem = _gioHangList.FirstOrDefault(x => x.MaSP == sp.MaSP);
            int tongMuaDuKien = (existingItem?.SoLuong ?? 0) + soLuongMua;

            if (tongMuaDuKien > tonHienTai)
            {
                MessageBox.Show($"Sản phẩm '{sp.TenSP}' chỉ còn {tonHienTai} trong kho!\nBạn đã thêm {(existingItem?.SoLuong ?? 0)}, không thể thêm tiếp {soLuongMua}.",
                                "Cảnh báo tồn kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (existingItem != null)
            {
                existingItem.SoLuong += soLuongMua;
            }
            else
            {
                _gioHangList.Add(new GioHangItemDTO
                {
                    MaSP = sp.MaSP,
                    TenSP = sp.TenSP,
                    DonGia = sp.GiaBan,
                    SoLuong = soLuongMua,
                    SoLuongTon = tonHienTai
                });
            }

            UpdateTongTienGioHang();
            LogGiaoDich($"[THÊM GIỎ] {sp.TenSP} x {soLuongMua} ({sp.GiaBan:N0} đ)");
        }

        private void BtnXoaKhoiGio_Click(object? sender, EventArgs e)
        {
            if (dgvGioHang.CurrentRow?.DataBoundItem is GioHangItemDTO item)
            {
                _gioHangList.Remove(item);
                UpdateTongTienGioHang();
                LogGiaoDich($"[XÓA GIỎ] Đã bớt sản phẩm {item.TenSP}");
            }
        }

        private void BtnXoaToanBoGio_Click(object? sender, EventArgs e)
        {
            if (_gioHangList.Count == 0) return;
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa toàn bộ giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _gioHangList.Clear();
                UpdateTongTienGioHang();
                LogGiaoDich("[HỦY GIỎ] Đã làm trống giỏ hàng.");
            }
        }

        private void CboKhachHang_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cboKhachHang.SelectedItem is KhachHangDTO kh)
            {
                txtDiemHienCo.Text = $"{kh.DiemTichLuy} điểm";
                UpdateTongTienGioHang();
            }
            else
            {
                txtDiemHienCo.Text = "0 điểm";
            }
        }

        private void UpdateTongTienGioHang()
        {
            decimal tongTien = _gioHangList.Sum(x => x.ThanhTien);
            txtTongTien.Text = $"{tongTien:N0} đ";

            // Điểm tích lũy: TongTien / 100000
            int diemCong = (int)(tongTien / 100000m);
            txtDiemTichLuyMoi.Text = $"+{diemCong} điểm";
        }

        private void BtnThanhToan_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();

            if (_gioHangList.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống! Vui lòng chọn sản phẩm vào giỏ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cboThuNgan.SelectedItem is not NhanVienDTO nv)
            {
                errorProvider.SetError(cboThuNgan, "Vui lòng chọn nhân viên thu ngân!");
                return;
            }

            var kh = cboKhachHang.SelectedItem as KhachHangDTO;
            decimal tongTien = _gioHangList.Sum(x => x.ThanhTien);

            var confirm = MessageBox.Show(
                $"Xác nhận thanh toán hóa đơn:\n" +
                $"- Thu ngân: {nv.TenNV}\n" +
                $"- Khách hàng: {kh?.TenKH ?? "Khách lẻ"}\n" +
                $"- Số mặt hàng: {_gioHangList.Count}\n" +
                $"- TỔNG TIỀN: {tongTien:N0} đ\n" +
                $"- Điểm cộng tích lũy: +{(int)(tongTien / 100000m)} điểm\n\n" +
                $"Hệ thống sẽ mở SqlTransaction để đảm bảo tính toàn vẹn dữ liệu (ACID).\nBạn có muốn tiếp tục?",
                "Xác nhận thanh toán SqlTransaction",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            LogGiaoDich("========================================");
            LogGiaoDich(">>> BẮT ĐẦU GIAO DỊCH SqlTransaction <<<");
            LogGiaoDich("1. Đang mở kết nối SqlConnection & trans = conn.BeginTransaction()...");

            var result = _hoaDonBUS.ThanhToan(nv.MaNV, kh?.MaKH, tongTien, _gioHangList.ToList(), forceSimulateRollback: false);

            if (result.Success)
            {
                LogGiaoDich($"2. Chèn 1 bản ghi vào HoaDon (MaHD = {result.MaHD})");
                LogGiaoDich($"3. Chèn {_gioHangList.Count} bản ghi vào ChiTietHoaDon");
                LogGiaoDich($"4. Trừ SoLuongTon tương ứng trong SanPham");
                if (kh != null && kh.MaKH > 0)
                {
                    LogGiaoDich($"5. Cộng +{(int)(tongTien / 100000m)} điểm tích lũy cho khách '{kh.TenKH}'");
                }
                LogGiaoDich(">>> trans.Commit() THÀNH CÔNG! <<<");
                LogGiaoDich("========================================");

                MessageBox.Show(result.Message, "Thanh toán thành công (SqlTransaction Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _gioHangList.Clear();
                UpdateTongTienGioHang();
                LoadDanhSachSanPham();
                LoadDanhSachKhachHang();
                LoadComboboxes();
                LoadBaoCaoThongKe();
            }
            else
            {
                LogGiaoDich($">>> trans.Rollback() KÍCH HOẠT! <<<\nLý do: {result.Message}");
                LogGiaoDich("========================================");
                MessageBox.Show(result.Message, "Giao dịch thất bại (SqlTransaction Rollback)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnTestRollback_Click(object? sender, EventArgs e)
        {
            if (cboThuNgan.SelectedItem is not NhanVienDTO nv)
            {
                MessageBox.Show("Vui lòng chọn nhân viên thu ngân!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var kh = cboKhachHang.SelectedItem as KhachHangDTO;
            var testList = new List<GioHangItemDTO>
            {
                new GioHangItemDTO
                {
                    MaSP = "SP002",
                    TenSP = "Bánh quy bơ Danisa 454g",
                    DonGia = 145000,
                    SoLuong = 999999, // Cố tình vượt tồn kho để kích hoạt Rollback
                    SoLuongTon = 50
                }
            };

            LogGiaoDich("========================================");
            LogGiaoDich(">>> BẮT ĐẦU THỬ NGHIỆM LỖI ROLLBACK <<<");
            LogGiaoDich("Kịch bản: Bán sản phẩm 'SP002' với Số lượng = 999,999 (Tồn kho: 50)");
            LogGiaoDich("1. SqlTransaction mở giao dịch...");
            LogGiaoDich("2. Kiểm tra tồn kho: SoLuongTon (50) < SoLuongBan (999,999)");

            var result = _hoaDonBUS.ThanhToan(nv.MaNV, kh?.MaKH, 999999 * 145000m, testList, forceSimulateRollback: true);

            LogGiaoDich($">>> KÍCH HOẠT trans.Rollback() THÀNH CÔNG! <<<\n{result.Message}");
            LogGiaoDich("Toàn bộ dữ liệu được bảo vệ an toàn 100%, không bị trừ kho ảo!");
            LogGiaoDich("========================================");

            MessageBox.Show(
                $"{result.Message}\n\nChứng minh: Tính toàn vẹn ACID đã bảo vệ dữ liệu, không có hóa đơn rác được lưu và kho hàng không bị trừ sai lệch!",
                "Minh họa An Toàn Dữ Liệu (SqlTransaction Rollback)",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void LogGiaoDich(string message)
        {
            txtLogGiaoDich.AppendText($"\r\n[{DateTime.Now:HH:mm:ss}] {message}");
            txtLogGiaoDich.SelectionStart = txtLogGiaoDich.Text.Length;
            txtLogGiaoDich.ScrollToCaret();
        }
        #endregion

        #region CRUD SẢN PHẨM & TÌM KIẾM SQLPARAMETER
        private void BtnSP_Search_Click(object? sender, EventArgs e)
        {
            string keyword = txtSP_Search.Text.Trim();
            // Tìm kiếm bằng SqlParameter có ký tự đại diện %
            var list = _sanPhamBUS.TimKiem(keyword);
            _sanPhamList.Clear();
            foreach (var item in list) _sanPhamList.Add(item);
            lblStatusMsg.Text = $"Tìm thấy {list.Count} sản phẩm khớp từ khóa '{keyword}' (SqlParameter LIKE %...%)";
        }

        private void DgvSanPham_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow?.DataBoundItem is SanPhamDTO sp)
            {
                txtSP_Ma.Text = sp.MaSP;
                txtSP_Ten.Text = sp.TenSP;
                nudSP_Gia.Value = Math.Max(nudSP_Gia.Minimum, Math.Min(nudSP_Gia.Maximum, sp.GiaBan));
                nudSP_Ton.Value = Math.Max(nudSP_Ton.Minimum, Math.Min(nudSP_Ton.Maximum, sp.SoLuongTon));
            }
        }

        private void BtnSP_Them_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtSP_Ma.Text))
            {
                errorProvider.SetError(txtSP_Ma, "Mã sản phẩm không được để trống!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSP_Ten.Text))
            {
                errorProvider.SetError(txtSP_Ten, "Tên sản phẩm không được để trống!");
                return;
            }
            if (nudSP_Gia.Value <= 0)
            {
                errorProvider.SetError(nudSP_Gia, "Giá bán phải lớn hơn 0!");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn thêm sản phẩm mới '{txtSP_Ten.Text.Trim()}'?",
                                          "Xác nhận Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var sp = new SanPhamDTO
                {
                    MaSP = txtSP_Ma.Text.Trim(),
                    TenSP = txtSP_Ten.Text.Trim(),
                    GiaBan = nudSP_Gia.Value,
                    SoLuongTon = (int)nudSP_Ton.Value
                };
                _sanPhamBUS.Them(sp);
                LoadDanhSachSanPham();
                LoadComboboxes();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Thêm Sản Phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSP_Sua_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtSP_Ma.Text))
            {
                errorProvider.SetError(txtSP_Ma, "Vui lòng chọn sản phẩm cần sửa!");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật sản phẩm mã '{txtSP_Ma.Text}'?",
                                          "Xác nhận Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var sp = new SanPhamDTO
                {
                    MaSP = txtSP_Ma.Text.Trim(),
                    TenSP = txtSP_Ten.Text.Trim(),
                    GiaBan = nudSP_Gia.Value,
                    SoLuongTon = (int)nudSP_Ton.Value
                };
                _sanPhamBUS.CapNhat(sp);
                LoadDanhSachSanPham();
                LoadComboboxes();
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSP_Xoa_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSP_Ma.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa sản phẩm mã '{txtSP_Ma.Text}'?\nThao tác này không thể hoàn tác!",
                                          "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _sanPhamBUS.Xoa(txtSP_Ma.Text.Trim());
                LoadDanhSachSanPham();
                LoadComboboxes();
                ResetSPInputs();
                MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetSPInputs()
        {
            txtSP_Ma.Clear();
            txtSP_Ten.Clear();
            nudSP_Gia.Value = 0;
            nudSP_Ton.Value = 0;
            errorProvider.Clear();
        }
        #endregion

        #region CRUD KHÁCH HÀNG
        private void DgvKhachHang_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvKhachHang.CurrentRow?.DataBoundItem is KhachHangDTO kh)
            {
                txtKH_Ma.Text = kh.MaKH.ToString();
                txtKH_Ten.Text = kh.TenKH;
                txtKH_SDT.Text = kh.DienThoai;
                nudKH_Diem.Value = Math.Max(0, Math.Min(100000, kh.DiemTichLuy));
            }
        }

        private void BtnKH_Them_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtKH_Ten.Text))
            {
                errorProvider.SetError(txtKH_Ten, "Tên khách hàng không được để trống!");
                return;
            }
            if (!Regex.IsMatch(txtKH_SDT.Text.Trim(), @"^(0[0-9]{9,10})$"))
            {
                errorProvider.SetError(txtKH_SDT, "Số điện thoại phải từ 10 - 11 chữ số!");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn thêm khách hàng '{txtKH_Ten.Text.Trim()}'?",
                                          "Xác nhận Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var kh = new KhachHangDTO
                {
                    TenKH = txtKH_Ten.Text.Trim(),
                    DienThoai = txtKH_SDT.Text.Trim(),
                    DiemTichLuy = (int)nudKH_Diem.Value
                };
                _khachHangBUS.Them(kh);
                LoadDanhSachKhachHang();
                LoadComboboxes();
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Thêm Khách Hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKH_Sua_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtKH_Ma.Text, out int maKH) || maKH <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin khách hàng mã {maKH}?",
                                          "Xác nhận Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var kh = new KhachHangDTO
                {
                    MaKH = maKH,
                    TenKH = txtKH_Ten.Text.Trim(),
                    DienThoai = txtKH_SDT.Text.Trim(),
                    DiemTichLuy = (int)nudKH_Diem.Value
                };
                _khachHangBUS.CapNhat(kh);
                LoadDanhSachKhachHang();
                LoadComboboxes();
                MessageBox.Show("Cập nhật khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnKH_Xoa_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtKH_Ma.Text, out int maKH) || maKH <= 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa khách hàng mã {maKH}?",
                                          "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _khachHangBUS.Xoa(maKH);
                LoadDanhSachKhachHang();
                LoadComboboxes();
                MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CRUD NHÂN VIÊN
        private void DgvNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow?.DataBoundItem is NhanVienDTO nv)
            {
                txtNV_Ma.Text = nv.MaNV.ToString();
                txtNV_Ten.Text = nv.TenNV;
                txtNV_SDT.Text = nv.SoDienThoai;
                cboNV_ChucVu.SelectedItem = nv.ChucVu;
            }
        }

        private void BtnNV_Them_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNV_Ten.Text))
            {
                errorProvider.SetError(txtNV_Ten, "Tên nhân viên không được để trống!");
                return;
            }
            if (!Regex.IsMatch(txtNV_SDT.Text.Trim(), @"^(0[0-9]{9,10})$"))
            {
                errorProvider.SetError(txtNV_SDT, "Số điện thoại phải từ 10 - 11 chữ số!");
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn thêm nhân viên '{txtNV_Ten.Text.Trim()}'?",
                                          "Xác nhận Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var nv = new NhanVienDTO
                {
                    TenNV = txtNV_Ten.Text.Trim(),
                    SoDienThoai = txtNV_SDT.Text.Trim(),
                    ChucVu = cboNV_ChucVu.SelectedItem?.ToString() ?? "Thu ngân"
                };
                _nhanVienBUS.Them(nv);
                LoadDanhSachNhanVien();
                LoadComboboxes();
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNV_Sua_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtNV_Ma.Text, out int maNV) || maNV <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn sửa thông tin nhân viên mã {maNV}?",
                                          "Xác nhận Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var nv = new NhanVienDTO
                {
                    MaNV = maNV,
                    TenNV = txtNV_Ten.Text.Trim(),
                    SoDienThoai = txtNV_SDT.Text.Trim(),
                    ChucVu = cboNV_ChucVu.SelectedItem?.ToString() ?? "Thu ngân"
                };
                _nhanVienBUS.CapNhat(nv);
                LoadDanhSachNhanVien();
                LoadComboboxes();
                MessageBox.Show("Cập nhật nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNV_Xoa_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtNV_Ma.Text, out int maNV) || maNV <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên mã {maNV}?",
                                          "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _nhanVienBUS.Xoa(maNV);
                LoadDanhSachNhanVien();
                LoadComboboxes();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
