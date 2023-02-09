using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題29
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[] arrayData = { 42, 32, 31, 31, 29 };
            MessageBox.Show("4番目の要素は" + arrayData[3].ToString() + "です。");
        }
    }
}
