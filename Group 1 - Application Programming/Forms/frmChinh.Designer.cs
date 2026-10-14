namespace Group_1___Application_Programming.Forms
{
    partial class frmChinh
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
            this.mnuChinh = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiKhongGian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhongGian = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuotThue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLichDaDat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTongQuan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanTri = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNguoiDung = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepLop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepNgang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXepDoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDongTatCa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsChinh = new System.Windows.Forms.ToolStrip();
            this.tslMoNhanh = new System.Windows.Forms.ToolStripLabel();
            this.tsbLuotThue = new System.Windows.Forms.ToolStripButton();
            this.tsbLichDaDat = new System.Windows.Forms.ToolStripButton();
            this.tsbKhachHang = new System.Windows.Forms.ToolStripButton();
            this.tsbTongQuan = new System.Windows.Forms.ToolStripButton();
            this.tsbBaoCao = new System.Windows.Forms.ToolStripButton();
            this.tsbDangXuat = new System.Windows.Forms.ToolStripButton();
            this.ssChinh = new System.Windows.Forms.StatusStrip();
            this.tsslNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslHomNay = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMayChu = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuChinh.SuspendLayout();
            this.tsChinh.SuspendLayout();
            this.ssChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuChinh
            // 
            this.mnuChinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.mnuChinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuNghiepVu,
            this.mnuBaoCao,
            this.mnuQuanTri,
            this.mnuCuaSo});
            this.mnuChinh.Location = new System.Drawing.Point(0, 0);
            this.mnuChinh.MdiWindowListItem = this.mnuCuaSo;
            this.mnuChinh.Name = "mnuChinh";
            this.mnuChinh.Size = new System.Drawing.Size(1350, 31);
            this.mnuChinh.TabIndex = 0;
            this.mnuChinh.Text = "mnuChinh";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiMatKhau,
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(96, 27);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDoiMatKhau
            // 
            this.mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            this.mnuDoiMatKhau.Size = new System.Drawing.Size(276, 28);
            this.mnuDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.L)));
            this.mnuDangXuat.Size = new System.Drawing.Size(276, 28);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(276, 28);
            this.mnuThoat.Text = "Thoát";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoaiKhongGian,
            this.mnuKhongGian,
            this.mnuKhachHang});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(103, 27);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuLoaiKhongGian
            // 
            this.mnuLoaiKhongGian.Name = "mnuLoaiKhongGian";
            this.mnuLoaiKhongGian.Size = new System.Drawing.Size(290, 28);
            this.mnuLoaiKhongGian.Text = "Loại không gian";
            // 
            // mnuKhongGian
            // 
            this.mnuKhongGian.Name = "mnuKhongGian";
            this.mnuKhongGian.Size = new System.Drawing.Size(290, 28);
            this.mnuKhongGian.Text = "Không gian";
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.K)));
            this.mnuKhachHang.Size = new System.Drawing.Size(290, 28);
            this.mnuKhachHang.Text = "Khách hàng";
            // 
            // mnuNghiepVu
            // 
            this.mnuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLuotThue,
            this.mnuLichDaDat});
            this.mnuNghiepVu.Name = "mnuNghiepVu";
            this.mnuNghiepVu.Size = new System.Drawing.Size(103, 27);
            this.mnuNghiepVu.Text = "Nghiệp vụ";
            // 
            // mnuLuotThue
            // 
            this.mnuLuotThue.Name = "mnuLuotThue";
            this.mnuLuotThue.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.mnuLuotThue.Size = new System.Drawing.Size(284, 28);
            this.mnuLuotThue.Text = "Lượt thuê";
            // 
            // mnuLichDaDat
            // 
            this.mnuLichDaDat.Name = "mnuLichDaDat";
            this.mnuLichDaDat.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.mnuLichDaDat.Size = new System.Drawing.Size(284, 28);
            this.mnuLichDaDat.Text = "Lịch đã đặt";
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTongQuan,
            this.mnuBaoCaoDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(85, 27);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuTongQuan
            // 
            this.mnuTongQuan.Name = "mnuTongQuan";
            this.mnuTongQuan.Size = new System.Drawing.Size(240, 28);
            this.mnuTongQuan.Text = "Tổng quan";
            // 
            // mnuBaoCaoDoanhThu
            // 
            this.mnuBaoCaoDoanhThu.Name = "mnuBaoCaoDoanhThu";
            this.mnuBaoCaoDoanhThu.Size = new System.Drawing.Size(240, 28);
            this.mnuBaoCaoDoanhThu.Text = "Báo cáo doanh thu";
            // 
            // mnuQuanTri
            // 
            this.mnuQuanTri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNguoiDung});
            this.mnuQuanTri.Name = "mnuQuanTri";
            this.mnuQuanTri.Size = new System.Drawing.Size(87, 27);
            this.mnuQuanTri.Text = "Quản trị";
            // 
            // mnuNguoiDung
            // 
            this.mnuNguoiDung.Name = "mnuNguoiDung";
            this.mnuNguoiDung.Size = new System.Drawing.Size(186, 28);
            this.mnuNguoiDung.Text = "Người dùng";
            // 
            // mnuCuaSo
            // 
            this.mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuXepLop,
            this.mnuXepNgang,
            this.mnuXepDoc,
            this.mnuDongTatCa});
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Size = new System.Drawing.Size(76, 27);
            this.mnuCuaSo.Text = "Cửa sổ";
            // 
            // mnuXepLop
            // 
            this.mnuXepLop.Name = "mnuXepLop";
            this.mnuXepLop.Size = new System.Drawing.Size(184, 28);
            this.mnuXepLop.Text = "Xếp lớp";
            // 
            // mnuXepNgang
            // 
            this.mnuXepNgang.Name = "mnuXepNgang";
            this.mnuXepNgang.Size = new System.Drawing.Size(184, 28);
            this.mnuXepNgang.Text = "Xếp ngang";
            // 
            // mnuXepDoc
            // 
            this.mnuXepDoc.Name = "mnuXepDoc";
            this.mnuXepDoc.Size = new System.Drawing.Size(184, 28);
            this.mnuXepDoc.Text = "Xếp dọc";
            // 
            // mnuDongTatCa
            // 
            this.mnuDongTatCa.Name = "mnuDongTatCa";
            this.mnuDongTatCa.Size = new System.Drawing.Size(184, 28);
            this.mnuDongTatCa.Text = "Đóng tất cả";
            // 
            // tsChinh
            // 
            this.tsChinh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsChinh.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsChinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMoNhanh,
            this.tsbLuotThue,
            this.tsbLichDaDat,
            this.tsbKhachHang,
            this.tsbTongQuan,
            this.tsbBaoCao,
            this.tsbDangXuat});
            this.tsChinh.Location = new System.Drawing.Point(0, 31);
            this.tsChinh.Name = "tsChinh";
            this.tsChinh.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tsChinh.Size = new System.Drawing.Size(1350, 36);
            this.tsChinh.TabIndex = 1;
            this.tsChinh.Text = "tsChinh";
            // 
            // tslMoNhanh
            // 
            this.tslMoNhanh.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tslMoNhanh.Name = "tslMoNhanh";
            this.tslMoNhanh.Size = new System.Drawing.Size(93, 27);
            this.tslMoNhanh.Text = "Mở nhanh:";
            // 
            // tsbLuotThue
            // 
            this.tsbLuotThue.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsbLuotThue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLuotThue.ImageTransparentColor = System.Drawing.Color.White;
            this.tsbLuotThue.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.tsbLuotThue.Name = "tsbLuotThue";
            this.tsbLuotThue.Size = new System.Drawing.Size(88, 27);
            this.tsbLuotThue.Text = "Lượt thuê";
            this.tsbLuotThue.Click += new System.EventHandler(this.tsbLuotThue_Click);
            // 
            // tsbLichDaDat
            // 
            this.tsbLichDaDat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsbLichDaDat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLichDaDat.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.tsbLichDaDat.Name = "tsbLichDaDat";
            this.tsbLichDaDat.Size = new System.Drawing.Size(98, 27);
            this.tsbLichDaDat.Text = "Lịch đã đặt";
            // 
            // tsbKhachHang
            // 
            this.tsbKhachHang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsbKhachHang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbKhachHang.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.tsbKhachHang.Name = "tsbKhachHang";
            this.tsbKhachHang.Size = new System.Drawing.Size(105, 27);
            this.tsbKhachHang.Text = "Khách hàng";
            // 
            // tsbTongQuan
            // 
            this.tsbTongQuan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsbTongQuan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTongQuan.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.tsbTongQuan.Name = "tsbTongQuan";
            this.tsbTongQuan.Size = new System.Drawing.Size(97, 27);
            this.tsbTongQuan.Text = "Tổng quan";
            // 
            // tsbBaoCao
            // 
            this.tsbBaoCao.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tsbBaoCao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBaoCao.Margin = new System.Windows.Forms.Padding(4, 1, 4, 2);
            this.tsbBaoCao.Name = "tsbBaoCao";
            this.tsbBaoCao.Size = new System.Drawing.Size(160, 27);
            this.tsbBaoCao.Text = "Báo cáo doanh thu";
            // 
            // tsbDangXuat
            // 
            this.tsbDangXuat.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDangXuat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDangXuat.Name = "tsbDangXuat";
            this.tsbDangXuat.Size = new System.Drawing.Size(93, 27);
            this.tsbDangXuat.Text = "Đăng xuất";
            // 
            // ssChinh
            // 
            this.ssChinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslNguoiDung,
            this.tsslHomNay,
            this.tsslMayChu});
            this.ssChinh.Location = new System.Drawing.Point(0, 573);
            this.ssChinh.Name = "ssChinh";
            this.ssChinh.Size = new System.Drawing.Size(1350, 29);
            this.ssChinh.TabIndex = 2;
            this.ssChinh.Text = "ssChinh";
            // 
            // tsslNguoiDung
            // 
            this.tsslNguoiDung.Margin = new System.Windows.Forms.Padding(6, 3, 6, 2);
            this.tsslNguoiDung.Name = "tsslNguoiDung";
            this.tsslNguoiDung.Size = new System.Drawing.Size(92, 24);
            this.tsslNguoiDung.Text = "Người dùng:";
            // 
            // tsslHomNay
            // 
            this.tsslHomNay.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslHomNay.Margin = new System.Windows.Forms.Padding(0, 3, 6, 2);
            this.tsslHomNay.Name = "tsslHomNay";
            this.tsslHomNay.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tsslHomNay.Size = new System.Drawing.Size(82, 24);
            this.tsslHomNay.Text = "Hôm nay:";
            // 
            // tsslMayChu
            // 
            this.tsslMayChu.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tsslMayChu.Margin = new System.Windows.Forms.Padding(0, 3, 6, 2);
            this.tsslMayChu.Name = "tsslMayChu";
            this.tsslMayChu.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tsslMayChu.Size = new System.Drawing.Size(77, 24);
            this.tsslMayChu.Text = "Máy chủ:";
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 602);
            this.Controls.Add(this.ssChinh);
            this.Controls.Add(this.tsChinh);
            this.Controls.Add(this.mnuChinh);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuChinh;
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "frmChinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cho thuê không gian triển lãm";
            this.mnuChinh.ResumeLayout(false);
            this.mnuChinh.PerformLayout();
            this.tsChinh.ResumeLayout(false);
            this.tsChinh.PerformLayout();
            this.ssChinh.ResumeLayout(false);
            this.ssChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuChinh;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMatKhau;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiKhongGian;
        private System.Windows.Forms.ToolStripMenuItem mnuKhongGian;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuLuotThue;
        private System.Windows.Forms.ToolStripMenuItem mnuLichDaDat;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuTongQuan;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanTri;
        private System.Windows.Forms.ToolStripMenuItem mnuNguoiDung;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuXepLop;
        private System.Windows.Forms.ToolStripMenuItem mnuXepNgang;
        private System.Windows.Forms.ToolStripMenuItem mnuXepDoc;
        private System.Windows.Forms.ToolStripMenuItem mnuDongTatCa;
        private System.Windows.Forms.ToolStrip tsChinh;
        private System.Windows.Forms.ToolStripLabel tslMoNhanh;
        private System.Windows.Forms.ToolStripButton tsbLuotThue;
        private System.Windows.Forms.ToolStripButton tsbLichDaDat;
        private System.Windows.Forms.ToolStripButton tsbKhachHang;
        private System.Windows.Forms.ToolStripButton tsbTongQuan;
        private System.Windows.Forms.ToolStripButton tsbBaoCao;
        private System.Windows.Forms.ToolStripButton tsbDangXuat;
        private System.Windows.Forms.StatusStrip ssChinh;
        private System.Windows.Forms.ToolStripStatusLabel tsslNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tsslHomNay;
        private System.Windows.Forms.ToolStripStatusLabel tsslMayChu;
    }
}
