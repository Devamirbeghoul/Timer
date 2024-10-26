namespace Timer
{
    partial class fmTimerScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmTimerScreen));
            this.btnTimeNow = new Guna.UI2.WinForms.Guna2Button();
            this.btnAlarmClock = new Guna.UI2.WinForms.Guna2Button();
            this.btnTimer = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEnableTimeNow = new System.Windows.Forms.Label();
            this.lbEnableAlarmClock = new System.Windows.Forms.Label();
            this.lbEnableTimer = new System.Windows.Forms.Label();
            this.pnBtnsAndLbs = new System.Windows.Forms.Panel();
            this.ucTimerScreen = new Timer.ucTimer();
            this.ucTimerNowScreen = new Timer.ucTimeNow();
            this.ucAlarmClockScreen = new Timer.ucAlarmClock();
            this.pnBtnsAndLbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimeNow
            // 
            this.btnTimeNow.Checked = true;
            this.btnTimeNow.CheckedState.Parent = this.btnTimeNow;
            this.btnTimeNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeNow.CustomImages.Parent = this.btnTimeNow;
            this.btnTimeNow.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTimeNow.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeNow.ForeColor = System.Drawing.Color.White;
            this.btnTimeNow.HoverState.Parent = this.btnTimeNow;
            this.btnTimeNow.Location = new System.Drawing.Point(10, 26);
            this.btnTimeNow.Name = "btnTimeNow";
            this.btnTimeNow.ShadowDecoration.Parent = this.btnTimeNow;
            this.btnTimeNow.Size = new System.Drawing.Size(183, 57);
            this.btnTimeNow.TabIndex = 0;
            this.btnTimeNow.Text = "Time Now";
            this.btnTimeNow.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAlarmClock
            // 
            this.btnAlarmClock.CheckedState.Parent = this.btnAlarmClock;
            this.btnAlarmClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarmClock.CustomImages.Parent = this.btnAlarmClock;
            this.btnAlarmClock.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAlarmClock.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmClock.ForeColor = System.Drawing.Color.White;
            this.btnAlarmClock.HoverState.Parent = this.btnAlarmClock;
            this.btnAlarmClock.Location = new System.Drawing.Point(199, 26);
            this.btnAlarmClock.Name = "btnAlarmClock";
            this.btnAlarmClock.ShadowDecoration.Parent = this.btnAlarmClock;
            this.btnAlarmClock.Size = new System.Drawing.Size(183, 57);
            this.btnAlarmClock.TabIndex = 1;
            this.btnAlarmClock.Text = "Alarm Clock";
            this.btnAlarmClock.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.CheckedState.Parent = this.btnTimer;
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimer.CustomImages.Parent = this.btnTimer;
            this.btnTimer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnTimer.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.HoverState.Parent = this.btnTimer;
            this.btnTimer.Location = new System.Drawing.Point(388, 26);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.ShadowDecoration.Parent = this.btnTimer;
            this.btnTimer.Size = new System.Drawing.Size(183, 57);
            this.btnTimer.TabIndex = 2;
            this.btnTimer.Text = "Timer";
            this.btnTimer.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(229, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Timer";
            // 
            // lbEnableTimeNow
            // 
            this.lbEnableTimeNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.lbEnableTimeNow.ForeColor = System.Drawing.Color.Black;
            this.lbEnableTimeNow.Location = new System.Drawing.Point(10, 80);
            this.lbEnableTimeNow.Name = "lbEnableTimeNow";
            this.lbEnableTimeNow.Size = new System.Drawing.Size(183, 3);
            this.lbEnableTimeNow.TabIndex = 6;
            // 
            // lbEnableAlarmClock
            // 
            this.lbEnableAlarmClock.BackColor = System.Drawing.Color.Transparent;
            this.lbEnableAlarmClock.ForeColor = System.Drawing.Color.Black;
            this.lbEnableAlarmClock.Location = new System.Drawing.Point(199, 80);
            this.lbEnableAlarmClock.Name = "lbEnableAlarmClock";
            this.lbEnableAlarmClock.Size = new System.Drawing.Size(183, 3);
            this.lbEnableAlarmClock.TabIndex = 7;
            // 
            // lbEnableTimer
            // 
            this.lbEnableTimer.BackColor = System.Drawing.Color.Transparent;
            this.lbEnableTimer.ForeColor = System.Drawing.Color.Black;
            this.lbEnableTimer.Location = new System.Drawing.Point(388, 80);
            this.lbEnableTimer.Name = "lbEnableTimer";
            this.lbEnableTimer.Size = new System.Drawing.Size(183, 3);
            this.lbEnableTimer.TabIndex = 8;
            // 
            // pnBtnsAndLbs
            // 
            this.pnBtnsAndLbs.Controls.Add(this.lbEnableTimer);
            this.pnBtnsAndLbs.Controls.Add(this.lbEnableAlarmClock);
            this.pnBtnsAndLbs.Controls.Add(this.lbEnableTimeNow);
            this.pnBtnsAndLbs.Controls.Add(this.btnTimer);
            this.pnBtnsAndLbs.Controls.Add(this.btnAlarmClock);
            this.pnBtnsAndLbs.Controls.Add(this.btnTimeNow);
            this.pnBtnsAndLbs.Location = new System.Drawing.Point(3, 92);
            this.pnBtnsAndLbs.Name = "pnBtnsAndLbs";
            this.pnBtnsAndLbs.Size = new System.Drawing.Size(587, 123);
            this.pnBtnsAndLbs.TabIndex = 9;
            // 
            // ucTimerScreen
            // 
            this.ucTimerScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.ucTimerScreen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTimerScreen.Location = new System.Drawing.Point(8, 201);
            this.ucTimerScreen.Margin = new System.Windows.Forms.Padding(5);
            this.ucTimerScreen.Name = "ucTimerScreen";
            this.ucTimerScreen.Size = new System.Drawing.Size(566, 504);
            this.ucTimerScreen.TabIndex = 10;
            this.ucTimerScreen.Visible = false;
            // 
            // ucTimerNowScreen
            // 
            this.ucTimerNowScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.ucTimerNowScreen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTimerNowScreen.Location = new System.Drawing.Point(13, 201);
            this.ucTimerNowScreen.Margin = new System.Windows.Forms.Padding(5);
            this.ucTimerNowScreen.Name = "ucTimerNowScreen";
            this.ucTimerNowScreen.Size = new System.Drawing.Size(558, 443);
            this.ucTimerNowScreen.TabIndex = 4;
            // 
            // ucAlarmClockScreen
            // 
            this.ucAlarmClockScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.ucAlarmClockScreen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucAlarmClockScreen.Location = new System.Drawing.Point(17, 209);
            this.ucAlarmClockScreen.Margin = new System.Windows.Forms.Padding(5);
            this.ucAlarmClockScreen.Name = "ucAlarmClockScreen";
            this.ucAlarmClockScreen.Size = new System.Drawing.Size(557, 482);
            this.ucAlarmClockScreen.TabIndex = 11;
            this.ucAlarmClockScreen.Visible = false;
            // 
            // fmTimerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(585, 710);
            this.Controls.Add(this.ucAlarmClockScreen);
            this.Controls.Add(this.ucTimerScreen);
            this.Controls.Add(this.pnBtnsAndLbs);
            this.Controls.Add(this.ucTimerNowScreen);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmTimerScreen";
            this.Text = "Timer";
            this.pnBtnsAndLbs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnTimeNow;
        private Guna.UI2.WinForms.Guna2Button btnAlarmClock;
        private Guna.UI2.WinForms.Guna2Button btnTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEnableTimeNow;
        private System.Windows.Forms.Label lbEnableAlarmClock;
        private System.Windows.Forms.Label lbEnableTimer;
        private System.Windows.Forms.Panel pnBtnsAndLbs;
        private ucTimeNow ucTimerNowScreen;
        private ucTimer ucTimerScreen;
        private ucAlarmClock ucAlarmClockScreen;
    }
}

