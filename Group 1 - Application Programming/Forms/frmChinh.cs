using System;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    // Màn hình SCR-02 Màn hình chính: khung MDI có menu, thanh công cụ và thanh trạng thái (FR-05, D-06, mục 8.2).
    // Menu và nút được ẩn theo vai trò; mỗi form con chỉ mở một thể hiện.
    public partial class frmChinh : BaseForm
    {
        // Khởi tạo form và ghi nhớ thể hiện đang mở.
        public frmChinh()
        {
            InitializeComponent();
        }

        private void tsbLuotThue_Click(object sender, EventArgs e)
        {
            frmLuotThue frm = new frmLuotThue();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
