using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Hộp thoại SCR-17 Xóa khách hàng: nhập lý do xóa rồi gọi lớp nghiệp vụ để xóa và ghi nhật ký (FR-08, BR-18, mục 8.16).
    // Hộp thoại được mở từ nút Xóa của SCR-08, chỉ với Quản trị viên và Quản lý (D-40).
    public partial class frmLyDoXoa : BaseForm
    {
        // Khởi tạo hộp thoại với khách hàng cần xóa.
        /// <param name="khachHangId">Khóa chính của khách hàng.</param>
        /// <param name="maKhachHang">Mã khách hàng, dùng để hiển thị.</param>
        /// <param name="tenKhachHang">Tên khách hàng, dùng để hiển thị.</param>
        /// <param name="phienBan">Giá trị PhienBan của dòng đang chọn trên SCR-08 (BR-14).</param>
        public frmLyDoXoa(int khachHangId, string maKhachHang, string tenKhachHang, byte[] phienBan)
        {
            InitializeComponent();
        }
    }
}
