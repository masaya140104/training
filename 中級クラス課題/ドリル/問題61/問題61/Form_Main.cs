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
using System.Xml.Linq;

namespace 問題61
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] names = { "IF太朗", "IF花子", "IF次郎", "IF良子", "IF三郎" };
            StreamWriter sw = new StreamWriter(@"C:\Users\Public\Documents\order.txt", false, Encoding.UTF8);
            for (int i = 0; i < names.Length; i++)
            {
                sw.WriteLine((i + 1).ToString() + " " + names[i]);
            }
            sw.Close();
            MessageBox.Show("order.txtに書き込みました。");
        }
    }
}
