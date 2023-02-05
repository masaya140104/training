using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題18
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) >= int.Parse(textBox2.Text))
            {
                textBox_Judge.Text = textBox1.Text;
            }
            else
            {
                textBox_Judge.Text = textBox2.Text;
            }
        }
    }
}
