namespace Group_1___Application_Programming.Forms
{
    partial class frmLyDoXoa
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
            this.lblCanhBao = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lblLyDoXoa = new System.Windows.Forms.Label();
            this.lblSaoLyDoXoa = new System.Windows.Forms.Label();
            this.txtLyDoXoa = new System.Windows.Forms.TextBox();
            this.btnXacNhanXoa = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCanhBao
            // 
            this.lblCanhBao.AutoSize = true;
            this.lblCanhBao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblCanhBao.Location = new System.Drawing.Point(9, 14);
            this.lblCanhBao.Name = "lblCanhBao";
            this.lblCanhBao.Size = new System.Drawing.Size(341, 15);
            this.lblCanhBao.TabIndex = 0;
            this.lblCanhBao.Text = "Khách hàng sẽ bị xóa vĩnh viễn. Lý do xóa được lưu vào nhật ký.";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(9, 49);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(73, 15);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.txtKhachHang.Location = new System.Drawing.Point(108, 46);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(342, 23);
            this.txtKhachHang.TabIndex = 2;
            this.txtKhachHang.TabStop = false;
            // 
            // lblLyDoXoa
            // 
            this.lblLyDoXoa.AutoSize = true;
            this.lblLyDoXoa.Location = new System.Drawing.Point(9, 84);
            this.lblLyDoXoa.Name = "lblLyDoXoa";
            this.lblLyDoXoa.Size = new System.Drawing.Size(59, 15);
            this.lblLyDoXoa.TabIndex = 3;
            this.lblLyDoXoa.Text = "Lý do xóa:";
            // 
            // lblSaoLyDoXoa
            // 
            this.lblSaoLyDoXoa.AutoSize = true;
            this.lblSaoLyDoXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblSaoLyDoXoa.Location = new System.Drawing.Point(64, 84);
            this.lblSaoLyDoXoa.Name = "lblSaoLyDoXoa";
            this.lblSaoLyDoXoa.Size = new System.Drawing.Size(12, 15);
            this.lblSaoLyDoXoa.TabIndex = 4;
            this.lblSaoLyDoXoa.Text = "*";
            // 
            // txtLyDoXoa
            // 
            this.txtLyDoXoa.Location = new System.Drawing.Point(108, 81);
            this.txtLyDoXoa.MaxLength = 500;
            this.txtLyDoXoa.Multiline = true;
            this.txtLyDoXoa.Name = "txtLyDoXoa";
            this.txtLyDoXoa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLyDoXoa.Size = new System.Drawing.Size(342, 160);
            this.txtLyDoXoa.TabIndex = 5;
            // 
            // btnXacNhanXoa
            // 
            this.btnXacNhanXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnXacNhanXoa.Location = new System.Drawing.Point(234, 258);
            this.btnXacNhanXoa.Name = "btnXacNhanXoa";
            this.btnXacNhanXoa.Size = new System.Drawing.Size(110, 30);
            this.btnXacNhanXoa.TabIndex = 6;
            this.btnXacNhanXoa.Text = "Xác nhận xóa";
            this.btnXacNhanXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(352, 258);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(98, 30);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Hủy bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // frmLyDoXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 300);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnXacNhanXoa);
            this.Controls.Add(this.txtLyDoXoa);
            this.Controls.Add(this.lblSaoLyDoXoa);
            this.Controls.Add(this.lblLyDoXoa);
            this.Controls.Add(this.txtKhachHang);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblCanhBao);
            this.CancelButton = this.btnHuyBo;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLyDoXoa";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xóa khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCanhBao;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label lblLyDoXoa;
        private System.Windows.Forms.Label lblSaoLyDoXoa;
        private System.Windows.Forms.TextBox txtLyDoXoa;
        private System.Windows.Forms.Button btnXacNhanXoa;
        private System.Windows.Forms.Button btnHuyBo;
    }
}
