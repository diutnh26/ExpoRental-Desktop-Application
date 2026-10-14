using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Màn hình SCR-01 Đăng nhập: xác thực người dùng rồi mở màn hình chính (FR-01, mục 8.1).
    // Form này là form gốc của ứng dụng; nó được ẩn khi đã đăng nhập và hiện lại sau khi đăng xuất.
    public partial class frmDangNhap : BaseForm
    {
        // Khởi tạo form và các control do trình thiết kế sinh ra.
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLuotThue frmLuotThue = new frmLuotThue();
            frmLuotThue.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
