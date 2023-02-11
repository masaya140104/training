using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題66
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            list.Add("IF太郎");
            list.Add("IF花子");
            list.Add("IF次郎");
            list.Add("IF良子");
            list.Add("IF三郎");

            string displayText = string.Empty;
            for (int i = 0; i < list.Count; i++)
            {
                displayText += list[i] + "\n";
            }

            MessageBox.Show(displayText);

        }
    }
}
