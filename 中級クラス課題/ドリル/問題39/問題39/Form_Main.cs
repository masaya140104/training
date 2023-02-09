using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
            int fare = 0;
            if (radioButton_Adult.Checked)
            {
                if (radioButton_Ikebukuro.Checked)
                {
                    fare = 150;
                }
                if (radioButton_Sibuya.Checked)
                {
                    fare = 150;
                }
                if (radioButton_Sinagawa.Checked)
                {
                    fare = 190;
                }
                if (radioButton_Tokyo.Checked)
                {
                    fare = 190;
                }
                if (radioButton_Ueno.Checked)
                {
                    fare = 190;
                }
            }
            else if (radioButton_Child.Checked)
            {
                if (radioButton_Ikebukuro.Checked)
                {
                    fare = 70;
                }
                if (radioButton_Sibuya.Checked)
                {
                    fare = 70;
                }
                if (radioButton_Sinagawa.Checked)
                {
                    fare = 90;
                }
                if (radioButton_Tokyo.Checked)
                {
                    fare = 90;
                }
                if (radioButton_Ueno.Checked)
                {
                    fare = 90;
                }
            }
            MessageBox.Show("運賃は" + fare.ToString() + "円になります。");
        }
    }
}
