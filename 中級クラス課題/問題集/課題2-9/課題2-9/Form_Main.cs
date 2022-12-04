using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 課題2_9
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] today = DateTime.Today.ToString("yyyy MM dd").Split(' ');
            string[] birthday = this.dateTimePicker.Value.ToString("yyyy MM dd").Split(' ');

            if (int.Parse(today[2]) < int.Parse(birthday[2]))
            {
                today[2] = (int.Parse(today[2]) + 30).ToString();
                today[1] = (int.Parse(today[1]) - 1).ToString();
            }
            
            if (int.Parse(today[1]) < int.Parse(birthday[1]))
            {
                today[1] = (int.Parse(today[1]) + 12).ToString();
                today[0] = (int.Parse(today[0]) - 1).ToString();
            }

            int year = (int.Parse(today[0]) - int.Parse(birthday[0])) * 365;
            int month = (int.Parse(today[1]) - int.Parse(birthday[1])) * 30;
            int day = int.Parse(today[2]) - int.Parse(birthday[2]);

            int result = year + month + day;

            MessageBox.Show("あなたが生まれてから" + result.ToString() + "日目です。");
        }
    }
}
