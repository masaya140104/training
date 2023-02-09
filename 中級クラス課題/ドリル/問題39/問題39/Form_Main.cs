using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題39
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (radioButton_Adult.Checked == true)
            {
                if (radioButton_Ikebukuro.Checked == true)
                {
                    MessageBox.Show("運賃は150円になります。");
                }
                if (radioButton_Sibuya.Checked == true)
                {
                    MessageBox.Show("運賃は150円になります。");
                }
                if (radioButton_Sinagawa.Checked == true)
                {
                    MessageBox.Show("運賃は190円になります。");
                }
                if (radioButton_Tokyo.Checked == true)
                {
                    MessageBox.Show("運賃は190円になります。");
                }
                if (radioButton_Ueno.Checked == true)
                {
                    MessageBox.Show("運賃は190円になります。");
                }
            }
            else if (radioButton_Child.Checked == true)
            {
                if (radioButton_Ikebukuro.Checked == true)
                {
                    MessageBox.Show("運賃は70円になります。");
                }
                if (radioButton_Sibuya.Checked == true)
                {
                    MessageBox.Show("運賃は70円になります。");
                }
                if (radioButton_Sinagawa.Checked == true)
                {
                    MessageBox.Show("運賃は90円になります。");
                }
                if (radioButton_Tokyo.Checked == true)
                {
                    MessageBox.Show("運賃は90円になります。");
                }
                if (radioButton_Ueno.Checked == true)
                {
                    MessageBox.Show("運賃は90円になります。");
                }
            }
        }
    }
}
