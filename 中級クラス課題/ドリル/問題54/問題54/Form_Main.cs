using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 問題54
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Public\Documents\name.txt", Encoding.UTF8);
            string s = sr.ReadToEnd();
            sr.Close();


            string[] arr = s.Split('\n');
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i].Replace(",", " ");
                arr[i] = arr[i].Replace("\n", "");
                arr[i] = arr[i].Replace("\r", "");
                arr[i] = arr[i] + "歳";
            }
            string displayText = string.Join("\n", arr);
            MessageBox.Show(displayText);
        }
    }
}
