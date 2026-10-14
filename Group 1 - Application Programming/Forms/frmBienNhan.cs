using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{

    // Hộp thoại SCR-14 Biên nhận: hiển thị biên nhận của một giao dịch thanh toán dạng chỉ đọc (FR-19, D-27, mục 8.14).
    public partial class frmBienNhan : BaseForm
    {

        // Khởi tạo hộp thoại với giao dịch cần xem biên nhận.
        /// <param name="thanhToanId">Khóa chính của giao dịch thanh toán.</param>
        public frmBienNhan(int thanhToanId)
        {
            InitializeComponent();
        }
    }
}
