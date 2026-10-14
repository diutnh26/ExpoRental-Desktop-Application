namespace Group_1___Application_Programming.Forms
{
    partial class frmBaoCaoDoanhThu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpDieuKien = new System.Windows.Forms.GroupBox();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.lblSaoTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.lblSaoDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.rdoTheoKhuVuc = new System.Windows.Forms.RadioButton();
            this.rdoTheoThang = new System.Windows.Forms.RadioButton();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvBaoCao = new System.Windows.Forms.DataGridView();
            this.lblSoBanGhi = new System.Windows.Forms.Label();
            this.pnlTong = new System.Windows.Forms.Panel();
            this.lblNhanTongThu = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblNhanTongHoan = new System.Windows.Forms.Label();
            this.lblTongHoan = new System.Windows.Forms.Label();
            this.lblNhanDoanhThuThuan = new System.Windows.Forms.Label();
            this.lblDoanhThuThuan = new System.Windows.Forms.Label();
            this.grpDieuKien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).BeginInit();
            this.pnlTong.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDieuKien
            // 
            this.grpDieuKien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDieuKien.Controls.Add(this.lblTuNgay);
            this.grpDieuKien.Controls.Add(this.lblSaoTuNgay);
            this.grpDieuKien.Controls.Add(this.dtpTuNgay);
            this.grpDieuKien.Controls.Add(this.lblDenNgay);
            this.grpDieuKien.Controls.Add(this.lblSaoDenNgay);
            this.grpDieuKien.Controls.Add(this.dtpDenNgay);
            this.grpDieuKien.Controls.Add(this.rdoTheoKhuVuc);
            this.grpDieuKien.Controls.Add(this.rdoTheoThang);
            this.grpDieuKien.Controls.Add(this.btnXem);
            this.grpDieuKien.Controls.Add(this.btnLamMoi);
            this.grpDieuKien.Controls.Add(this.btnDong);
            this.grpDieuKien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDieuKien.Location = new System.Drawing.Point(9, 6);
            this.grpDieuKien.Name = "grpDieuKien";
            this.grpDieuKien.Size = new System.Drawing.Size(1332, 58);
            this.grpDieuKien.TabIndex = 0;
            this.grpDieuKien.TabStop = false;
            this.grpDieuKien.Text = "Điều kiện báo cáo";
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTuNgay.Location = new System.Drawing.Point(10, 26);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(65, 20);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày:";
            // 
            // lblSaoTuNgay
            // 
            this.lblSaoTuNgay.AutoSize = true;
            this.lblSaoTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoTuNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoTuNgay.Location = new System.Drawing.Point(59, 26);
            this.lblSaoTuNgay.Name = "lblSaoTuNgay";
            this.lblSaoTuNgay.Size = new System.Drawing.Size(15, 20);
            this.lblSaoTuNgay.TabIndex = 1;
            this.lblSaoTuNgay.Text = "*";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(82, 22);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(108, 27);
            this.dtpTuNgay.TabIndex = 2;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDenNgay.Location = new System.Drawing.Point(208, 26);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(75, 20);
            this.lblDenNgay.TabIndex = 3;
            this.lblDenNgay.Text = "Đến ngày:";
            // 
            // lblSaoDenNgay
            // 
            this.lblSaoDenNgay.AutoSize = true;
            this.lblSaoDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoDenNgay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoDenNgay.Location = new System.Drawing.Point(264, 26);
            this.lblSaoDenNgay.Name = "lblSaoDenNgay";
            this.lblSaoDenNgay.Size = new System.Drawing.Size(15, 20);
            this.lblSaoDenNgay.TabIndex = 4;
            this.lblSaoDenNgay.Text = "*";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(289, 22);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(108, 27);
            this.dtpDenNgay.TabIndex = 5;
            // 
            // rdoTheoKhuVuc
            // 
            this.rdoTheoKhuVuc.AutoSize = true;
            this.rdoTheoKhuVuc.Checked = true;
            this.rdoTheoKhuVuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoTheoKhuVuc.Location = new System.Drawing.Point(433, 24);
            this.rdoTheoKhuVuc.Name = "rdoTheoKhuVuc";
            this.rdoTheoKhuVuc.Size = new System.Drawing.Size(159, 24);
            this.rdoTheoKhuVuc.TabIndex = 6;
            this.rdoTheoKhuVuc.TabStop = true;
            this.rdoTheoKhuVuc.Text = "Nhóm theo khu vực";
            this.rdoTheoKhuVuc.UseVisualStyleBackColor = true;
            // 
            // rdoTheoThang
            // 
            this.rdoTheoThang.AutoSize = true;
            this.rdoTheoThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rdoTheoThang.Location = new System.Drawing.Point(604, 24);
            this.rdoTheoThang.Name = "rdoTheoThang";
            this.rdoTheoThang.Size = new System.Drawing.Size(147, 24);
            this.rdoTheoThang.TabIndex = 7;
            this.rdoTheoThang.Text = "Nhóm theo tháng";
            this.rdoTheoThang.UseVisualStyleBackColor = true;
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXem.ForeColor = System.Drawing.Color.White;
            this.btnXem.Location = new System.Drawing.Point(784, 20);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(116, 29);
            this.btnXem.TabIndex = 8;
            this.btnXem.Text = "Xem báo cáo";
            this.btnXem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.Location = new System.Drawing.Point(906, 20);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(84, 29);
            this.btnLamMoi.TabIndex = 9;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.Location = new System.Drawing.Point(996, 19);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(71, 29);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // dgvBaoCao
            // 
            this.dgvBaoCao.AllowUserToAddRows = false;
            this.dgvBaoCao.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvBaoCao.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBaoCao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBaoCao.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBaoCao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvBaoCao.ColumnHeadersHeight = 26;
            this.dgvBaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBaoCao.Location = new System.Drawing.Point(9, 72);
            this.dgvBaoCao.MultiSelect = false;
            this.dgvBaoCao.Name = "dgvBaoCao";
            this.dgvBaoCao.ReadOnly = true;
            this.dgvBaoCao.RowHeadersVisible = false;
            this.dgvBaoCao.RowHeadersWidth = 51;
            this.dgvBaoCao.RowTemplate.Height = 24;
            this.dgvBaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCao.Size = new System.Drawing.Size(1332, 440);
            this.dgvBaoCao.TabIndex = 1;
            // 
            // lblSoBanGhi
            // 
            this.lblSoBanGhi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSoBanGhi.Location = new System.Drawing.Point(9, 518);
            this.lblSoBanGhi.Name = "lblSoBanGhi";
            this.lblSoBanGhi.Size = new System.Drawing.Size(600, 17);
            this.lblSoBanGhi.TabIndex = 2;
            // 
            // pnlTong
            // 
            this.pnlTong.Controls.Add(this.lblNhanTongThu);
            this.pnlTong.Controls.Add(this.lblTongThu);
            this.pnlTong.Controls.Add(this.lblNhanTongHoan);
            this.pnlTong.Controls.Add(this.lblTongHoan);
            this.pnlTong.Controls.Add(this.lblNhanDoanhThuThuan);
            this.pnlTong.Controls.Add(this.lblDoanhThuThuan);
            this.pnlTong.Location = new System.Drawing.Point(9, 540);
            this.pnlTong.Name = "pnlTong";
            this.pnlTong.Size = new System.Drawing.Size(1332, 34);
            this.pnlTong.TabIndex = 3;
            // 
            // lblNhanTongThu
            // 
            this.lblNhanTongThu.AutoSize = true;
            this.lblNhanTongThu.Location = new System.Drawing.Point(12, 9);
            this.lblNhanTongThu.Name = "lblNhanTongThu";
            this.lblNhanTongThu.Size = new System.Drawing.Size(71, 20);
            this.lblNhanTongThu.TabIndex = 0;
            this.lblNhanTongThu.Text = "Tổng thu:";
            // 
            // lblTongThu
            // 
            this.lblTongThu.Location = new System.Drawing.Point(78, 9);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(130, 17);
            this.lblTongThu.TabIndex = 1;
            // 
            // lblNhanTongHoan
            // 
            this.lblNhanTongHoan.AutoSize = true;
            this.lblNhanTongHoan.Location = new System.Drawing.Point(526, 9);
            this.lblNhanTongHoan.Name = "lblNhanTongHoan";
            this.lblNhanTongHoan.Size = new System.Drawing.Size(83, 20);
            this.lblNhanTongHoan.TabIndex = 2;
            this.lblNhanTongHoan.Text = "Tổng hoàn:";
            // 
            // lblTongHoan
            // 
            this.lblTongHoan.Location = new System.Drawing.Point(600, 9);
            this.lblTongHoan.Name = "lblTongHoan";
            this.lblTongHoan.Size = new System.Drawing.Size(130, 17);
            this.lblTongHoan.TabIndex = 3;
            // 
            // lblNhanDoanhThuThuan
            // 
            this.lblNhanDoanhThuThuan.AutoSize = true;
            this.lblNhanDoanhThuThuan.Location = new System.Drawing.Point(918, 9);
            this.lblNhanDoanhThuThuan.Name = "lblNhanDoanhThuThuan";
            this.lblNhanDoanhThuThuan.Size = new System.Drawing.Size(122, 20);
            this.lblNhanDoanhThuThuan.TabIndex = 4;
            this.lblNhanDoanhThuThuan.Text = "Doanh thu thuần:";
            // 
            // lblDoanhThuThuan
            // 
            this.lblDoanhThuThuan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuThuan.Location = new System.Drawing.Point(1022, 9);
            this.lblDoanhThuThuan.Name = "lblDoanhThuThuan";
            this.lblDoanhThuThuan.Size = new System.Drawing.Size(160, 17);
            this.lblDoanhThuThuan.TabIndex = 5;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.pnlTong);
            this.Controls.Add(this.lblSoBanGhi);
            this.Controls.Add(this.dgvBaoCao);
            this.Controls.Add(this.grpDieuKien);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.KeyPreview = true;
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu";
            this.grpDieuKien.ResumeLayout(false);
            this.grpDieuKien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCao)).EndInit();
            this.pnlTong.ResumeLayout(false);
            this.pnlTong.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDieuKien;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.Label lblSaoTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.Label lblSaoDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.RadioButton rdoTheoKhuVuc;
        private System.Windows.Forms.RadioButton rdoTheoThang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuotThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongHoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoanhThuThuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKhuVucId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThang;
        private System.Windows.Forms.Label lblSoBanGhi;
        private System.Windows.Forms.Panel pnlTong;
        private System.Windows.Forms.Label lblNhanTongThu;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblNhanTongHoan;
        private System.Windows.Forms.Label lblTongHoan;
        private System.Windows.Forms.Label lblNhanDoanhThuThuan;
        private System.Windows.Forms.Label lblDoanhThuThuan;
    }
}
