using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServD
{
    public partial class FormMain : Form
    {
        const string TB_SEACH_PLACEHOLDER = "Search (Strg+F)";

        public FormMain()
        {
            InitializeComponent();
            tb_search.GotFocus += tb_search_GotFocus;
            tb_search.LostFocus += tb_search_LostFocus;

            lbl_title.Text = this.Text;
        }

        #region Custom Windowheader        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void tb_search_LostFocus(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(tb_search.Text))
            {
                tb_search.ForeColor = Color.FromArgb(199, 199, 199);
                tb_search.Text = TB_SEACH_PLACEHOLDER;
            }
        }

        private void tb_search_GotFocus(object sender, EventArgs e)
        {
            tb_search.ForeColor = Color.White;
            tb_search.Text = "";
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pb_max_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }            
        }

        private void pb_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pb_min_MouseUp(object sender, MouseEventArgs e)
        {
            pb_min.Image = Properties.Resources.min;
        }

        private void pb_min_MouseLeave(object sender, EventArgs e)
        {
            pb_min.Image = Properties.Resources.min;
        }

        private void pb_min_MouseEnter(object sender, EventArgs e)
        {
            pb_min.Image = Properties.Resources.min_hover;
        }

        private void pb_min_MouseDown(object sender, MouseEventArgs e)
        {
            pb_min.Image = Properties.Resources.min_pressed;
        }

        private void pb_max_MouseDown(object sender, MouseEventArgs e)
        {
            pb_max.Image = Properties.Resources.max_pressed;
        }

        private void pb_max_MouseEnter(object sender, EventArgs e)
        {
            pb_max.Image = Properties.Resources.max_hover;
        }

        private void pb_max_MouseLeave(object sender, EventArgs e)
        {
            pb_max.Image = Properties.Resources.max;
        }

        private void pb_max_MouseUp(object sender, MouseEventArgs e)
        {
            pb_max.Image = Properties.Resources.max;
        }

        private void pb_close_MouseDown(object sender, MouseEventArgs e)
        {
            pb_close.Image = Properties.Resources.close_pressed;
        }

        private void pb_close_MouseEnter(object sender, EventArgs e)
        {
            pb_close.Image = Properties.Resources.close_hover;
        }

        private void pb_close_MouseLeave(object sender, EventArgs e)
        {
            pb_close.Image = Properties.Resources.close;
        }

        private void pb_close_MouseUp(object sender, MouseEventArgs e)
        {
            pb_close.Image = Properties.Resources.close;
        }

        private void panel_move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }
        #endregion
    }
}
