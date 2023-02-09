using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題35
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[,] arrayDate = { { 5, 1, 3, 2, 1 }, 
                                 { 5, 9, 4, 6, 7 }, 
                                 { 9, 10, 31, 12, 9 },
                                 { 13, 14, 15, 20, 18 }, 
                                 { 10, 13, 14, 15, 21 } };

            string s = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                int max = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (max < arrayDate[i, j])
                    {
                        max = arrayDate[i, j];
                    }
                }
                s = s + (i + 1).ToString() + "行目の最大値 = " + max.ToString() + "です。\n";
            }
            MessageBox.Show(s);
        }
    }
}
