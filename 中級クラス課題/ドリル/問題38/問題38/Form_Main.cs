using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題38
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void radioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Male.Checked)
            {
                textBox_Male.Enabled = true;
            }
            else
            {
                textBox_Male.Enabled = false;
            }
        }

        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Female.Checked)
            {
                textBox_Female.Enabled = true;
            }
            else
            {
                textBox_Female.Enabled = false;
            }
        }
    }
}
