namespace bai6_2.GUI
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

            // Tab 1: Ho So Nhan Su
            this.tabNhanSu = new System.Windows.Forms.TabPage();
            this.panelNS_Top = new System.Windows.Forms.Panel();
            this.grpNS_Input = new System.Windows.Forms.GroupBox();
            this.lblNS_MaNV = new System.Windows.Forms.Label();
            this.txtNS_MaNV = new System.Windows.Forms.TextBox();
            this.lblNS_HoTen = new System.Windows.Forms.Label();
            this.txtNS_HoTen = new System.Windows.Forms.TextBox();
            this.lblNS_NgaySinh = new System.Windows.Forms.Label();
            this.dtpNS_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblNS_CCCD = new System.Windows.Forms.Label();
            this.txtNS_CCCD = new System.Windows.Forms.TextBox();
            this.lblNS_PhongBan = new System.Windows.Forms.Label();
            this.cboNS_PhongBan = new System.Windows.Forms.ComboBox();
            this.lblNS_LuongCB = new System.Windows.Forms.Label();
            this.nudNS_LuongCB = new System.Windows.Forms.NumericUpDown();
            this.lblNS_HeSo = new System.Windows.Forms.Label();
            this.nudNS_HeSo = new System.Windows.Forms.NumericUpDown();
            this.btnNS_Them = new System.Windows.Forms.Button();
            this.btnNS_Sua = new System.Windows.Forms.Button();
            this.btnNS_Xoa = new System.Windows.Forms.Button();
            this.btnNS_LamMoi = new System.Windows.Forms.Button();
            this.panelNS_Search = new System.Windows.Forms.Panel();
            this.lblNS_Search = new System.Windows.Forms.Label();
            this.txtNS_Search = new System.Windows.Forms.TextBox();
            this.lblNS_FilterPB = new System.Windows.Forms.Label();
            this.cboNS_FilterPB = new System.Windows.Forms.ComboBox();
            this.btnNS_Search = new System.Windows.Forms.Button();
            this.btnNS_ResetSearch = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.colNS_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS_NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS_CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS_TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS_LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNS_HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // Tab 2: Cham Cong Ngat Ket Noi (Disconnected Model)
            this.tabChamCong = new System.Windows.Forms.TabPage();
            this.panelCC_Top = new System.Windows.Forms.Panel();
            this.lblCC_ThangNam = new System.Windows.Forms.Label();
            this.cboCC_ThangNam = new System.Windows.Forms.ComboBox();
            this.btnCC_Nap = new System.Windows.Forms.Button();
            this.btnCC_Luu = new System.Windows.Forms.Button();
            this.lblCC_HuongDan = new System.Windows.Forms.Label();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.panelCC_Bottom = new System.Windows.Forms.Panel();
            this.lblCC_Stats = new System.Windows.Forms.Label();

            // Tab 3: Tinh Luong & Chot Luong
            this.tabTinhLuong = new System.Windows.Forms.TabPage();
            this.panelTL_Top = new System.Windows.Forms.Panel();
            this.lblTL_ThangNam = new System.Windows.Forms.Label();
            this.cboTL_ThangNam = new System.Windows.Forms.ComboBox();
            this.btnTL_TinhDuKien = new System.Windows.Forms.Button();
            this.btnTL_ChotLuong = new System.Windows.Forms.Button();
            this.lblTL_CongThuc = new System.Windows.Forms.Label();
            this.panelTL_Cards = new System.Windows.Forms.Panel();
            this.pnlTL_CardTongLuong = new System.Windows.Forms.Panel();
            this.lblTL_CardTitle = new System.Windows.Forms.Label();
            this.lblTL_TongTienLuong = new System.Windows.Forms.Label();
            this.lblTL_SoNhanVien = new System.Windows.Forms.Label();
            this.txtTL_LogTrans = new System.Windows.Forms.TextBox();
            this.dgvBangLuong = new System.Windows.Forms.DataGridView();
            this.colTL_MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_LuongCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_NgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_GioOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTL_ThucLinh = new System.Windows.Forms.DataGridViewTextBoxColumn();

            // StatusStrip
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusConnection = new System.Windows.Forms.ToolStripStatusLabel();

            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);

            this.panelHeader.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabNhanSu.SuspendLayout();
            this.panelNS_Top.SuspendLayout();
            this.grpNS_Input.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_LuongCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_HeSo)).BeginInit();
            this.panelNS_Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.tabChamCong.SuspendLayout();
            this.panelCC_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.panelCC_Bottom.SuspendLayout();
            this.tabTinhLuong.SuspendLayout();
            this.panelTL_Top.SuspendLayout();
            this.panelTL_Cards.SuspendLayout();
            this.pnlTL_CardTongLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).BeginInit();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(80)))), ((int)(((byte)(140)))));
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
            this.lblHeaderTitle.Size = new System.Drawing.Size(760, 30);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ & TÍNH LƯƠNG (HRM & PAYROLL SYSTEM)";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(22, 45);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(820, 17);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Mô hình Ngắt Kết Nối (Disconnected Model: DataSet/SqlDataAdapter/SqlCommandBuilder) | SqlTransaction Chốt Lương | Nguyễn Hải Nam (24810310617)";

            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabNhanSu);
            this.tabControlMain.Controls.Add(this.tabChamCong);
            this.tabControlMain.Controls.Add(this.tabTinhLuong);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tabControlMain.Location = new System.Drawing.Point(0, 75);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1184, 615);
            this.tabControlMain.TabIndex = 1;

            // ==========================================
            // TAB 1: HO SO NHAN SU (CRUD 3-TIER)
            // ==========================================
            this.tabNhanSu.Controls.Add(this.dgvNhanVien);
            this.tabNhanSu.Controls.Add(this.panelNS_Search);
            this.tabNhanSu.Controls.Add(this.panelNS_Top);
            this.tabNhanSu.Location = new System.Drawing.Point(4, 26);
            this.tabNhanSu.Name = "tabNhanSu";
            this.tabNhanSu.Padding = new System.Windows.Forms.Padding(6);
            this.tabNhanSu.Size = new System.Drawing.Size(1176, 585);
            this.tabNhanSu.TabIndex = 0;
            this.tabNhanSu.Text = "👤 Quản Lý Hồ Sơ Nhân Sự (CRUD 3-Tier)";
            this.tabNhanSu.UseVisualStyleBackColor = true;

            this.panelNS_Top.Controls.Add(this.grpNS_Input);
            this.panelNS_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNS_Top.Location = new System.Drawing.Point(6, 6);
            this.panelNS_Top.Name = "panelNS_Top";
            this.panelNS_Top.Size = new System.Drawing.Size(1164, 155);
            this.panelNS_Top.TabIndex = 0;

            this.grpNS_Input.Controls.Add(this.lblNS_MaNV);
            this.grpNS_Input.Controls.Add(this.txtNS_MaNV);
            this.grpNS_Input.Controls.Add(this.lblNS_HoTen);
            this.grpNS_Input.Controls.Add(this.txtNS_HoTen);
            this.grpNS_Input.Controls.Add(this.lblNS_NgaySinh);
            this.grpNS_Input.Controls.Add(this.dtpNS_NgaySinh);
            this.grpNS_Input.Controls.Add(this.lblNS_CCCD);
            this.grpNS_Input.Controls.Add(this.txtNS_CCCD);
            this.grpNS_Input.Controls.Add(this.lblNS_PhongBan);
            this.grpNS_Input.Controls.Add(this.cboNS_PhongBan);
            this.grpNS_Input.Controls.Add(this.lblNS_LuongCB);
            this.grpNS_Input.Controls.Add(this.nudNS_LuongCB);
            this.grpNS_Input.Controls.Add(this.lblNS_HeSo);
            this.grpNS_Input.Controls.Add(this.nudNS_HeSo);
            this.grpNS_Input.Controls.Add(this.btnNS_Them);
            this.grpNS_Input.Controls.Add(this.btnNS_Sua);
            this.grpNS_Input.Controls.Add(this.btnNS_Xoa);
            this.grpNS_Input.Controls.Add(this.btnNS_LamMoi);
            this.grpNS_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNS_Input.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpNS_Input.Location = new System.Drawing.Point(0, 0);
            this.grpNS_Input.Name = "grpNS_Input";
            this.grpNS_Input.Size = new System.Drawing.Size(1164, 155);
            this.grpNS_Input.TabIndex = 0;
            this.grpNS_Input.TabStop = false;
            this.grpNS_Input.Text = "Thông tin Hồ sơ Nhân Viên:";

            this.lblNS_MaNV.AutoSize = true;
            this.lblNS_MaNV.Location = new System.Drawing.Point(15, 28);
            this.lblNS_MaNV.Name = "lblNS_MaNV";
            this.lblNS_MaNV.Size = new System.Drawing.Size(53, 17);
            this.lblNS_MaNV.TabIndex = 0;
            this.lblNS_MaNV.Text = "Mã NV:";

            this.txtNS_MaNV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNS_MaNV.Location = new System.Drawing.Point(75, 25);
            this.txtNS_MaNV.Name = "txtNS_MaNV";
            this.txtNS_MaNV.ReadOnly = true;
            this.txtNS_MaNV.Size = new System.Drawing.Size(65, 24);
            this.txtNS_MaNV.TabIndex = 1;

            this.lblNS_HoTen.AutoSize = true;
            this.lblNS_HoTen.Location = new System.Drawing.Point(155, 28);
            this.lblNS_HoTen.Name = "lblNS_HoTen";
            this.lblNS_HoTen.Size = new System.Drawing.Size(54, 17);
            this.lblNS_HoTen.TabIndex = 2;
            this.lblNS_HoTen.Text = "Họ Tên:";

            this.txtNS_HoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNS_HoTen.Location = new System.Drawing.Point(215, 25);
            this.txtNS_HoTen.Name = "txtNS_HoTen";
            this.txtNS_HoTen.Size = new System.Drawing.Size(210, 24);
            this.txtNS_HoTen.TabIndex = 3;

            this.lblNS_NgaySinh.AutoSize = true;
            this.lblNS_NgaySinh.Location = new System.Drawing.Point(440, 28);
            this.lblNS_NgaySinh.Name = "lblNS_NgaySinh";
            this.lblNS_NgaySinh.Size = new System.Drawing.Size(73, 17);
            this.lblNS_NgaySinh.TabIndex = 4;
            this.lblNS_NgaySinh.Text = "Ngày sinh:";

            this.dtpNS_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNS_NgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dtpNS_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNS_NgaySinh.Location = new System.Drawing.Point(520, 25);
            this.dtpNS_NgaySinh.Name = "dtpNS_NgaySinh";
            this.dtpNS_NgaySinh.Size = new System.Drawing.Size(120, 24);
            this.dtpNS_NgaySinh.TabIndex = 5;

            this.lblNS_CCCD.AutoSize = true;
            this.lblNS_CCCD.Location = new System.Drawing.Point(655, 28);
            this.lblNS_CCCD.Name = "lblNS_CCCD";
            this.lblNS_CCCD.Size = new System.Drawing.Size(65, 17);
            this.lblNS_CCCD.TabIndex = 6;
            this.lblNS_CCCD.Text = "Số CCCD:";

            this.txtNS_CCCD.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNS_CCCD.Location = new System.Drawing.Point(725, 25);
            this.txtNS_CCCD.MaxLength = 12;
            this.txtNS_CCCD.Name = "txtNS_CCCD";
            this.txtNS_CCCD.Size = new System.Drawing.Size(150, 24);
            this.txtNS_CCCD.TabIndex = 7;

            // Hàng 2: Phòng ban, Lương cơ bản, Hệ số lương
            this.lblNS_PhongBan.AutoSize = true;
            this.lblNS_PhongBan.Location = new System.Drawing.Point(15, 68);
            this.lblNS_PhongBan.Name = "lblNS_PhongBan";
            this.lblNS_PhongBan.Size = new System.Drawing.Size(78, 17);
            this.lblNS_PhongBan.TabIndex = 8;
            this.lblNS_PhongBan.Text = "Phòng ban:";

            this.cboNS_PhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNS_PhongBan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNS_PhongBan.FormattingEnabled = true;
            this.cboNS_PhongBan.Location = new System.Drawing.Point(100, 65);
            this.cboNS_PhongBan.Name = "cboNS_PhongBan";
            this.cboNS_PhongBan.Size = new System.Drawing.Size(250, 24);
            this.cboNS_PhongBan.TabIndex = 9;

            this.lblNS_LuongCB.AutoSize = true;
            this.lblNS_LuongCB.Location = new System.Drawing.Point(370, 68);
            this.lblNS_LuongCB.Name = "lblNS_LuongCB";
            this.lblNS_LuongCB.Size = new System.Drawing.Size(95, 17);
            this.lblNS_LuongCB.TabIndex = 10;
            this.lblNS_LuongCB.Text = "Lương cơ bản:";

            this.nudNS_LuongCB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudNS_LuongCB.Increment = new decimal(new int[] { 500000, 0, 0, 0 });
            this.nudNS_LuongCB.Location = new System.Drawing.Point(475, 65);
            this.nudNS_LuongCB.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            this.nudNS_LuongCB.Name = "nudNS_LuongCB";
            this.nudNS_LuongCB.Size = new System.Drawing.Size(140, 24);
            this.nudNS_LuongCB.TabIndex = 11;

            this.lblNS_HeSo.AutoSize = true;
            this.lblNS_HeSo.Location = new System.Drawing.Point(635, 68);
            this.lblNS_HeSo.Name = "lblNS_HeSo";
            this.lblNS_HeSo.Size = new System.Drawing.Size(86, 17);
            this.lblNS_HeSo.TabIndex = 12;
            this.lblNS_HeSo.Text = "Hệ số lương:";

            this.nudNS_HeSo.DecimalPlaces = 2;
            this.nudNS_HeSo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudNS_HeSo.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            this.nudNS_HeSo.Location = new System.Drawing.Point(725, 65);
            this.nudNS_HeSo.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            this.nudNS_HeSo.Name = "nudNS_HeSo";
            this.nudNS_HeSo.Size = new System.Drawing.Size(80, 24);
            this.nudNS_HeSo.TabIndex = 13;
            this.nudNS_HeSo.Value = new decimal(new int[] { 10, 0, 0, 65536 });

            // Buttons
            this.btnNS_Them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnNS_Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNS_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNS_Them.ForeColor = System.Drawing.Color.White;
            this.btnNS_Them.Location = new System.Drawing.Point(100, 105);
            this.btnNS_Them.Name = "btnNS_Them";
            this.btnNS_Them.Size = new System.Drawing.Size(120, 35);
            this.btnNS_Them.TabIndex = 14;
            this.btnNS_Them.Text = "Thêm NV";
            this.btnNS_Them.UseVisualStyleBackColor = false;

            this.btnNS_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnNS_Sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNS_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNS_Sua.ForeColor = System.Drawing.Color.White;
            this.btnNS_Sua.Location = new System.Drawing.Point(235, 105);
            this.btnNS_Sua.Name = "btnNS_Sua";
            this.btnNS_Sua.Size = new System.Drawing.Size(140, 35);
            this.btnNS_Sua.TabIndex = 15;
            this.btnNS_Sua.Text = "Sửa / Chuyển PB";
            this.btnNS_Sua.UseVisualStyleBackColor = false;

            this.btnNS_Xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.btnNS_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNS_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNS_Xoa.ForeColor = System.Drawing.Color.White;
            this.btnNS_Xoa.Location = new System.Drawing.Point(390, 105);
            this.btnNS_Xoa.Name = "btnNS_Xoa";
            this.btnNS_Xoa.Size = new System.Drawing.Size(110, 35);
            this.btnNS_Xoa.TabIndex = 16;
            this.btnNS_Xoa.Text = "Xóa NV";
            this.btnNS_Xoa.UseVisualStyleBackColor = false;

            this.btnNS_LamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(130)))), ((int)(((byte)(140)))));
            this.btnNS_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNS_LamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNS_LamMoi.ForeColor = System.Drawing.Color.White;
            this.btnNS_LamMoi.Location = new System.Drawing.Point(515, 105);
            this.btnNS_LamMoi.Name = "btnNS_LamMoi";
            this.btnNS_LamMoi.Size = new System.Drawing.Size(110, 35);
            this.btnNS_LamMoi.TabIndex = 17;
            this.btnNS_LamMoi.Text = "Làm mới";
            this.btnNS_LamMoi.UseVisualStyleBackColor = false;

            // Search Bar
            this.panelNS_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(252)))));
            this.panelNS_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNS_Search.Controls.Add(this.lblNS_Search);
            this.panelNS_Search.Controls.Add(this.txtNS_Search);
            this.panelNS_Search.Controls.Add(this.lblNS_FilterPB);
            this.panelNS_Search.Controls.Add(this.cboNS_FilterPB);
            this.panelNS_Search.Controls.Add(this.btnNS_Search);
            this.panelNS_Search.Controls.Add(this.btnNS_ResetSearch);
            this.panelNS_Search.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNS_Search.Location = new System.Drawing.Point(6, 161);
            this.panelNS_Search.Name = "panelNS_Search";
            this.panelNS_Search.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.panelNS_Search.Size = new System.Drawing.Size(1164, 45);
            this.panelNS_Search.TabIndex = 1;

            this.lblNS_Search.AutoSize = true;
            this.lblNS_Search.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNS_Search.Location = new System.Drawing.Point(10, 12);
            this.lblNS_Search.Name = "lblNS_Search";
            this.lblNS_Search.Size = new System.Drawing.Size(209, 17);
            this.lblNS_Search.TabIndex = 0;
            this.lblNS_Search.Text = "🔍 Tìm kiếm (Tên / CCCD / PB):";

            this.txtNS_Search.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtNS_Search.Location = new System.Drawing.Point(225, 9);
            this.txtNS_Search.Name = "txtNS_Search";
            this.txtNS_Search.Size = new System.Drawing.Size(230, 24);
            this.txtNS_Search.TabIndex = 1;

            this.lblNS_FilterPB.AutoSize = true;
            this.lblNS_FilterPB.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNS_FilterPB.Location = new System.Drawing.Point(475, 12);
            this.lblNS_FilterPB.Name = "lblNS_FilterPB";
            this.lblNS_FilterPB.Size = new System.Drawing.Size(78, 17);
            this.lblNS_FilterPB.TabIndex = 2;
            this.lblNS_FilterPB.Text = "Phòng ban:";

            this.cboNS_FilterPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNS_FilterPB.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboNS_FilterPB.FormattingEnabled = true;
            this.cboNS_FilterPB.Location = new System.Drawing.Point(560, 9);
            this.cboNS_FilterPB.Name = "cboNS_FilterPB";
            this.cboNS_FilterPB.Size = new System.Drawing.Size(220, 24);
            this.cboNS_FilterPB.TabIndex = 3;

            this.btnNS_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnNS_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNS_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNS_Search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNS_Search.ForeColor = System.Drawing.Color.White;
            this.btnNS_Search.Location = new System.Drawing.Point(795, 7);
            this.btnNS_Search.Name = "btnNS_Search";
            this.btnNS_Search.Size = new System.Drawing.Size(90, 28);
            this.btnNS_Search.TabIndex = 4;
            this.btnNS_Search.Text = "Tìm kiếm";
            this.btnNS_Search.UseVisualStyleBackColor = false;

            this.btnNS_ResetSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(145)))), ((int)(((byte)(150)))));
            this.btnNS_ResetSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNS_ResetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNS_ResetSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNS_ResetSearch.ForeColor = System.Drawing.Color.White;
            this.btnNS_ResetSearch.Location = new System.Drawing.Point(895, 7);
            this.btnNS_ResetSearch.Name = "btnNS_ResetSearch";
            this.btnNS_ResetSearch.Size = new System.Drawing.Size(90, 28);
            this.btnNS_ResetSearch.TabIndex = 5;
            this.btnNS_ResetSearch.Text = "Tất cả";
            this.btnNS_ResetSearch.UseVisualStyleBackColor = false;

            // dgvNhanVien
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNS_MaNV,
            this.colNS_HoTen,
            this.colNS_NgaySinh,
            this.colNS_CCCD,
            this.colNS_TenPB,
            this.colNS_LuongCB,
            this.colNS_HeSo});
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(6, 206);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersVisible = false;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(1164, 373);
            this.dgvNhanVien.TabIndex = 2;

            this.colNS_MaNV.DataPropertyName = "MaNV";
            this.colNS_MaNV.FillWeight = 10F;
            this.colNS_MaNV.HeaderText = "Mã NV";
            this.colNS_MaNV.Name = "colNS_MaNV";
            this.colNS_MaNV.ReadOnly = true;

            this.colNS_HoTen.DataPropertyName = "HoTen";
            this.colNS_HoTen.FillWeight = 30F;
            this.colNS_HoTen.HeaderText = "Họ và Tên";
            this.colNS_HoTen.Name = "colNS_HoTen";
            this.colNS_HoTen.ReadOnly = true;

            this.colNS_NgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNS_NgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNS_NgaySinh.FillWeight = 15F;
            this.colNS_NgaySinh.HeaderText = "Ngày Sinh";
            this.colNS_NgaySinh.Name = "colNS_NgaySinh";
            this.colNS_NgaySinh.ReadOnly = true;

            this.colNS_CCCD.DataPropertyName = "CCCD";
            this.colNS_CCCD.FillWeight = 18F;
            this.colNS_CCCD.HeaderText = "Số CCCD";
            this.colNS_CCCD.Name = "colNS_CCCD";
            this.colNS_CCCD.ReadOnly = true;

            this.colNS_TenPB.DataPropertyName = "TenPB";
            this.colNS_TenPB.FillWeight = 25F;
            this.colNS_TenPB.HeaderText = "Phòng Ban";
            this.colNS_TenPB.Name = "colNS_TenPB";
            this.colNS_TenPB.ReadOnly = true;

            this.colNS_LuongCB.DataPropertyName = "LuongCoBan";
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colNS_LuongCB.DefaultCellStyle = dataGridViewCellStyle2;
            this.colNS_LuongCB.FillWeight = 20F;
            this.colNS_LuongCB.HeaderText = "Lương CB (đ)";
            this.colNS_LuongCB.Name = "colNS_LuongCB";
            this.colNS_LuongCB.ReadOnly = true;

            this.colNS_HeSo.DataPropertyName = "HeSoLuong";
            this.colNS_HeSo.FillWeight = 12F;
            this.colNS_HeSo.HeaderText = "Hệ Số";
            this.colNS_HeSo.Name = "colNS_HeSo";
            this.colNS_HeSo.ReadOnly = true;

            // ==========================================
            // TAB 2: CHAM CONG NGAT KET NOI (DISCONNECTED)
            // ==========================================
            this.tabChamCong.Controls.Add(this.dgvChamCong);
            this.tabChamCong.Controls.Add(this.panelCC_Bottom);
            this.tabChamCong.Controls.Add(this.panelCC_Top);
            this.tabChamCong.Location = new System.Drawing.Point(4, 26);
            this.tabChamCong.Name = "tabChamCong";
            this.tabChamCong.Padding = new System.Windows.Forms.Padding(6);
            this.tabChamCong.Size = new System.Drawing.Size(1176, 585);
            this.tabChamCong.TabIndex = 1;
            this.tabChamCong.Text = "📅 Chấm Công Ngắt Kết Nối (SqlDataAdapter & DataTable)";
            this.tabChamCong.UseVisualStyleBackColor = true;

            this.panelCC_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panelCC_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCC_Top.Controls.Add(this.lblCC_ThangNam);
            this.panelCC_Top.Controls.Add(this.cboCC_ThangNam);
            this.panelCC_Top.Controls.Add(this.btnCC_Nap);
            this.panelCC_Top.Controls.Add(this.btnCC_Luu);
            this.panelCC_Top.Controls.Add(this.lblCC_HuongDan);
            this.panelCC_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCC_Top.Location = new System.Drawing.Point(6, 6);
            this.panelCC_Top.Name = "panelCC_Top";
            this.panelCC_Top.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelCC_Top.Size = new System.Drawing.Size(1164, 75);
            this.panelCC_Top.TabIndex = 0;

            this.lblCC_ThangNam.AutoSize = true;
            this.lblCC_ThangNam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCC_ThangNam.Location = new System.Drawing.Point(12, 12);
            this.lblCC_ThangNam.Name = "lblCC_ThangNam";
            this.lblCC_ThangNam.Size = new System.Drawing.Size(126, 19);
            this.lblCC_ThangNam.TabIndex = 0;
            this.lblCC_ThangNam.Text = "Chọn Tháng/Năm:";

            this.cboCC_ThangNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCC_ThangNam.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cboCC_ThangNam.FormattingEnabled = true;
            this.cboCC_ThangNam.Items.AddRange(new object[] { "11/2026", "10/2026", "09/2026", "12/2026" });
            this.cboCC_ThangNam.Location = new System.Drawing.Point(145, 10);
            this.cboCC_ThangNam.Name = "cboCC_ThangNam";
            this.cboCC_ThangNam.Size = new System.Drawing.Size(120, 25);
            this.cboCC_ThangNam.TabIndex = 1;

            this.btnCC_Nap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnCC_Nap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCC_Nap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCC_Nap.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCC_Nap.ForeColor = System.Drawing.Color.White;
            this.btnCC_Nap.Location = new System.Drawing.Point(280, 7);
            this.btnCC_Nap.Name = "btnCC_Nap";
            this.btnCC_Nap.Size = new System.Drawing.Size(160, 32);
            this.btnCC_Nap.TabIndex = 2;
            this.btnCC_Nap.Text = "📥 Nạp Bảng Chấm Công";
            this.btnCC_Nap.UseVisualStyleBackColor = false;

            this.btnCC_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(130)))), ((int)(((byte)(60)))));
            this.btnCC_Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCC_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCC_Luu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCC_Luu.ForeColor = System.Drawing.Color.White;
            this.btnCC_Luu.Location = new System.Drawing.Point(450, 7);
            this.btnCC_Luu.Name = "btnCC_Luu";
            this.btnCC_Luu.Size = new System.Drawing.Size(260, 32);
            this.btnCC_Luu.TabIndex = 3;
            this.btnCC_Luu.Text = "💾 Lưu Chấm Công (adapter.Update)";
            this.btnCC_Luu.UseVisualStyleBackColor = false;

            this.lblCC_HuongDan.AutoSize = true;
            this.lblCC_HuongDan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblCC_HuongDan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.lblCC_HuongDan.Location = new System.Drawing.Point(12, 45);
            this.lblCC_HuongDan.Name = "lblCC_HuongDan";
            this.lblCC_HuongDan.Size = new System.Drawing.Size(780, 15);
            this.lblCC_HuongDan.TabIndex = 4;
            this.lblCC_HuongDan.Text = "💡 Hướng dẫn: Bạn có thể click trực tiếp vào ô 'Số Ngày Công' hoặc 'Số Giờ OT' trên lưới để sửa, sau đó bấm 'Lưu Chấm Công' để đồng bộ về SQL Server.";

            // dgvChamCong
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.Color.White;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChamCong.Location = new System.Drawing.Point(6, 81);
            this.dgvChamCong.MultiSelect = false;
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.RowHeadersVisible = false;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(1164, 463);
            this.dgvChamCong.TabIndex = 1;

            // panelCC_Bottom
            this.panelCC_Bottom.Controls.Add(this.lblCC_Stats);
            this.panelCC_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCC_Bottom.Location = new System.Drawing.Point(6, 544);
            this.panelCC_Bottom.Name = "panelCC_Bottom";
            this.panelCC_Bottom.Size = new System.Drawing.Size(1164, 35);
            this.panelCC_Bottom.TabIndex = 2;

            this.lblCC_Stats.AutoSize = true;
            this.lblCC_Stats.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblCC_Stats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.lblCC_Stats.Location = new System.Drawing.Point(10, 8);
            this.lblCC_Stats.Name = "lblCC_Stats";
            this.lblCC_Stats.Size = new System.Drawing.Size(560, 17);
            this.lblCC_Stats.TabIndex = 0;
            this.lblCC_Stats.Text = "Mô hình Ngắt kết nối: DataTable giữ bản sao cục bộ, không giữ kết nối liên tục với DB.";

            // ==========================================
            // TAB 3: TINH LUONG & CHOT LUONG (SQLTRANSACTION)
            // ==========================================
            this.tabTinhLuong.Controls.Add(this.dgvBangLuong);
            this.tabTinhLuong.Controls.Add(this.panelTL_Cards);
            this.tabTinhLuong.Controls.Add(this.panelTL_Top);
            this.tabTinhLuong.Location = new System.Drawing.Point(4, 26);
            this.tabTinhLuong.Name = "tabTinhLuong";
            this.tabTinhLuong.Padding = new System.Windows.Forms.Padding(6);
            this.tabTinhLuong.Size = new System.Drawing.Size(1176, 585);
            this.tabTinhLuong.TabIndex = 2;
            this.tabTinhLuong.Text = "💰 Tính Lương & Chốt Lương (SqlTransaction)";
            this.tabTinhLuong.UseVisualStyleBackColor = true;

            this.panelTL_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(254)))));
            this.panelTL_Top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTL_Top.Controls.Add(this.lblTL_ThangNam);
            this.panelTL_Top.Controls.Add(this.cboTL_ThangNam);
            this.panelTL_Top.Controls.Add(this.btnTL_TinhDuKien);
            this.panelTL_Top.Controls.Add(this.btnTL_ChotLuong);
            this.panelTL_Top.Controls.Add(this.lblTL_CongThuc);
            this.panelTL_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTL_Top.Location = new System.Drawing.Point(6, 6);
            this.panelTL_Top.Name = "panelTL_Top";
            this.panelTL_Top.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.panelTL_Top.Size = new System.Drawing.Size(1164, 75);
            this.panelTL_Top.TabIndex = 0;

            this.lblTL_ThangNam.AutoSize = true;
            this.lblTL_ThangNam.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTL_ThangNam.Location = new System.Drawing.Point(12, 12);
            this.lblTL_ThangNam.Name = "lblTL_ThangNam";
            this.lblTL_ThangNam.Size = new System.Drawing.Size(126, 19);
            this.lblTL_ThangNam.TabIndex = 0;
            this.lblTL_ThangNam.Text = "Chọn Tháng/Năm:";

            this.cboTL_ThangNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTL_ThangNam.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.cboTL_ThangNam.FormattingEnabled = true;
            this.cboTL_ThangNam.Items.AddRange(new object[] { "11/2026", "10/2026", "09/2026", "12/2026" });
            this.cboTL_ThangNam.Location = new System.Drawing.Point(145, 10);
            this.cboTL_ThangNam.Name = "cboTL_ThangNam";
            this.cboTL_ThangNam.Size = new System.Drawing.Size(120, 25);
            this.cboTL_ThangNam.TabIndex = 1;

            this.btnTL_TinhDuKien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(90)))), ((int)(((byte)(188)))));
            this.btnTL_TinhDuKien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTL_TinhDuKien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTL_TinhDuKien.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnTL_TinhDuKien.ForeColor = System.Drawing.Color.White;
            this.btnTL_TinhDuKien.Location = new System.Drawing.Point(280, 7);
            this.btnTL_TinhDuKien.Name = "btnTL_TinhDuKien";
            this.btnTL_TinhDuKien.Size = new System.Drawing.Size(170, 32);
            this.btnTL_TinhDuKien.TabIndex = 2;
            this.btnTL_TinhDuKien.Text = "🧮 Tính Lương Dự Kiến";
            this.btnTL_TinhDuKien.UseVisualStyleBackColor = false;

            this.btnTL_ChotLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(30)))));
            this.btnTL_ChotLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTL_ChotLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTL_ChotLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTL_ChotLuong.ForeColor = System.Drawing.Color.White;
            this.btnTL_ChotLuong.Location = new System.Drawing.Point(465, 7);
            this.btnTL_ChotLuong.Name = "btnTL_ChotLuong";
            this.btnTL_ChotLuong.Size = new System.Drawing.Size(260, 32);
            this.btnTL_ChotLuong.TabIndex = 3;
            this.btnTL_ChotLuong.Text = "🔒 Chốt Lương Tháng (SqlTransaction)";
            this.btnTL_ChotLuong.UseVisualStyleBackColor = false;

            this.lblTL_CongThuc.AutoSize = true;
            this.lblTL_CongThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTL_CongThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(40)))), ((int)(((byte)(20)))));
            this.lblTL_CongThuc.Location = new System.Drawing.Point(12, 45);
            this.lblTL_CongThuc.Name = "lblTL_CongThuc";
            this.lblTL_CongThuc.Size = new System.Drawing.Size(680, 15);
            this.lblTL_CongThuc.TabIndex = 4;
            this.lblTL_CongThuc.Text = "Công thức: Thực Lĩnh = (Lương Cơ Bản * Hệ Số Lương / 22) * Số Ngày Công + (Số Giờ OT * 50,000 đ)";

            // panelTL_Cards
            this.panelTL_Cards.Controls.Add(this.txtTL_LogTrans);
            this.panelTL_Cards.Controls.Add(this.pnlTL_CardTongLuong);
            this.panelTL_Cards.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTL_Cards.Location = new System.Drawing.Point(6, 81);
            this.panelTL_Cards.Name = "panelTL_Cards";
            this.panelTL_Cards.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.panelTL_Cards.Size = new System.Drawing.Size(1164, 110);
            this.panelTL_Cards.TabIndex = 1;

            // pnlTL_CardTongLuong
            this.pnlTL_CardTongLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(248)))), ((int)(((byte)(240)))));
            this.pnlTL_CardTongLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTL_CardTongLuong.Controls.Add(this.lblTL_CardTitle);
            this.pnlTL_CardTongLuong.Controls.Add(this.lblTL_TongTienLuong);
            this.pnlTL_CardTongLuong.Controls.Add(this.lblTL_SoNhanVien);
            this.pnlTL_CardTongLuong.Location = new System.Drawing.Point(0, 6);
            this.pnlTL_CardTongLuong.Name = "pnlTL_CardTongLuong";
            this.pnlTL_CardTongLuong.Padding = new System.Windows.Forms.Padding(12);
            this.pnlTL_CardTongLuong.Size = new System.Drawing.Size(350, 95);
            this.pnlTL_CardTongLuong.TabIndex = 0;

            this.lblTL_CardTitle.AutoSize = true;
            this.lblTL_CardTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTL_CardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(40)))));
            this.lblTL_CardTitle.Location = new System.Drawing.Point(12, 10);
            this.lblTL_CardTitle.Name = "lblTL_CardTitle";
            this.lblTL_CardTitle.Size = new System.Drawing.Size(185, 17);
            this.lblTL_CardTitle.TabIndex = 0;
            this.lblTL_CardTitle.Text = "TỔNG QUỸ LƯƠNG THÁNG:";

            this.lblTL_TongTienLuong.AutoSize = true;
            this.lblTL_TongTienLuong.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTL_TongTienLuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.lblTL_TongTienLuong.Location = new System.Drawing.Point(12, 32);
            this.lblTL_TongTienLuong.Name = "lblTL_TongTienLuong";
            this.lblTL_TongTienLuong.Size = new System.Drawing.Size(60, 30);
            this.lblTL_TongTienLuong.TabIndex = 1;
            this.lblTL_TongTienLuong.Text = "0 đ";

            this.lblTL_SoNhanVien.AutoSize = true;
            this.lblTL_SoNhanVien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTL_SoNhanVien.ForeColor = System.Drawing.Color.Gray;
            this.lblTL_SoNhanVien.Location = new System.Drawing.Point(14, 68);
            this.lblTL_SoNhanVien.Name = "lblTL_SoNhanVien";
            this.lblTL_SoNhanVien.Size = new System.Drawing.Size(123, 15);
            this.lblTL_SoNhanVien.TabIndex = 2;
            this.lblTL_SoNhanVien.Text = "Số nhân viên: 0 người";

            // txtTL_LogTrans
            this.txtTL_LogTrans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(35)))), ((int)(((byte)(45)))));
            this.txtTL_LogTrans.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.txtTL_LogTrans.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(240)))), ((int)(((byte)(180)))));
            this.txtTL_LogTrans.Location = new System.Drawing.Point(370, 6);
            this.txtTL_LogTrans.Multiline = true;
            this.txtTL_LogTrans.Name = "txtTL_LogTrans";
            this.txtTL_LogTrans.ReadOnly = true;
            this.txtTL_LogTrans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTL_LogTrans.Size = new System.Drawing.Size(790, 95);
            this.txtTL_LogTrans.TabIndex = 1;
            this.txtTL_LogTrans.Text = "[Hệ thống tính lương & SqlTransaction]\r\nChờ lệnh chốt lương tháng từ người dùng...";

            // dgvBangLuong
            this.dgvBangLuong.AllowUserToAddRows = false;
            this.dgvBangLuong.AllowUserToDeleteRows = false;
            this.dgvBangLuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBangLuong.BackgroundColor = System.Drawing.Color.White;
            this.dgvBangLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBangLuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTL_MaNV,
            this.colTL_HoTen,
            this.colTL_TenPB,
            this.colTL_LuongCB,
            this.colTL_HeSo,
            this.colTL_NgayCong,
            this.colTL_GioOT,
            this.colTL_ThucLinh});
            this.dgvBangLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBangLuong.Location = new System.Drawing.Point(6, 191);
            this.dgvBangLuong.MultiSelect = false;
            this.dgvBangLuong.Name = "dgvBangLuong";
            this.dgvBangLuong.ReadOnly = true;
            this.dgvBangLuong.RowHeadersVisible = false;
            this.dgvBangLuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBangLuong.Size = new System.Drawing.Size(1164, 388);
            this.dgvBangLuong.TabIndex = 2;

            this.colTL_MaNV.DataPropertyName = "MaNV";
            this.colTL_MaNV.FillWeight = 10F;
            this.colTL_MaNV.HeaderText = "Mã NV";
            this.colTL_MaNV.Name = "colTL_MaNV";
            this.colTL_MaNV.ReadOnly = true;

            this.colTL_HoTen.DataPropertyName = "HoTen";
            this.colTL_HoTen.FillWeight = 25F;
            this.colTL_HoTen.HeaderText = "Họ và Tên";
            this.colTL_HoTen.Name = "colTL_HoTen";
            this.colTL_HoTen.ReadOnly = true;

            this.colTL_TenPB.DataPropertyName = "TenPB";
            this.colTL_TenPB.FillWeight = 22F;
            this.colTL_TenPB.HeaderText = "Phòng Ban";
            this.colTL_TenPB.Name = "colTL_TenPB";
            this.colTL_TenPB.ReadOnly = true;

            this.colTL_LuongCB.DataPropertyName = "LuongCoBan";
            this.colTL_LuongCB.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTL_LuongCB.FillWeight = 18F;
            this.colTL_LuongCB.HeaderText = "Lương CB (đ)";
            this.colTL_LuongCB.Name = "colTL_LuongCB";
            this.colTL_LuongCB.ReadOnly = true;

            this.colTL_HeSo.DataPropertyName = "HeSoLuong";
            this.colTL_HeSo.FillWeight = 10F;
            this.colTL_HeSo.HeaderText = "Hệ Số";
            this.colTL_HeSo.Name = "colTL_HeSo";
            this.colTL_HeSo.ReadOnly = true;

            this.colTL_NgayCong.DataPropertyName = "SoNgayCong";
            this.colTL_NgayCong.FillWeight = 12F;
            this.colTL_NgayCong.HeaderText = "Ngày Công";
            this.colTL_NgayCong.Name = "colTL_NgayCong";
            this.colTL_NgayCong.ReadOnly = true;

            this.colTL_GioOT.DataPropertyName = "SoGioOT";
            this.colTL_GioOT.FillWeight = 12F;
            this.colTL_GioOT.HeaderText = "Giờ OT";
            this.colTL_GioOT.Name = "colTL_GioOT";
            this.colTL_GioOT.ReadOnly = true;

            this.colTL_ThucLinh.DataPropertyName = "ThucLinh";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(40)))));
            this.colTL_ThucLinh.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTL_ThucLinh.FillWeight = 22F;
            this.colTL_ThucLinh.HeaderText = "Thực Lĩnh (đ)";
            this.colTL_ThucLinh.Name = "colTL_ThucLinh";
            this.colTL_ThucLinh.ReadOnly = true;

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
            this.lblStatusConnection.Text = "CSDL: HRMDB (Microsoft SQL Server / LocalDB)";
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
            this.Text = "Hệ thống Quản lý Nhân sự & Tính Lương (HRM & Payroll System) - Nguyễn Hải Nam (24810310617)";

            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabNhanSu.ResumeLayout(false);
            this.panelNS_Top.ResumeLayout(false);
            this.grpNS_Input.ResumeLayout(false);
            this.grpNS_Input.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_LuongCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNS_HeSo)).EndInit();
            this.panelNS_Search.ResumeLayout(false);
            this.panelNS_Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.tabChamCong.ResumeLayout(false);
            this.panelCC_Top.ResumeLayout(false);
            this.panelCC_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.panelCC_Bottom.ResumeLayout(false);
            this.panelCC_Bottom.PerformLayout();
            this.tabTinhLuong.ResumeLayout(false);
            this.panelTL_Top.ResumeLayout(false);
            this.panelTL_Top.PerformLayout();
            this.panelTL_Cards.ResumeLayout(false);
            this.panelTL_Cards.PerformLayout();
            this.pnlTL_CardTongLuong.ResumeLayout(false);
            this.pnlTL_CardTongLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBangLuong)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Components
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblHeaderSubtitle;
        private System.Windows.Forms.TabControl tabControlMain;

        // Tab 1: Nhan su
        private System.Windows.Forms.TabPage tabNhanSu;
        private System.Windows.Forms.Panel panelNS_Top;
        private System.Windows.Forms.GroupBox grpNS_Input;
        private System.Windows.Forms.Label lblNS_MaNV;
        private System.Windows.Forms.TextBox txtNS_MaNV;
        private System.Windows.Forms.Label lblNS_HoTen;
        private System.Windows.Forms.TextBox txtNS_HoTen;
        private System.Windows.Forms.Label lblNS_NgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNS_NgaySinh;
        private System.Windows.Forms.Label lblNS_CCCD;
        private System.Windows.Forms.TextBox txtNS_CCCD;
        private System.Windows.Forms.Label lblNS_PhongBan;
        private System.Windows.Forms.ComboBox cboNS_PhongBan;
        private System.Windows.Forms.Label lblNS_LuongCB;
        private System.Windows.Forms.NumericUpDown nudNS_LuongCB;
        private System.Windows.Forms.Label lblNS_HeSo;
        private System.Windows.Forms.NumericUpDown nudNS_HeSo;
        private System.Windows.Forms.Button btnNS_Them;
        private System.Windows.Forms.Button btnNS_Sua;
        private System.Windows.Forms.Button btnNS_Xoa;
        private System.Windows.Forms.Button btnNS_LamMoi;
        private System.Windows.Forms.Panel panelNS_Search;
        private System.Windows.Forms.Label lblNS_Search;
        private System.Windows.Forms.TextBox txtNS_Search;
        private System.Windows.Forms.Label lblNS_FilterPB;
        private System.Windows.Forms.ComboBox cboNS_FilterPB;
        private System.Windows.Forms.Button btnNS_Search;
        private System.Windows.Forms.Button btnNS_ResetSearch;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_LuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNS_HeSo;

        // Tab 2: Cham cong
        private System.Windows.Forms.TabPage tabChamCong;
        private System.Windows.Forms.Panel panelCC_Top;
        private System.Windows.Forms.Label lblCC_ThangNam;
        private System.Windows.Forms.ComboBox cboCC_ThangNam;
        private System.Windows.Forms.Button btnCC_Nap;
        private System.Windows.Forms.Button btnCC_Luu;
        private System.Windows.Forms.Label lblCC_HuongDan;
        private System.Windows.Forms.DataGridView dgvChamCong;
        private System.Windows.Forms.Panel panelCC_Bottom;
        private System.Windows.Forms.Label lblCC_Stats;

        // Tab 3: Tinh luong
        private System.Windows.Forms.TabPage tabTinhLuong;
        private System.Windows.Forms.Panel panelTL_Top;
        private System.Windows.Forms.Label lblTL_ThangNam;
        private System.Windows.Forms.ComboBox cboTL_ThangNam;
        private System.Windows.Forms.Button btnTL_TinhDuKien;
        private System.Windows.Forms.Button btnTL_ChotLuong;
        private System.Windows.Forms.Label lblTL_CongThuc;
        private System.Windows.Forms.Panel panelTL_Cards;
        private System.Windows.Forms.Panel pnlTL_CardTongLuong;
        private System.Windows.Forms.Label lblTL_CardTitle;
        private System.Windows.Forms.Label lblTL_TongTienLuong;
        private System.Windows.Forms.Label lblTL_SoNhanVien;
        private System.Windows.Forms.TextBox txtTL_LogTrans;
        private System.Windows.Forms.DataGridView dgvBangLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_LuongCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_HeSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_NgayCong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_GioOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTL_ThucLinh;

        // Status & Error
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusMsg;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusConnection;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
