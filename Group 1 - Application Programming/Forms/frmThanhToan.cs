using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Hộp thoại SCR-10 Ghi nhận thanh toán: ghi giao dịch đặt cọc hoặc thanh toán phần còn lại (FR-13, mục 8.10).
    // Số tiền do lớp nghiệp vụ tự tính; người dùng chỉ chọn phương thức và nhập ghi chú (BR-05).
    public partial class frmThanhToan : BaseForm
    {
        // Khởi tạo hộp thoại với lượt thuê và loại thanh toán.
        /// <param name="luotThueId">Khóa chính của lượt thuê.</param>
        /// <param name="loaiThanhToan">Mã loại thanh toán: COC hoặc CONLAI.</param>
        public frmThanhToan(int luotThueId, string loaiThanhToan)
        {
            InitializeComponent();
        }
    }
}
