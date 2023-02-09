using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題32
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[] arrayData = { "鈴木一郎", "山田花子", "佐藤良子", "田中次郎", "伊藤太郎" };
            string s = string.Empty;
            for (int i = 0; i < arrayData.Length; i++)
            {
                s += (i + 1).ToString() + "番 " + arrayData[i] + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
