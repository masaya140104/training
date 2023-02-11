using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題48
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string colors = "赤,青,黄,緑,桃,黒,白";
            string[] data = colors.Split(',');
            string displayText = string.Empty;
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = (i + 1).ToString() + "番 " + data[i];
            }
            MessageBox.Show(string.Join(",", data));
        }
    }
}
