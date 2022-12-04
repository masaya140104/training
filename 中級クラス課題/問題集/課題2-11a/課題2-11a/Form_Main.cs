using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 課題2_11a
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private DateTime countTimer = DateTime.Parse("00:00:00");

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = true;
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            this.timer.Enabled = false;
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            reset();
            this.timer.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.countTimer = this.countTimer.AddSeconds(1.0);
            this.label.Text = this.countTimer.ToString("mm:ss");

            if(countTimer.ToString() == "60:00")
            {
                reset();
            }
        }

        private void reset()
        {
            this.label.Text = "00:00";
            countTimer = DateTime.Parse("00:00:00");
        }
    }
}
