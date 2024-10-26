namespace Timer
{
    partial class ucAlarmClock
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAlarmClock));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTimeNow = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpAlarm = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.lbRemainingTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Timer(this.components);
            this.NotyTimer = new System.Windows.Forms.NotifyIcon(this.components);
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Time  Now:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select  an  Alarm:";
            // 
            // dtpTimeNow
            // 
            this.dtpTimeNow.BorderRadius = 20;
            this.dtpTimeNow.CheckedState.Parent = this.dtpTimeNow;
            this.dtpTimeNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dtpTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.dtpTimeNow.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTimeNow.HoverState.Parent = this.dtpTimeNow;
            this.dtpTimeNow.Location = new System.Drawing.Point(239, 30);
            this.dtpTimeNow.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTimeNow.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTimeNow.Name = "dtpTimeNow";
            this.dtpTimeNow.ShadowDecoration.Parent = this.dtpTimeNow;
            this.dtpTimeNow.Size = new System.Drawing.Size(306, 43);
            this.dtpTimeNow.TabIndex = 2;
            this.dtpTimeNow.Value = new System.DateTime(2024, 10, 26, 20, 55, 27, 822);
            this.dtpTimeNow.ValueChanged += new System.EventHandler(this.dtpTimeNow_ValueChanged);
            // 
            // dtpAlarm
            // 
            this.dtpAlarm.BorderRadius = 20;
            this.dtpAlarm.CheckedState.Parent = this.dtpAlarm;
            this.dtpAlarm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.dtpAlarm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.dtpAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpAlarm.HoverState.Parent = this.dtpAlarm;
            this.dtpAlarm.Location = new System.Drawing.Point(239, 99);
            this.dtpAlarm.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpAlarm.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpAlarm.Name = "dtpAlarm";
            this.dtpAlarm.ShadowDecoration.Parent = this.dtpAlarm;
            this.dtpAlarm.Size = new System.Drawing.Size(306, 43);
            this.dtpAlarm.TabIndex = 3;
            this.dtpAlarm.Value = new System.DateTime(2024, 10, 26, 20, 55, 27, 822);
            this.dtpAlarm.ValueChanged += new System.EventHandler(this.dtpAlarm_ValueChanged);
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 25;
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.Enabled = false;
            this.btnStop.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btnStop.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Location = new System.Drawing.Point(345, 418);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(188, 46);
            this.btnStop.TabIndex = 10;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.BorderRadius = 25;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(23, 418);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(188, 46);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Alarm after:";
            // 
            // lbPeriod
            // 
            this.lbPeriod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriod.ForeColor = System.Drawing.Color.White;
            this.lbPeriod.Location = new System.Drawing.Point(181, 324);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(199, 29);
            this.lbPeriod.TabIndex = 12;
            // 
            // lbRemainingTime
            // 
            this.lbRemainingTime.AutoSize = true;
            this.lbRemainingTime.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemainingTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.lbRemainingTime.Location = new System.Drawing.Point(185, 258);
            this.lbRemainingTime.Name = "lbRemainingTime";
            this.lbRemainingTime.Size = new System.Drawing.Size(156, 42);
            this.lbRemainingTime.TabIndex = 13;
            this.lbRemainingTime.Text = "00:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Remaining  Time:";
            // 
            // RemainingTime
            // 
            this.RemainingTime.Interval = 1000;
            this.RemainingTime.Tick += new System.EventHandler(this.RemainingTime_Tick);
            // 
            // NotyTimer
            // 
            this.NotyTimer.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotyTimer.BalloonTipText = "Ended Time";
            this.NotyTimer.BalloonTipTitle = "Note";
            this.NotyTimer.Icon = ((System.Drawing.Icon)(resources.GetObject("NotyTimer.Icon")));
            this.NotyTimer.Text = "Timer";
            this.NotyTimer.Visible = true;
            this.NotyTimer.BalloonTipShown += new System.EventHandler(this.NotyTimer_BalloonTipShown);
            // 
            // TimeNow
            // 
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // ucAlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRemainingTime);
            this.Controls.Add(this.lbPeriod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dtpAlarm);
            this.Controls.Add(this.dtpTimeNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucAlarmClock";
            this.Size = new System.Drawing.Size(560, 492);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTimeNow;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpAlarm;
        private Guna.UI2.WinForms.Guna2Button btnStop;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Label lbRemainingTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer RemainingTime;
        private System.Windows.Forms.NotifyIcon NotyTimer;
        private System.Windows.Forms.Timer TimeNow;
    }
}
