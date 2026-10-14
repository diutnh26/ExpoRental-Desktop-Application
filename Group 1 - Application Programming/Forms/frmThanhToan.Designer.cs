namespace Group_1___Application_Programming.Forms
{
    partial class frmThanhToan
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
            this.grpLuotThue = new System.Windows.Forms.GroupBox();
            this.lblMaLuotThue = new System.Windows.Forms.Label();
            this.txtMaLuotThue = new System.Windows.Forms.TextBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.txtTenKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhongGian = new System.Windows.Forms.Label();
            this.txtKhongGian = new System.Windows.Forms.TextBox();
            this.grpGiaoDich = new System.Windows.Forms.GroupBox();
            this.lblLoaiThanhToan = new System.Windows.Forms.Label();
            this.txtLoaiThanhToan = new System.Windows.Forms.TextBox();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.lblSaoPhuongThuc = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnGhiNhan = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.grpLuotThue.SuspendLayout();
            this.grpGiaoDich.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLuotThue
            // 
            this.grpLuotThue.Controls.Add(this.lblMaLuotThue);
            this.grpLuotThue.Controls.Add(this.txtMaLuotThue);
            this.grpLuotThue.Controls.Add(this.lblTenKhachHang);
            this.grpLuotThue.Controls.Add(this.txtTenKhachHang);
            this.grpLuotThue.Controls.Add(this.lblKhongGian);
            this.grpLuotThue.Controls.Add(this.txtKhongGian);
            this.grpLuotThue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpLuotThue.Location = new System.Drawing.Point(9, 6);
            this.grpLuotThue.Name = "grpLuotThue";
            this.grpLuotThue.Size = new System.Drawing.Size(442, 112);
            this.grpLuotThue.TabIndex = 0;
            this.grpLuotThue.TabStop = false;
            this.grpLuotThue.Text = "Lượt thuê";
            // 
            // lblMaLuotThue
            // 
            this.lblMaLuotThue.AutoSize = true;
            this.lblMaLuotThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMaLuotThue.Location = new System.Drawing.Point(10, 27);
            this.lblMaLuotThue.Name = "lblMaLuotThue";
            this.lblMaLuotThue.Size = new System.Drawing.Size(61, 15);
            this.lblMaLuotThue.TabIndex = 0;
            this.lblMaLuotThue.Text = "Lượt thuê:";
            // 
            // txtMaLuotThue
            // 
            this.txtMaLuotThue.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaLuotThue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaLuotThue.Location = new System.Drawing.Point(120, 24);
            this.txtMaLuotThue.Name = "txtMaLuotThue";
            this.txtMaLuotThue.ReadOnly = true;
            this.txtMaLuotThue.Size = new System.Drawing.Size(310, 23);
            this.txtMaLuotThue.TabIndex = 1;
            this.txtMaLuotThue.TabStop = false;
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTenKhachHang.Location = new System.Drawing.Point(10, 54);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(73, 15);
            this.lblTenKhachHang.TabIndex = 2;
            this.lblTenKhachHang.Text = "Khách hàng:";
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKhachHang.Location = new System.Drawing.Point(120, 51);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.ReadOnly = true;
            this.txtTenKhachHang.Size = new System.Drawing.Size(310, 23);
            this.txtTenKhachHang.TabIndex = 3;
            this.txtTenKhachHang.TabStop = false;
            // 
            // lblKhongGian
            // 
            this.lblKhongGian.AutoSize = true;
            this.lblKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKhongGian.Location = new System.Drawing.Point(10, 81);
            this.lblKhongGian.Name = "lblKhongGian";
            this.lblKhongGian.Size = new System.Drawing.Size(71, 15);
            this.lblKhongGian.TabIndex = 4;
            this.lblKhongGian.Text = "Không gian:";
            // 
            // txtKhongGian
            // 
            this.txtKhongGian.BackColor = System.Drawing.SystemColors.Control;
            this.txtKhongGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtKhongGian.Location = new System.Drawing.Point(120, 78);
            this.txtKhongGian.Name = "txtKhongGian";
            this.txtKhongGian.ReadOnly = true;
            this.txtKhongGian.Size = new System.Drawing.Size(310, 23);
            this.txtKhongGian.TabIndex = 5;
            this.txtKhongGian.TabStop = false;
            // 
            // grpGiaoDich
            // 
            this.grpGiaoDich.Controls.Add(this.lblLoaiThanhToan);
            this.grpGiaoDich.Controls.Add(this.txtLoaiThanhToan);
            this.grpGiaoDich.Controls.Add(this.lblSoTien);
            this.grpGiaoDich.Controls.Add(this.txtSoTien);
            this.grpGiaoDich.Controls.Add(this.lblPhuongThuc);
            this.grpGiaoDich.Controls.Add(this.lblSaoPhuongThuc);
            this.grpGiaoDich.Controls.Add(this.cboPhuongThuc);
            this.grpGiaoDich.Controls.Add(this.lblGhiChu);
            this.grpGiaoDich.Controls.Add(this.txtGhiChu);
            this.grpGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpGiaoDich.Location = new System.Drawing.Point(9, 124);
            this.grpGiaoDich.Name = "grpGiaoDich";
            this.grpGiaoDich.Size = new System.Drawing.Size(442, 190);
            this.grpGiaoDich.TabIndex = 1;
            this.grpGiaoDich.TabStop = false;
            this.grpGiaoDich.Text = "Giao dịch";
            // 
            // lblLoaiThanhToan
            // 
            this.lblLoaiThanhToan.AutoSize = true;
            this.lblLoaiThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLoaiThanhToan.Location = new System.Drawing.Point(10, 27);
            this.lblLoaiThanhToan.Name = "lblLoaiThanhToan";
            this.lblLoaiThanhToan.Size = new System.Drawing.Size(93, 15);
            this.lblLoaiThanhToan.TabIndex = 0;
            this.lblLoaiThanhToan.Text = "Loại thanh toán:";
            // 
            // txtLoaiThanhToan
            // 
            this.txtLoaiThanhToan.BackColor = System.Drawing.SystemColors.Control;
            this.txtLoaiThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoaiThanhToan.Location = new System.Drawing.Point(120, 24);
            this.txtLoaiThanhToan.Name = "txtLoaiThanhToan";
            this.txtLoaiThanhToan.ReadOnly = true;
            this.txtLoaiThanhToan.Size = new System.Drawing.Size(310, 23);
            this.txtLoaiThanhToan.TabIndex = 1;
            this.txtLoaiThanhToan.TabStop = false;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSoTien.Location = new System.Drawing.Point(10, 58);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(46, 15);
            this.lblSoTien.TabIndex = 2;
            this.lblSoTien.Text = "Số tiền:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtSoTien.Location = new System.Drawing.Point(120, 51);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(310, 23);
            this.txtSoTien.TabIndex = 3;
            this.txtSoTien.TabStop = false;
            this.txtSoTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPhuongThuc.Location = new System.Drawing.Point(10, 91);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(79, 15);
            this.lblPhuongThuc.TabIndex = 4;
            this.lblPhuongThuc.Text = "Phương thức:";
            // 
            // lblSaoPhuongThuc
            // 
            this.lblSaoPhuongThuc.AutoSize = true;
            this.lblSaoPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSaoPhuongThuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoPhuongThuc.Location = new System.Drawing.Point(85, 91);
            this.lblSaoPhuongThuc.Name = "lblSaoPhuongThuc";
            this.lblSaoPhuongThuc.Size = new System.Drawing.Size(12, 15);
            this.lblSaoPhuongThuc.TabIndex = 5;
            this.lblSaoPhuongThuc.Text = "*";
            // 
            // cboPhuongThuc
            // 
            this.cboPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhuongThuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboPhuongThuc.FormattingEnabled = true;
            this.cboPhuongThuc.Location = new System.Drawing.Point(120, 88);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(310, 23);
            this.cboPhuongThuc.TabIndex = 6;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblGhiChu.Location = new System.Drawing.Point(10, 118);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(51, 15);
            this.lblGhiChu.TabIndex = 7;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(120, 115);
            this.txtGhiChu.MaxLength = 255;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGhiChu.Size = new System.Drawing.Size(310, 62);
            this.txtGhiChu.TabIndex = 8;
            // 
            // btnGhiNhan
            // 
            this.btnGhiNhan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnGhiNhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGhiNhan.ForeColor = System.Drawing.Color.White;
            this.btnGhiNhan.Location = new System.Drawing.Point(247, 322);
            this.btnGhiNhan.Name = "btnGhiNhan";
            this.btnGhiNhan.Size = new System.Drawing.Size(100, 30);
            this.btnGhiNhan.TabIndex = 2;
            this.btnGhiNhan.Text = "Ghi nhận";
            this.btnGhiNhan.UseVisualStyleBackColor = false;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(355, 322);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(96, 30);
            this.btnHuyBo.TabIndex = 3;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 360);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnGhiNhan);
            this.Controls.Add(this.grpGiaoDich);
            this.Controls.Add(this.grpLuotThue);
            this.AcceptButton = this.btnGhiNhan;
            this.CancelButton = this.btnHuyBo;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThanhToan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ghi nhận thanh toán";
            this.grpLuotThue.ResumeLayout(false);
            this.grpLuotThue.PerformLayout();
            this.grpGiaoDich.ResumeLayout(false);
            this.grpGiaoDich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLuotThue;
        private System.Windows.Forms.Label lblMaLuotThue;
        private System.Windows.Forms.TextBox txtMaLuotThue;
        private System.Windows.Forms.Label lblTenKhachHang;
        private System.Windows.Forms.TextBox txtTenKhachHang;
        private System.Windows.Forms.Label lblKhongGian;
        private System.Windows.Forms.TextBox txtKhongGian;
        private System.Windows.Forms.GroupBox grpGiaoDich;
        private System.Windows.Forms.Label lblLoaiThanhToan;
        private System.Windows.Forms.TextBox txtLoaiThanhToan;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.Label lblSaoPhuongThuc;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnGhiNhan;
        private System.Windows.Forms.Button btnHuyBo;
    }
}
