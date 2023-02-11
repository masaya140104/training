using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題77
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string pos_X = button.Location.X.ToString();
            string pos_Y = button.Location.Y.ToString();
            string pos = pos_X + "," + pos_Y;
            string width = button.Size.Width.ToString();
            string height = button.Size.Height.ToString();
            label.Text = "ボタンの左上の座標は「" + pos + "」\n" +
                "サイズは「幅 = " + width + "」「高さ = " + height + "」";
        }
    }
}
