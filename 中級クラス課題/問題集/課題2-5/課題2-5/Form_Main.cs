using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 課題2_5
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string name = this.textBox_Name.Text;
            string month = this.textBox_Month.Text;
            string day = this.textBox_Day.Text;
            MessageBox.Show(name + "さん、あなたは" + month + "月" + day + "日生まれですね。");
        }
    }
}
