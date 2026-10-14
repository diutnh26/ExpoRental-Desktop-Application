using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Hộp thoại SCR-13 Hợp đồng thuê: hiển thị hợp đồng dạng chỉ đọc bằng Label và GroupBox (FR-18, D-27, mục 8.13).
    // Hợp đồng chỉ xem được khi lượt thuê từ trạng thái Đã xác nhận trở đi (BR-17).
    public partial class frmHopDong : BaseForm
    {
        // Khởi tạo hộp thoại với lượt thuê cần xem hợp đồng.
        /// <param name="luotThueId">Khóa chính của lượt thuê.</param>
        public frmHopDong(int luotThueId)
        {
            InitializeComponent();
        }
    }
}
