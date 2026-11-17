using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using bai6_2.BUS;
using bai6_2.DAL;
using bai6_2.DTO;

namespace bai6_2.GUI
{
    public partial class FormMain : Form
    {
        private readonly PhongBanBUS _phongBanBUS = new();
        private readonly NhanVienBUS _nhanVienBUS = new();
        private readonly ChamCongBUS _chamCongBUS = new();
        private readonly LuongBUS _luongBUS = new();

        // DataBinding Nhân sự
        private readonly BindingList<NhanVienDTO> _nhanVienList = new();
        private readonly BindingSource _nhanVienBindingSource = new();

        // DataTable Chấm công ngắt kết nối
        private DataTable? _tableChamCong;

        // DataBinding Bảng lương
        private readonly BindingList<BangLuongDTO> _bangLuongList = new();
        private readonly BindingSource _bangLuongBindingSource = new();

        public FormMain()
        {
            InitializeComponent();
            SetupDataBindings();
            RegisterEvents();
        }

        private void SetupDataBindings()
        {
            _nhanVienBindingSource.DataSource = _nhanVienList;
            dgvNhanVien.DataSource = _nhanVienBindingSource;

            _bangLuongBindingSource.DataSource = _bangLuongList;
            dgvBangLuong.DataSource = _bangLuongBindingSource;

            bool dbOk = DbHelper.CheckDatabaseConnection();
            lblStatusConnection.Text = dbOk
                ? "🟢 CSDL: HRMDB (Microsoft SQL Server ĐANG KẾT NỐI)"
                : "🟡 CSDL: HRMDB (Chế độ Disconnected Model & Local ACID Provider)";
        }

        private void RegisterEvents()
        {
            this.Load += FormMain_Load;

            // CRUD Nhân sự
            btnNS_Them.Click += BtnNS_Them_Click;
            btnNS_Sua.Click += BtnNS_Sua_Click;
            btnNS_Xoa.Click += BtnNS_Xoa_Click;
            btnNS_LamMoi.Click += (s, e) => ResetNSInputs();
            btnNS_Search.Click += BtnNS_Search_Click;
            btnNS_ResetSearch.Click += (s, e) => { txtNS_Search.Clear(); cboNS_FilterPB.SelectedIndex = 0; LoadDanhSachNhanVien(); };
            txtNS_Search.KeyDown += (s, e) => { if (e.KeyCode == Keys.Enter) BtnNS_Search_Click(s, e); };
            dgvNhanVien.SelectionChanged += DgvNhanVien_SelectionChanged;

            // Chấm công
            btnCC_Nap.Click += BtnCC_Nap_Click;
            btnCC_Luu.Click += BtnCC_Luu_Click;
            cboCC_ThangNam.SelectedIndexChanged += (s, e) => BtnCC_Nap_Click(s, e);

            // Tính & Chốt lương
            btnTL_TinhDuKien.Click += BtnTL_TinhDuKien_Click;
            btnTL_ChotLuong.Click += BtnTL_ChotLuong_Click;
            cboTL_ThangNam.SelectedIndexChanged += (s, e) => BtnTL_TinhDuKien_Click(s, e);
        }

        private void FormMain_Load(object? sender, EventArgs e)
        {
            LoadDanhSachPhongBan();
            LoadDanhSachNhanVien();

            if (cboCC_ThangNam.Items.Count > 0) cboCC_ThangNam.SelectedIndex = 0;
            if (cboTL_ThangNam.Items.Count > 0) cboTL_ThangNam.SelectedIndex = 0;

            BtnCC_Nap_Click(this, EventArgs.Empty);
            BtnTL_TinhDuKien_Click(this, EventArgs.Empty);
        }

        #region LOAD DỮ LIỆU
        public void LoadDanhSachPhongBan()
        {
            var pbs = _phongBanBUS.LayDanhSach();

            cboNS_PhongBan.DataSource = new List<PhongBanDTO>(pbs);
            cboNS_PhongBan.DisplayMember = "TenPB";
            cboNS_PhongBan.ValueMember = "MaPB";

            var filterList = new List<PhongBanDTO>
            {
                new PhongBanDTO { MaPB = 0, TenPB = "-- Tất cả phòng ban --" }
            };
            filterList.AddRange(pbs);
            cboNS_FilterPB.DataSource = filterList;
            cboNS_FilterPB.DisplayMember = "TenPB";
            cboNS_FilterPB.ValueMember = "MaPB";
            cboNS_FilterPB.SelectedIndex = 0;
        }

        public void LoadDanhSachNhanVien()
        {
            _nhanVienList.Clear();
            var list = _nhanVienBUS.LayDanhSach();
            foreach (var item in list) _nhanVienList.Add(item);
            lblStatusMsg.Text = $"Đã tải {_nhanVienList.Count} hồ sơ nhân viên";
        }
        #endregion

        #region CRUD HỒ SƠ NHÂN SỰ
        private void DgvNhanVien_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow?.DataBoundItem is NhanVienDTO nv)
            {
                txtNS_MaNV.Text = nv.MaNV.ToString();
                txtNS_HoTen.Text = nv.HoTen;
                if (nv.NgaySinh.HasValue) dtpNS_NgaySinh.Value = nv.NgaySinh.Value;
                txtNS_CCCD.Text = nv.CCCD;
                cboNS_PhongBan.SelectedValue = nv.MaPB;
                nudNS_LuongCB.Value = Math.Max(nudNS_LuongCB.Minimum, Math.Min(nudNS_LuongCB.Maximum, nv.LuongCoBan));
                nudNS_HeSo.Value = Math.Max(nudNS_HeSo.Minimum, Math.Min(nudNS_HeSo.Maximum, (decimal)nv.HeSoLuong));
            }
        }

        private void BtnNS_Them_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrWhiteSpace(txtNS_HoTen.Text))
            {
                errorProvider.SetError(txtNS_HoTen, "Họ tên không được để trống!");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNS_CCCD.Text) || !Regex.IsMatch(txtNS_CCCD.Text.Trim(), @"^\d{12}$"))
            {
                errorProvider.SetError(txtNS_CCCD, "Số CCCD phải gồm đúng 12 chữ số!");
                return;
            }
            if (cboNS_PhongBan.SelectedValue == null)
            {
                errorProvider.SetError(cboNS_PhongBan, "Vui lòng chọn phòng ban!");
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận thêm mới nhân viên '{txtNS_HoTen.Text.Trim()}'?",
                                          "Xác nhận Thêm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var nv = new NhanVienDTO
                {
                    HoTen = txtNS_HoTen.Text.Trim(),
                    NgaySinh = dtpNS_NgaySinh.Value,
                    CCCD = txtNS_CCCD.Text.Trim(),
                    MaPB = Convert.ToInt32(cboNS_PhongBan.SelectedValue),
                    LuongCoBan = nudNS_LuongCB.Value,
                    HeSoLuong = (double)nudNS_HeSo.Value
                };
                _nhanVienBUS.Them(nv);
                LoadDanhSachNhanVien();
                BtnCC_Nap_Click(this, EventArgs.Empty);
                MessageBox.Show("Thêm nhân viên mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Thêm Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNS_Sua_Click(object? sender, EventArgs e)
        {
            errorProvider.Clear();
            if (!int.TryParse(txtNS_MaNV.Text, out int maNV) || maNV <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa hoặc chuyển phòng ban!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Xác nhận cập nhật thông tin và phòng ban cho nhân viên mã #{maNV}?",
                                          "Xác nhận Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var nv = new NhanVienDTO
                {
                    MaNV = maNV,
                    HoTen = txtNS_HoTen.Text.Trim(),
                    NgaySinh = dtpNS_NgaySinh.Value,
                    CCCD = txtNS_CCCD.Text.Trim(),
                    MaPB = Convert.ToInt32(cboNS_PhongBan.SelectedValue),
                    LuongCoBan = nudNS_LuongCB.Value,
                    HeSoLuong = (double)nudNS_HeSo.Value
                };
                _nhanVienBUS.CapNhat(nv);
                LoadDanhSachNhanVien();
                BtnCC_Nap_Click(this, EventArgs.Empty);
                MessageBox.Show("Cập nhật hồ sơ nhân sự thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Cập Nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNS_Xoa_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(txtNS_MaNV.Text, out int maNV) || maNV <= 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên mã #{maNV}?\nThao tác này sẽ xóa hồ sơ vĩnh viễn!",
                                          "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                _nhanVienBUS.Xoa(maNV);
                LoadDanhSachNhanVien();
                BtnCC_Nap_Click(this, EventArgs.Empty);
                ResetNSInputs();
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNS_Search_Click(object? sender, EventArgs e)
        {
            string keyword = txtNS_Search.Text.Trim();
            int? maPB = null;
            if (cboNS_FilterPB.SelectedValue is int pbId && pbId > 0) maPB = pbId;

            var list = _nhanVienBUS.TimKiem(keyword, maPB);
            _nhanVienList.Clear();
            foreach (var item in list) _nhanVienList.Add(item);
            lblStatusMsg.Text = $"Tìm thấy {list.Count} nhân viên (Parameterized Query)";
        }

        private void ResetNSInputs()
        {
            txtNS_MaNV.Clear();
            txtNS_HoTen.Clear();
            dtpNS_NgaySinh.Value = new DateTime(2000, 1, 1);
            txtNS_CCCD.Clear();
            if (cboNS_PhongBan.Items.Count > 0) cboNS_PhongBan.SelectedIndex = 0;
            nudNS_LuongCB.Value = 10000000;
            nudNS_HeSo.Value = 1.0m;
            errorProvider.Clear();
        }
        #endregion

        #region CHẤM CÔNG NGẮT KẾT NỐI (DISCONNECTED MODEL)
        private void BtnCC_Nap_Click(object? sender, EventArgs e)
        {
            string thangNam = cboCC_ThangNam.SelectedItem?.ToString() ?? "11/2026";
            try
            {
                // Dùng SqlDataAdapter nạp toàn bộ nhân viên vào DataTable chấm công
                _tableChamCong = _chamCongBUS.NapBangChamCong(thangNam);
                dgvChamCong.DataSource = _tableChamCong;

                // Tinh chỉnh tiêu đề và khóa các cột không cho sửa
                var colMaCong = dgvChamCong.Columns["MaCong"];
                if (colMaCong != null)
                {
                    colMaCong.HeaderText = "Mã Công";
                    colMaCong.ReadOnly = true;
                    colMaCong.FillWeight = 10;
                }
                var colMaNV = dgvChamCong.Columns["MaNV"];
                if (colMaNV != null)
                {
                    colMaNV.HeaderText = "Mã NV";
                    colMaNV.ReadOnly = true;
                    colMaNV.FillWeight = 10;
                }
                var colHoTen = dgvChamCong.Columns["HoTen"];
                if (colHoTen != null)
                {
                    colHoTen.HeaderText = "Họ và Tên";
                    colHoTen.ReadOnly = true;
                    colHoTen.FillWeight = 25;
                }
                var colTenPB = dgvChamCong.Columns["TenPB"];
                if (colTenPB != null)
                {
                    colTenPB.HeaderText = "Phòng Ban";
                    colTenPB.ReadOnly = true;
                    colTenPB.FillWeight = 22;
                }
                var colThangNam = dgvChamCong.Columns["ThangNam"];
                if (colThangNam != null)
                {
                    colThangNam.HeaderText = "Tháng/Năm";
                    colThangNam.ReadOnly = true;
                    colThangNam.FillWeight = 12;
                }
                var colSoNgayCong = dgvChamCong.Columns["SoNgayCong"];
                if (colSoNgayCong != null)
                {
                    colSoNgayCong.HeaderText = "Số Ngày Công (Sửa)";
                    colSoNgayCong.ReadOnly = false; // Cho phép sửa trực tiếp
                    colSoNgayCong.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 230);
                    colSoNgayCong.FillWeight = 15;
                }
                var colSoGioOT = dgvChamCong.Columns["SoGioOT"];
                if (colSoGioOT != null)
                {
                    colSoGioOT.HeaderText = "Số Giờ OT (Sửa)";
                    colSoGioOT.ReadOnly = false; // Cho phép sửa trực tiếp
                    colSoGioOT.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240);
                    colSoGioOT.FillWeight = 15;
                }
                var colTrangThai = dgvChamCong.Columns["TrangThai"];
                if (colTrangThai != null)
                {
                    colTrangThai.HeaderText = "Trạng Thái";
                    colTrangThai.ReadOnly = true;
                    colTrangThai.FillWeight = 15;
                }

                lblCC_Stats.Text = $"[Disconnected Model]: Đã nạp {_tableChamCong.Rows.Count} bản ghi chấm công tháng {thangNam} vào DataTable.";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi Nạp Chấm Công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCC_Luu_Click(object? sender, EventArgs e)
        {
            if (_tableChamCong == null)
            {
                MessageBox.Show("Vui lòng nạp bảng chấm công trước khi lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kết thúc chỉnh sửa ô hiện tại trên DataGridView
            dgvChamCong.EndEdit();

            var confirm = MessageBox.Show(
                "Xác nhận lưu thay đổi chấm công về CSDL?\n" +
                "Hệ thống sẽ dùng SqlCommandBuilder và adapter.Update() để đồng bộ 1 thao tác duy nhất.",
                "Lưu Chấm Công (Disconnected Model)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var result = _chamCongBUS.LuuChamCong(_tableChamCong);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Lưu Chấm Công Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblCC_Stats.Text = $"Đã đồng bộ {result.AffectedRows} thay đổi về CSDL lúc {DateTime.Now:HH:mm:ss}";
                BtnTL_TinhDuKien_Click(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show(result.Message, "Lỗi Đồng Bộ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TÍNH LƯƠNG & CHỐT LƯƠNG (SQLTRANSACTION)
        private void BtnTL_TinhDuKien_Click(object? sender, EventArgs e)
        {
            string thangNam = cboTL_ThangNam.SelectedItem?.ToString() ?? "11/2026";
            var list = _luongBUS.TinhLuongDuKien(thangNam);

            _bangLuongList.Clear();
            foreach (var item in list) _bangLuongList.Add(item);

            decimal tongQuy = list.Sum(x => x.ThucLinh);
            lblTL_TongTienLuong.Text = $"{tongQuy:N0} đ";
            lblTL_SoNhanVien.Text = $"Số nhân viên: {list.Count} người";

            LogTrans($"[TÍNH LƯƠNG DỰ KIẾN]: Đã tính lương tháng {thangNam} cho {list.Count} nhân viên. Tổng quỹ lương: {tongQuy:N0} đ");
        }

        private void BtnTL_ChotLuong_Click(object? sender, EventArgs e)
        {
            string thangNam = cboTL_ThangNam.SelectedItem?.ToString() ?? "11/2026";
            if (_bangLuongList.Count == 0)
            {
                MessageBox.Show("Vui lòng tính lương dự kiến trước khi chốt lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal tongQuy = _bangLuongList.Sum(x => x.ThucLinh);
            var confirm = MessageBox.Show(
                $"XÁC NHẬN CHỐT LƯƠNG THÁNG {thangNam}:\n" +
                $"- Số nhân viên chốt: {_bangLuongList.Count} người\n" +
                $"- Tổng quỹ lương: {tongQuy:N0} đ\n\n" +
                $"Hệ thống sẽ mở SqlTransaction thực hiện đồng thời:\n" +
                $"1. Ghi nhận dữ liệu vào bảng BangLuong.\n" +
                $"2. Khóa dữ liệu chấm công tháng {thangNam} ('Đã chốt lương').\n" +
                $"3. Gọi trans.Commit() bảo đảm an toàn dữ liệu ACID.\n\n" +
                $"Bạn có chắc chắn muốn chốt lương?",
                "Chốt Lương Tháng (SqlTransaction)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            LogTrans("========================================");
            LogTrans($">>> BẮT ĐẦU GIAO DỊCH CHỐT LƯƠNG THÁNG {thangNam} <<<");
            LogTrans("1. Mở kết nối SqlConnection & trans = conn.BeginTransaction()...");

            var result = _luongBUS.ChotLuong(thangNam, _bangLuongList.ToList());

            if (result.Success)
            {
                LogTrans($"2. Ghi nhận {_bangLuongList.Count} bản ghi vào bảng BangLuong");
                LogTrans($"3. Cập nhật khóa trạng thái chấm công ('Đã chốt lương')");
                LogTrans(">>> trans.Commit() THÀNH CÔNG! Dữ liệu đã lưu vĩnh viễn <<<");
                LogTrans("========================================");

                MessageBox.Show(result.Message, "Chốt Lương Thành Công (SqlTransaction Commit)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnCC_Nap_Click(this, EventArgs.Empty);
            }
            else
            {
                LogTrans($">>> trans.Rollback() KÍCH HOẠT! <<<\nLý do: {result.Message}");
                LogTrans("========================================");
                MessageBox.Show(result.Message, "Lỗi Chốt Lương (SqlTransaction Rollback)", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogTrans(string message)
        {
            txtTL_LogTrans.AppendText($"\r\n[{DateTime.Now:HH:mm:ss}] {message}");
            txtTL_LogTrans.SelectionStart = txtTL_LogTrans.Text.Length;
            txtTL_LogTrans.ScrollToCaret();
        }
        #endregion
    }
}
