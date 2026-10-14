namespace Group_1___Application_Programming.Forms
{
    partial class frmLichDaDat
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
            this.grpBoLoc = new System.Windows.Forms.GroupBox();
            this.mclLich = new System.Windows.Forms.MonthCalendar();
            this.lblKhuVuc = new System.Windows.Forms.Label();
            this.cboKhuVuc = new System.Windows.Forms.ComboBox();
            this.lblChuThich = new System.Windows.Forms.Label();
            this.btnTuanTruoc = new System.Windows.Forms.Button();
            this.btnHomNay = new System.Windows.Forms.Button();
            this.btnTuanSau = new System.Windows.Forms.Button();
            this.grpThongKe = new System.Windows.Forms.GroupBox();
            this.grpTrongNgay = new System.Windows.Forms.GroupBox();
            this.lblNhanSoLuotTrongNgay = new System.Windows.Forms.Label();
            this.lblSoLuotTrongNgay = new System.Windows.Forms.Label();
            this.lblNhanSoBatDauTrongNgay = new System.Windows.Forms.Label();
            this.lblSoBatDauTrongNgay = new System.Windows.Forms.Label();
            this.lblNhanSoKetThucTrongNgay = new System.Windows.Forms.Label();
            this.lblSoKetThucTrongNgay = new System.Windows.Forms.Label();
            this.grpTrongTuan = new System.Windows.Forms.GroupBox();
            this.lblNhanSoLuotTrongTuan = new System.Windows.Forms.Label();
            this.lblSoLuotTrongTuan = new System.Windows.Forms.Label();
            this.lblNhanSoBatDauTrongTuan = new System.Windows.Forms.Label();
            this.lblSoBatDauTrongTuan = new System.Windows.Forms.Label();
            this.lblNhanSoKetThucTrongTuan = new System.Windows.Forms.Label();
            this.lblSoKetThucTrongTuan = new System.Windows.Forms.Label();
            this.lblTieuDeLuoi = new System.Windows.Forms.Label();
            this.dgvLuotThueTuan = new System.Windows.Forms.DataGridView();
            this.lblSoBanGhi = new System.Windows.Forms.Label();
            this.pnlChucNang = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXemChiTiet = new System.Windows.Forms.Button();
            this.grpBoLoc.SuspendLayout();
            this.grpThongKe.SuspendLayout();
            this.grpTrongNgay.SuspendLayout();
            this.grpTrongTuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuotThueTuan)).BeginInit();
            this.pnlChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoLoc
            // 
            this.grpBoLoc.Controls.Add(this.mclLich);
            this.grpBoLoc.Controls.Add(this.lblKhuVuc);
            this.grpBoLoc.Controls.Add(this.cboKhuVuc);
            this.grpBoLoc.Controls.Add(this.lblChuThich);
            this.grpBoLoc.Controls.Add(this.btnTuanTruoc);
            this.grpBoLoc.Controls.Add(this.btnHomNay);
            this.grpBoLoc.Controls.Add(this.btnTuanSau);
            this.grpBoLoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpBoLoc.Location = new System.Drawing.Point(10, 7);
            this.grpBoLoc.Name = "grpBoLoc";
            this.grpBoLoc.Size = new System.Drawing.Size(294, 380);
            this.grpBoLoc.TabIndex = 0;
            this.grpBoLoc.TabStop = false;
            this.grpBoLoc.Text = "Bộ lọc";
            // 
            // mclLich
            // 
            this.mclLich.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.mclLich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mclLich.Location = new System.Drawing.Point(11, 30);
            this.mclLich.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.mclLich.MaxSelectionCount = 1;
            this.mclLich.Name = "mclLich";
            this.mclLich.TabIndex = 0;
            // 
            // lblKhuVuc
            // 
            this.lblKhuVuc.AutoSize = true;
            this.lblKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhuVuc.Location = new System.Drawing.Point(11, 235);
            this.lblKhuVuc.Name = "lblKhuVuc";
            this.lblKhuVuc.Size = new System.Drawing.Size(64, 20);
            this.lblKhuVuc.TabIndex = 1;
            this.lblKhuVuc.Text = "Khu vực:";
            // 
            // cboKhuVuc
            // 
            this.cboKhuVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboKhuVuc.FormattingEnabled = true;
            this.cboKhuVuc.Location = new System.Drawing.Point(11, 258);
            this.cboKhuVuc.Name = "cboKhuVuc";
            this.cboKhuVuc.Size = new System.Drawing.Size(271, 28);
            this.cboKhuVuc.TabIndex = 2;
            // 
            // lblChuThich
            // 
            this.lblChuThich.AutoSize = true;
            this.lblChuThich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblChuThich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.lblChuThich.Location = new System.Drawing.Point(11, 294);
            this.lblChuThich.Name = "lblChuThich";
            this.lblChuThich.Size = new System.Drawing.Size(233, 20);
            this.lblChuThich.TabIndex = 3;
            this.lblChuThich.Text = "Ngày in đậm là ngày có lượt thuê.";
            // 
            // btnTuanTruoc
            // 
            this.btnTuanTruoc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTuanTruoc.Location = new System.Drawing.Point(11, 329);
            this.btnTuanTruoc.Name = "btnTuanTruoc";
            this.btnTuanTruoc.Size = new System.Drawing.Size(86, 31);
            this.btnTuanTruoc.TabIndex = 4;
            this.btnTuanTruoc.Text = "Tuần trước";
            this.btnTuanTruoc.UseVisualStyleBackColor = true;
            // 
            // btnHomNay
            // 
            this.btnHomNay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHomNay.Location = new System.Drawing.Point(104, 329);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(86, 31);
            this.btnHomNay.TabIndex = 5;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.UseVisualStyleBackColor = true;
            // 
            // btnTuanSau
            // 
            this.btnTuanSau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTuanSau.Location = new System.Drawing.Point(196, 329);
            this.btnTuanSau.Name = "btnTuanSau";
            this.btnTuanSau.Size = new System.Drawing.Size(87, 31);
            this.btnTuanSau.TabIndex = 6;
            this.btnTuanSau.Text = "Tuần sau";
            this.btnTuanSau.UseVisualStyleBackColor = true;
            // 
            // grpThongKe
            // 
            this.grpThongKe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpThongKe.Controls.Add(this.grpTrongNgay);
            this.grpThongKe.Controls.Add(this.grpTrongTuan);
            this.grpThongKe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpThongKe.Location = new System.Drawing.Point(314, 7);
            this.grpThongKe.Name = "grpThongKe";
            this.grpThongKe.Size = new System.Drawing.Size(1195, 152);
            this.grpThongKe.TabIndex = 1;
            this.grpThongKe.TabStop = false;
            this.grpThongKe.Text = "Thống kê";
            // 
            // grpTrongNgay
            // 
            this.grpTrongNgay.Controls.Add(this.lblNhanSoLuotTrongNgay);
            this.grpTrongNgay.Controls.Add(this.lblSoLuotTrongNgay);
            this.grpTrongNgay.Controls.Add(this.lblNhanSoBatDauTrongNgay);
            this.grpTrongNgay.Controls.Add(this.lblSoBatDauTrongNgay);
            this.grpTrongNgay.Controls.Add(this.lblNhanSoKetThucTrongNgay);
            this.grpTrongNgay.Controls.Add(this.lblSoKetThucTrongNgay);
            this.grpTrongNgay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTrongNgay.Location = new System.Drawing.Point(11, 25);
            this.grpTrongNgay.Name = "grpTrongNgay";
            this.grpTrongNgay.Size = new System.Drawing.Size(579, 115);
            this.grpTrongNgay.TabIndex = 0;
            this.grpTrongNgay.TabStop = false;
            this.grpTrongNgay.Text = "Trong ngày";
            // 
            // lblNhanSoLuotTrongNgay
            // 
            this.lblNhanSoLuotTrongNgay.AutoSize = true;
            this.lblNhanSoLuotTrongNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanSoLuotTrongNgay.Location = new System.Drawing.Point(11, 32);
            this.lblNhanSoLuotTrongNgay.Name = "lblNhanSoLuotTrongNgay";
            this.lblNhanSoLuotTrongNgay.Size = new System.Drawing.Size(125, 20);
            this.lblNhanSoLuotTrongNgay.TabIndex = 0;
            this.lblNhanSoLuotTrongNgay.Text = "Lượt thuê diễn ra:";
            // 
            // lblSoLuotTrongNgay
            // 
            this.lblSoLuotTrongNgay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoLuotTrongNgay.Location = new System.Drawing.Point(9, 60);
            this.lblSoLuotTrongNgay.Name = "lblSoLuotTrongNgay";
            this.lblSoLuotTrongNgay.Size = new System.Drawing.Size(169, 34);
            this.lblSoLuotTrongNgay.TabIndex = 1;
            this.lblSoLuotTrongNgay.Text = "0";
            // 
            // lblNhanSoBatDauTrongNgay
            // 
            this.lblNhanSoBatDauTrongNgay.AutoSize = true;
            this.lblNhanSoBatDauTrongNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanSoBatDauTrongNgay.Location = new System.Drawing.Point(200, 32);
            this.lblNhanSoBatDauTrongNgay.Name = "lblNhanSoBatDauTrongNgay";
            this.lblNhanSoBatDauTrongNgay.Size = new System.Drawing.Size(139, 20);
            this.lblNhanSoBatDauTrongNgay.TabIndex = 2;
            this.lblNhanSoBatDauTrongNgay.Text = "Bắt đầu trong ngày:";
            // 
            // lblSoBatDauTrongNgay
            // 
            this.lblSoBatDauTrongNgay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoBatDauTrongNgay.Location = new System.Drawing.Point(198, 60);
            this.lblSoBatDauTrongNgay.Name = "lblSoBatDauTrongNgay";
            this.lblSoBatDauTrongNgay.Size = new System.Drawing.Size(169, 34);
            this.lblSoBatDauTrongNgay.TabIndex = 3;
            this.lblSoBatDauTrongNgay.Text = "0";
            // 
            // lblNhanSoKetThucTrongNgay
            // 
            this.lblNhanSoKetThucTrongNgay.AutoSize = true;
            this.lblNhanSoKetThucTrongNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanSoKetThucTrongNgay.Location = new System.Drawing.Point(389, 32);
            this.lblNhanSoKetThucTrongNgay.Name = "lblNhanSoKetThucTrongNgay";
            this.lblNhanSoKetThucTrongNgay.Size = new System.Drawing.Size(142, 20);
            this.lblNhanSoKetThucTrongNgay.TabIndex = 4;
            this.lblNhanSoKetThucTrongNgay.Text = "Kết thúc trong ngày:";
            // 
            // lblSoKetThucTrongNgay
            // 
            this.lblSoKetThucTrongNgay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoKetThucTrongNgay.Location = new System.Drawing.Point(387, 60);
            this.lblSoKetThucTrongNgay.Name = "lblSoKetThucTrongNgay";
            this.lblSoKetThucTrongNgay.Size = new System.Drawing.Size(169, 34);
            this.lblSoKetThucTrongNgay.TabIndex = 5;
            this.lblSoKetThucTrongNgay.Text = "0";
            // 
            // grpTrongTuan
            // 
            this.grpTrongTuan.Controls.Add(this.lblNhanSoLuotTrongTuan);
            this.grpTrongTuan.Controls.Add(this.lblSoLuotTrongTuan);
            this.grpTrongTuan.Controls.Add(this.lblNhanSoBatDauTrongTuan);
            this.grpTrongTuan.Controls.Add(this.lblSoBatDauTrongTuan);
            this.grpTrongTuan.Controls.Add(this.lblNhanSoKetThucTrongTuan);
            this.grpTrongTuan.Controls.Add(this.lblSoKetThucTrongTuan);
            this.grpTrongTuan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpTrongTuan.Location = new System.Drawing.Point(602, 25);
            this.grpTrongTuan.Name = "grpTrongTuan";
            this.grpTrongTuan.Size = new System.Drawing.Size(579, 115);
            this.grpTrongTuan.TabIndex = 1;
            this.grpTrongTuan.TabStop = false;
            this.grpTrongTuan.Text = "Trong tuần";
            // 
            // lblNhanSoLuotTrongTuan
            // 
            this.lblNhanSoLuotTrongTuan.AutoSize = true;
            this.lblNhanSoLuotTrongTuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanSoLuotTrongTuan.Location = new System.Drawing.Point(11, 32);
            this.lblNhanSoLuotTrongTuan.Name = "lblNhanSoLuotTrongTuan";
            this.lblNhanSoLuotTrongTuan.Size = new System.Drawing.Size(125, 20);
            this.lblNhanSoLuotTrongTuan.TabIndex = 0;
            this.lblNhanSoLuotTrongTuan.Text = "Lượt thuê diễn ra:";
            // 
            // lblSoLuotTrongTuan
            // 
            this.lblSoLuotTrongTuan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoLuotTrongTuan.Location = new System.Drawing.Point(9, 60);
            this.lblSoLuotTrongTuan.Name = "lblSoLuotTrongTuan";
            this.lblSoLuotTrongTuan.Size = new System.Drawing.Size(169, 34);
            this.lblSoLuotTrongTuan.TabIndex = 1;
            this.lblSoLuotTrongTuan.Text = "0";
            // 
            // lblNhanSoBatDauTrongTuan
            // 
            this.lblNhanSoBatDauTrongTuan.AutoSize = true;
            this.lblNhanSoBatDauTrongTuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanSoBatDauTrongTuan.Location = new System.Drawing.Point(200, 32);
            this.lblNhanSoBatDauTrongTuan.Name = "lblNhanSoBatDauTrongTuan";
            this.lblNhanSoBatDauTrongTuan.Size = new System.Drawing.Size(136, 20);
            this.lblNhanSoBatDauTrongTuan.TabIndex = 2;
            this.lblNhanSoBatDauTrongTuan.Text = "Bắt đầu trong tuần:";
            // 
            // lblSoBatDauTrongTuan
            // 
            this.lblSoBatDauTrongTuan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoBatDauTrongTuan.Location = new System.Drawing.Point(198, 60);
            this.lblSoBatDauTrongTuan.Name = "lblSoBatDauTrongTuan";
            this.lblSoBatDauTrongTuan.Size = new System.Drawing.Size(169, 34);
            this.lblSoBatDauTrongTuan.TabIndex = 3;
            this.lblSoBatDauTrongTuan.Text = "0";
            // 
            // lblNhanSoKetThucTrongTuan
            // 
            this.lblNhanSoKetThucTrongTuan.AutoSize = true;
            this.lblNhanSoKetThucTrongTuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNhanSoKetThucTrongTuan.Location = new System.Drawing.Point(389, 32);
            this.lblNhanSoKetThucTrongTuan.Name = "lblNhanSoKetThucTrongTuan";
            this.lblNhanSoKetThucTrongTuan.Size = new System.Drawing.Size(139, 20);
            this.lblNhanSoKetThucTrongTuan.TabIndex = 4;
            this.lblNhanSoKetThucTrongTuan.Text = "Kết thúc trong tuần:";
            // 
            // lblSoKetThucTrongTuan
            // 
            this.lblSoKetThucTrongTuan.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSoKetThucTrongTuan.Location = new System.Drawing.Point(387, 60);
            this.lblSoKetThucTrongTuan.Name = "lblSoKetThucTrongTuan";
            this.lblSoKetThucTrongTuan.Size = new System.Drawing.Size(169, 34);
            this.lblSoKetThucTrongTuan.TabIndex = 5;
            this.lblSoKetThucTrongTuan.Text = "0";
            // 
            // lblTieuDeLuoi
            // 
            this.lblTieuDeLuoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTieuDeLuoi.Location = new System.Drawing.Point(314, 168);
            this.lblTieuDeLuoi.Name = "lblTieuDeLuoi";
            this.lblTieuDeLuoi.Size = new System.Drawing.Size(788, 20);
            this.lblTieuDeLuoi.TabIndex = 2;
            this.lblTieuDeLuoi.Text = "Lượt thuê trong tuần";
            // 
            // dgvLuotThueTuan
            // 
            this.dgvLuotThueTuan.AllowUserToAddRows = false;
            this.dgvLuotThueTuan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvLuotThueTuan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLuotThueTuan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuotThueTuan.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLuotThueTuan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLuotThueTuan.ColumnHeadersHeight = 26;
            this.dgvLuotThueTuan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLuotThueTuan.Location = new System.Drawing.Point(314, 193);
            this.dgvLuotThueTuan.MultiSelect = false;
            this.dgvLuotThueTuan.Name = "dgvLuotThueTuan";
            this.dgvLuotThueTuan.ReadOnly = true;
            this.dgvLuotThueTuan.RowHeadersVisible = false;
            this.dgvLuotThueTuan.RowHeadersWidth = 51;
            this.dgvLuotThueTuan.RowTemplate.Height = 24;
            this.dgvLuotThueTuan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuotThueTuan.Size = new System.Drawing.Size(1195, 428);
            this.dgvLuotThueTuan.TabIndex = 3;
            // 
            // lblSoBanGhi
            // 
            this.lblSoBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoBanGhi.AutoSize = true;
            this.lblSoBanGhi.Location = new System.Drawing.Point(314, 628);
            this.lblSoBanGhi.Name = "lblSoBanGhi";
            this.lblSoBanGhi.Size = new System.Drawing.Size(152, 23);
            this.lblSoBanGhi.TabIndex = 4;
            this.lblSoBanGhi.Text = "Tổng số: 0 bản ghi";
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlChucNang.Controls.Add(this.btnDong);
            this.pnlChucNang.Controls.Add(this.btnLamMoi);
            this.pnlChucNang.Controls.Add(this.btnXemChiTiet);
            this.pnlChucNang.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlChucNang.Location = new System.Drawing.Point(1198, 644);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(310, 39);
            this.pnlChucNang.TabIndex = 5;
            this.pnlChucNang.WrapContents = false;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(229, 3);
            this.btnDong.Margin = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 31);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(131, 3);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 31);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.Location = new System.Drawing.Point(6, 3);
            this.btnXemChiTiet.Margin = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Size = new System.Drawing.Size(118, 31);
            this.btnXemChiTiet.TabIndex = 2;
            this.btnXemChiTiet.Text = "Xem chi tiết";
            this.btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // frmLichDaDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 690);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.lblSoBanGhi);
            this.Controls.Add(this.dgvLuotThueTuan);
            this.Controls.Add(this.lblTieuDeLuoi);
            this.Controls.Add(this.grpThongKe);
            this.Controls.Add(this.grpBoLoc);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KeyPreview = true;
            this.Name = "frmLichDaDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý lịch đã đặt";
            this.grpBoLoc.ResumeLayout(false);
            this.grpBoLoc.PerformLayout();
            this.grpThongKe.ResumeLayout(false);
            this.grpTrongNgay.ResumeLayout(false);
            this.grpTrongNgay.PerformLayout();
            this.grpTrongTuan.ResumeLayout(false);
            this.grpTrongTuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuotThueTuan)).EndInit();
            this.pnlChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoLoc;
        private System.Windows.Forms.MonthCalendar mclLich;
        private System.Windows.Forms.Label lblKhuVuc;
        private System.Windows.Forms.ComboBox cboKhuVuc;
        private System.Windows.Forms.Label lblChuThich;
        private System.Windows.Forms.Button btnTuanTruoc;
        private System.Windows.Forms.Button btnHomNay;
        private System.Windows.Forms.Button btnTuanSau;
        private System.Windows.Forms.GroupBox grpThongKe;
        private System.Windows.Forms.GroupBox grpTrongNgay;
        private System.Windows.Forms.GroupBox grpTrongTuan;
        private System.Windows.Forms.Label lblNhanSoLuotTrongNgay;
        private System.Windows.Forms.Label lblSoLuotTrongNgay;
        private System.Windows.Forms.Label lblNhanSoBatDauTrongNgay;
        private System.Windows.Forms.Label lblSoBatDauTrongNgay;
        private System.Windows.Forms.Label lblNhanSoKetThucTrongNgay;
        private System.Windows.Forms.Label lblSoKetThucTrongNgay;
        private System.Windows.Forms.Label lblNhanSoLuotTrongTuan;
        private System.Windows.Forms.Label lblSoLuotTrongTuan;
        private System.Windows.Forms.Label lblNhanSoBatDauTrongTuan;
        private System.Windows.Forms.Label lblSoBatDauTrongTuan;
        private System.Windows.Forms.Label lblNhanSoKetThucTrongTuan;
        private System.Windows.Forms.Label lblSoKetThucTrongTuan;
        private System.Windows.Forms.Label lblTieuDeLuoi;
        private System.Windows.Forms.DataGridView dgvLuotThueTuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLuotThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhongGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSuKien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoNgayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThaiHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhongGianId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuVucId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDaThanhToanDu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTienThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhongGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaKhachHang;
        private System.Windows.Forms.Label lblSoBanGhi;
        private System.Windows.Forms.FlowLayoutPanel pnlChucNang;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemChiTiet;
    }
}
