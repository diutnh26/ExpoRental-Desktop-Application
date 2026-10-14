namespace Group_1___Application_Programming.Forms
{
    partial class frmLoaiKhongGian
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
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblSoBanGhi = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaLoaiKhongGian = new System.Windows.Forms.Label();
            this.txtMaLoaiKhongGian = new System.Windows.Forms.TextBox();
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.lblSaoTenLoai = new System.Windows.Forms.Label();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.lblDonGiaNgay = new System.Windows.Forms.Label();
            this.lblSaoDonGiaNgay = new System.Windows.Forms.Label();
            this.nudDonGiaNgay = new System.Windows.Forms.NumericUpDown();
            this.lblGoiYDonGia = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.chkDangHoatDong = new System.Windows.Forms.CheckBox();
            this.lblSoKhongGian = new System.Windows.Forms.Label();
            this.txtSoKhongGian = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNgay)).BeginInit();
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
            this.txtTuKhoa.Size = new System.Drawing.Size(303, 27);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // lblGoiYTuKhoa
            // 
            this.lblGoiYTuKhoa.AutoSize = true;
            this.lblGoiYTuKhoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblGoiYTuKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblGoiYTuKhoa.Location = new System.Drawing.Point(82, 55);
            this.lblGoiYTuKhoa.Name = "lblGoiYTuKhoa";
            this.lblGoiYTuKhoa.Size = new System.Drawing.Size(83, 19);
            this.lblGoiYTuKhoa.TabIndex = 2;
            this.lblGoiYTuKhoa.Text = "Mã, tên loại";
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocTrangThai.Location = new System.Drawing.Point(406, 29);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(79, 20);
            this.lblLocTrangThai.TabIndex = 3;
            this.lblLocTrangThai.Text = "Tình trạng:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(487, 25);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(182, 28);
            this.cboLocTrangThai.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.Location = new System.Drawing.Point(690, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(72, 29);
            this.btnTimKiem.TabIndex = 5;
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
            this.dgvDanhSach.Size = new System.Drawing.Size(800, 534);
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
            this.grpThongTin.Controls.Add(this.lblMaLoaiKhongGian);
            this.grpThongTin.Controls.Add(this.txtMaLoaiKhongGian);
            this.grpThongTin.Controls.Add(this.lblTenLoai);
            this.grpThongTin.Controls.Add(this.lblSaoTenLoai);
            this.grpThongTin.Controls.Add(this.txtTenLoai);
            this.grpThongTin.Controls.Add(this.lblDonGiaNgay);
            this.grpThongTin.Controls.Add(this.lblSaoDonGiaNgay);
            this.grpThongTin.Controls.Add(this.nudDonGiaNgay);
            this.grpThongTin.Controls.Add(this.lblGoiYDonGia);
            this.grpThongTin.Controls.Add(this.lblMoTa);
            this.grpThongTin.Controls.Add(this.txtMoTa);
            this.grpThongTin.Controls.Add(this.chkDangHoatDong);
            this.grpThongTin.Controls.Add(this.lblSoKhongGian);
            this.grpThongTin.Controls.Add(this.txtSoKhongGian);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(820, 94);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(688, 285);
            this.grpThongTin.TabIndex = 3;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin loại không gian";
            // 
            // lblMaLoaiKhongGian
            // 
            this.lblMaLoaiKhongGian.AutoSize = true;
            this.lblMaLoaiKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaLoaiKhongGian.Location = new System.Drawing.Point(11, 34);
            this.lblMaLoaiKhongGian.Name = "lblMaLoaiKhongGian";
            this.lblMaLoaiKhongGian.Size = new System.Drawing.Size(62, 20);
            this.lblMaLoaiKhongGian.TabIndex = 0;
            this.lblMaLoaiKhongGian.Text = "Mã loại:";
            // 
            // txtMaLoaiKhongGian
            // 
            this.txtMaLoaiKhongGian.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaLoaiKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLoaiKhongGian.Location = new System.Drawing.Point(153, 31);
            this.txtMaLoaiKhongGian.MaxLength = 10;
            this.txtMaLoaiKhongGian.Name = "txtMaLoaiKhongGian";
            this.txtMaLoaiKhongGian.ReadOnly = true;
            this.txtMaLoaiKhongGian.Size = new System.Drawing.Size(151, 27);
            this.txtMaLoaiKhongGian.TabIndex = 1;
            this.txtMaLoaiKhongGian.TabStop = false;
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.AutoSize = true;
            this.lblTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenLoai.Location = new System.Drawing.Point(11, 66);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(64, 20);
            this.lblTenLoai.TabIndex = 2;
            this.lblTenLoai.Text = "Tên loại:";
            // 
            // lblSaoTenLoai
            // 
            this.lblSaoTenLoai.AutoSize = true;
            this.lblSaoTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoTenLoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoTenLoai.Location = new System.Drawing.Point(64, 66);
            this.lblSaoTenLoai.Name = "lblSaoTenLoai";
            this.lblSaoTenLoai.Size = new System.Drawing.Size(15, 20);
            this.lblSaoTenLoai.TabIndex = 3;
            this.lblSaoTenLoai.Text = "*";
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenLoai.Location = new System.Drawing.Point(153, 62);
            this.txtTenLoai.MaxLength = 100;
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(524, 27);
            this.txtTenLoai.TabIndex = 4;
            // 
            // lblDonGiaNgay
            // 
            this.lblDonGiaNgay.AutoSize = true;
            this.lblDonGiaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonGiaNgay.Location = new System.Drawing.Point(11, 97);
            this.lblDonGiaNgay.Name = "lblDonGiaNgay";
            this.lblDonGiaNgay.Size = new System.Drawing.Size(126, 20);
            this.lblDonGiaNgay.TabIndex = 5;
            this.lblDonGiaNgay.Text = "Đơn giá/ngày (đ):";
            // 
            // lblSaoDonGiaNgay
            // 
            this.lblSaoDonGiaNgay.AutoSize = true;
            this.lblSaoDonGiaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoDonGiaNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoDonGiaNgay.Location = new System.Drawing.Point(119, 97);
            this.lblSaoDonGiaNgay.Name = "lblSaoDonGiaNgay";
            this.lblSaoDonGiaNgay.Size = new System.Drawing.Size(15, 20);
            this.lblSaoDonGiaNgay.TabIndex = 6;
            this.lblSaoDonGiaNgay.Text = "*";
            // 
            // nudDonGiaNgay
            // 
            this.nudDonGiaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDonGiaNgay.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudDonGiaNgay.Location = new System.Drawing.Point(153, 93);
            this.nudDonGiaNgay.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudDonGiaNgay.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDonGiaNgay.Name = "nudDonGiaNgay";
            this.nudDonGiaNgay.Size = new System.Drawing.Size(202, 27);
            this.nudDonGiaNgay.TabIndex = 7;
            this.nudDonGiaNgay.ThousandsSeparator = true;
            this.nudDonGiaNgay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblGoiYDonGia
            // 
            this.lblGoiYDonGia.AutoSize = true;
            this.lblGoiYDonGia.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblGoiYDonGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblGoiYDonGia.Location = new System.Drawing.Point(153, 123);
            this.lblGoiYDonGia.Name = "lblGoiYDonGia";
            this.lblGoiYDonGia.Size = new System.Drawing.Size(353, 19);
            this.lblGoiYDonGia.TabIndex = 8;
            this.lblGoiYDonGia.Text = "Đơn giá mới chỉ áp dụng cho lượt thuê tạo sau khi lưu.";
            this.lblGoiYDonGia.Visible = false;
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.Location = new System.Drawing.Point(11, 151);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(51, 20);
            this.lblMoTa.TabIndex = 9;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(153, 147);
            this.txtMoTa.MaxLength = 255;
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(524, 59);
            this.txtMoTa.TabIndex = 10;
            // 
            // chkDangHoatDong
            // 
            this.chkDangHoatDong.AutoSize = true;
            this.chkDangHoatDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkDangHoatDong.Location = new System.Drawing.Point(153, 216);
            this.chkDangHoatDong.Name = "chkDangHoatDong";
            this.chkDangHoatDong.Size = new System.Drawing.Size(158, 28);
            this.chkDangHoatDong.TabIndex = 11;
            this.chkDangHoatDong.Text = "Đang hoạt động";
            this.chkDangHoatDong.UseVisualStyleBackColor = true;
            // 
            // lblSoKhongGian
            // 
            this.lblSoKhongGian.AutoSize = true;
            this.lblSoKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoKhongGian.Location = new System.Drawing.Point(11, 248);
            this.lblSoKhongGian.Name = "lblSoKhongGian";
            this.lblSoKhongGian.Size = new System.Drawing.Size(107, 20);
            this.lblSoKhongGian.TabIndex = 12;
            this.lblSoKhongGian.Text = "Số không gian:";
            // 
            // txtSoKhongGian
            // 
            this.txtSoKhongGian.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSoKhongGian.Location = new System.Drawing.Point(153, 245);
            this.txtSoKhongGian.Name = "txtSoKhongGian";
            this.txtSoKhongGian.ReadOnly = true;
            this.txtSoKhongGian.Size = new System.Drawing.Size(151, 27);
            this.txtSoKhongGian.TabIndex = 13;
            this.txtSoKhongGian.TabStop = false;
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
            this.pnlChucNang.Location = new System.Drawing.Point(820, 386);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(688, 39);
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
            // frmLoaiKhongGian
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
            this.Name = "frmLoaiKhongGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Loại không gian và đơn giá";
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDonGiaNgay)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblGoiYTuKhoa;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLoaiKhongGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoKhongGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDangHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhienBan;
        private System.Windows.Forms.Label lblSoBanGhi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaLoaiKhongGian;
        private System.Windows.Forms.TextBox txtMaLoaiKhongGian;
        private System.Windows.Forms.Label lblTenLoai;
        private System.Windows.Forms.Label lblSaoTenLoai;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.Label lblDonGiaNgay;
        private System.Windows.Forms.Label lblSaoDonGiaNgay;
        private System.Windows.Forms.NumericUpDown nudDonGiaNgay;
        private System.Windows.Forms.Label lblGoiYDonGia;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.CheckBox chkDangHoatDong;
        private System.Windows.Forms.Label lblSoKhongGian;
        private System.Windows.Forms.TextBox txtSoKhongGian;
        private System.Windows.Forms.FlowLayoutPanel pnlChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
    }
}
