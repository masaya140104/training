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

namespace 課題2_6a
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tsubo\source\repos\インフィニット・フィールド\training\中級クラス課題\問題集\課題2-6a\names.txt", Encoding.UTF8);
            List<string> list = new List<string>();
            while (-1 < sr.Peek())
            {
                list.Add(sr.ReadLine());
            }
            sr.Close();

            this.listBox.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                string s = list[i];
                this.listBox.Items.Add(s);
            }
        }
    }
}
