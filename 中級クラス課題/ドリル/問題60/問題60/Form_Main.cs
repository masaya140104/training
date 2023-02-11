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

namespace 問題60
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string name = "坪倉雅弥";
            int age = 21;
            StreamWriter sw = new StreamWriter(@"C:\Users\Public\Documents\name.txt", false, Encoding.UTF8);
            sw.WriteLine(name + "," + age.ToString());
            sw.Close();
            MessageBox.Show("name.txtに書き込みました。");
        }
    }
}
