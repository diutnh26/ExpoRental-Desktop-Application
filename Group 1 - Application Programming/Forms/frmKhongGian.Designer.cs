namespace Group_1___Application_Programming.Forms
{
    partial class frmKhongGian
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
            this.lblLocKhuVuc = new System.Windows.Forms.Label();
            this.cboLocKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblLocLoai = new System.Windows.Forms.Label();
            this.cboLocLoai = new System.Windows.Forms.ComboBox();
            this.lblLocTrangThai = new System.Windows.Forms.Label();
            this.cboLocTrangThai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.lblSoBanGhi = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblMaKhongGian = new System.Windows.Forms.Label();
            this.txtMaKhongGian = new System.Windows.Forms.TextBox();
            this.lblTenKhongGian = new System.Windows.Forms.Label();
            this.lblSaoTenKhongGian = new System.Windows.Forms.Label();
            this.txtTenKhongGian = new System.Windows.Forms.TextBox();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.lblSaoKhuVuc = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblLoaiKhongGian = new System.Windows.Forms.Label();
            this.lblSaoLoaiKhongGian = new System.Windows.Forms.Label();
            this.cboLoaiKhongGian = new System.Windows.Forms.ComboBox();
            this.lblDonGiaNgay = new System.Windows.Forms.Label();
            this.txtDonGiaNgay = new System.Windows.Forms.TextBox();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.lblSaoDienTich = new System.Windows.Forms.Label();
            this.nudDienTich = new System.Windows.Forms.NumericUpDown();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.chkDangHoatDong = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudDienTich)).BeginInit();
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
            this.grpTimKiem.Controls.Add(this.lblLocKhuVuc);
            this.grpTimKiem.Controls.Add(this.cboLocKhuVuc);
            this.grpTimKiem.Controls.Add(this.lblLocLoai);
            this.grpTimKiem.Controls.Add(this.cboLocLoai);
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
            this.txtTuKhoa.Size = new System.Drawing.Size(192, 27);
            this.txtTuKhoa.TabIndex = 1;
            // 
            // lblGoiYTuKhoa
            // 
            this.lblGoiYTuKhoa.AutoSize = true;
            this.lblGoiYTuKhoa.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.lblGoiYTuKhoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblGoiYTuKhoa.Location = new System.Drawing.Point(82, 55);
            this.lblGoiYTuKhoa.Name = "lblGoiYTuKhoa";
            this.lblGoiYTuKhoa.Size = new System.Drawing.Size(130, 19);
            this.lblGoiYTuKhoa.TabIndex = 2;
            this.lblGoiYTuKhoa.Text = "Mã, tên không gian";
            // 
            // lblLocKhuVuc
            // 
            this.lblLocKhuVuc.AutoSize = true;
            this.lblLocKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocKhuVuc.Location = new System.Drawing.Point(295, 29);
            this.lblLocKhuVuc.Name = "lblLocKhuVuc";
            this.lblLocKhuVuc.Size = new System.Drawing.Size(64, 20);
            this.lblLocKhuVuc.TabIndex = 3;
            this.lblLocKhuVuc.Text = "Khu vực:";
            // 
            // cboLocKhuVuc
            // 
            this.cboLocKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocKhuVuc.FormattingEnabled = true;
            this.cboLocKhuVuc.Location = new System.Drawing.Point(366, 25);
            this.cboLocKhuVuc.Name = "cboLocKhuVuc";
            this.cboLocKhuVuc.Size = new System.Drawing.Size(151, 28);
            this.cboLocKhuVuc.TabIndex = 4;
            // 
            // lblLocLoai
            // 
            this.lblLocLoai.AutoSize = true;
            this.lblLocLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocLoai.Location = new System.Drawing.Point(538, 29);
            this.lblLocLoai.Name = "lblLocLoai";
            this.lblLocLoai.Size = new System.Drawing.Size(40, 20);
            this.lblLocLoai.TabIndex = 5;
            this.lblLocLoai.Text = "Loại:";
            // 
            // cboLocLoai
            // 
            this.cboLocLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocLoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocLoai.FormattingEnabled = true;
            this.cboLocLoai.Location = new System.Drawing.Point(578, 25);
            this.cboLocLoai.Name = "cboLocLoai";
            this.cboLocLoai.Size = new System.Drawing.Size(182, 28);
            this.cboLocLoai.TabIndex = 6;
            // 
            // lblLocTrangThai
            // 
            this.lblLocTrangThai.AutoSize = true;
            this.lblLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLocTrangThai.Location = new System.Drawing.Point(781, 29);
            this.lblLocTrangThai.Name = "lblLocTrangThai";
            this.lblLocTrangThai.Size = new System.Drawing.Size(79, 20);
            this.lblLocTrangThai.TabIndex = 7;
            this.lblLocTrangThai.Text = "Tình trạng:";
            // 
            // cboLocTrangThai
            // 
            this.cboLocTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocTrangThai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLocTrangThai.FormattingEnabled = true;
            this.cboLocTrangThai.Location = new System.Drawing.Point(862, 25);
            this.cboLocTrangThai.Name = "cboLocTrangThai";
            this.cboLocTrangThai.Size = new System.Drawing.Size(162, 28);
            this.cboLocTrangThai.TabIndex = 8;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.Location = new System.Drawing.Point(1044, 24);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(72, 29);
            this.btnTimKiem.TabIndex = 9;
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
            this.grpThongTin.Controls.Add(this.lblMaKhongGian);
            this.grpThongTin.Controls.Add(this.txtMaKhongGian);
            this.grpThongTin.Controls.Add(this.lblTenKhongGian);
            this.grpThongTin.Controls.Add(this.lblSaoTenKhongGian);
            this.grpThongTin.Controls.Add(this.txtTenKhongGian);
            this.grpThongTin.Controls.Add(this.lblKhuVuc);
            this.grpThongTin.Controls.Add(this.lblSaoKhuVuc);
            this.grpThongTin.Controls.Add(this.cboKhuVuc);
            this.grpThongTin.Controls.Add(this.lblLoaiKhongGian);
            this.grpThongTin.Controls.Add(this.lblSaoLoaiKhongGian);
            this.grpThongTin.Controls.Add(this.cboLoaiKhongGian);
            this.grpThongTin.Controls.Add(this.lblDonGiaNgay);
            this.grpThongTin.Controls.Add(this.txtDonGiaNgay);
            this.grpThongTin.Controls.Add(this.lblDienTich);
            this.grpThongTin.Controls.Add(this.lblSaoDienTich);
            this.grpThongTin.Controls.Add(this.nudDienTich);
            this.grpThongTin.Controls.Add(this.lblMoTa);
            this.grpThongTin.Controls.Add(this.txtMoTa);
            this.grpThongTin.Controls.Add(this.chkDangHoatDong);
            this.grpThongTin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongTin.Location = new System.Drawing.Point(820, 94);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(688, 322);
            this.grpThongTin.TabIndex = 3;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin không gian";
            // 
            // lblMaKhongGian
            // 
            this.lblMaKhongGian.AutoSize = true;
            this.lblMaKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaKhongGian.Location = new System.Drawing.Point(11, 34);
            this.lblMaKhongGian.Name = "lblMaKhongGian";
            this.lblMaKhongGian.Size = new System.Drawing.Size(111, 20);
            this.lblMaKhongGian.TabIndex = 0;
            this.lblMaKhongGian.Text = "Mã không gian:";
            // 
            // txtMaKhongGian
            // 
            this.txtMaKhongGian.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKhongGian.Location = new System.Drawing.Point(153, 31);
            this.txtMaKhongGian.MaxLength = 10;
            this.txtMaKhongGian.Name = "txtMaKhongGian";
            this.txtMaKhongGian.ReadOnly = true;
            this.txtMaKhongGian.Size = new System.Drawing.Size(151, 27);
            this.txtMaKhongGian.TabIndex = 1;
            this.txtMaKhongGian.TabStop = false;
            // 
            // lblTenKhongGian
            // 
            this.lblTenKhongGian.AutoSize = true;
            this.lblTenKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKhongGian.Location = new System.Drawing.Point(11, 66);
            this.lblTenKhongGian.Name = "lblTenKhongGian";
            this.lblTenKhongGian.Size = new System.Drawing.Size(113, 20);
            this.lblTenKhongGian.TabIndex = 2;
            this.lblTenKhongGian.Text = "Tên không gian:";
            // 
            // lblSaoTenKhongGian
            // 
            this.lblSaoTenKhongGian.AutoSize = true;
            this.lblSaoTenKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoTenKhongGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoTenKhongGian.Location = new System.Drawing.Point(110, 66);
            this.lblSaoTenKhongGian.Name = "lblSaoTenKhongGian";
            this.lblSaoTenKhongGian.Size = new System.Drawing.Size(15, 20);
            this.lblSaoTenKhongGian.TabIndex = 3;
            this.lblSaoTenKhongGian.Text = "*";
            // 
            // txtTenKhongGian
            // 
            this.txtTenKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhongGian.Location = new System.Drawing.Point(153, 62);
            this.txtTenKhongGian.MaxLength = 100;
            this.txtTenKhongGian.Name = "txtTenKhongGian";
            this.txtTenKhongGian.Size = new System.Drawing.Size(524, 27);
            this.txtTenKhongGian.TabIndex = 4;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhuVuc.Location = new System.Drawing.Point(11, 97);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(64, 20);
            this.lblKhuVuc.TabIndex = 5;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // lblSaoKhuVuc
            // 
            this.lblSaoKhuVuc.AutoSize = true;
            this.lblSaoKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoKhuVuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoKhuVuc.Location = new System.Drawing.Point(66, 97);
            this.lblSaoKhuVuc.Name = "lblSaoKhuVuc";
            this.lblSaoKhuVuc.Size = new System.Drawing.Size(15, 20);
            this.lblSaoKhuVuc.TabIndex = 6;
            this.lblSaoKhuVuc.Text = "*";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(153, 93);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(242, 28);
            this.cboKhuVuc.TabIndex = 7;
            // 
            // lblLoaiKhongGian
            // 
            this.lblLoaiKhongGian.AutoSize = true;
            this.lblLoaiKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiKhongGian.Location = new System.Drawing.Point(11, 128);
            this.lblLoaiKhongGian.Name = "lblLoaiKhongGian";
            this.lblLoaiKhongGian.Size = new System.Drawing.Size(118, 20);
            this.lblLoaiKhongGian.TabIndex = 8;
            this.lblLoaiKhongGian.Text = "Loại không gian:";
            // 
            // lblSaoLoaiKhongGian
            // 
            this.lblSaoLoaiKhongGian.AutoSize = true;
            this.lblSaoLoaiKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoLoaiKhongGian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoLoaiKhongGian.Location = new System.Drawing.Point(114, 128);
            this.lblSaoLoaiKhongGian.Name = "lblSaoLoaiKhongGian";
            this.lblSaoLoaiKhongGian.Size = new System.Drawing.Size(15, 20);
            this.lblSaoLoaiKhongGian.TabIndex = 9;
            this.lblSaoLoaiKhongGian.Text = "*";
            // 
            // cboLoaiKhongGian
            // 
            this.cboLoaiKhongGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboLoaiKhongGian.FormattingEnabled = true;
            this.cboLoaiKhongGian.Location = new System.Drawing.Point(153, 124);
            this.cboLoaiKhongGian.Name = "cboLoaiKhongGian";
            this.cboLoaiKhongGian.Size = new System.Drawing.Size(242, 28);
            this.cboLoaiKhongGian.TabIndex = 10;
            // 
            // lblDonGiaNgay
            // 
            this.lblDonGiaNgay.AutoSize = true;
            this.lblDonGiaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDonGiaNgay.Location = new System.Drawing.Point(11, 159);
            this.lblDonGiaNgay.Name = "lblDonGiaNgay";
            this.lblDonGiaNgay.Size = new System.Drawing.Size(103, 20);
            this.lblDonGiaNgay.TabIndex = 11;
            this.lblDonGiaNgay.Text = "Đơn giá/ngày:";
            // 
            // txtDonGiaNgay
            // 
            this.txtDonGiaNgay.BackColor = System.Drawing.SystemColors.Control;
            this.txtDonGiaNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDonGiaNgay.Location = new System.Drawing.Point(153, 155);
            this.txtDonGiaNgay.Name = "txtDonGiaNgay";
            this.txtDonGiaNgay.ReadOnly = true;
            this.txtDonGiaNgay.Size = new System.Drawing.Size(151, 27);
            this.txtDonGiaNgay.TabIndex = 12;
            this.txtDonGiaNgay.TabStop = false;
            this.txtDonGiaNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDienTich.Location = new System.Drawing.Point(11, 190);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(104, 20);
            this.lblDienTich.TabIndex = 13;
            this.lblDienTich.Text = "Diện tích (m²):";
            // 
            // lblSaoDienTich
            // 
            this.lblSaoDienTich.AutoSize = true;
            this.lblSaoDienTich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoDienTich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoDienTich.Location = new System.Drawing.Point(100, 190);
            this.lblSaoDienTich.Name = "lblSaoDienTich";
            this.lblSaoDienTich.Size = new System.Drawing.Size(15, 20);
            this.lblSaoDienTich.TabIndex = 14;
            this.lblSaoDienTich.Text = "*";
            // 
            // nudDienTich
            // 
            this.nudDienTich.DecimalPlaces = 2;
            this.nudDienTich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nudDienTich.Location = new System.Drawing.Point(153, 186);
            this.nudDienTich.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            131072});
            this.nudDienTich.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.nudDienTich.Name = "nudDienTich";
            this.nudDienTich.Size = new System.Drawing.Size(152, 27);
            this.nudDienTich.TabIndex = 15;
            this.nudDienTich.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoTa.Location = new System.Drawing.Point(11, 221);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(51, 20);
            this.lblMoTa.TabIndex = 16;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMoTa.Location = new System.Drawing.Point(153, 217);
            this.txtMoTa.MaxLength = 255;
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(524, 59);
            this.txtMoTa.TabIndex = 17;
            // 
            // chkDangHoatDong
            // 
            this.chkDangHoatDong.AutoSize = true;
            this.chkDangHoatDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkDangHoatDong.Location = new System.Drawing.Point(153, 286);
            this.chkDangHoatDong.Name = "chkDangHoatDong";
            this.chkDangHoatDong.Size = new System.Drawing.Size(158, 28);
            this.chkDangHoatDong.TabIndex = 18;
            this.chkDangHoatDong.Text = "Đang hoạt động";
            this.chkDangHoatDong.UseVisualStyleBackColor = true;
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
            this.pnlChucNang.Location = new System.Drawing.Point(820, 423);
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
            // frmKhongGian
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
            this.Name = "frmKhongGian";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Không gian triển lãm";
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDienTich)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.Label lblGoiYTuKhoa;
        private System.Windows.Forms.Label lblLocKhuVuc;
        private System.Windows.Forms.ComboBox cboLocKhuVuc;
        private System.Windows.Forms.Label lblLocLoai;
        private System.Windows.Forms.ComboBox cboLocLoai;
        private System.Windows.Forms.Label lblLocTrangThai;
        private System.Windows.Forms.ComboBox cboLocTrangThai;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvDanhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhongGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhongGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGiaNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuVucId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoaiKhongGianId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDangHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoTheDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhienBan;
        private System.Windows.Forms.Label lblSoBanGhi;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblMaKhongGian;
        private System.Windows.Forms.TextBox txtMaKhongGian;
        private System.Windows.Forms.Label lblTenKhongGian;
        private System.Windows.Forms.Label lblSaoTenKhongGian;
        private System.Windows.Forms.TextBox txtTenKhongGian;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.Label lblSaoKhuVuc;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label lblLoaiKhongGian;
        private System.Windows.Forms.Label lblSaoLoaiKhongGian;
        private System.Windows.Forms.ComboBox cboLoaiKhongGian;
        private System.Windows.Forms.Label lblDonGiaNgay;
        private System.Windows.Forms.TextBox txtDonGiaNgay;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.Label lblSaoDienTich;
        private System.Windows.Forms.NumericUpDown nudDienTich;
        private System.Windows.Forms.Label lblMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.CheckBox chkDangHoatDong;
        private System.Windows.Forms.FlowLayoutPanel pnlChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
    }
}
