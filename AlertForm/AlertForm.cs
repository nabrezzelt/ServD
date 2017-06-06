using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alerts
{
    public class AlertForm
    {
        public static readonly Color COLOR_DANGER = Color.FromArgb(240, 65, 36);
        public static readonly Color COLOR_WARNING = Color.FromArgb(233, 144, 2);
        public static readonly Color COLOR_SUCCESS = Color.FromArgb(67, 172, 106);

        int PADDING_TOP = 31;
        int PADDING_LEFT = 12;
        int PADDING_RIGHT = 12;
        int HEIGHT = 38;        

        Timer tmr;
        Form form;
        Panel grayOutPanel;
        int current_length;
        int max_length;

        public AlertForm(Form form)
        {
            this.form = form;

            tmr = new Timer();
            tmr.Interval = 1;
            tmr.Tick += Tmr_Tick;
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(current_length + " " + max_length);
            current_length++;

            if(current_length > max_length)
            {
                Console.WriteLine(true);
                tmr.Stop();
                Hide();
            }
        }

        public void Hide()
        {
            grayOutPanel.Dispose();
            grayOutPanel = null;
        }

        public void Show(string alertText, Color alertColor, int milisecondsToShow = 1500)
        {
            max_length = milisecondsToShow / 10;

            // take a screenshot of the form and darken it:
            Bitmap bmp = new Bitmap(form.ClientRectangle.Width, form.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(form.PointToScreen(new Point(0, 0)), new Point(0, 0), form.ClientRectangle.Size);
                double percent = 0.60;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, form.ClientRectangle);
                }
            }

            // put the darkened screenshot into a Panel and bring it to the front:
            grayOutPanel = new Panel();
            
            grayOutPanel.Location = new Point(0, 0);
            grayOutPanel.Size = form.ClientRectangle.Size;
            grayOutPanel.BackgroundImage = bmp;                        

            Panel alertPanel = new Panel();
            alertPanel.BackColor = alertColor;
            alertPanel.Location = new Point(PADDING_LEFT, PADDING_TOP);
            alertPanel.Size = new Size(form.Width - PADDING_LEFT - PADDING_RIGHT, HEIGHT);

            Label lbl_alertText = new Label();
            lbl_alertText.Text = alertText;
            lbl_alertText.ForeColor = Color.White;
            lbl_alertText.BackColor = Color.Transparent;
            lbl_alertText.Location = new Point(14, 13);

            alertPanel.Controls.Add(lbl_alertText);

            grayOutPanel.Controls.Add(alertPanel);

            form.Controls.Add(grayOutPanel);
            grayOutPanel.BringToFront();

            tmr.Start();
        }
    }
}
