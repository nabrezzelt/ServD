using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alerts;
using System.Runtime.InteropServices;

namespace ServD
{
    public partial class FormLogin : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            AlertForm alert = new AlertForm(this);

            if (tb_username.Text == String.Empty)
            {                
                alert.Show("Username missing!", AlertForm.COLOR_WARNING);
                return;
            }

            if(tb_password.Text == String.Empty)
            {
                alert.Show("Password missing!", AlertForm.COLOR_WARNING);
                return;
            }
        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
    }
}
