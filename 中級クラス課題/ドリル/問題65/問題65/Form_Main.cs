using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題65
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                arrayList.Add(i + 1);
            }

            int sum = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                sum += (int)arrayList[i];
            }

            MessageBox.Show("1～10まで合計した結果は" + sum.ToString() + "です。");
        }
    }
}
