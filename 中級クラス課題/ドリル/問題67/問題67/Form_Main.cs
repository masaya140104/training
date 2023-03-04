using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題67
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
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\name.txt", Encoding.UTF8);
            string[] s = sr.ReadToEnd().Split('\n');
            for (int i = 0; i < s.Length; i++)
            {
                arrayList.Add(s[i]);
            }

            string displayText = string.Empty;
            for (int j = 0; j < arrayList.Count; j++)
            {
                displayText += (string)arrayList[j] + "\n";
            }

            MessageBox.Show(displayText);
        }
    }
}
