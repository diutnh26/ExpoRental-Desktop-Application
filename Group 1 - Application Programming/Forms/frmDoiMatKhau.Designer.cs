namespace Group_1___Application_Programming.Forms
{
    partial class frmDoiMatKhau
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
            this.lblMatKhauCu = new System.Windows.Forms.Label();
            this.lblSaoMatKhauCu = new System.Windows.Forms.Label();
            this.txtMatKhauCu = new System.Windows.Forms.TextBox();
            this.lblMatKhauMoi = new System.Windows.Forms.Label();
            this.lblSaoMatKhauMoi = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.lblXacNhanMatKhau = new System.Windows.Forms.Label();
            this.lblSaoXacNhanMatKhau = new System.Windows.Forms.Label();
            this.txtXacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMatKhauCu
            // 
            this.lblMatKhauCu.AutoSize = true;
            this.lblMatKhauCu.Location = new System.Drawing.Point(20, 33);
            this.lblMatKhauCu.Name = "lblMatKhauCu";
            this.lblMatKhauCu.Size = new System.Drawing.Size(102, 15);
            this.lblMatKhauCu.TabIndex = 0;
            this.lblMatKhauCu.Text = "Mật khẩu hiện tại:";
            // 
            // lblSaoMatKhauCu
            // 
            this.lblSaoMatKhauCu.AutoSize = true;
            this.lblSaoMatKhauCu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoMatKhauCu.Location = new System.Drawing.Point(118, 33);
            this.lblSaoMatKhauCu.Name = "lblSaoMatKhauCu";
            this.lblSaoMatKhauCu.Size = new System.Drawing.Size(12, 15);
            this.lblSaoMatKhauCu.TabIndex = 1;
            this.lblSaoMatKhauCu.Text = "*";
            // 
            // txtMatKhauCu
            // 
            this.txtMatKhauCu.Location = new System.Drawing.Point(190, 30);
            this.txtMatKhauCu.MaxLength = 50;
            this.txtMatKhauCu.Name = "txtMatKhauCu";
            this.txtMatKhauCu.Size = new System.Drawing.Size(184, 23);
            this.txtMatKhauCu.TabIndex = 2;
            this.txtMatKhauCu.UseSystemPasswordChar = true;
            // 
            // lblMatKhauMoi
            // 
            this.lblMatKhauMoi.AutoSize = true;
            this.lblMatKhauMoi.Location = new System.Drawing.Point(20, 69);
            this.lblMatKhauMoi.Name = "lblMatKhauMoi";
            this.lblMatKhauMoi.Size = new System.Drawing.Size(84, 15);
            this.lblMatKhauMoi.TabIndex = 3;
            this.lblMatKhauMoi.Text = "Mật khẩu mới:";
            // 
            // lblSaoMatKhauMoi
            // 
            this.lblSaoMatKhauMoi.AutoSize = true;
            this.lblSaoMatKhauMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoMatKhauMoi.Location = new System.Drawing.Point(100, 69);
            this.lblSaoMatKhauMoi.Name = "lblSaoMatKhauMoi";
            this.lblSaoMatKhauMoi.Size = new System.Drawing.Size(12, 15);
            this.lblSaoMatKhauMoi.TabIndex = 4;
            this.lblSaoMatKhauMoi.Text = "*";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(190, 66);
            this.txtMatKhauMoi.MaxLength = 50;
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(184, 23);
            this.txtMatKhauMoi.TabIndex = 5;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // lblXacNhanMatKhau
            // 
            this.lblXacNhanMatKhau.AutoSize = true;
            this.lblXacNhanMatKhau.Location = new System.Drawing.Point(20, 105);
            this.lblXacNhanMatKhau.Name = "lblXacNhanMatKhau";
            this.lblXacNhanMatKhau.Size = new System.Drawing.Size(136, 15);
            this.lblXacNhanMatKhau.TabIndex = 6;
            this.lblXacNhanMatKhau.Text = "Xác nhận mật khẩu mới:";
            // 
            // lblSaoXacNhanMatKhau
            // 
            this.lblSaoXacNhanMatKhau.AutoSize = true;
            this.lblSaoXacNhanMatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoXacNhanMatKhau.Location = new System.Drawing.Point(152, 105);
            this.lblSaoXacNhanMatKhau.Name = "lblSaoXacNhanMatKhau";
            this.lblSaoXacNhanMatKhau.Size = new System.Drawing.Size(12, 15);
            this.lblSaoXacNhanMatKhau.TabIndex = 7;
            this.lblSaoXacNhanMatKhau.Text = "*";
            // 
            // txtXacNhanMatKhau
            // 
            this.txtXacNhanMatKhau.Location = new System.Drawing.Point(190, 102);
            this.txtXacNhanMatKhau.MaxLength = 50;
            this.txtXacNhanMatKhau.Name = "txtXacNhanMatKhau";
            this.txtXacNhanMatKhau.Size = new System.Drawing.Size(184, 23);
            this.txtXacNhanMatKhau.TabIndex = 8;
            this.txtXacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(103)))), ((int)(((byte)(192)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(190, 176);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(82, 30);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(292, 176);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 30);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtXacNhanMatKhau);
            this.Controls.Add(this.lblSaoXacNhanMatKhau);
            this.Controls.Add(this.lblXacNhanMatKhau);
            this.Controls.Add(this.txtMatKhauMoi);
            this.Controls.Add(this.lblSaoMatKhauMoi);
            this.Controls.Add(this.lblMatKhauMoi);
            this.Controls.Add(this.txtMatKhauCu);
            this.Controls.Add(this.lblSaoMatKhauCu);
            this.Controls.Add(this.lblMatKhauCu);
            this.AcceptButton = this.btnLuu;
            this.CancelButton = this.btnHuy;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiMatKhau";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatKhauCu;
        private System.Windows.Forms.Label lblSaoMatKhauCu;
        private System.Windows.Forms.TextBox txtMatKhauCu;
        private System.Windows.Forms.Label lblMatKhauMoi;
        private System.Windows.Forms.Label lblSaoMatKhauMoi;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label lblXacNhanMatKhau;
        private System.Windows.Forms.Label lblSaoXacNhanMatKhau;
        private System.Windows.Forms.TextBox txtXacNhanMatKhau;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
