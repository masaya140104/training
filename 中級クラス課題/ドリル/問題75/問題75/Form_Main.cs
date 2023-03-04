using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題75
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int this_month_days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            label.Text = ("今月は" + this_month_days.ToString() + "日");        
        }
    }
}
