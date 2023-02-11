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

namespace 問題53
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[,] datas = new string[2, 2];
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\name.txt", Encoding.UTF8);
            for (int i = 0; i < 2; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                datas[i,0] = s[0];
                datas[i,1] = s[1];
            }
            sr.Close();

            string displayText = string.Empty;
            for (int i = 0; i < 2; i++)
            {
                string[] s = { datas[i, 0], datas[i, 1] } ;
                string name = s[0];
                string age = s[1] + "歳";
                displayText += name + " " + age + "\n";
            }
            MessageBox.Show(displayText);
        }
    }
}
