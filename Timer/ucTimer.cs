using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class ucTimer : UserControl
    {
        public ucTimer()
        {
            InitializeComponent();
        }

        short Seconds, Minutes, Hours;
        int FullTime , CurrentTime;

        string GetPeriod()
        {
            if (Hours == 0 && Minutes == 0 && Seconds != 0)
                return Seconds.ToString() + "s";

            if (Hours == 0)
            {
                if (Seconds == 0)
                    return Minutes.ToString() + "m";
                else
                    return Minutes.ToString() + "m , " + Seconds.ToString() + "s";
            }

            else
            {
                if (Minutes == 0)
                {
                    if (Seconds == 0)
                        return Hours.ToString() + "h";
                    else
                        return Hours.ToString() + "h , " + Seconds.ToString() + "s";
                }

                else
                {
                    if (Seconds == 0)
                        return Hours.ToString() + "h , " + Minutes.ToString() + "m";
                    else
                        return Hours.ToString() + "h , " + Minutes.ToString() + "m , " + Seconds.ToString() + "s";
                }
            
            }
        }

        void Reset()
        {
            nupHours.Value = 0;
            nupMinutes.Value = 0;
            nupSeconds.Value = 0;

            lbPeriod.Text = string.Empty;
            lbStartFrom.Text = "00:00:00";

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            Timer.Stop();

            pbProgress.Value = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void NotyTimer_BalloonTipShown(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (nupHours.Value == 0 && nupMinutes.Value == 0 && nupSeconds.Value == 0)
                return;

            Seconds = Convert.ToInt16(nupSeconds.Value);
            Minutes = Convert.ToInt16(nupMinutes.Value);
            Hours = Convert.ToInt16(nupHours.Value);

            FullTime = Seconds + Minutes * 60 + Hours * 60 * 60;
            CurrentTime = Seconds + Minutes * 60 + Hours * 60 * 60;

            pbProgress.Value = 100;

            lbStartFrom.Text = Hours.ToString("00") + ":" + Minutes.ToString("00") + ":" + Seconds.ToString("00");
            lbPeriod.Text = GetPeriod();
            
            Timer.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;


        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            pbProgress.Value = CurrentTime * 100 / FullTime;
            lbStartFrom.Text = Hours.ToString("00") + ":" + Minutes.ToString("00") + ":" + Seconds.ToString("00");

            if (Seconds == 0)
            {
                if (Minutes == 0)
                {
                    if (Hours == 0)
                    {
                        Timer.Stop();
                        NotyTimer.ShowBalloonTip(1000);
                    }

                    else
                    {
                        Hours--;
                        Minutes = 59;
                        Seconds = 59;
                    }
                }

                else
                {
                    Minutes--;
                    Seconds = 59;
                }
            }

            else
                Seconds--;

            CurrentTime--;
        }
    }
}
