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
            textBox_Male.Enabled = radioButton_Male.Checked;
        }

        private void radioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Female.Enabled = radioButton_Female.Checked;
        }
    }
}
