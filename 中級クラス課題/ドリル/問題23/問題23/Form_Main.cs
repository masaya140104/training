using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題23
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string s = string.Empty;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    s = s + (i * j).ToString();
                    if (j == 9)
                    {
                        s = s + Environment.NewLine;
                    }
                    else
                    {
                        s = s + ",";
                    }
                }
            }
            textBox.Text = s;
        }
    }
}
