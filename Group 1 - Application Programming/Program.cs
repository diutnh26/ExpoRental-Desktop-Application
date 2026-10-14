using System;
using System.Globalization;
using System.Windows.Forms;
using Group_1___Application_Programming.Forms;

namespace Group_1___Application_Programming
{
    // Điểm khởi động của ứng dụng: đặt định dạng số và ngày kiểu Việt Nam rồi mở màn hình đăng nhập SCR-01.
    internal static class Program
    {
        // Phương thức chính của ứng dụng.
        [STAThread]
        static void Main()
        {
            // Dùng định dạng Việt Nam để tiền hiển thị dạng 1.500.000 và số thập phân dạng 9,00 (A-02, A-03).
            CultureInfo vanHoaViet = new CultureInfo("vi-VN");
            CultureInfo.DefaultThreadCurrentCulture = vanHoaViet;
            Application.CurrentCulture = vanHoaViet;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmDangNhap());
        }
    }
}
