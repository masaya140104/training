using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題28
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("男性" + textBox_Male.Text + "人\n"
                            + "女性" + textBox_Female.Text + "人\n"
                            + "合計" + (int.Parse(textBox_Male.Text) + int.Parse(textBox_Female.Text)).ToString() + "人");
        }
    }
}
