using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題31
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            int[] arrayData = { 10, 15, 32, 8, 20 };
            int average = 0;
            for (int i = 0; i < arrayData.Length; i++)
            {
                average += arrayData[i];
            }
            average /= arrayData.Length;
            MessageBox.Show("平均は" + average.ToString() + "です。");
        }
    }
}
