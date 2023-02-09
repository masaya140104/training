using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題36
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[] nameOfMonth = { "睦月", "如月", "弥生", "卯月", "皐月", "水無月",
                                     "文月", "葉月", "長月", "神無月", "霜月", "師走" };

            if (1 <= int.Parse(textBox.Text) && 12 >= int.Parse(textBox.Text))
            {
                MessageBox.Show(nameOfMonth[(int.Parse(textBox.Text) - 1)]);
            }
            
        }
    }
}
