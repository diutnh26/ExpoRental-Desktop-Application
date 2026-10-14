namespace Group_1___Application_Programming.Forms
{
    partial class frmDangNhap
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.lblPhuDe = new System.Windows.Forms.Label();
            this.lblTenDangNhap = new System.Windows.Forms.Label();
            this.lblSaoTenDangNhap = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.lblSaoMatKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTieuDe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTieuDe.Location = new System.Drawing.Point(146, 34);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(340, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // lblPhuDe
            // 
            this.lblPhuDe.AutoSize = true;
            this.lblPhuDe.Location = new System.Drawing.Point(177, 72);
            this.lblPhuDe.Name = "lblPhuDe";
            this.lblPhuDe.Size = new System.Drawing.Size(261, 20);
            this.lblPhuDe.TabIndex = 1;
            this.lblPhuDe.Text = "Quản lý cho thuê không gian triển lãm";
            // 
            // lblTenDangNhap
            // 
            this.lblTenDangNhap.AutoSize = true;
            this.lblTenDangNhap.Location = new System.Drawing.Point(53, 122);
            this.lblTenDangNhap.Name = "lblTenDangNhap";
            this.lblTenDangNhap.Size = new System.Drawing.Size(110, 20);
            this.lblTenDangNhap.TabIndex = 2;
            this.lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblSaoTenDangNhap
            // 
            this.lblSaoTenDangNhap.AutoSize = true;
            this.lblSaoTenDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoTenDangNhap.Location = new System.Drawing.Point(136, 122);
            this.lblSaoTenDangNhap.Name = "lblSaoTenDangNhap";
            this.lblSaoTenDangNhap.Size = new System.Drawing.Size(15, 20);
            this.lblSaoTenDangNhap.TabIndex = 3;
            this.lblSaoTenDangNhap.Text = "*";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(169, 119);
            this.txtTenDangNhap.MaxLength = 50;
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(247, 27);
            this.txtTenDangNhap.TabIndex = 4;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(53, 158);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(73, 20);
            this.lblMatKhau.TabIndex = 5;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // lblSaoMatKhau
            // 
            this.lblSaoMatKhau.AutoSize = true;
            this.lblSaoMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoMatKhau.Location = new System.Drawing.Point(111, 158);
            this.lblSaoMatKhau.Name = "lblSaoMatKhau";
            this.lblSaoMatKhau.Size = new System.Drawing.Size(15, 20);
            this.lblSaoMatKhau.TabIndex = 6;
            this.lblSaoMatKhau.Text = "*";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(169, 155);
            this.txtMatKhau.MaxLength = 50;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(247, 27);
            this.txtMatKhau.TabIndex = 7;
            this.txtMatKhau.UseSystemPasswordChar = true;
            // 
            // chkHienMatKhau
            // 
            this.chkHienMatKhau.AutoSize = true;
            this.chkHienMatKhau.Location = new System.Drawing.Point(169, 190);
            this.chkHienMatKhau.Name = "chkHienMatKhau";
            this.chkHienMatKhau.Size = new System.Drawing.Size(127, 24);
            this.chkHienMatKhau.TabIndex = 8;
            this.chkHienMatKhau.Text = "Hiện mật khẩu";
            this.chkHienMatKhau.UseVisualStyleBackColor = true;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(208, 228);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(121, 30);
            this.btnDangNhap.TabIndex = 9;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(335, 228);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 30);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group_1___Application_Programming.Properties.Resources.museum;
            this.pictureBox1.Location = new System.Drawing.Point(31, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(476, 280);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.chkHienMatKhau);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblSaoMatKhau);
            this.Controls.Add(this.lblMatKhau);
            this.Controls.Add(this.txtTenDangNhap);
            this.Controls.Add(this.lblSaoTenDangNhap);
            this.Controls.Add(this.lblTenDangNhap);
            this.Controls.Add(this.lblPhuDe);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblPhuDe;
        private System.Windows.Forms.Label lblTenDangNhap;
        private System.Windows.Forms.Label lblSaoTenDangNhap;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Label lblSaoMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkHienMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
