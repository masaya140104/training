using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題34
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string[,] arrayData = { { "1", "2", "3", "4", "5" }, 
                                    { "5", "6", "7", "8", "9" },
                                    { "9", "10", "11", "12", "13" }, 
                                    { "13", "14", "15", "16", "17" },
                                    { "17", "18", "19", "20", "21" } };

            string s = string.Empty;
            for (int i = 0; i < 5; i++)
            {
                int sum = 0;
                for (int j = 0; j < 5; j++)
                {
                    sum += int.Parse(arrayData[i,j]);
                }
                s = s + (i + 1).ToString() + "行目の合計 = " + sum.ToString() + "\n";
            }
            MessageBox.Show(s);
        }
    }
}
