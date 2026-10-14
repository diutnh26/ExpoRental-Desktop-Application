using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Group_1___Application_Programming.Forms
{
    /// <summary>
    /// Lớp cơ sở cho mọi form của ứng dụng. Form nào kế thừa BaseForm (thay vì Form) sẽ tự có 2 tính năng:
    /// 1. Lúc mở: nằm giữa màn hình, hoặc giữa form cha nếu là form con.
    /// 2. Khi bấm Maximize: các control bên trong tự phóng to theo tỉ lệ để vừa với form.
    /// </summary>
    public class BaseForm : Form
    {
        // Kích thước vùng bên trong form lúc vừa mở (kích thước thiết kế).
        private Size kichThuocGoc;

        // Vị trí + kích thước gốc của từng control.
        private Dictionary<Control, Rectangle> viTriGoc = new Dictionary<Control, Rectangle>();

        // Cỡ chữ gốc của từng control.
        private Dictionary<Control, float> coChuGoc = new Dictionary<Control, float>();

        // Độ rộng gốc của từng cột trong các DataGridView.
        private Dictionary<DataGridViewColumn, int> doRongCotGoc = new Dictionary<DataGridViewColumn, int>();

        // Cho biết đã ghi nhớ kích thước gốc hay chưa.
        private bool daGhiNho = false;

        /// <summary>
        /// Chạy khi form vừa mở, trước khi hiện lên màn hình.
        /// </summary>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Trong màn hình thiết kế (Designer) của Visual Studio thì không làm gì.
            if (DesignMode)
            {
                return;
            }

            // Form luôn mở ở kích thước thiết kế.
            WindowState = FormWindowState.Normal;

            // Không cho thu nhỏ form nhỏ hơn kích thước thiết kế.
            if (MaximizeBox)
            {
                MinimumSize = Size;
            }

            CanGiuaForm();
            GhiNhoKichThuocGoc();
        }

        /// <summary>
        /// Chạy mỗi khi form đổi kích thước (Maximize, Restore, kéo viền).
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (daGhiNho && WindowState != FormWindowState.Minimized)
            {
                PhongToCacControl();
            }
        }

        /// <summary>
        /// Đặt form vào giữa màn hình, hoặc giữa form cha nếu có.
        /// </summary>
        private void CanGiuaForm()
        {
            StartPosition = FormStartPosition.Manual;

            // Vùng sẽ chứa form: mặc định là màn hình (trừ thanh taskbar).
            Rectangle vungChua = Screen.FromControl(this).WorkingArea;

            if (MdiParent != null)
            {
                // Form con nằm trong form chính (MDI): căn giữa vùng trống bên trong form chính.
                foreach (Control control in MdiParent.Controls)
                {
                    if (control is MdiClient)
                    {
                        vungChua = new Rectangle(0, 0, control.ClientSize.Width, control.ClientSize.Height);
                    }
                }
            }
            else if (Owner != null)
            {
                // Hộp thoại mở bằng ShowDialog(this): căn giữa form cha.
                vungChua = Owner.Bounds;
            }

            int x = vungChua.X + (vungChua.Width - Width) / 2;
            int y = vungChua.Y + (vungChua.Height - Height) / 2;

            // Nếu form to hơn vùng chứa thì đặt sát mép trái/trên, không để form tràn ra ngoài.
            if (x < vungChua.X) x = vungChua.X;
            if (y < vungChua.Y) y = vungChua.Y;

            Location = new Point(x, y);
        }

        /// <summary>
        /// Ghi nhớ kích thước gốc của form và của mọi control bên trong.
        /// </summary>
        private void GhiNhoKichThuocGoc()
        {
            kichThuocGoc = ClientSize;
            GhiNhoControlCon(this);
            daGhiNho = true;
        }

        /// <summary>
        /// Ghi nhớ các control nằm trong một control cha (gọi lại chính nó để đi hết các control lồng nhau).
        /// </summary>
        private void GhiNhoControlCon(Control cha)
        {
            foreach (Control control in cha.Controls)
            {
                // Bỏ qua menu, thanh công cụ, thanh trạng thái và vùng chứa form con: chúng tự giãn theo form.
                if (control is ToolStrip || control is MdiClient)
                {
                    continue;
                }

                // Control đã Dock thì WinForms tự giãn nó, chỉ cần xử lý các control bên trong.
                if (control.Dock == DockStyle.None)
                {
                    viTriGoc[control] = control.Bounds;
                    coChuGoc[control] = control.Font.Size;

                    // Để BaseForm tự tính vị trí, tránh Anchor đẩy control đi chỗ khác.
                    control.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }

                DataGridView bang = control as DataGridView;
                if (bang != null)
                {
                    foreach (DataGridViewColumn cot in bang.Columns)
                    {
                        doRongCotGoc[cot] = cot.Width;
                    }
                }

                GhiNhoControlCon(control);
            }
        }

        /// <summary>
        /// Phóng to / thu nhỏ mọi control theo tỉ lệ giữa kích thước hiện tại và kích thước gốc của form.
        /// </summary>
        private void PhongToCacControl()
        {
            if (ClientSize.Width == 0 || ClientSize.Height == 0)
            {
                return;
            }

            // Tỉ lệ theo chiều ngang và chiều dọc. Ví dụ form to gấp 1.5 lần thì tỉ lệ = 1.5.
            float tiLeNgang = (float)ClientSize.Width / kichThuocGoc.Width;
            float tiLeDoc = (float)ClientSize.Height / kichThuocGoc.Height;

            // Chữ phóng theo tỉ lệ nhỏ hơn để không bị tràn.
            float tiLeChu = Math.Min(tiLeNgang, tiLeDoc);

            SuspendLayout();

            foreach (Control control in viTriGoc.Keys)
            {
                Rectangle goc = viTriGoc[control];

                int x = (int)(goc.X * tiLeNgang);
                int y = (int)(goc.Y * tiLeDoc);
                int rong = (int)(goc.Width * tiLeNgang);
                int cao = (int)(goc.Height * tiLeDoc);

                if (control.Parent is FlowLayoutPanel)
                {
                    // Trong FlowLayoutPanel, vị trí do panel tự sắp xếp, chỉ đổi kích thước.
                    control.Size = new Size(rong, cao);
                }
                else
                {
                    control.SetBounds(x, y, rong, cao);
                }

                float coChuMoi = coChuGoc[control] * tiLeChu;
                control.Font = new Font(control.Font.FontFamily, coChuMoi, control.Font.Style);
            }

            // Giãn độ rộng các cột của bảng theo chiều ngang.
            foreach (DataGridViewColumn cot in doRongCotGoc.Keys)
            {
                // Chỉ đổi cột có độ rộng cố định; cột tự giãn (Fill, AllCells, ...) thì WinForms tự lo.
                if (cot.AutoSizeMode == DataGridViewAutoSizeColumnMode.None
                    || cot.AutoSizeMode == DataGridViewAutoSizeColumnMode.NotSet)
                {
                    int doRongMoi = (int)(doRongCotGoc[cot] * tiLeNgang);

                    // Không được nhỏ hơn độ rộng tối thiểu của cột.
                    cot.Width = Math.Max(doRongMoi, cot.MinimumWidth);
                }
            }

            ResumeLayout();
        }
    }
}
