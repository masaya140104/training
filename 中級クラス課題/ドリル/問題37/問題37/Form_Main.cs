﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題37
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void checkBox_Male_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Male.Enabled = checkBox_Male.Checked;
        }

        private void checkBox_Female_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Female.Enabled = checkBox_Female.Checked;
        }
    }
}
