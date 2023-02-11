using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題79
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            label.Location = new Point(label.Location.X - 10, label.Location.Y);
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            label.Location = new Point(label.Location.X + 10, label.Location.Y);
        }
    }
}
