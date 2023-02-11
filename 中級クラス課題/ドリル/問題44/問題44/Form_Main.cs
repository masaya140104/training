using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題44
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            comboBox.Items.Add(listBox.SelectedItem.ToString());
            listBox.Items.RemoveAt(listBox.SelectedIndex);
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            listBox.Items.Add(comboBox.SelectedItem);
            comboBox.Items.RemoveAt(comboBox.SelectedIndex);
        }
    }
}
