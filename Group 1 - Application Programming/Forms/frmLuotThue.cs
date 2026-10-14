using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Màn hình SCR-09 Lượt thuê: tạo, tra cứu, sửa, thanh toán và hủy lượt thuê (FR-09 đến FR-15, mục 8.9).
    // Áp dụng mẫu CRUD ở mục 8.0.2 với điều chỉnh của D-32: không có Xóa, Chỉnh sửa chỉ mở tên sự kiện và ghi chú.
    // Quản trị viên và Nhân viên có đầy đủ quyền; Quản lý chỉ xem, tìm kiếm và hủy.
    public partial class frmLuotThue : BaseForm
    {
        // Khởi tạo form và các control do trình thiết kế sinh ra.
        public frmLuotThue()
        {
            InitializeComponent();
        }
    }
}
