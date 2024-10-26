namespace Timer
{
    partial class ucTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTimer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nupHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nupMinutes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.nupSeconds = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pbProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.lbStartFrom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPeriod = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.NotyTimer = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSeconds)).BeginInit();
            this.pbProgress.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(223, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(448, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seconds";
            // 
            // nupHours
            // 
            this.nupHours.BackColor = System.Drawing.Color.Transparent;
            this.nupHours.BorderRadius = 15;
            this.nupHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nupHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nupHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nupHours.DisabledState.Parent = this.nupHours;
            this.nupHours.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nupHours.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nupHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupHours.FocusedState.Parent = this.nupHours;
            this.nupHours.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHours.ForeColor = System.Drawing.Color.Black;
            this.nupHours.Location = new System.Drawing.Point(22, 47);
            this.nupHours.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nupHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nupHours.Name = "nupHours";
            this.nupHours.ShadowDecoration.Parent = this.nupHours;
            this.nupHours.Size = new System.Drawing.Size(69, 33);
            this.nupHours.TabIndex = 3;
            this.nupHours.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            // 
            // nupMinutes
            // 
            this.nupMinutes.BackColor = System.Drawing.Color.Transparent;
            this.nupMinutes.BorderRadius = 15;
            this.nupMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupMinutes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nupMinutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nupMinutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nupMinutes.DisabledState.Parent = this.nupMinutes;
            this.nupMinutes.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nupMinutes.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nupMinutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupMinutes.FocusedState.Parent = this.nupMinutes;
            this.nupMinutes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMinutes.ForeColor = System.Drawing.Color.Black;
            this.nupMinutes.Location = new System.Drawing.Point(238, 47);
            this.nupMinutes.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nupMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupMinutes.Name = "nupMinutes";
            this.nupMinutes.ShadowDecoration.Parent = this.nupMinutes;
            this.nupMinutes.Size = new System.Drawing.Size(69, 33);
            this.nupMinutes.TabIndex = 4;
            this.nupMinutes.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            // 
            // nupSeconds
            // 
            this.nupSeconds.BackColor = System.Drawing.Color.Transparent;
            this.nupSeconds.BorderRadius = 15;
            this.nupSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupSeconds.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nupSeconds.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nupSeconds.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nupSeconds.DisabledState.Parent = this.nupSeconds;
            this.nupSeconds.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nupSeconds.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nupSeconds.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupSeconds.FocusedState.Parent = this.nupSeconds;
            this.nupSeconds.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSeconds.ForeColor = System.Drawing.Color.Black;
            this.nupSeconds.Location = new System.Drawing.Point(463, 47);
            this.nupSeconds.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nupSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nupSeconds.Name = "nupSeconds";
            this.nupSeconds.ShadowDecoration.Parent = this.nupSeconds;
            this.nupSeconds.Size = new System.Drawing.Size(69, 33);
            this.nupSeconds.TabIndex = 5;
            this.nupSeconds.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            // 
            // pbProgress
            // 
            this.pbProgress.Controls.Add(this.lbPeriod);
            this.pbProgress.Controls.Add(this.label4);
            this.pbProgress.Controls.Add(this.lbStartFrom);
            this.pbProgress.Location = new System.Drawing.Point(146, 119);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.pbProgress.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.pbProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbProgress.ShadowDecoration.Parent = this.pbProgress;
            this.pbProgress.Size = new System.Drawing.Size(245, 251);
            this.pbProgress.TabIndex = 6;
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
            this.btnStart.Location = new System.Drawing.Point(22, 401);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(188, 46);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbStartFrom
            // 
            this.lbStartFrom.AutoSize = true;
            this.lbStartFrom.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.lbStartFrom.Location = new System.Drawing.Point(61, 79);
            this.lbStartFrom.Name = "lbStartFrom";
            this.lbStartFrom.Size = new System.Drawing.Size(124, 32);
            this.lbStartFrom.TabIndex = 8;
            this.lbStartFrom.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(45, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Period :";
            // 
            // lbPeriod
            // 
            this.lbPeriod.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeriod.ForeColor = System.Drawing.Color.White;
            this.lbPeriod.Location = new System.Drawing.Point(67, 151);
            this.lbPeriod.Name = "lbPeriod";
            this.lbPeriod.Size = new System.Drawing.Size(103, 58);
            this.lbPeriod.TabIndex = 10;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
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
            this.btnStop.Location = new System.Drawing.Point(344, 401);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(188, 46);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.nupSeconds);
            this.Controls.Add(this.nupMinutes);
            this.Controls.Add(this.nupHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(560, 492);
            ((System.ComponentModel.ISupportInitialize)(this.nupHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSeconds)).EndInit();
            this.pbProgress.ResumeLayout(false);
            this.pbProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupHours;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupMinutes;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupSeconds;
        private Guna.UI2.WinForms.Guna2CircleProgressBar pbProgress;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private System.Windows.Forms.Label lbStartFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPeriod;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.NotifyIcon NotyTimer;
        private Guna.UI2.WinForms.Guna2Button btnStop;
    }
}
