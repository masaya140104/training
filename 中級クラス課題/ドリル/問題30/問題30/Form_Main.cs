using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題30
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
            MessageBox.Show("2番目の要素は" + arrayData[1] + "です。"); 
        }
    }
}
