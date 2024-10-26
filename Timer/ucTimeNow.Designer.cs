namespace Timer
{
    partial class ucTimeNow
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
            this.lbCurrentTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPresent = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbCurrentTime
            // 
            this.lbCurrentTime.AutoSize = true;
            this.lbCurrentTime.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(109)))), ((int)(((byte)(255)))));
            this.lbCurrentTime.Location = new System.Drawing.Point(175, 77);
            this.lbCurrentTime.Name = "lbCurrentTime";
            this.lbCurrentTime.Size = new System.Drawing.Size(156, 42);
            this.lbCurrentTime.TabIndex = 0;
            this.lbCurrentTime.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(155, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Present:";
            // 
            // lbPresent
            // 
            this.lbPresent.AutoSize = true;
            this.lbPresent.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPresent.ForeColor = System.Drawing.Color.White;
            this.lbPresent.Location = new System.Drawing.Point(238, 158);
            this.lbPresent.Name = "lbPresent";
            this.lbPresent.Size = new System.Drawing.Size(88, 24);
            this.lbPresent.TabIndex = 2;
            this.lbPresent.Text = "1/1/2000";
            // 
            // TimeNow
            // 
            this.TimeNow.Interval = 1000;
            this.TimeNow.Tick += new System.EventHandler(this.TimeNow_Tick);
            // 
            // ucTimeNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.lbPresent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCurrentTime);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ucTimeNow";
            this.Size = new System.Drawing.Size(560, 293);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCurrentTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPresent;
        private System.Windows.Forms.Timer TimeNow;
    }
}
