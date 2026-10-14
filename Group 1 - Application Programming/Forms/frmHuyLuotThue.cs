using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Hộp thoại SCR-11 Hủy lượt thuê: xem trước phí phạt và tiền hoàn, nhập lý do rồi hủy (FR-15, BR-06, mục 8.11).
    // Cả ba vai trò đều mở được hộp thoại này (D-36).
    public partial class frmHuyLuotThue : BaseForm
    {
        // Khởi tạo hộp thoại với lượt thuê cần hủy.
        /// <param name="luotThueId">Khóa chính của lượt thuê.</param>
        /// <param name="phienBan">Giá trị PhienBan của dòng đang chọn trên SCR-09.</param>
        public frmHuyLuotThue(int luotThueId, byte[] phienBan)
        {
            InitializeComponent();
        }
    }
}
