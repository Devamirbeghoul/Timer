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
    public partial class ucTimeNow : UserControl
    {
        public ucTimeNow()
        {
            InitializeComponent();
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            TimeNow.Start();
            lbPresent.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
        }

        private void TimeNow_Tick(object sender, EventArgs e)
        {
            lbCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lbPresent.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
