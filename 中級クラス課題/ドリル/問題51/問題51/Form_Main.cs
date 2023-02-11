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

namespace 問題51
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\name.txt", Encoding.UTF8);
            string[] s = sr.ReadToEnd().Split(' ');
            sr.Close();

            string name = s[0];
            string age = s[1] + "歳";
            MessageBox.Show(name + "\n" + age);
        }
    }
}
