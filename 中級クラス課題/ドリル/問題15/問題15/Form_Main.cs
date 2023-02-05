using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Multiply_Click(object sender, EventArgs e)
        {
            label_Mark.Text = "×";
            textBox_Result.Text = (int.Parse(textBox1.Text) * int.Parse(textBox2.Text)).ToString();
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            label_Mark.Text = "÷";
            textBox_Result.Text = (int.Parse(textBox1.Text) / int.Parse(textBox2.Text)).ToString();
        }
    }
}
