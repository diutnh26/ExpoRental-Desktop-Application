namespace Group_1___Application_Programming.Forms
{
    partial class frmTongQuan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpChonThang = new System.Windows.Forms.GroupBox();
            this.lblThang = new System.Windows.Forms.Label();
            this.dtpThang = new System.Windows.Forms.DateTimePicker();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grpChiSo = new System.Windows.Forms.GroupBox();
            this.lblNhanCongSuat = new System.Windows.Forms.Label();
            this.lblCongSuat = new System.Windows.Forms.Label();
            this.lblNhanSoNgay = new System.Windows.Forms.Label();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.lblNhanSoKhongGian = new System.Windows.Forms.Label();
            this.lblSoKhongGian = new System.Windows.Forms.Label();
            this.lblNhanTongThu = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.lblNhanTongHoan = new System.Windows.Forms.Label();
            this.lblTongHoan = new System.Windows.Forms.Label();
            this.lblNhanDoanhThuThuan = new System.Windows.Forms.Label();
            this.lblDoanhThuThuan = new System.Windows.Forms.Label();
            this.dgvCongSuatKhuVuc = new System.Windows.Forms.DataGridView();
            this.dgvDoanhThu6Thang = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.grpChonThang.SuspendLayout();
            this.grpChiSo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongSuatKhuVuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu6Thang)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChonThang
            // 
            this.grpChonThang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChonThang.Controls.Add(this.lblThang);
            this.grpChonThang.Controls.Add(this.dtpThang);
            this.grpChonThang.Controls.Add(this.btnXem);
            this.grpChonThang.Controls.Add(this.btnLamMoi);
            this.grpChonThang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpChonThang.Location = new System.Drawing.Point(10, 7);
            this.grpChonThang.Name = "grpChonThang";
            this.grpChonThang.Size = new System.Drawing.Size(1498, 67);
            this.grpChonThang.TabIndex = 0;
            this.grpChonThang.TabStop = false;
            this.grpChonThang.Text = "Chọn tháng";
            // 
            // lblThang
            // 
            this.lblThang.AutoSize = true;
            this.lblThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblThang.Location = new System.Drawing.Point(11, 30);
            this.lblThang.Name = "lblThang";
            this.lblThang.Size = new System.Drawing.Size(53, 20);
            this.lblThang.TabIndex = 0;
            this.lblThang.Text = "Tháng:";
            // 
            // dtpThang
            // 
            this.dtpThang.CustomFormat = "MM/yyyy";
            this.dtpThang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThang.Location = new System.Drawing.Point(72, 25);
            this.dtpThang.Name = "dtpThang";
            this.dtpThang.ShowUpDown = true;
            this.dtpThang.Size = new System.Drawing.Size(121, 27);
            this.dtpThang.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXem.Location = new System.Drawing.Point(214, 24);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(81, 29);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLamMoi.Location = new System.Drawing.Point(305, 24);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(91, 29);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // grpChiSo
            // 
            this.grpChiSo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChiSo.Controls.Add(this.lblNhanCongSuat);
            this.grpChiSo.Controls.Add(this.lblCongSuat);
            this.grpChiSo.Controls.Add(this.lblNhanSoNgay);
            this.grpChiSo.Controls.Add(this.lblSoNgay);
            this.grpChiSo.Controls.Add(this.lblNhanSoKhongGian);
            this.grpChiSo.Controls.Add(this.lblSoKhongGian);
            this.grpChiSo.Controls.Add(this.lblNhanTongThu);
            this.grpChiSo.Controls.Add(this.lblTongThu);
            this.grpChiSo.Controls.Add(this.lblNhanTongHoan);
            this.grpChiSo.Controls.Add(this.lblTongHoan);
            this.grpChiSo.Controls.Add(this.lblNhanDoanhThuThuan);
            this.grpChiSo.Controls.Add(this.lblDoanhThuThuan);
            this.grpChiSo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpChiSo.Location = new System.Drawing.Point(10, 80);
            this.grpChiSo.Name = "grpChiSo";
            this.grpChiSo.Size = new System.Drawing.Size(1498, 120);
            this.grpChiSo.TabIndex = 1;
            this.grpChiSo.TabStop = false;
            this.grpChiSo.Text = "Chỉ số trong tháng";
            // 
            // lblNhanCongSuat
            // 
            this.lblNhanCongSuat.AutoSize = true;
            this.lblNhanCongSuat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanCongSuat.Location = new System.Drawing.Point(11, 34);
            this.lblNhanCongSuat.Name = "lblNhanCongSuat";
            this.lblNhanCongSuat.Size = new System.Drawing.Size(92, 23);
            this.lblNhanCongSuat.TabIndex = 0;
            this.lblNhanCongSuat.Text = "Công suất:";
            // 
            // lblCongSuat
            // 
            this.lblCongSuat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCongSuat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.lblCongSuat.Location = new System.Drawing.Point(15, 62);
            this.lblCongSuat.Name = "lblCongSuat";
            this.lblCongSuat.Size = new System.Drawing.Size(158, 46);
            this.lblCongSuat.TabIndex = 1;
            // 
            // lblNhanSoNgay
            // 
            this.lblNhanSoNgay.AutoSize = true;
            this.lblNhanSoNgay.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanSoNgay.Location = new System.Drawing.Point(177, 34);
            this.lblNhanSoNgay.Name = "lblNhanSoNgay";
            this.lblNhanSoNgay.Size = new System.Drawing.Size(207, 23);
            this.lblNhanSoNgay.TabIndex = 2;
            this.lblNhanSoNgay.Text = "Ngày đã thuê / khả dụng:";
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoNgay.Location = new System.Drawing.Point(181, 67);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(255, 39);
            this.lblSoNgay.TabIndex = 3;
            // 
            // lblNhanSoKhongGian
            // 
            this.lblNhanSoKhongGian.AutoSize = true;
            this.lblNhanSoKhongGian.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanSoKhongGian.Location = new System.Drawing.Point(453, 34);
            this.lblNhanSoKhongGian.Name = "lblNhanSoKhongGian";
            this.lblNhanSoKhongGian.Size = new System.Drawing.Size(209, 23);
            this.lblNhanSoKhongGian.TabIndex = 4;
            this.lblNhanSoKhongGian.Text = "Số không gian hoạt động:";
            // 
            // lblSoKhongGian
            // 
            this.lblSoKhongGian.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSoKhongGian.Location = new System.Drawing.Point(457, 67);
            this.lblSoKhongGian.Name = "lblSoKhongGian";
            this.lblSoKhongGian.Size = new System.Drawing.Size(229, 39);
            this.lblSoKhongGian.TabIndex = 5;
            // 
            // lblNhanTongThu
            // 
            this.lblNhanTongThu.AutoSize = true;
            this.lblNhanTongThu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanTongThu.Location = new System.Drawing.Point(735, 34);
            this.lblNhanTongThu.Name = "lblNhanTongThu";
            this.lblNhanTongThu.Size = new System.Drawing.Size(84, 23);
            this.lblNhanTongThu.TabIndex = 6;
            this.lblNhanTongThu.Text = "Tổng thu:";
            // 
            // lblTongThu
            // 
            this.lblTongThu.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongThu.Location = new System.Drawing.Point(739, 67);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(219, 39);
            this.lblTongThu.TabIndex = 7;
            // 
            // lblNhanTongHoan
            // 
            this.lblNhanTongHoan.AutoSize = true;
            this.lblNhanTongHoan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanTongHoan.Location = new System.Drawing.Point(967, 34);
            this.lblNhanTongHoan.Name = "lblNhanTongHoan";
            this.lblNhanTongHoan.Size = new System.Drawing.Size(97, 23);
            this.lblNhanTongHoan.TabIndex = 8;
            this.lblNhanTongHoan.Text = "Tổng hoàn:";
            // 
            // lblTongHoan
            // 
            this.lblTongHoan.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTongHoan.Location = new System.Drawing.Point(971, 67);
            this.lblTongHoan.Name = "lblTongHoan";
            this.lblTongHoan.Size = new System.Drawing.Size(223, 39);
            this.lblTongHoan.TabIndex = 9;
            // 
            // lblNhanDoanhThuThuan
            // 
            this.lblNhanDoanhThuThuan.AutoSize = true;
            this.lblNhanDoanhThuThuan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNhanDoanhThuThuan.Location = new System.Drawing.Point(1204, 34);
            this.lblNhanDoanhThuThuan.Name = "lblNhanDoanhThuThuan";
            this.lblNhanDoanhThuThuan.Size = new System.Drawing.Size(146, 23);
            this.lblNhanDoanhThuThuan.TabIndex = 10;
            this.lblNhanDoanhThuThuan.Text = "Doanh thu thuần:";
            // 
            // lblDoanhThuThuan
            // 
            this.lblDoanhThuThuan.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuThuan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.lblDoanhThuThuan.Location = new System.Drawing.Point(1208, 62);
            this.lblDoanhThuThuan.Name = "lblDoanhThuThuan";
            this.lblDoanhThuThuan.Size = new System.Drawing.Size(269, 46);
            this.lblDoanhThuThuan.TabIndex = 11;
            // 
            // dgvCongSuatKhuVuc
            // 
            this.dgvCongSuatKhuVuc.AllowUserToAddRows = false;
            this.dgvCongSuatKhuVuc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvCongSuatKhuVuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCongSuatKhuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCongSuatKhuVuc.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCongSuatKhuVuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCongSuatKhuVuc.ColumnHeadersHeight = 26;
            this.dgvCongSuatKhuVuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCongSuatKhuVuc.Location = new System.Drawing.Point(10, 212);
            this.dgvCongSuatKhuVuc.MultiSelect = false;
            this.dgvCongSuatKhuVuc.Name = "dgvCongSuatKhuVuc";
            this.dgvCongSuatKhuVuc.ReadOnly = true;
            this.dgvCongSuatKhuVuc.RowHeadersVisible = false;
            this.dgvCongSuatKhuVuc.RowHeadersWidth = 51;
            this.dgvCongSuatKhuVuc.RowTemplate.Height = 24;
            this.dgvCongSuatKhuVuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongSuatKhuVuc.Size = new System.Drawing.Size(749, 421);
            this.dgvCongSuatKhuVuc.TabIndex = 2;
            // 
            // dgvDoanhThu6Thang
            // 
            this.dgvDoanhThu6Thang.AllowUserToAddRows = false;
            this.dgvDoanhThu6Thang.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvDoanhThu6Thang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDoanhThu6Thang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoanhThu6Thang.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoanhThu6Thang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDoanhThu6Thang.ColumnHeadersHeight = 26;
            this.dgvDoanhThu6Thang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDoanhThu6Thang.Location = new System.Drawing.Point(770, 212);
            this.dgvDoanhThu6Thang.MultiSelect = false;
            this.dgvDoanhThu6Thang.Name = "dgvDoanhThu6Thang";
            this.dgvDoanhThu6Thang.ReadOnly = true;
            this.dgvDoanhThu6Thang.RowHeadersVisible = false;
            this.dgvDoanhThu6Thang.RowHeadersWidth = 51;
            this.dgvDoanhThu6Thang.RowTemplate.Height = 24;
            this.dgvDoanhThu6Thang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoanhThu6Thang.Size = new System.Drawing.Size(739, 421);
            this.dgvDoanhThu6Thang.TabIndex = 3;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDong.Location = new System.Drawing.Point(1428, 644);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(81, 34);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // frmTongQuan
            // 
            this.AcceptButton = this.btnXem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 690);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDoanhThu6Thang);
            this.Controls.Add(this.dgvCongSuatKhuVuc);
            this.Controls.Add(this.grpChiSo);
            this.Controls.Add(this.grpChonThang);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.KeyPreview = true;
            this.Name = "frmTongQuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tổng quan";
            this.grpChonThang.ResumeLayout(false);
            this.grpChonThang.PerformLayout();
            this.grpChiSo.ResumeLayout(false);
            this.grpChiSo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongSuatKhuVuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoanhThu6Thang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChonThang;
        private System.Windows.Forms.Label lblThang;
        private System.Windows.Forms.DateTimePicker dtpThang;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grpChiSo;
        private System.Windows.Forms.Label lblNhanCongSuat;
        private System.Windows.Forms.Label lblCongSuat;
        private System.Windows.Forms.Label lblNhanSoNgay;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.Label lblNhanSoKhongGian;
        private System.Windows.Forms.Label lblSoKhongGian;
        private System.Windows.Forms.Label lblNhanTongThu;
        private System.Windows.Forms.Label lblTongThu;
        private System.Windows.Forms.Label lblNhanTongHoan;
        private System.Windows.Forms.Label lblTongHoan;
        private System.Windows.Forms.Label lblNhanDoanhThuThuan;
        private System.Windows.Forms.Label lblDoanhThuThuan;
        private System.Windows.Forms.DataGridView dgvCongSuatKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsTenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsSoKhongGianHoatDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsSoNgayKhaDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsSoNgayDaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsCongSuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCsKhuVucId;
        private System.Windows.Forms.DataGridView dgvDoanhThu6Thang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtNhanThang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtSoLuotThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtTongThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtTongHoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDtDoanhThuThuan;
        private System.Windows.Forms.Button btnDong;
    }
}
