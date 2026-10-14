using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Màn hình SCR-08 Khách hàng: quản lý khách hàng cá nhân và doanh nghiệp theo mẫu CRUD ở mục 8.0.2 (FR-08, mục 8.8).
    // Mọi vai trò được thêm và sửa; chỉ Quản trị viên và Quản lý thấy nút Xóa, và xóa phải kèm lý do qua SCR-17 (D-40).
    public partial class frmKhachHang : BaseForm
    {
        // Khởi tạo form và các control do trình thiết kế sinh ra.
        public frmKhachHang()
        {
            InitializeComponent();
        }
    }
}
