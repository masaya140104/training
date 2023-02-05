using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題19
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox.Text) % 5 == 0)
            {
                MessageBox.Show("5の倍数です。");
            }
            else
            {
                MessageBox.Show("5の倍数ではありません。");
            }
        }
    }
}
