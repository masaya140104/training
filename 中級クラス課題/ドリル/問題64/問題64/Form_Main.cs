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

namespace 問題64
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Public\Documents\order.txt", false, Encoding.UTF8);
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                sw.WriteLine((i + 1).ToString() + "番　" +listBox.Items[i]);
            }
            sw.Close();
            MessageBox.Show("order.txtに書き込みました。");
        }
    }
}
