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
            DateTime dt = DateTime.Now;
            dt = dt.AddMonths(1);
            string s = dt.ToString("yyyy/MM/01");
            dt = DateTime.Parse(s);
            dt = dt.AddDays(-1);
            label.Text = dt.ToString("今月はdd日");        
        }
    }
}
