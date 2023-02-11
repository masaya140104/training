using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題55
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {

            string[] s = new string[5];
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\name.txt", Encoding.UTF8);
            for (int i = 0; i < 5; i++)
            {
                s[i] = sr.ReadLine();
            }
            sr.Close();

            string displayText = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                displayText += (i + 1).ToString() + "番 " + s[i] + "\n";
            }
            MessageBox.Show(displayText);
        }
    }
}
