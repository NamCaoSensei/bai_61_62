namespace bai6_1.GUI
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            
            // Tab 1: Ban Hang
            this.tabBanHang = new System.Windows.Forms.TabPage();
            this.panelBanHangLeft = new System.Windows.Forms.Panel();
            this.grpGioHang = new System.Windows.Forms.GroupBox();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.colGH_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGH_TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGH_DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGH_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGH_ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChonSP = new System.Windows.Forms.Panel();
            this.lblChonSP = new System.Windows.Forms.Label();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.lblSoLuongMua = new System.Windows.Forms.Label();
            this.nudSoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.btnThemVaoGio = new System.Windows.Forms.Button();
            this.btnXoaKhoiGio = new System.Windows.Forms.Button();
            this.btnXoaToanBoGio = new System.Windows.Forms.Button();
            
            this.panelBanHangRight = new System.Windows.Forms.Panel();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.lblThuNgan = new System.Windows.Forms.Label();
            this.cboThuNgan = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblDiemHienCo = new System.Windows.Forms.Label();
            this.txtDiemHienCo = new System.Windows.Forms.TextBox();
            this.lblDiemTichLuyMoi = new System.Windows.Forms.Label();
            this.txtDiemTichLuyMoi = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTestRollback = new System.Windows.Forms.Button();
            this.txtLogGiaoDich = new System.Windows.Forms.TextBox();

            // Tab 2: Danh muc San Pham & CRUD
            this.tabDanhMuc = new System.Windows.Forms.TabPage();
            this.tabControlDanhMuc = new System.Windows.Forms.TabControl();
            this.tabSanPham = new System.Windows.Forms.TabPage();
            this.panelSP_Top = new System.Windows.Forms.Panel();
            this.grpSP_Input = new System.Windows.Forms.GroupBox();
            this.lblSP_Ma = new System.Windows.Forms.Label();
            this.txtSP_Ma = new System.Windows.Forms.TextBox();
            this.lblSP_Ten = new System.Windows.Forms.Label();
            this.txtSP_Ten = new System.Windows.Forms.TextBox();
            this.lblSP_Gia = new System.Windows.Forms.Label();
            this.nudSP_Gia = new System.Windows.Forms.NumericUpDown();
            this.lblSP_Ton = new System.Windows.Forms.Label();
            this.nudSP_Ton = new System.Windows.Forms.NumericUpDown();
            this.btnSP_Them = new System.Windows.Forms.Button();
            this.btnSP_Sua = new System.Windows.Forms.Button();
            this.btnSP_Xoa = new System.Windows.Forms.Button();
            this.btnSP_LamMoi = new System.Windows.Forms.Button();
            this.panelSP_Search = new System.Windows.Forms.Panel();
            this.lblSP_Search = new System.Windows.Forms.Label();
            this.txtSP_Search = new System.Windows.Forms.TextBox();
            this.btnSP_Search = new System.Windows.Forms.Button();
            this.btnSP_ResetSearch = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.colSP_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSP_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSP_Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSP_Ton = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Tab 2.2: Khach Hang
            this.tabKhachHang = new System.Windows.Forms.TabPage();
            this.panelKH_Top = new System.Windows.Forms.Panel();
            this.grpKH_Input = new System.Windows.Forms.GroupBox();
            this.lblKH_Ma = new System.Windows.Forms.Label();
            this.txtKH_Ma = new System.Windows.Forms.TextBox();
            this.lblKH_Ten = new System.Windows.Forms.Label();
            this.txtKH_Ten = new System.Windows.Forms.TextBox();
            this.lblKH_SDT = new System.Windows.Forms.Label();
            this.txtKH_SDT = new System.Windows.Forms.TextBox();
            this.lblKH_Diem = new System.Windows.Forms.Label();
            this.nudKH_Diem = new System.Windows.Forms.NumericUpDown();
            this.btnKH_Them = new System.Windows.Forms.Button();
            this.btnKH_Sua = new System.Windows.Forms.Button();
            this.btnKH_Xoa = new System.Windows.Forms.Button();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.colKH_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKH_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKH_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKH_Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Tab 2.3: Nhan Vien
            this.tabNhanVien = new System.Windows.Forms.TabPage();
            this.panelNV_Top = new System.Windows.Forms.Panel();
            this.grpNV_Input = new System.Windows.Forms.GroupBox();
            this.lblNV_Ma = new System.Windows.Forms.Label();
            this.txtNV_Ma = new System.Windows.Forms.TextBox();
            this.lblNV_Ten = new System.Windows.Forms.Label();
            this.txtNV_Ten = new System.Windows.Forms.TextBox();
            this.lblNV_SDT = new System.Windows.Forms.Label();
            this.txtNV_SDT = new System.Windows.Forms.TextBox();
            this.lblNV_ChucVu = new System.Windows.Forms.Label();
            this.cboNV_ChucVu = new System.Windows.Forms.ComboBox();
            this.btnNV_Them = new System.Windows.Forms.Button();
            this.btnNV_Sua = new System.Windows.Forms.Button();
            this.btnNV_Xoa = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colNV_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNV_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNV_SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNV_ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Tab 3: Bao Cao - Thong Ke
            this.tabBaoCao = new System.Windows.Forms.TabPage();
            this.panelBC_Cards = new System.Windows.Forms.Panel();
            this.pnlCardDoanhThuNgay = new System.Windows.Forms.Panel();
            this.lblBC_TitleNgay = new System.Windows.Forms.Label();
            this.lblBC_ValDoanhThuNgay = new System.Windows.Forms.Label();
            this.lblBC_SubNgay = new System.Windows.Forms.Label();
            this.pnlCardDoanhThuThang = new System.Windows.Forms.Panel();
            this.lblBC_TitleThang = new System.Windows.Forms.Label();
            this.lblBC_ValDoanhThuThang = new System.Windows.Forms.Label();
            this.lblBC_SubThang = new System.Windows.Forms.Label();
            this.pnlCardTopSP = new System.Windows.Forms.Panel();
            this.lblBC_TopTitle = new System.Windows.Forms.Label();
            this.dgvTopSanPham = new System.Windows.Forms.DataGridView();
            this.colTop_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTop_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTop_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTop_DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpLichSuHD = new System.Windows.Forms.GroupBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colHD_Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_NgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHD_TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoiBaoCao = new System.Windows.Forms.Button();

            // StatusStrip
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();

            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabBanHang.SuspendLayout();
            this.panelBanHangLeft.SuspendLayout();
            this.grpGioHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.panelChonSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMua)).BeginInit();
            this.panelBanHangRight.SuspendLayout();
            this.grpThanhToan.SuspendLayout();
            this.tabDanhMuc.SuspendLayout();
            this.tabControlDanhMuc.SuspendLayout();
            this.tabSanPham.SuspendLayout();
            this.panelSP_Top.SuspendLayout();
            this.grpSP_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSP_Gia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSP_Ton)).BeginInit();
            this.panelSP_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.tabKhachHang.SuspendLayout();
            this.panelKH_Top.SuspendLayout();
            this.grpKH_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKH_Diem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.tabNhanVien.SuspendLayout();
            this.panelNV_Top.SuspendLayout();
            this.grpNV_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabBaoCao.SuspendLayout();
            this.panelBC_Cards.SuspendLayout();
            this.pnlCardDoanhThuNgay.SuspendLayout();
            this.pnlCardDoanhThuThang.SuspendLayout();
            this.pnlCardTopSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSanPham)).BeginInit();
            this.grpLichSuHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.panelHeader.Controls.Add(this.lblHeaderSubtitle);
            this.panelHeader.Controls.Add(this.lblHeaderTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1184, 75);
            this.panelHeader.TabIndex = 0;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lblHeaderTitle.Location = new System.Drawing.Point(20, 12);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(730, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG & SIÊU THỊ MINI (RETAIL SALES SYSTEM)";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(760, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Kiến trúc 3-Tier (DTO - DAL - BUS - GUI) | SqlTransaction ACID | Phòng chống 100% SQL Injection | Sinh viên: Nguyễn Hải Nam (24810310617)";

            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabBanHang);
            this.tabControlMain.Controls.Add(this.tabDanhMuc);
            this.tabControlMain.Controls.Add(this.tabBaoCao);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 75);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1184, 615);
            this.tabControlMain.TabIndex = 1;

            // ==========================================
            // TAB 1: BAN HANG / LAP HOA DON
            // ==========================================
            this.tabBanHang.Controls.Add(this.panelBanHangLeft);
            this.tabBanHang.Controls.Add(this.panelBanHangRight);
            this.tabBanHang.Location = new System.Drawing.Point(4, 26);
            this.tabBanHang.Name = "tabBanHang";
            this.tabBanHang.Padding = new System.Windows.Forms.Padding(8);
            this.tabBanHang.Size = new System.Drawing.Size(1176, 585);
            this.tabBanHang.TabIndex = 0;
            this.tabBanHang.Text = "🛒 Màn hình Bán Hàng (SqlTransaction)";
            this.tabBanHang.UseVisualStyleBackColor = true;

            // panelBanHangLeft
            this.panelBanHangLeft.Controls.Add(this.grpGioHang);
            this.panelBanHangLeft.Controls.Add(this.panelChonSP);
            this.panelBanHangLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBanHangLeft.Location = new System.Drawing.Point(8, 8);
            this.panelBanHangLeft.Name = "panelBanHangLeft";
            this.panelBanHangLeft.Size = new System.Drawing.Size(770, 569);
            this.panelBanHangLeft.TabIndex = 0;

            // panelChonSP
            this.panelChonSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panelChonSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChonSP.Controls.Add(this.lblChonSP);
            this.panelChonSP.Controls.Add(this.cboSanPham);
            this.panelChonSP.Controls.Add(this.lblSoLuongMua);
            this.panelChonSP.Controls.Add(this.nudSoLuongMua);
            this.panelChonSP.Controls.Add(this.btnThemVaoGio);
            this.panelChonSP.Controls.Add(this.btnXoaKhoiGio);
            this.panelChonSP.Controls.Add(this.btnXoaToanBoGio);
            this.panelChonSP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChonSP.Location = new System.Drawing.Point(0, 0);
            this.panelChonSP.Name = "panelChonSP";
            this.panelChonSP.Padding = new System.Windows.Forms.Padding(10);
            this.panelChonSP.Size = new System.Drawing.Size(770, 75);
            this.panelChonSP.TabIndex = 0;

            this.lblChonSP.AutoSize = true;
            this.lblChonSP.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblChonSP.Location = new System.Drawing.Point(10, 10);
            this.lblChonSP.Name = "lblChonSP";
            this.lblChonSP.Size = new System.Drawing.Size(107, 17);
            this.lblChonSP.Text = "Chọn sản phẩm:";

            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(10, 33);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(320, 25);
            this.cboSanPham.TabIndex = 0;

            this.lblSoLuongMua.AutoSize = true;
            this.lblSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSoLuongMua.Location = new System.Drawing.Point(345, 10);
            this.lblSoLuongMua.Name = "lblSoLuongMua";
            this.lblSoLuongMua.Size = new System.Drawing.Size(69, 17);
            this.lblSoLuongMua.TabIndex = 1;
            this.lblSoLuongMua.Text = "Số lượng:";

            this.nudSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudSoLuongMua.Location = new System.Drawing.Point(345, 33);
            this.nudSoLuongMua.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSoLuongMua.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.nudSoLuongMua.Name = "nudSoLuongMua";
            this.nudSoLuongMua.Size = new System.Drawing.Size(80, 24);
            this.nudSoLuongMua.TabIndex = 1;
            this.nudSoLuongMua.Value = new decimal(new int[] { 1, 0, 0, 0 });

            this.btnThemVaoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(140)))), ((int)(((byte)(60)))));
            this.btnThemVaoGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemVaoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemVaoGio.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnThemVaoGio.ForeColor = System.Drawing.Color.White;
            this.btnThemVaoGio.Location = new System.Drawing.Point(440, 28);
            this.btnThemVaoGio.Name = "btnThemVaoGio";
            this.btnThemVaoGio.Size = new System.Drawing.Size(120, 32);
            this.btnThemVaoGio.TabIndex = 2;
            this.btnThemVaoGio.Text = "+ Thêm giỏ";
            this.btnThemVaoGio.UseVisualStyleBackColor = false;

            this.btnXoaKhoiGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(80)))), ((int)(((byte)(50)))));
            this.btnXoaKhoiGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaKhoiGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKhoiGio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaKhoiGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaKhoiGio.Location = new System.Drawing.Point(568, 28);
            this.btnXoaKhoiGio.Name = "btnXoaKhoiGio";
            this.btnXoaKhoiGio.Size = new System.Drawing.Size(90, 32);
            this.btnXoaKhoiGio.TabIndex = 3;
            this.btnXoaKhoiGio.Text = "Xóa món";
            this.btnXoaKhoiGio.UseVisualStyleBackColor = false;

            this.btnXoaToanBoGio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnXoaToanBoGio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaToanBoGio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaToanBoGio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaToanBoGio.ForeColor = System.Drawing.Color.White;
            this.btnXoaToanBoGio.Location = new System.Drawing.Point(665, 28);
            this.btnXoaToanBoGio.Name = "btnXoaToanBoGio";
            this.btnXoaToanBoGio.Size = new System.Drawing.Size(85, 32);
            this.btnXoaToanBoGio.TabIndex = 4;
            this.btnXoaToanBoGio.Text = "Xóa hết";
            this.btnXoaToanBoGio.UseVisualStyleBackColor = false;

            // grpGioHang
            this.grpGioHang.Controls.Add(this.dgvGioHang);
            this.grpGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGioHang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpGioHang.Location = new System.Drawing.Point(0, 75);
            this.grpGioHang.Name = "grpGioHang";
            this.grpGioHang.Padding = new System.Windows.Forms.Padding(6);
            this.grpGioHang.Size = new System.Drawing.Size(770, 494);
            this.grpGioHang.TabIndex = 1;
            this.grpGioHang.TabStop = false;
            this.grpGioHang.Text = "Chi tiết giỏ hàng hiện tại:";

            // dgvGioHang
            this.dgvGioHang.AllowUserToAddRows = false;
            this.dgvGioHang.AllowUserToDeleteRows = false;
            this.dgvGioHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGioHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGH_MaSP,
            this.colGH_TenSP,
            this.colGH_DonGia,
            this.colGH_SoLuong,
            this.colGH_ThanhTien});
            this.dgvGioHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGioHang.Location = new System.Drawing.Point(6, 23);
            this.dgvGioHang.MultiSelect = false;
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.ReadOnly = true;
            this.dgvGioHang.RowHeadersVisible = false;
            this.dgvGioHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGioHang.Size = new System.Drawing.Size(758, 465);
            this.dgvGioHang.TabIndex = 0;

            this.colGH_MaSP.DataPropertyName = "MaSP";
            this.colGH_MaSP.FillWeight = 20F;
            this.colGH_MaSP.HeaderText = "Mã SP";
            this.colGH_MaSP.Name = "colGH_MaSP";
            this.colGH_MaSP.ReadOnly = true;

            this.colGH_TenSP.DataPropertyName = "TenSP";
            this.colGH_TenSP.FillWeight = 40F;
            this.colGH_TenSP.HeaderText = "Tên Sản Phẩm";
            this.colGH_TenSP.Name = "colGH_TenSP";
            this.colGH_TenSP.ReadOnly = true;

            this.colGH_DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colGH_DonGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.colGH_DonGia.FillWeight = 20F;
            this.colGH_DonGia.HeaderText = "Đơn Giá (đ)";
            this.colGH_DonGia.Name = "colGH_DonGia";
            this.colGH_DonGia.ReadOnly = true;

            this.colGH_SoLuong.DataPropertyName = "SoLuong";
            this.colGH_SoLuong.FillWeight = 15F;
            this.colGH_SoLuong.HeaderText = "Số Lượng";
            this.colGH_SoLuong.Name = "colGH_SoLuong";
            this.colGH_SoLuong.ReadOnly = true;

            this.colGH_ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.colGH_ThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.colGH_ThanhTien.FillWeight = 25F;
            this.colGH_ThanhTien.HeaderText = "Thành Tiền (đ)";
            this.colGH_ThanhTien.Name = "colGH_ThanhTien";
            this.colGH_ThanhTien.ReadOnly = true;

            // panelBanHangRight
            this.panelBanHangRight.Controls.Add(this.grpThanhToan);
            this.panelBanHangRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBanHangRight.Location = new System.Drawing.Point(778, 8);
            this.panelBanHangRight.Name = "panelBanHangRight";
            this.panelBanHangRight.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.panelBanHangRight.Size = new System.Drawing.Size(390, 569);
            this.panelBanHangRight.TabIndex = 1;

            // grpThanhToan
            this.grpThanhToan.Controls.Add(this.lblThuNgan);
            this.grpThanhToan.Controls.Add(this.cboThuNgan);
            this.grpThanhToan.Controls.Add(this.lblKhachHang);
            this.grpThanhToan.Controls.Add(this.cboKhachHang);
            this.grpThanhToan.Controls.Add(this.lblDiemHienCo);
            this.grpThanhToan.Controls.Add(this.txtDiemHienCo);
            this.grpThanhToan.Controls.Add(this.lblDiemTichLuyMoi);
            this.grpThanhToan.Controls.Add(this.txtDiemTichLuyMoi);
            this.grpThanhToan.Controls.Add(this.lblTongTien);
            this.grpThanhToan.Controls.Add(this.txtTongTien);
            this.grpThanhToan.Controls.Add(this.btnThanhToan);
            this.grpThanhToan.Controls.Add(this.btnTestRollback);
            this.grpThanhToan.Controls.Add(this.txtLogGiaoDich);
            this.grpThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpThanhToan.Location = new System.Drawing.Point(8, 0);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Padding = new System.Windows.Forms.Padding(12);
            this.grpThanhToan.Size = new System.Drawing.Size(382, 569);
            this.grpThanhToan.TabIndex = 0;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Thông tin Hóa Đơn & Thanh Toán:";

            this.lblThuNgan.AutoSize = true;
            this.lblThuNgan.Location = new System.Drawing.Point(12, 28);
            this.lblThuNgan.Name = "lblThuNgan";
            this.lblThuNgan.Size = new System.Drawing.Size(134, 17);
            this.lblThuNgan.TabIndex = 0;
            this.lblThuNgan.Text = "Nhân viên thu ngân:";

            this.cboThuNgan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThuNgan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboThuNgan.FormattingEnabled = true;
            this.cboThuNgan.Location = new System.Drawing.Point(15, 48);
            this.cboThuNgan.Name = "cboThuNgan";
            this.cboThuNgan.Size = new System.Drawing.Size(350, 25);
            this.cboThuNgan.TabIndex = 1;

            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(12, 85);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(86, 17);
            this.lblKhachHang.TabIndex = 2;
            this.lblKhachHang.Text = "Khách hàng:";

            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(15, 105);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(350, 25);
            this.cboKhachHang.TabIndex = 3;

            this.lblDiemHienCo.AutoSize = true;
            this.lblDiemHienCo.Location = new System.Drawing.Point(12, 142);
            this.lblDiemHienCo.Name = "lblDiemHienCo";
            this.lblDiemHienCo.Size = new System.Drawing.Size(126, 17);
            this.lblDiemHienCo.TabIndex = 4;
            this.lblDiemHienCo.Text = "Điểm tích lũy hiện:";

            this.txtDiemHienCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtDiemHienCo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtDiemHienCo.Location = new System.Drawing.Point(15, 162);
            this.txtDiemHienCo.Name = "txtDiemHienCo";
            this.txtDiemHienCo.ReadOnly = true;
            this.txtDiemHienCo.Size = new System.Drawing.Size(160, 24);
            this.txtDiemHienCo.TabIndex = 5;

            this.lblDiemTichLuyMoi.AutoSize = true;
            this.lblDiemTichLuyMoi.Location = new System.Drawing.Point(195, 142);
            this.lblDiemTichLuyMoi.Name = "lblDiemTichLuyMoi";
            this.lblDiemTichLuyMoi.Size = new System.Drawing.Size(123, 17);
            this.lblDiemTichLuyMoi.TabIndex = 6;
            this.lblDiemTichLuyMoi.Text = "Điểm cộng lần này:";

            this.txtDiemTichLuyMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.txtDiemTichLuyMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.txtDiemTichLuyMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.txtDiemTichLuyMoi.Location = new System.Drawing.Point(198, 162);
            this.txtDiemTichLuyMoi.Name = "txtDiemTichLuyMoi";
            this.txtDiemTichLuyMoi.ReadOnly = true;
            this.txtDiemTichLuyMoi.Size = new System.Drawing.Size(167, 24);
            this.txtDiemTichLuyMoi.TabIndex = 7;

            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTongTien.Location = new System.Drawing.Point(12, 198);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(170, 20);
            this.lblTongTien.TabIndex = 8;
            this.lblTongTien.Text = "TỔNG TIỀN MẶT (VNĐ):";

            this.txtTongTien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(230)))));
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.txtTongTien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtTongTien.Location = new System.Drawing.Point(15, 222);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(350, 36);
            this.txtTongTien.TabIndex = 9;
            this.txtTongTien.Text = "0 đ";
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(15, 272);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(350, 45);
            this.btnThanhToan.TabIndex = 10;
            this.btnThanhToan.Text = "💳 THANH TOÁN (SqlTransaction)";
            this.btnThanhToan.UseVisualStyleBackColor = false;

            this.btnTestRollback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(80)))), ((int)(((byte)(40)))));
            this.btnTestRollback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestRollback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTestRollback.ForeColor = System.Drawing.Color.White;
            this.btnTestRollback.Location = new System.Drawing.Point(15, 325);
            this.btnTestRollback.Name = "btnTestRollback";
            this.btnTestRollback.Size = new System.Drawing.Size(350, 32);
            this.btnTestRollback.TabIndex = 11;
            this.btnTestRollback.Text = "⚠️ Thử nghiệm Lỗi Rollback (Vượt tồn kho)";
            this.btnTestRollback.UseVisualStyleBackColor = false;

            this.txtLogGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.txtLogGiaoDich.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.txtLogGiaoDich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.txtLogGiaoDich.Location = new System.Drawing.Point(15, 370);
            this.txtLogGiaoDich.Multiline = true;
            this.txtLogGiaoDich.Name = "txtLogGiaoDich";
            this.txtLogGiaoDich.ReadOnly = true;
            this.txtLogGiaoDich.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogGiaoDich.Size = new System.Drawing.Size(350, 185);
            this.txtLogGiaoDich.TabIndex = 12;
            this.txtLogGiaoDich.Text = "[Hệ thống sẵn sàng]\r\nChờ lập hóa đơn giao dịch SqlTransaction...";

            // ==========================================
            // TAB 2: QUAN LY DANH MUC (CRUD 3-TIER)
            // ==========================================
            this.tabDanhMuc.Controls.Add(this.tabControlDanhMuc);
            this.tabDanhMuc.Location = new System.Drawing.Point(4, 26);
            this.tabDanhMuc.Name = "tabDanhMuc";
            this.tabDanhMuc.Padding = new System.Windows.Forms.Padding(6);
            this.tabDanhMuc.Size = new System.Drawing.Size(1176, 585);
            this.tabDanhMuc.TabIndex = 1;
            this.tabDanhMuc.Text = "📋 Quản Lý Danh Mục (CRUD 3-Tier)";
            this.tabDanhMuc.UseVisualStyleBackColor = true;

            this.tabControlDanhMuc.Controls.Add(this.tabSanPham);
            this.tabControlDanhMuc.Controls.Add(this.tabKhachHang);
            this.tabControlDanhMuc.Controls.Add(this.tabNhanVien);
            this.tabControlDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDanhMuc.Location = new System.Drawing.Point(6, 6);
            this.tabControlDanhMuc.Name = "tabControlDanhMuc";
            this.tabControlDanhMuc.SelectedIndex = 0;
            this.tabControlDanhMuc.Size = new System.Drawing.Size(1164, 573);
            this.tabControlDanhMuc.TabIndex = 0;

            // --- TAB SAN PHAM ---
            this.tabSanPham.Controls.Add(this.dgvSanPham);
            this.tabSanPham.Controls.Add(this.panelSP_Search);
            this.tabSanPham.Controls.Add(this.panelSP_Top);
            this.tabSanPham.Location = new System.Drawing.Point(4, 26);
            this.tabSanPham.Name = "tabSanPham";
            this.tabSanPham.Padding = new System.Windows.Forms.Padding(6);
            this.tabSanPham.Size = new System.Drawing.Size(1156, 543);
            this.tabSanPham.TabIndex = 0;
            this.tabSanPham.Text = "Hàng Hóa / Sản Phẩm";
            this.tabSanPham.UseVisualStyleBackColor = true;

            this.panelSP_Top.Controls.Add(this.grpSP_Input);
            this.panelSP_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSP_Top.Location = new System.Drawing.Point(6, 6);
            this.panelSP_Top.Name = "panelSP_Top";
            this.panelSP_Top.Size = new System.Drawing.Size(1144, 130);
            this.panelSP_Top.TabIndex = 0;

            this.grpSP_Input.Controls.Add(this.lblSP_Ma);
            this.grpSP_Input.Controls.Add(this.txtSP_Ma);
            this.grpSP_Input.Controls.Add(this.lblSP_Ten);
            this.grpSP_Input.Controls.Add(this.txtSP_Ten);
            this.grpSP_Input.Controls.Add(this.lblSP_Gia);
            this.grpSP_Input.Controls.Add(this.nudSP_Gia);
            this.grpSP_Input.Controls.Add(this.lblSP_Ton);
            this.grpSP_Input.Controls.Add(this.nudSP_Ton);
            this.grpSP_Input.Controls.Add(this.btnSP_Them);
            this.grpSP_Input.Controls.Add(this.btnSP_Sua);
            this.grpSP_Input.Controls.Add(this.btnSP_Xoa);
            this.grpSP_Input.Controls.Add(this.btnSP_LamMoi);
            this.grpSP_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSP_Input.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpSP_Input.Location = new System.Drawing.Point(0, 0);
            this.grpSP_Input.Name = "grpSP_Input";
            this.grpSP_Input.Size = new System.Drawing.Size(1144, 130);
            this.grpSP_Input.TabIndex = 0;
            this.grpSP_Input.TabStop = false;
            this.grpSP_Input.Text = "Thông tin Sản Phẩm:";

            this.lblSP_Ma.AutoSize = true;
            this.lblSP_Ma.Location = new System.Drawing.Point(15, 25);
            this.lblSP_Ma.Name = "lblSP_Ma";
            this.lblSP_Ma.Size = new System.Drawing.Size(51, 17);
            this.lblSP_Ma.TabIndex = 0;
            this.lblSP_Ma.Text = "Mã SP:";

            this.txtSP_Ma.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSP_Ma.Location = new System.Drawing.Point(75, 22);
            this.txtSP_Ma.Name = "txtSP_Ma";
            this.txtSP_Ma.Size = new System.Drawing.Size(120, 24);
            this.txtSP_Ma.TabIndex = 1;

            this.lblSP_Ten.AutoSize = true;
            this.lblSP_Ten.Location = new System.Drawing.Point(215, 25);
            this.lblSP_Ten.Name = "lblSP_Ten";
            this.lblSP_Ten.Size = new System.Drawing.Size(54, 17);
            this.lblSP_Ten.TabIndex = 2;
            this.lblSP_Ten.Text = "Tên SP:";

            this.txtSP_Ten.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSP_Ten.Location = new System.Drawing.Point(275, 22);
            this.txtSP_Ten.Name = "txtSP_Ten";
            this.txtSP_Ten.Size = new System.Drawing.Size(320, 24);
            this.txtSP_Ten.TabIndex = 3;

            this.lblSP_Gia.AutoSize = true;
            this.lblSP_Gia.Location = new System.Drawing.Point(615, 25);
            this.lblSP_Gia.Name = "lblSP_Gia";
            this.lblSP_Gia.Size = new System.Drawing.Size(59, 17);
            this.lblSP_Gia.TabIndex = 4;
            this.lblSP_Gia.Text = "Giá bán:";

            this.nudSP_Gia.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudSP_Gia.Location = new System.Drawing.Point(680, 22);
            this.nudSP_Gia.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            this.nudSP_Gia.Name = "nudSP_Gia";
            this.nudSP_Gia.Size = new System.Drawing.Size(130, 24);
            this.nudSP_Gia.TabIndex = 5;

            this.lblSP_Ton.AutoSize = true;
            this.lblSP_Ton.Location = new System.Drawing.Point(830, 25);
            this.lblSP_Ton.Name = "lblSP_Ton";
            this.lblSP_Ton.Size = new System.Drawing.Size(65, 17);
            this.lblSP_Ton.TabIndex = 6;
            this.lblSP_Ton.Text = "Tồn kho:";

            this.nudSP_Ton.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudSP_Ton.Location = new System.Drawing.Point(905, 22);
            this.nudSP_Ton.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudSP_Ton.Name = "nudSP_Ton";
            this.nudSP_Ton.Size = new System.Drawing.Size(90, 24);
            this.nudSP_Ton.TabIndex = 7;

            // Buttons CRUD SP
            this.btnSP_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnSP_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP_Them.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSP_Them.ForeColor = System.Drawing.Color.White;
            this.btnSP_Them.Location = new System.Drawing.Point(75, 68);
            this.btnSP_Them.Name = "btnSP_Them";
            this.btnSP_Them.Size = new System.Drawing.Size(110, 35);
            this.btnSP_Them.TabIndex = 8;
            this.btnSP_Them.Text = "Thêm mới";
            this.btnSP_Them.UseVisualStyleBackColor = false;

            this.btnSP_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnSP_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP_Sua.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSP_Sua.ForeColor = System.Drawing.Color.White;
            this.btnSP_Sua.Location = new System.Drawing.Point(200, 68);
            this.btnSP_Sua.Name = "btnSP_Sua";
            this.btnSP_Sua.Size = new System.Drawing.Size(110, 35);
            this.btnSP_Sua.TabIndex = 9;
            this.btnSP_Sua.Text = "Sửa đổi";
            this.btnSP_Sua.UseVisualStyleBackColor = false;

            this.btnSP_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnSP_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP_Xoa.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnSP_Xoa.ForeColor = System.Drawing.Color.White;
            this.btnSP_Xoa.Location = new System.Drawing.Point(325, 68);
            this.btnSP_Xoa.Name = "btnSP_Xoa";
            this.btnSP_Xoa.Size = new System.Drawing.Size(110, 35);
            this.btnSP_Xoa.TabIndex = 10;
            this.btnSP_Xoa.Text = "Xóa bỏ";
            this.btnSP_Xoa.UseVisualStyleBackColor = false;

            this.btnSP_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnSP_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP_LamMoi.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnSP_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btnSP_LamMoi.Location = new System.Drawing.Point(450, 68);
            this.btnSP_LamMoi.Name = "btnSP_LamMoi";
            this.btnSP_LamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnSP_LamMoi.TabIndex = 11;
            this.btnSP_LamMoi.Text = "Làm mới";
            this.btnSP_LamMoi.UseVisualStyleBackColor = false;

            // Search Bar SP
            this.panelSP_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.panelSP_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSP_Search.Controls.Add(this.lblSP_Search);
            this.panelSP_Search.Controls.Add(this.txtSP_Search);
            this.panelSP_Search.Controls.Add(this.btnSP_Search);
            this.panelSP_Search.Controls.Add(this.btnSP_ResetSearch);
            this.panelSP_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSP_Search.Location = new System.Drawing.Point(6, 136);
            this.panelSP_Search.Name = "panelSP_Search";
            this.panelSP_Search.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.panelSP_Search.Size = new System.Drawing.Size(1144, 45);
            this.panelSP_Search.TabIndex = 1;

            this.lblSP_Search.AutoSize = true;
            this.lblSP_Search.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblSP_Search.Location = new System.Drawing.Point(10, 12);
            this.lblSP_Search.Name = "lblSP_Search";
            this.lblSP_Search.Size = new System.Drawing.Size(262, 17);
            this.lblSP_Search.TabIndex = 0;
            this.lblSP_Search.Text = "🔍 Tìm kiếm SP (SqlParameter LIKE %...%):";

            this.txtSP_Search.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSP_Search.Location = new System.Drawing.Point(280, 9);
            this.txtSP_Search.Name = "txtSP_Search";
            this.txtSP_Search.Size = new System.Drawing.Size(300, 24);
            this.txtSP_Search.TabIndex = 1;

            this.btnSP_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnSP_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSP_Search.ForeColor = System.Drawing.Color.White;
            this.btnSP_Search.Location = new System.Drawing.Point(590, 7);
            this.btnSP_Search.Name = "btnSP_Search";
            this.btnSP_Search.Size = new System.Drawing.Size(90, 28);
            this.btnSP_Search.TabIndex = 2;
            this.btnSP_Search.Text = "Tìm kiếm";
            this.btnSP_Search.UseVisualStyleBackColor = false;

            this.btnSP_ResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
            this.btnSP_ResetSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSP_ResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSP_ResetSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSP_ResetSearch.ForeColor = System.Drawing.Color.White;
            this.btnSP_ResetSearch.Location = new System.Drawing.Point(690, 7);
            this.btnSP_ResetSearch.Name = "btnSP_ResetSearch";
            this.btnSP_ResetSearch.Size = new System.Drawing.Size(90, 28);
            this.btnSP_ResetSearch.TabIndex = 3;
            this.btnSP_ResetSearch.Text = "Hiển thị tất";
            this.btnSP_ResetSearch.UseVisualStyleBackColor = false;

            // dgvSanPham
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSP_Ma,
            this.colSP_Ten,
            this.colSP_Gia,
            this.colSP_Ton});
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(6, 181);
            this.dgvSanPham.MultiSelect = false;
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1144, 356);
            this.dgvSanPham.TabIndex = 2;

            this.colSP_Ma.DataPropertyName = "MaSP";
            this.colSP_Ma.FillWeight = 20F;
            this.colSP_Ma.HeaderText = "Mã Sản Phẩm";
            this.colSP_Ma.Name = "colSP_Ma";
            this.colSP_Ma.ReadOnly = true;

            this.colSP_Ten.DataPropertyName = "TenSP";
            this.colSP_Ten.FillWeight = 45F;
            this.colSP_Ten.HeaderText = "Tên Sản Phẩm";
            this.colSP_Ten.Name = "colSP_Ten";
            this.colSP_Ten.ReadOnly = true;

            this.colSP_Gia.DataPropertyName = "GiaBan";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSP_Gia.DefaultCellStyle = dataGridViewCellStyle3;
            this.colSP_Gia.FillWeight = 20F;
            this.colSP_Gia.HeaderText = "Giá Bán (đ)";
            this.colSP_Gia.Name = "colSP_Gia";
            this.colSP_Gia.ReadOnly = true;

            this.colSP_Ton.DataPropertyName = "SoLuongTon";
            this.colSP_Ton.FillWeight = 15F;
            this.colSP_Ton.HeaderText = "Số Lượng Tồn";
            this.colSP_Ton.Name = "colSP_Ton";
            this.colSP_Ton.ReadOnly = true;

            // --- TAB KHACH HANG ---
            this.tabKhachHang.Controls.Add(this.dgvKhachHang);
            this.tabKhachHang.Controls.Add(this.panelKH_Top);
            this.tabKhachHang.Location = new System.Drawing.Point(4, 26);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.Padding = new System.Windows.Forms.Padding(6);
            this.tabKhachHang.Size = new System.Drawing.Size(1156, 543);
            this.tabKhachHang.TabIndex = 1;
            this.tabKhachHang.Text = "Khách Hàng";
            this.tabKhachHang.UseVisualStyleBackColor = true;

            this.panelKH_Top.Controls.Add(this.grpKH_Input);
            this.panelKH_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKH_Top.Location = new System.Drawing.Point(6, 6);
            this.panelKH_Top.Name = "panelKH_Top";
            this.panelKH_Top.Size = new System.Drawing.Size(1144, 120);
            this.panelKH_Top.TabIndex = 0;

            this.grpKH_Input.Controls.Add(this.lblKH_Ma);
            this.grpKH_Input.Controls.Add(this.txtKH_Ma);
            this.grpKH_Input.Controls.Add(this.lblKH_Ten);
            this.grpKH_Input.Controls.Add(this.txtKH_Ten);
            this.grpKH_Input.Controls.Add(this.lblKH_SDT);
            this.grpKH_Input.Controls.Add(this.txtKH_SDT);
            this.grpKH_Input.Controls.Add(this.lblKH_Diem);
            this.grpKH_Input.Controls.Add(this.nudKH_Diem);
            this.grpKH_Input.Controls.Add(this.btnKH_Them);
            this.grpKH_Input.Controls.Add(this.btnKH_Sua);
            this.grpKH_Input.Controls.Add(this.btnKH_Xoa);
            this.grpKH_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpKH_Input.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpKH_Input.Location = new System.Drawing.Point(0, 0);
            this.grpKH_Input.Name = "grpKH_Input";
            this.grpKH_Input.Size = new System.Drawing.Size(1144, 120);
            this.grpKH_Input.TabIndex = 0;
            this.grpKH_Input.TabStop = false;
            this.grpKH_Input.Text = "Thông tin Khách Hàng:";

            this.lblKH_Ma.AutoSize = true;
            this.lblKH_Ma.Location = new System.Drawing.Point(15, 25);
            this.lblKH_Ma.Name = "lblKH_Ma";
            this.lblKH_Ma.Size = new System.Drawing.Size(53, 17);
            this.lblKH_Ma.TabIndex = 0;
            this.lblKH_Ma.Text = "Mã KH:";

            this.txtKH_Ma.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKH_Ma.Location = new System.Drawing.Point(75, 22);
            this.txtKH_Ma.Name = "txtKH_Ma";
            this.txtKH_Ma.ReadOnly = true;
            this.txtKH_Ma.Size = new System.Drawing.Size(80, 24);
            this.txtKH_Ma.TabIndex = 1;

            this.lblKH_Ten.AutoSize = true;
            this.lblKH_Ten.Location = new System.Drawing.Point(175, 25);
            this.lblKH_Ten.Name = "lblKH_Ten";
            this.lblKH_Ten.Size = new System.Drawing.Size(56, 17);
            this.lblKH_Ten.TabIndex = 2;
            this.lblKH_Ten.Text = "Tên KH:";

            this.txtKH_Ten.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKH_Ten.Location = new System.Drawing.Point(240, 22);
            this.txtKH_Ten.Name = "txtKH_Ten";
            this.txtKH_Ten.Size = new System.Drawing.Size(260, 24);
            this.txtKH_Ten.TabIndex = 3;

            this.lblKH_SDT.AutoSize = true;
            this.lblKH_SDT.Location = new System.Drawing.Point(520, 25);
            this.lblKH_SDT.Name = "lblKH_SDT";
            this.lblKH_SDT.Size = new System.Drawing.Size(75, 17);
            this.lblKH_SDT.TabIndex = 4;
            this.lblKH_SDT.Text = "Điện thoại:";

            this.txtKH_SDT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtKH_SDT.Location = new System.Drawing.Point(605, 22);
            this.txtKH_SDT.Name = "txtKH_SDT";
            this.txtKH_SDT.Size = new System.Drawing.Size(160, 24);
            this.txtKH_SDT.TabIndex = 5;

            this.lblKH_Diem.AutoSize = true;
            this.lblKH_Diem.Location = new System.Drawing.Point(785, 25);
            this.lblKH_Diem.Name = "lblKH_Diem";
            this.lblKH_Diem.Size = new System.Drawing.Size(94, 17);
            this.lblKH_Diem.TabIndex = 6;
            this.lblKH_Diem.Text = "Điểm tích lũy:";

            this.nudKH_Diem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudKH_Diem.Location = new System.Drawing.Point(885, 22);
            this.nudKH_Diem.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.nudKH_Diem.Name = "nudKH_Diem";
            this.nudKH_Diem.Size = new System.Drawing.Size(90, 24);
            this.nudKH_Diem.TabIndex = 7;

            this.btnKH_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnKH_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKH_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_Them.ForeColor = System.Drawing.Color.White;
            this.btnKH_Them.Location = new System.Drawing.Point(75, 65);
            this.btnKH_Them.Name = "btnKH_Them";
            this.btnKH_Them.Size = new System.Drawing.Size(110, 35);
            this.btnKH_Them.TabIndex = 8;
            this.btnKH_Them.Text = "Thêm KH";
            this.btnKH_Them.UseVisualStyleBackColor = false;

            this.btnKH_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnKH_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKH_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_Sua.ForeColor = System.Drawing.Color.White;
            this.btnKH_Sua.Location = new System.Drawing.Point(200, 65);
            this.btnKH_Sua.Name = "btnKH_Sua";
            this.btnKH_Sua.Size = new System.Drawing.Size(110, 35);
            this.btnKH_Sua.TabIndex = 9;
            this.btnKH_Sua.Text = "Sửa KH";
            this.btnKH_Sua.UseVisualStyleBackColor = false;

            this.btnKH_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnKH_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKH_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKH_Xoa.ForeColor = System.Drawing.Color.White;
            this.btnKH_Xoa.Location = new System.Drawing.Point(325, 65);
            this.btnKH_Xoa.Name = "btnKH_Xoa";
            this.btnKH_Xoa.Size = new System.Drawing.Size(110, 35);
            this.btnKH_Xoa.TabIndex = 10;
            this.btnKH_Xoa.Text = "Xóa KH";
            this.btnKH_Xoa.UseVisualStyleBackColor = false;

            // dgvKhachHang
            this.dgvKhachHang.AllowUserToAddRows = false;
            this.dgvKhachHang.AllowUserToDeleteRows = false;
            this.dgvKhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKH_Ma,
            this.colKH_Ten,
            this.colKH_SDT,
            this.colKH_Diem});
            this.dgvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachHang.Location = new System.Drawing.Point(6, 126);
            this.dgvKhachHang.MultiSelect = false;
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.ReadOnly = true;
            this.dgvKhachHang.RowHeadersVisible = false;
            this.dgvKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhachHang.Size = new System.Drawing.Size(1144, 411);
            this.dgvKhachHang.TabIndex = 1;

            this.colKH_Ma.DataPropertyName = "MaKH";
            this.colKH_Ma.FillWeight = 15F;
            this.colKH_Ma.HeaderText = "Mã KH";
            this.colKH_Ma.Name = "colKH_Ma";
            this.colKH_Ma.ReadOnly = true;

            this.colKH_Ten.DataPropertyName = "TenKH";
            this.colKH_Ten.FillWeight = 45F;
            this.colKH_Ten.HeaderText = "Tên Khách Hàng";
            this.colKH_Ten.Name = "colKH_Ten";
            this.colKH_Ten.ReadOnly = true;

            this.colKH_SDT.DataPropertyName = "DienThoai";
            this.colKH_SDT.FillWeight = 25F;
            this.colKH_SDT.HeaderText = "Số Điện Thoại";
            this.colKH_SDT.Name = "colKH_SDT";
            this.colKH_SDT.ReadOnly = true;

            this.colKH_Diem.DataPropertyName = "DiemTichLuy";
            this.colKH_Diem.FillWeight = 15F;
            this.colKH_Diem.HeaderText = "Điểm Tích Lũy";
            this.colKH_Diem.Name = "colKH_Diem";
            this.colKH_Diem.ReadOnly = true;

            // --- TAB NHAN VIEN ---
            this.tabNhanVien.Controls.Add(this.dgvNhanVien);
            this.tabNhanVien.Controls.Add(this.panelNV_Top);
            this.tabNhanVien.Location = new System.Drawing.Point(4, 26);
            this.tabNhanVien.Name = "tabNhanVien";
            this.tabNhanVien.Padding = new System.Windows.Forms.Padding(6);
            this.tabNhanVien.Size = new System.Drawing.Size(1156, 543);
            this.tabNhanVien.TabIndex = 2;
            this.tabNhanVien.Text = "Nhân Viên";
            this.tabNhanVien.UseVisualStyleBackColor = true;

            this.panelNV_Top.Controls.Add(this.grpNV_Input);
            this.panelNV_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNV_Top.Location = new System.Drawing.Point(6, 6);
            this.panelNV_Top.Name = "panelNV_Top";
            this.panelNV_Top.Size = new System.Drawing.Size(1144, 120);
            this.panelNV_Top.TabIndex = 0;

            this.grpNV_Input.Controls.Add(this.lblNV_Ma);
            this.grpNV_Input.Controls.Add(this.txtNV_Ma);
            this.grpNV_Input.Controls.Add(this.lblNV_Ten);
            this.grpNV_Input.Controls.Add(this.txtNV_Ten);
            this.grpNV_Input.Controls.Add(this.lblNV_SDT);
            this.grpNV_Input.Controls.Add(this.txtNV_SDT);
            this.grpNV_Input.Controls.Add(this.lblNV_ChucVu);
            this.grpNV_Input.Controls.Add(this.cboNV_ChucVu);
            this.grpNV_Input.Controls.Add(this.btnNV_Them);
            this.grpNV_Input.Controls.Add(this.btnNV_Sua);
            this.grpNV_Input.Controls.Add(this.btnNV_Xoa);
            this.grpNV_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNV_Input.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpNV_Input.Location = new System.Drawing.Point(0, 0);
            this.grpNV_Input.Name = "grpNV_Input";
            this.grpNV_Input.Size = new System.Drawing.Size(1144, 120);
            this.grpNV_Input.TabIndex = 0;
            this.grpNV_Input.TabStop = false;
            this.grpNV_Input.Text = "Thông tin Nhân Viên:";

            this.lblNV_Ma.AutoSize = true;
            this.lblNV_Ma.Location = new System.Drawing.Point(15, 25);
            this.lblNV_Ma.Name = "lblNV_Ma";
            this.lblNV_Ma.Size = new System.Drawing.Size(53, 17);
            this.lblNV_Ma.TabIndex = 0;
            this.lblNV_Ma.Text = "Mã NV:";

            this.txtNV_Ma.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNV_Ma.Location = new System.Drawing.Point(75, 22);
            this.txtNV_Ma.Name = "txtNV_Ma";
            this.txtNV_Ma.ReadOnly = true;
            this.txtNV_Ma.Size = new System.Drawing.Size(80, 24);
            this.txtNV_Ma.TabIndex = 1;

            this.lblNV_Ten.AutoSize = true;
            this.lblNV_Ten.Location = new System.Drawing.Point(175, 25);
            this.lblNV_Ten.Name = "lblNV_Ten";
            this.lblNV_Ten.Size = new System.Drawing.Size(56, 17);
            this.lblNV_Ten.TabIndex = 2;
            this.lblNV_Ten.Text = "Tên NV:";

            this.txtNV_Ten.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNV_Ten.Location = new System.Drawing.Point(240, 22);
            this.txtNV_Ten.Name = "txtNV_Ten";
            this.txtNV_Ten.Size = new System.Drawing.Size(260, 24);
            this.txtNV_Ten.TabIndex = 3;

            this.lblNV_SDT.AutoSize = true;
            this.lblNV_SDT.Location = new System.Drawing.Point(520, 25);
            this.lblNV_SDT.Name = "lblNV_SDT";
            this.lblNV_SDT.Size = new System.Drawing.Size(75, 17);
            this.lblNV_SDT.TabIndex = 4;
            this.lblNV_SDT.Text = "Điện thoại:";

            this.txtNV_SDT.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNV_SDT.Location = new System.Drawing.Point(605, 22);
            this.txtNV_SDT.Name = "txtNV_SDT";
            this.txtNV_SDT.Size = new System.Drawing.Size(160, 24);
            this.txtNV_SDT.TabIndex = 5;

            this.lblNV_ChucVu.AutoSize = true;
            this.lblNV_ChucVu.Location = new System.Drawing.Point(785, 25);
            this.lblNV_ChucVu.Name = "lblNV_ChucVu";
            this.lblNV_ChucVu.Size = new System.Drawing.Size(62, 17);
            this.lblNV_ChucVu.TabIndex = 6;
            this.lblNV_ChucVu.Text = "Chức vụ:";

            this.cboNV_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV_ChucVu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNV_ChucVu.FormattingEnabled = true;
            this.cboNV_ChucVu.Items.AddRange(new object[] { "Thu ngân", "Quản lý", "Bán hàng", "Kho vận" });
            this.cboNV_ChucVu.Location = new System.Drawing.Point(855, 22);
            this.cboNV_ChucVu.Name = "cboNV_ChucVu";
            this.cboNV_ChucVu.Size = new System.Drawing.Size(160, 25);
            this.cboNV_ChucVu.TabIndex = 7;

            this.btnNV_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnNV_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNV_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV_Them.ForeColor = System.Drawing.Color.White;
            this.btnNV_Them.Location = new System.Drawing.Point(75, 65);
            this.btnNV_Them.Name = "btnNV_Them";
            this.btnNV_Them.Size = new System.Drawing.Size(110, 35);
            this.btnNV_Them.TabIndex = 8;
            this.btnNV_Them.Text = "Thêm NV";
            this.btnNV_Them.UseVisualStyleBackColor = false;

            this.btnNV_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnNV_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNV_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV_Sua.ForeColor = System.Drawing.Color.White;
            this.btnNV_Sua.Location = new System.Drawing.Point(200, 65);
            this.btnNV_Sua.Name = "btnNV_Sua";
            this.btnNV_Sua.Size = new System.Drawing.Size(110, 35);
            this.btnNV_Sua.TabIndex = 9;
            this.btnNV_Sua.Text = "Sửa NV";
            this.btnNV_Sua.UseVisualStyleBackColor = false;

            this.btnNV_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnNV_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNV_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNV_Xoa.ForeColor = System.Drawing.Color.White;
            this.btnNV_Xoa.Location = new System.Drawing.Point(325, 65);
            this.btnNV_Xoa.Name = "btnNV_Xoa";
            this.btnNV_Xoa.Size = new System.Drawing.Size(110, 35);
            this.btnNV_Xoa.TabIndex = 10;
            this.btnNV_Xoa.Text = "Xóa NV";
            this.btnNV_Xoa.UseVisualStyleBackColor = false;

            // dgvNhanVien
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNV_Ma,
            this.colNV_Ten,
            this.colNV_SDT,
            this.colNV_ChucVu});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 126);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1144, 411);
            this.dgvNhanVien.TabIndex = 1;

            this.colNV_Ma.DataPropertyName = "MaNV";
            this.colNV_Ma.FillWeight = 15F;
            this.colNV_Ma.HeaderText = "Mã NV";
            this.colNV_Ma.Name = "colNV_Ma";
            this.colNV_Ma.ReadOnly = true;

            this.colNV_Ten.DataPropertyName = "TenNV";
            this.colNV_Ten.FillWeight = 40F;
            this.colNV_Ten.HeaderText = "Họ Tên Nhân Viên";
            this.colNV_Ten.Name = "colNV_Ten";
            this.colNV_Ten.ReadOnly = true;

            this.colNV_SDT.DataPropertyName = "SoDienThoai";
            this.colNV_SDT.FillWeight = 25F;
            this.colNV_SDT.HeaderText = "Số Điện Thoại";
            this.colNV_SDT.Name = "colNV_SDT";
            this.colNV_SDT.ReadOnly = true;

            this.colNV_ChucVu.DataPropertyName = "ChucVu";
            this.colNV_ChucVu.FillWeight = 20F;
            this.colNV_ChucVu.HeaderText = "Chức Vụ";
            this.colNV_ChucVu.Name = "colNV_ChucVu";
            this.colNV_ChucVu.ReadOnly = true;

            // ==========================================
            // TAB 3: BAO CAO - THONG KE
            // ==========================================
            this.tabBaoCao.Controls.Add(this.grpLichSuHD);
            this.tabBaoCao.Controls.Add(this.panelBC_Cards);
            this.tabBaoCao.Location = new System.Drawing.Point(4, 26);
            this.tabBaoCao.Name = "tabBaoCao";
            this.tabBaoCao.Padding = new System.Windows.Forms.Padding(8);
            this.tabBaoCao.Size = new System.Drawing.Size(1176, 585);
            this.tabBaoCao.TabIndex = 2;
            this.tabBaoCao.Text = "📊 Báo Cáo - Thống Kê (ExecuteScalar & SqlDataReader)";
            this.tabBaoCao.UseVisualStyleBackColor = true;

            this.panelBC_Cards.Controls.Add(this.btnLamMoiBaoCao);
            this.panelBC_Cards.Controls.Add(this.pnlCardTopSP);
            this.panelBC_Cards.Controls.Add(this.pnlCardDoanhThuThang);
            this.panelBC_Cards.Controls.Add(this.pnlCardDoanhThuNgay);
            this.panelBC_Cards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBC_Cards.Location = new System.Drawing.Point(8, 8);
            this.panelBC_Cards.Name = "panelBC_Cards";
            this.panelBC_Cards.Size = new System.Drawing.Size(1160, 260);
            this.panelBC_Cards.TabIndex = 0;

            // Card Doanh Thu Ngay (ExecuteScalar)
            this.pnlCardDoanhThuNgay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.pnlCardDoanhThuNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardDoanhThuNgay.Controls.Add(this.lblBC_TitleNgay);
            this.pnlCardDoanhThuNgay.Controls.Add(this.lblBC_ValDoanhThuNgay);
            this.pnlCardDoanhThuNgay.Controls.Add(this.lblBC_SubNgay);
            this.pnlCardDoanhThuNgay.Location = new System.Drawing.Point(10, 10);
            this.pnlCardDoanhThuNgay.Name = "pnlCardDoanhThuNgay";
            this.pnlCardDoanhThuNgay.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardDoanhThuNgay.Size = new System.Drawing.Size(260, 110);
            this.pnlCardDoanhThuNgay.TabIndex = 0;

            this.lblBC_TitleNgay.AutoSize = true;
            this.lblBC_TitleNgay.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBC_TitleNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.lblBC_TitleNgay.Location = new System.Drawing.Point(12, 12);
            this.lblBC_TitleNgay.Name = "lblBC_TitleNgay";
            this.lblBC_TitleNgay.Size = new System.Drawing.Size(200, 17);
            this.lblBC_TitleNgay.TabIndex = 0;
            this.lblBC_TitleNgay.Text = "DOANH THU HÔM NAY (Scalar):";

            this.lblBC_ValDoanhThuNgay.AutoSize = true;
            this.lblBC_ValDoanhThuNgay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBC_ValDoanhThuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblBC_ValDoanhThuNgay.Location = new System.Drawing.Point(12, 38);
            this.lblBC_ValDoanhThuNgay.Name = "lblBC_ValDoanhThuNgay";
            this.lblBC_ValDoanhThuNgay.Size = new System.Drawing.Size(60, 30);
            this.lblBC_ValDoanhThuNgay.TabIndex = 1;
            this.lblBC_ValDoanhThuNgay.Text = "0 đ";

            this.lblBC_SubNgay.AutoSize = true;
            this.lblBC_SubNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBC_SubNgay.ForeColor = System.Drawing.Color.Gray;
            this.lblBC_SubNgay.Location = new System.Drawing.Point(14, 75);
            this.lblBC_SubNgay.Name = "lblBC_SubNgay";
            this.lblBC_SubNgay.Size = new System.Drawing.Size(117, 15);
            this.lblBC_SubNgay.TabIndex = 2;
            this.lblBC_SubNgay.Text = "Số hóa đơn: 0";

            // Card Doanh Thu Thang (ExecuteScalar)
            this.pnlCardDoanhThuThang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.pnlCardDoanhThuThang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCardDoanhThuThang.Controls.Add(this.lblBC_TitleThang);
            this.pnlCardDoanhThuThang.Controls.Add(this.lblBC_ValDoanhThuThang);
            this.pnlCardDoanhThuThang.Controls.Add(this.lblBC_SubThang);
            this.pnlCardDoanhThuThang.Location = new System.Drawing.Point(10, 130);
            this.pnlCardDoanhThuThang.Name = "pnlCardDoanhThuThang";
            this.pnlCardDoanhThuThang.Padding = new System.Windows.Forms.Padding(12);
            this.pnlCardDoanhThuThang.Size = new System.Drawing.Size(260, 115);
            this.pnlCardDoanhThuThang.TabIndex = 1;

            this.lblBC_TitleThang.AutoSize = true;
            this.lblBC_TitleThang.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBC_TitleThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.lblBC_TitleThang.Location = new System.Drawing.Point(12, 12);
            this.lblBC_TitleThang.Name = "lblBC_TitleThang";
            this.lblBC_TitleThang.Size = new System.Drawing.Size(211, 17);
            this.lblBC_TitleThang.TabIndex = 0;
            this.lblBC_TitleThang.Text = "DOANH THU THÁNG NÀY (Scalar):";

            this.lblBC_ValDoanhThuThang.AutoSize = true;
            this.lblBC_ValDoanhThuThang.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBC_ValDoanhThuThang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.lblBC_ValDoanhThuThang.Location = new System.Drawing.Point(12, 38);
            this.lblBC_ValDoanhThuThang.Name = "lblBC_ValDoanhThuThang";
            this.lblBC_ValDoanhThuThang.Size = new System.Drawing.Size(60, 30);
            this.lblBC_ValDoanhThuThang.TabIndex = 1;
            this.lblBC_ValDoanhThuThang.Text = "0 đ";

            this.lblBC_SubThang.AutoSize = true;
            this.lblBC_SubThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBC_SubThang.ForeColor = System.Drawing.Color.Gray;
            this.lblBC_SubThang.Location = new System.Drawing.Point(14, 75);
            this.lblBC_SubThang.Name = "lblBC_SubThang";
            this.lblBC_SubThang.Size = new System.Drawing.Size(117, 15);
            this.lblBC_SubThang.TabIndex = 2;
            this.lblBC_SubThang.Text = "Số hóa đơn: 0";

            // Card Top 5 SP (SqlDataReader)
            this.pnlCardTopSP.Controls.Add(this.dgvTopSanPham);
            this.pnlCardTopSP.Controls.Add(this.lblBC_TopTitle);
            this.pnlCardTopSP.Location = new System.Drawing.Point(290, 10);
            this.pnlCardTopSP.Name = "pnlCardTopSP";
            this.pnlCardTopSP.Size = new System.Drawing.Size(720, 235);
            this.pnlCardTopSP.TabIndex = 2;

            this.lblBC_TopTitle.AutoSize = true;
            this.lblBC_TopTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBC_TopTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(20)))));
            this.lblBC_TopTitle.Location = new System.Drawing.Point(3, 5);
            this.lblBC_TopTitle.Name = "lblBC_TopTitle";
            this.lblBC_TopTitle.Size = new System.Drawing.Size(430, 19);
            this.lblBC_TopTitle.TabIndex = 0;
            this.lblBC_TopTitle.Text = "🏆 TOP 5 SẢN PHẨM BÁN CHẠY NHẤT (Truy vấn SqlDataReader):";

            this.dgvTopSanPham.AllowUserToAddRows = false;
            this.dgvTopSanPham.AllowUserToDeleteRows = false;
            this.dgvTopSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvTopSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTop_Ma,
            this.colTop_Ten,
            this.colTop_SoLuong,
            this.colTop_DoanhThu});
            this.dgvTopSanPham.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTopSanPham.Location = new System.Drawing.Point(0, 30);
            this.dgvTopSanPham.MultiSelect = false;
            this.dgvTopSanPham.Name = "dgvTopSanPham";
            this.dgvTopSanPham.ReadOnly = true;
            this.dgvTopSanPham.RowHeadersVisible = false;
            this.dgvTopSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTopSanPham.Size = new System.Drawing.Size(720, 205);
            this.dgvTopSanPham.TabIndex = 1;

            this.colTop_Ma.DataPropertyName = "MaSP";
            this.colTop_Ma.FillWeight = 20F;
            this.colTop_Ma.HeaderText = "Mã SP";
            this.colTop_Ma.Name = "colTop_Ma";
            this.colTop_Ma.ReadOnly = true;

            this.colTop_Ten.DataPropertyName = "TenSP";
            this.colTop_Ten.FillWeight = 45F;
            this.colTop_Ten.HeaderText = "Tên Sản Phẩm";
            this.colTop_Ten.Name = "colTop_Ten";
            this.colTop_Ten.ReadOnly = true;

            this.colTop_SoLuong.DataPropertyName = "TongSoLuongBan";
            this.colTop_SoLuong.FillWeight = 20F;
            this.colTop_SoLuong.HeaderText = "Đã Bán";
            this.colTop_SoLuong.Name = "colTop_SoLuong";
            this.colTop_SoLuong.ReadOnly = true;

            this.colTop_DoanhThu.DataPropertyName = "TongDoanhThu";
            this.colTop_DoanhThu.FillWeight = 25F;
            this.colTop_DoanhThu.HeaderText = "Doanh Thu (đ)";
            this.colTop_DoanhThu.Name = "colTop_DoanhThu";
            this.colTop_DoanhThu.ReadOnly = true;

            this.btnLamMoiBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnLamMoiBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLamMoiBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLamMoiBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnLamMoiBaoCao.Location = new System.Drawing.Point(1025, 40);
            this.btnLamMoiBaoCao.Name = "btnLamMoiBaoCao";
            this.btnLamMoiBaoCao.Size = new System.Drawing.Size(125, 45);
            this.btnLamMoiBaoCao.TabIndex = 3;
            this.btnLamMoiBaoCao.Text = "🔄 Làm Mới";
            this.btnLamMoiBaoCao.UseVisualStyleBackColor = false;

            // grpLichSuHD
            this.grpLichSuHD.Controls.Add(this.dgvHoaDon);
            this.grpLichSuHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLichSuHD.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpLichSuHD.Location = new System.Drawing.Point(8, 268);
            this.grpLichSuHD.Name = "grpLichSuHD";
            this.grpLichSuHD.Padding = new System.Windows.Forms.Padding(6);
            this.grpLichSuHD.Size = new System.Drawing.Size(1160, 309);
            this.grpLichSuHD.TabIndex = 1;
            this.grpLichSuHD.TabStop = false;
            this.grpLichSuHD.Text = "Lịch sử các hóa đơn bán hàng đã lập:";

            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colHD_Ma,
            this.colHD_NgayLap,
            this.colHD_TenNV,
            this.colHD_TenKH,
            this.colHD_TongTien});
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(6, 23);
            this.dgvHoaDon.MultiSelect = false;
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1148, 280);
            this.dgvHoaDon.TabIndex = 0;

            this.colHD_Ma.DataPropertyName = "MaHD";
            this.colHD_Ma.FillWeight = 15F;
            this.colHD_Ma.HeaderText = "Mã HĐ";
            this.colHD_Ma.Name = "colHD_Ma";
            this.colHD_Ma.ReadOnly = true;

            this.colHD_NgayLap.DataPropertyName = "NgayLap";
            this.colHD_NgayLap.FillWeight = 25F;
            this.colHD_NgayLap.HeaderText = "Ngày Lập";
            this.colHD_NgayLap.Name = "colHD_NgayLap";
            this.colHD_NgayLap.ReadOnly = true;

            this.colHD_TenNV.DataPropertyName = "TenNV";
            this.colHD_TenNV.FillWeight = 25F;
            this.colHD_TenNV.HeaderText = "Nhân Viên Lập";
            this.colHD_TenNV.Name = "colHD_TenNV";
            this.colHD_TenNV.ReadOnly = true;

            this.colHD_TenKH.DataPropertyName = "TenKH";
            this.colHD_TenKH.FillWeight = 25F;
            this.colHD_TenKH.HeaderText = "Khách Hàng";
            this.colHD_TenKH.Name = "colHD_TenKH";
            this.colHD_TenKH.ReadOnly = true;

            this.colHD_TongTien.DataPropertyName = "TongTien";
            this.colHD_TongTien.FillWeight = 20F;
            this.colHD_TongTien.HeaderText = "Tổng Tiền (đ)";
            this.colHD_TongTien.Name = "colHD_TongTien";
            this.colHD_TongTien.ReadOnly = true;

            // statusStrip
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusMsg,
            this.lblStatusConnection});
            this.statusStrip.Location = new System.Drawing.Point(0, 690);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip.TabIndex = 2;

            this.lblStatusMsg.Name = "lblStatusMsg";
            this.lblStatusMsg.Size = new System.Drawing.Size(100, 17);
            this.lblStatusMsg.Text = "Hệ thống sẵn sàng";

            this.lblStatusConnection.Name = "lblStatusConnection";
            this.lblStatusConnection.Size = new System.Drawing.Size(1069, 17);
            this.lblStatusConnection.Spring = true;
            this.lblStatusConnection.Text = "CSDL: SalesDB (Microsoft SQL Server / LocalDB)";
            this.lblStatusConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.errorProvider.ContainerControl = this;

            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 712);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1100, 650);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Bán hàng & Siêu thị Mini (Retail Sales System) - Nguyễn Hải Nam (24810310617)";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabBanHang.ResumeLayout(false);
            this.panelBanHangLeft.ResumeLayout(false);
            this.grpGioHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.panelChonSP.ResumeLayout(false);
            this.panelChonSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongMua)).EndInit();
            this.panelBanHangRight.ResumeLayout(false);
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.tabDanhMuc.ResumeLayout(false);
            this.tabControlDanhMuc.ResumeLayout(false);
            this.tabSanPham.ResumeLayout(false);
            this.panelSP_Top.ResumeLayout(false);
            this.grpSP_Input.ResumeLayout(false);
            this.grpSP_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSP_Gia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSP_Ton)).EndInit();
            this.panelSP_Search.ResumeLayout(false);
            this.panelSP_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.tabKhachHang.ResumeLayout(false);
            this.panelKH_Top.ResumeLayout(false);
            this.grpKH_Input.ResumeLayout(false);
            this.grpKH_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudKH_Diem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.tabNhanVien.ResumeLayout(false);
            this.panelNV_Top.ResumeLayout(false);
            this.grpNV_Input.ResumeLayout(false);
            this.grpNV_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabBaoCao.ResumeLayout(false);
            this.panelBC_Cards.ResumeLayout(false);
            this.pnlCardDoanhThuNgay.ResumeLayout(false);
            this.pnlCardDoanhThuNgay.PerformLayout();
            this.pnlCardDoanhThuThang.ResumeLayout(false);
            this.pnlCardDoanhThuThang.PerformLayout();
            this.pnlCardTopSP.ResumeLayout(false);
            this.pnlCardTopSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopSanPham)).EndInit();
            this.grpLichSuHD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Component declarations
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.TabControl tabControlMain;
        
        // Tab Ban Hang
        private System.Windows.Forms.TabPage tabBanHang;
        private System.Windows.Forms.Panel panelBanHangLeft;
        private System.Windows.Forms.GroupBox grpGioHang;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGH_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGH_TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGH_DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGH_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGH_ThanhTien;
        private System.Windows.Forms.Panel panelChonSP;
        private System.Windows.Forms.Label lblChonSP;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label lblSoLuongMua;
        private System.Windows.Forms.NumericUpDown nudSoLuongMua;
        private System.Windows.Forms.Button btnThemVaoGio;
        private System.Windows.Forms.Button btnXoaKhoiGio;
        private System.Windows.Forms.Button btnXoaToanBoGio;
        
        private System.Windows.Forms.Panel panelBanHangRight;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.Label lblThuNgan;
        private System.Windows.Forms.ComboBox cboThuNgan;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblDiemHienCo;
        private System.Windows.Forms.TextBox txtDiemHienCo;
        private System.Windows.Forms.Label lblDiemTichLuyMoi;
        private System.Windows.Forms.TextBox txtDiemTichLuyMoi;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTestRollback;
        private System.Windows.Forms.TextBox txtLogGiaoDich;

        // Tab Danh Muc
        private System.Windows.Forms.TabPage tabDanhMuc;
        private System.Windows.Forms.TabControl tabControlDanhMuc;
        private System.Windows.Forms.TabPage tabSanPham;
        private System.Windows.Forms.Panel panelSP_Top;
        private System.Windows.Forms.GroupBox grpSP_Input;
        private System.Windows.Forms.Label lblSP_Ma;
        private System.Windows.Forms.TextBox txtSP_Ma;
        private System.Windows.Forms.Label lblSP_Ten;
        private System.Windows.Forms.TextBox txtSP_Ten;
        private System.Windows.Forms.Label lblSP_Gia;
        private System.Windows.Forms.NumericUpDown nudSP_Gia;
        private System.Windows.Forms.Label lblSP_Ton;
        private System.Windows.Forms.NumericUpDown nudSP_Ton;
        private System.Windows.Forms.Button btnSP_Them;
        private System.Windows.Forms.Button btnSP_Sua;
        private System.Windows.Forms.Button btnSP_Xoa;
        private System.Windows.Forms.Button btnSP_LamMoi;
        private System.Windows.Forms.Panel panelSP_Search;
        private System.Windows.Forms.Label lblSP_Search;
        private System.Windows.Forms.TextBox txtSP_Search;
        private System.Windows.Forms.Button btnSP_Search;
        private System.Windows.Forms.Button btnSP_ResetSearch;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP_Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSP_Ton;

        // Tab Khach Hang
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.Panel panelKH_Top;
        private System.Windows.Forms.GroupBox grpKH_Input;
        private System.Windows.Forms.Label lblKH_Ma;
        private System.Windows.Forms.TextBox txtKH_Ma;
        private System.Windows.Forms.Label lblKH_Ten;
        private System.Windows.Forms.TextBox txtKH_Ten;
        private System.Windows.Forms.Label lblKH_SDT;
        private System.Windows.Forms.TextBox txtKH_SDT;
        private System.Windows.Forms.Label lblKH_Diem;
        private System.Windows.Forms.NumericUpDown nudKH_Diem;
        private System.Windows.Forms.Button btnKH_Them;
        private System.Windows.Forms.Button btnKH_Sua;
        private System.Windows.Forms.Button btnKH_Xoa;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKH_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKH_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKH_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKH_Diem;

        // Tab Nhan Vien
        private System.Windows.Forms.TabPage tabNhanVien;
        private System.Windows.Forms.Panel panelNV_Top;
        private System.Windows.Forms.GroupBox grpNV_Input;
        private System.Windows.Forms.Label lblNV_Ma;
        private System.Windows.Forms.TextBox txtNV_Ma;
        private System.Windows.Forms.Label lblNV_Ten;
        private System.Windows.Forms.TextBox txtNV_Ten;
        private System.Windows.Forms.Label lblNV_SDT;
        private System.Windows.Forms.TextBox txtNV_SDT;
        private System.Windows.Forms.Label lblNV_ChucVu;
        private System.Windows.Forms.ComboBox cboNV_ChucVu;
        private System.Windows.Forms.Button btnNV_Them;
        private System.Windows.Forms.Button btnNV_Sua;
        private System.Windows.Forms.Button btnNV_Xoa;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNV_ChucVu;

        // Tab Bao Cao
        private System.Windows.Forms.TabPage tabBaoCao;
        private System.Windows.Forms.Panel panelBC_Cards;
        private System.Windows.Forms.Panel pnlCardDoanhThuNgay;
        private System.Windows.Forms.Label lblBC_TitleNgay;
        private System.Windows.Forms.Label lblBC_ValDoanhThuNgay;
        private System.Windows.Forms.Label lblBC_SubNgay;
        private System.Windows.Forms.Panel pnlCardDoanhThuThang;
        private System.Windows.Forms.Label lblBC_TitleThang;
        private System.Windows.Forms.Label lblBC_ValDoanhThuThang;
        private System.Windows.Forms.Label lblBC_SubThang;
        private System.Windows.Forms.Panel pnlCardTopSP;
        private System.Windows.Forms.Label lblBC_TopTitle;
        private System.Windows.Forms.DataGridView dgvTopSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTop_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTop_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTop_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTop_DoanhThu;
        private System.Windows.Forms.Button btnLamMoiBaoCao;
        private System.Windows.Forms.GroupBox grpLichSuHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_NgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHD_TongTien;

        // Status & Error
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMsg;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusConnection;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
