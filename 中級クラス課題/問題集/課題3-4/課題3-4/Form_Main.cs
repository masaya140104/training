using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 課題3_4
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            string constellation = constellationJudge();
            MessageBox.Show(this.textBox_Name.Text + "さん、あなたは" + constellation + "ですね。");
        }

        private string constellationJudge()
        {
            string constellation = string.Empty;
            int i = 0;

            if (int.Parse(this.textBox_Day.Text) < 10)
            {
                i = int.Parse(textBox_Month.Text + "0" + textBox_Day.Text);
            }
            else
            {
                i = int.Parse(textBox_Month.Text + textBox_Day.Text);
            }
            
            if (i <= 119)
            {
                constellation = "やぎ座";
            }
            else if (i <= 218)
            {
                constellation = "みずがめ座";
            }
            else if (i <= 320)
            {
                constellation = "うお座";
            }
            else if (i <= 419)
            {
                constellation = "おひつじ座";
            }
            else if (i <= 520)
            {
                constellation = "おうし座";
            }
            else if (i <= 621)
            {
                constellation = "ふたご座";
            }
            else if (i <= 722)
            {
                constellation = "かに座";
            }
            else if (i <= 822)
            {
                constellation = "しし座";
            }
            else if (i <= 922)
            {
                constellation = "おとめ座";
            }
            else if (i <= 1023)
            {
                constellation = "てんびん座";
            }
            else if (i <= 1122)
            {
                constellation = "さそり座";
            }
            else if (i <= 1221)
            {
                constellation = "いて座";
            }
            else
            {
                constellation = "やぎ座";
            }

            return constellation;
        }
    }
}
