using Guna.UI2.WinForms;
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

namespace Timer
{
    public partial class fmTimerScreen : Form
    {
        public fmTimerScreen()
        {
            InitializeComponent();
            CustomWindow(Color.FromArgb(68, 109, 255), Color.White, Color.FromArgb(68, 109, 255), Handle);

        }

        private string ToBgr(Color c) => $"{c.B:X2}{c.G:X2}{c.R:X2}";

        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        const int DWWMA_CAPTION_COLOR = 35;
        const int DWWMA_BORDER_COLOR = 34;
        const int DWMWA_TEXT_COLOR = 36;
        public void CustomWindow(Color captionColor, Color fontColor, Color borderColor, IntPtr handle)
        {
            IntPtr hWnd = handle;
            //Change caption color
            int[] caption = new int[] { int.Parse(ToBgr(captionColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_CAPTION_COLOR, caption, 4);
            //Change font color
            int[] font = new int[] { int.Parse(ToBgr(fontColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWMWA_TEXT_COLOR, font, 4);
            //Change border color
            int[] border = new int[] { int.Parse(ToBgr(borderColor), System.Globalization.NumberStyles.HexNumber) };
            DwmSetWindowAttribute(hWnd, DWWMA_BORDER_COLOR, border, 4);

        }

        void Reset()
        {
            ucTimerNowScreen.Visible = false;
            ucTimerScreen.Visible = false;
            ucAlarmClockScreen.Visible = false;

            foreach (var Control in pnBtnsAndLbs.Controls)
            {
                if (Control is Label)
                {
                    Label label = (Label)Control;

                    label.BackColor = Color.FromArgb(43, 41, 42);

                    continue;
                }

                if (Control is Guna2Button)
                {
                    Guna2Button button = (Guna2Button)Control;

                    button.Checked = false;

                    continue;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Reset();

            if (sender == btnTimeNow)
            {
                ucTimerNowScreen.Visible = true;
                btnTimeNow.Checked = true;
                lbEnableTimeNow.BackColor = Color.FromArgb(68, 109, 255);
                return;
            }

            if (sender == btnAlarmClock)
            {
                ucAlarmClockScreen.Visible = true;
                btnAlarmClock.Checked = true;
                lbEnableAlarmClock.BackColor = Color.FromArgb(68, 109, 255);
                return;
            }

            if (sender == btnTimer)
            {
                ucTimerScreen.Visible = true;
                btnTimer.Checked = true;
                lbEnableTimer.BackColor = Color.FromArgb(68, 109, 255);
                return;
            }
        }
    }
}
