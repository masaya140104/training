using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 課題2_7
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            reset();
        }

        private int numeral = 0; 

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.button_Start.Enabled = false;
            this.button_Jadge.Enabled = true;
            this.textBox.Enabled = true;

            Random random = new Random();
            numeral = random.Next(0, 100);
        }

        private void button_Jadge_Click(object sender, EventArgs e)
        {
            if (numeral > int.Parse(this.textBox.Text))
            {
                MessageBox.Show("もっと大きいです。");
            }
            else if(numeral < int.Parse(this.textBox.Text))
            {
                MessageBox.Show("もっと小さいです。");
            }
            else
            {
                MessageBox.Show("正解です。おめでとう！");
                reset();
            }
        }

        private void reset()
        {
            this.button_Start.Enabled = true;
            this.button_Jadge.Enabled = false;
            this.textBox.Enabled = false;
            this.textBox.Text = "";
        }
    }
}
