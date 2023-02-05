using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題20
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int max = int.Parse(textBox1.Text);

            if (int.Parse(textBox2.Text) > max)
            {
                max = int.Parse(textBox2.Text);
            }

            if (int.Parse(textBox3.Text) > max)
            {
                max = int.Parse(textBox3.Text);
            }

            if (int.Parse(textBox4.Text) > max)
            {
                max = int.Parse(textBox4.Text);
            }

            if (int.Parse(textBox5.Text) > max)
            {
                max = int.Parse(textBox5.Text);
            }

            MessageBox.Show("最大値は" + max.ToString() + "です。");
        }
    }
}
