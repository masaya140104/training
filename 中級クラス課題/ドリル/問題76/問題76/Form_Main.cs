using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題76
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string today = dt.ToString("dd");
            dt = dt.AddMonths(1);
            string s = dt.ToString("yyyy/MM/01");
            dt = DateTime.Parse(s);
            dt = dt.AddDays(-1);
            string monthEnd = dt.ToString("dd");
            int result = int.Parse(monthEnd) - int.Parse(today);
            label.Text = "月末まで" + result.ToString() + "日";
        }
    }
}
