using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 問題74
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
            DayOfWeek dayOfWeek = dt.DayOfWeek;

            switch (dayOfWeek)
            {
                case DayOfWeek.Sunday:
                    label.Text = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    label.Text = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    label.Text = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    label.Text = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    label.Text = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    label.Text = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    label.Text = "土曜日";
                    break;
            }
        }
    }
}
