using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題17
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox_Input.Text) > 0)
            {
                textBox_Judge.Text = "正の整数";
            }
            else if (int.Parse(textBox_Input.Text) < 0)
            {
                textBox_Judge.Text = "負の整数";
            }
            else //0の場合
            {
                textBox_Judge.Text = string.Empty;
            }
        }
    }
}
