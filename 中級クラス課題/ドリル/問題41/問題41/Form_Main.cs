﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題41
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            comboBox.Items.Add(textBox.Text);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            comboBox.Items.RemoveAt(comboBox.SelectedIndex);
        }
    }
}
