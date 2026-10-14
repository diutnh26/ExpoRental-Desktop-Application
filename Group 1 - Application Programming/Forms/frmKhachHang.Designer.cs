namespace Group_1___Application_Programming.Forms
{
    partial class frmKhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.lblGoiYTuKhoa = new System.Windows.Forms.Label();
            this.lblLocLoaiKhachHang = new System.Windows.Forms.Label();
            this.cboLocLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblSoBanGhi = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblLoaiKhachHang = new System.Windows.Forms.Label();
            this.lblSaoLoaiKhachHang = new System.Windows.Forms.Label();
            this.cboLoaiKhachHang = new System.Windows.Forms.ComboBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.lblSaoTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblMaSoThue = new System.Windows.Forms.Label();
            this.lblSaoMaSoThue = new System.Windows.Forms.Label();
            this.txtMaSoThue = new System.Windows.Forms.TextBox();
            this.lblNguoiLienHe = new System.Windows.Forms.Label();
            this.lblSaoNguoiLienHe = new System.Windows.Forms.Label();
            this.txtNguoiLienHe = new System.Windows.Forms.TextBox();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.lblSaoSoDienThoai = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.chkDangHoatDong = new System.Windows.Forms.CheckBox();
            this.lblSoLuotThue = new System.Windows.Forms.Label();
            this.txtSoLuotThue = new System.Windows.Forms.TextBox();
            this.pnlChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.grpThongTin.SuspendLayout();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTimKiem.Controls.Add(this.lblTuKhoa);
            this.grpTimKiem.Controls.Add(this.txtTuKhoa);
            this.grpTimKiem.Controls.Add(this.lblGoiYTuKhoa);
            this.grpTimKiem.Controls.Add(this.lblLocLoaiKhachHang);
            this.grpTimKiem.Controls.Add(this.cboLocLoaiKhachHang);
            this.grpTimKiem.Controls.Add(this.lblLocTrangThai);
            this.grpTimKiem.Controls.Add(this.cboLocTrangThai);
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTimKiem.Location = new System.Drawing.Point(10, 7);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Size = new System.Drawing.Size(1498, 83);
            this.grpTimKiem.TabIndex = 0;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm";
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTuKhoa.Location = new System.Drawing.Point(11, 29);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(65, 20);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Từ khóa:";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTuKhoa.Location = new System.Drawing.Point(82, 25);
            this.txtTuKhoa.MaxLength = 100;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(334, 27);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // lblGoiYTuKhoa
            // 
            this.lblGoiYTuKhoa.AutoSize = true;
            this.lblGoiYTuKhoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblGoiYTuKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblGoiYTuKhoa.Location = new System.Drawing.Point(82, 55);
            this.lblGoiYTuKhoa.Name = "lblGoiYTuKhoa";
            this.lblGoiYTuKhoa.Size = new System.Drawing.Size(221, 19);
            this.lblGoiYTuKhoa.TabIndex = 2;
            this.lblGoiYTuKhoa.Text = "Mã, tên, mã số thuế, số điện thoại";
            // 
            // lblLocLoaiKhachHang
            // 
            this.lblLocLoaiKhachHang.AutoSize = true;
            this.lblLocLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocLoaiKhachHang.Location = new System.Drawing.Point(436, 29);
            this.lblLocLoaiKhachHang.Name = "lblLocLoaiKhachHang";
            this.lblLocLoaiKhachHang.Size = new System.Drawing.Size(40, 20);
            this.lblLocLoaiKhachHang.TabIndex = 3;
            this.lblLocLoaiKhachHang.Text = "Loại:";
            // 
            // cboLocLoaiKhachHang
            // 
            this.cboLocLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocLoaiKhachHang.FormattingEnabled = true;
            this.cboLocLoaiKhachHang.Location = new System.Drawing.Point(477, 25);
            this.cboLocLoaiKhachHang.Name = "cboLocLoaiKhachHang";
            this.cboLocLoaiKhachHang.Size = new System.Drawing.Size(151, 28);
            this.cboLocLoaiKhachHang.TabIndex = 4;
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocTrangThai.Location = new System.Drawing.Point(649, 29);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(79, 20);
            this.lblLocTrangThai.TabIndex = 5;
            this.lblLocTrangThai.Text = "Tình trạng:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(730, 25);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(172, 28);
            this.cboLocTrangThai.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.Location = new System.Drawing.Point(922, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(72, 29);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSach.ColumnHeadersHeight = 26;
            this.dgvDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhSach.Location = new System.Drawing.Point(10, 99);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.RowTemplate.Height = 24;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(921, 534);
            this.dgvDanhSach.TabIndex = 1;
            // 
            // lblSoBanGhi
            // 
            this.lblSoBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoBanGhi.AutoSize = true;
            this.lblSoBanGhi.Location = new System.Drawing.Point(10, 642);
            this.lblSoBanGhi.Name = "lblSoBanGhi";
            this.lblSoBanGhi.Size = new System.Drawing.Size(152, 23);
            this.lblSoBanGhi.TabIndex = 2;
            this.lblSoBanGhi.Text = "Tổng số: 0 bản ghi";
            // 
            // grpThongTin
            // 
            this.grpThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongTin.Controls.Add(this.lblMaKhachHang);
            this.grpThongTin.Controls.Add(this.txtMaKhachHang);
            this.grpThongTin.Controls.Add(this.lblLoaiKhachHang);
            this.grpThongTin.Controls.Add(this.lblSaoLoaiKhachHang);
            this.grpThongTin.Controls.Add(this.cboLoaiKhachHang);
            this.grpThongTin.Controls.Add(this.lblTenKhachHang);
            this.grpThongTin.Controls.Add(this.lblSaoTenKhachHang);
            this.grpThongTin.Controls.Add(this.txtTenKhachHang);
            this.grpThongTin.Controls.Add(this.lblMaSoThue);
            this.grpThongTin.Controls.Add(this.lblSaoMaSoThue);
            this.grpThongTin.Controls.Add(this.txtMaSoThue);
            this.grpThongTin.Controls.Add(this.lblNguoiLienHe);
            this.grpThongTin.Controls.Add(this.lblSaoNguoiLienHe);
            this.grpThongTin.Controls.Add(this.txtNguoiLienHe);
            this.grpThongTin.Controls.Add(this.lblSoDienThoai);
            this.grpThongTin.Controls.Add(this.lblSaoSoDienThoai);
            this.grpThongTin.Controls.Add(this.txtSoDienThoai);
            this.grpThongTin.Controls.Add(this.lblEmail);
            this.grpThongTin.Controls.Add(this.txtEmail);
            this.grpThongTin.Controls.Add(this.lblDiaChi);
            this.grpThongTin.Controls.Add(this.txtDiaChi);
            this.grpThongTin.Controls.Add(this.chkDangHoatDong);
            this.grpThongTin.Controls.Add(this.lblSoLuotThue);
            this.grpThongTin.Controls.Add(this.txtSoLuotThue);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(942, 94);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(567, 384);
            this.grpThongTin.TabIndex = 3;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin khách hàng";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaKhachHang.Location = new System.Drawing.Point(11, 34);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(112, 20);
            this.lblMaKhachHang.TabIndex = 0;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKhachHang.Location = new System.Drawing.Point(153, 31);
            this.txtMaKhachHang.MaxLength = 10;
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.ReadOnly = true;
            this.txtMaKhachHang.Size = new System.Drawing.Size(151, 27);
            this.txtMaKhachHang.TabIndex = 1;
            this.txtMaKhachHang.TabStop = false;
            // 
            // lblLoaiKhachHang
            // 
            this.lblLoaiKhachHang.AutoSize = true;
            this.lblLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiKhachHang.Location = new System.Drawing.Point(11, 66);
            this.lblLoaiKhachHang.Name = "lblLoaiKhachHang";
            this.lblLoaiKhachHang.Size = new System.Drawing.Size(119, 20);
            this.lblLoaiKhachHang.TabIndex = 2;
            this.lblLoaiKhachHang.Text = "Loại khách hàng:";
            // 
            // lblSaoLoaiKhachHang
            // 
            this.lblSaoLoaiKhachHang.AutoSize = true;
            this.lblSaoLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoLoaiKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoLoaiKhachHang.Location = new System.Drawing.Point(116, 66);
            this.lblSaoLoaiKhachHang.Name = "lblSaoLoaiKhachHang";
            this.lblSaoLoaiKhachHang.Size = new System.Drawing.Size(15, 20);
            this.lblSaoLoaiKhachHang.TabIndex = 3;
            this.lblSaoLoaiKhachHang.Text = "*";
            // 
            // cboLoaiKhachHang
            // 
            this.cboLoaiKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiKhachHang.FormattingEnabled = true;
            this.cboLoaiKhachHang.Location = new System.Drawing.Point(153, 62);
            this.cboLoaiKhachHang.Name = "cboLoaiKhachHang";
            this.cboLoaiKhachHang.Size = new System.Drawing.Size(192, 28);
            this.cboLoaiKhachHang.TabIndex = 4;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKhachHang.Location = new System.Drawing.Point(11, 97);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(88, 20);
            this.lblTenKhachHang.TabIndex = 5;
            this.lblTenKhachHang.Text = "Tên công ty:";
            // 
            // lblSaoTenKhachHang
            // 
            this.lblSaoTenKhachHang.AutoSize = true;
            this.lblSaoTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoTenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoTenKhachHang.Location = new System.Drawing.Point(88, 97);
            this.lblSaoTenKhachHang.Name = "lblSaoTenKhachHang";
            this.lblSaoTenKhachHang.Size = new System.Drawing.Size(15, 20);
            this.lblSaoTenKhachHang.TabIndex = 6;
            this.lblSaoTenKhachHang.Text = "*";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhachHang.Location = new System.Drawing.Point(153, 93);
            this.txtTenKhachHang.MaxLength = 200;
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Size = new System.Drawing.Size(402, 27);
            this.txtTenKhachHang.TabIndex = 7;
            // 
            // lblMaSoThue
            // 
            this.lblMaSoThue.AutoSize = true;
            this.lblMaSoThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaSoThue.Location = new System.Drawing.Point(11, 128);
            this.lblMaSoThue.Name = "lblMaSoThue";
            this.lblMaSoThue.Size = new System.Drawing.Size(85, 20);
            this.lblMaSoThue.TabIndex = 8;
            this.lblMaSoThue.Text = "Mã số thuế:";
            // 
            // lblSaoMaSoThue
            // 
            this.lblSaoMaSoThue.AutoSize = true;
            this.lblSaoMaSoThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoMaSoThue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoMaSoThue.Location = new System.Drawing.Point(84, 128);
            this.lblSaoMaSoThue.Name = "lblSaoMaSoThue";
            this.lblSaoMaSoThue.Size = new System.Drawing.Size(15, 20);
            this.lblSaoMaSoThue.TabIndex = 9;
            this.lblSaoMaSoThue.Text = "*";
            // 
            // txtMaSoThue
            // 
            this.txtMaSoThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaSoThue.Location = new System.Drawing.Point(153, 124);
            this.txtMaSoThue.MaxLength = 14;
            this.txtMaSoThue.Name = "txtMaSoThue";
            this.txtMaSoThue.Size = new System.Drawing.Size(192, 27);
            this.txtMaSoThue.TabIndex = 10;
            // 
            // lblNguoiLienHe
            // 
            this.lblNguoiLienHe.AutoSize = true;
            this.lblNguoiLienHe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNguoiLienHe.Location = new System.Drawing.Point(11, 159);
            this.lblNguoiLienHe.Name = "lblNguoiLienHe";
            this.lblNguoiLienHe.Size = new System.Drawing.Size(102, 20);
            this.lblNguoiLienHe.TabIndex = 11;
            this.lblNguoiLienHe.Text = "Người liên hệ:";
            // 
            // lblSaoNguoiLienHe
            // 
            this.lblSaoNguoiLienHe.AutoSize = true;
            this.lblSaoNguoiLienHe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoNguoiLienHe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoNguoiLienHe.Location = new System.Drawing.Point(98, 159);
            this.lblSaoNguoiLienHe.Name = "lblSaoNguoiLienHe";
            this.lblSaoNguoiLienHe.Size = new System.Drawing.Size(15, 20);
            this.lblSaoNguoiLienHe.TabIndex = 12;
            this.lblSaoNguoiLienHe.Text = "*";
            // 
            // txtNguoiLienHe
            // 
            this.txtNguoiLienHe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNguoiLienHe.Location = new System.Drawing.Point(153, 155);
            this.txtNguoiLienHe.MaxLength = 100;
            this.txtNguoiLienHe.Name = "txtNguoiLienHe";
            this.txtNguoiLienHe.Size = new System.Drawing.Size(402, 27);
            this.txtNguoiLienHe.TabIndex = 13;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoDienThoai.Location = new System.Drawing.Point(11, 190);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(100, 20);
            this.lblSoDienThoai.TabIndex = 14;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // lblSaoSoDienThoai
            // 
            this.lblSaoSoDienThoai.AutoSize = true;
            this.lblSaoSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoSoDienThoai.Location = new System.Drawing.Point(96, 190);
            this.lblSaoSoDienThoai.Name = "lblSaoSoDienThoai";
            this.lblSaoSoDienThoai.Size = new System.Drawing.Size(15, 20);
            this.lblSaoSoDienThoai.TabIndex = 15;
            this.lblSaoSoDienThoai.Text = "*";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(153, 186);
            this.txtSoDienThoai.MaxLength = 10;
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(192, 27);
            this.txtSoDienThoai.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(11, 221);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(153, 217);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(402, 27);
            this.txtEmail.TabIndex = 18;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDiaChi.Location = new System.Drawing.Point(11, 252);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(58, 20);
            this.lblDiaChi.TabIndex = 19;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiaChi.Location = new System.Drawing.Point(153, 248);
            this.txtDiaChi.MaxLength = 300;
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDiaChi.Size = new System.Drawing.Size(402, 59);
            this.txtDiaChi.TabIndex = 20;
            // 
            // chkDangHoatDong
            // 
            this.chkDangHoatDong.AutoSize = true;
            this.chkDangHoatDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkDangHoatDong.Location = new System.Drawing.Point(153, 317);
            this.chkDangHoatDong.Name = "chkDangHoatDong";
            this.chkDangHoatDong.Size = new System.Drawing.Size(158, 28);
            this.chkDangHoatDong.TabIndex = 21;
            this.chkDangHoatDong.Text = "Đang hoạt động";
            this.chkDangHoatDong.UseVisualStyleBackColor = true;
            // 
            // lblSoLuotThue
            // 
            this.lblSoLuotThue.AutoSize = true;
            this.lblSoLuotThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoLuotThue.Location = new System.Drawing.Point(11, 350);
            this.lblSoLuotThue.Name = "lblSoLuotThue";
            this.lblSoLuotThue.Size = new System.Drawing.Size(93, 20);
            this.lblSoLuotThue.TabIndex = 22;
            this.lblSoLuotThue.Text = "Số lượt thuê:";
            // 
            // txtSoLuotThue
            // 
            this.txtSoLuotThue.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoLuotThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoLuotThue.Location = new System.Drawing.Point(153, 346);
            this.txtSoLuotThue.Name = "txtSoLuotThue";
            this.txtSoLuotThue.ReadOnly = true;
            this.txtSoLuotThue.Size = new System.Drawing.Size(151, 27);
            this.txtSoLuotThue.TabIndex = 23;
            this.txtSoLuotThue.TabStop = false;
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChucNang.Controls.Add(this.btnThem);
            this.pnlChucNang.Controls.Add(this.btnSua);
            this.pnlChucNang.Controls.Add(this.btnLuu);
            this.pnlChucNang.Controls.Add(this.btnXoa);
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnDong);
            this.pnlChucNang.Location = new System.Drawing.Point(942, 485);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(567, 39);
            this.pnlChucNang.TabIndex = 4;
            this.pnlChucNang.WrapContents = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(0, 3);
            this.btnThem.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(81, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(88, 3);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 31);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.Location = new System.Drawing.Point(176, 3);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(81, 31);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXoa.Location = new System.Drawing.Point(264, 3);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 31);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(352, 3);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 31);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(450, 3);
            this.btnDong.Margin = new System.Windows.Forms.Padding(0, 3, 7, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 31);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 690);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.lblSoBanGhi);
            this.Controls.Add(this.dgvDanhSach);
            this.Controls.Add(this.grpTimKiem);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KeyPreview = true;
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khách hàng";
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblGoiYTuKhoa;
        private System.Windows.Forms.Label lblLocLoaiKhachHang;
        private System.Windows.Forms.ComboBox cboLocLoaiKhachHang;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiKhachHangHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSoThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNguoiLienHe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuotThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDangHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhienBan;
        private System.Windows.Forms.Label lblSoBanGhi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.Label lblLoaiKhachHang;
        private System.Windows.Forms.Label lblSaoLoaiKhachHang;
        private System.Windows.Forms.ComboBox cboLoaiKhachHang;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.Label lblSaoTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblMaSoThue;
        private System.Windows.Forms.Label lblSaoMaSoThue;
        private System.Windows.Forms.TextBox txtMaSoThue;
        private System.Windows.Forms.Label lblNguoiLienHe;
        private System.Windows.Forms.Label lblSaoNguoiLienHe;
        private System.Windows.Forms.TextBox txtNguoiLienHe;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblSaoSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.CheckBox chkDangHoatDong;
        private System.Windows.Forms.Label lblSoLuotThue;
        private System.Windows.Forms.TextBox txtSoLuotThue;
        private System.Windows.Forms.FlowLayoutPanel pnlChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
    }
}
