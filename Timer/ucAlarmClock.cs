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
    public partial class ucAlarmClock : UserControl
    {
        public ucAlarmClock()
        {
            InitializeComponent();
            dtpTimeNow.Value = DateTime.Now;
            dtpAlarm.Value = DateTime.Now;
        }

        short FullTime, CurrentTime;
        short Seconds, Minutes, Hours , Days;

        void Reset()
        {
            lbPeriod.Text = string.Empty;
            dtpTimeNow.Value = DateTime.Now;
            lbRemainingTime.Text = "00:00:00";

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            RemainingTime.Stop();
        }

        private void dtpTimeNow_ValueChanged(object sender, EventArgs e)
        {
            dtpTimeNow.Value = DateTime.Now;
                
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void NotyTimer_BalloonTipShown(object sender, EventArgs e)
        {
            Reset();
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            dtpTimeNow.Value = DateTime.Now;
        }

        private void RemainingTime_Tick(object sender, EventArgs e)
        {

            lbRemainingTime.Text = Days.ToString("00") + ":" + Hours.ToString("00") + ":" + Minutes.ToString("00") + ":" + Seconds.ToString("00");

            if (Seconds == 0)
            {
                if (Minutes == 0)
                {
                    if (Hours == 0)
                    {
                        if (Days == 0)
                        {
                            RemainingTime.Stop();
                            NotyTimer.ShowBalloonTip(1000);
                        }

                        else
                        {
                            Days--;
                            Hours = 23;
                            Minutes = 59;
                            Seconds = 59;
                        }
                        
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

         
        }
    
        private void dtpAlarm_ValueChanged(object sender, EventArgs e)
        {
            if (dtpAlarm.Value < dtpTimeNow.Value)
            {
                dtpAlarm.Value = dtpTimeNow.Value.AddMinutes(1);
                return;
            }
        }

        string GetPeriod()
        {
            if (Days == 0 && Hours == 0 && Minutes == 0 && Seconds != 0)
                return Seconds.ToString() + "s";

            if (Days == 0)
            {
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

            else
            {
                if (Hours == 0)
                {
                    if (Seconds == 0)
                        return Days.ToString() + "d ," + Minutes.ToString() + "m";
                    else
                        return Days.ToString() + "d ," + Minutes.ToString() + "m , " + Seconds.ToString() + "s";
                }

                else
                {
                    if (Minutes == 0)
                    {
                        if (Seconds == 0)
                            return Days.ToString() + "d ," + Hours.ToString() + "h";
                        else
                            return Days.ToString() + "d ," + Hours.ToString() + "h , " + Seconds.ToString() + "s";
                    }

                    else
                    {
                        if (Seconds == 0)
                            return Days.ToString() + "d ," + Hours.ToString() + "h , " + Minutes.ToString() + "m";
                        else
                            return Days.ToString() + "d ," + Hours.ToString() + "h , " + Minutes.ToString() + "m , " + Seconds.ToString() + "s";
                    }

                }
            }

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            TimeSpan FullTime = dtpAlarm.Value.Subtract(dtpTimeNow.Value);
            Seconds = Convert.ToInt16(FullTime.Seconds);
            Minutes = Convert.ToInt16(FullTime.Minutes);
            Hours = Convert.ToInt16(FullTime.Hours);
            Days = Convert.ToInt16(FullTime.Days);

            lbRemainingTime.Text = Days.ToString("00") + ":" + Hours.ToString("00") + ":" + Minutes.ToString("00") + ":" + Seconds.ToString("00");

            lbPeriod.Text = GetPeriod();

            RemainingTime.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }
    }
}
