using Microsoft.VisualBasic.ApplicationServices;
using System.Text;
using System.IO;
using System;

namespace 課題2_2a
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"C:\Users\tsubo\source\repos\インフィニット・フィールド\training\中級クラス課題\問題集\課題2-4\おみくじ.txt", Encoding.UTF8);
            
            List<string> list = new List<string>();
            
            while (-1 < sr.Peek())
            {
                string s = sr.ReadLine();
                list.Add(s);
            }
            sr.Close();

            Random rand = new Random();

            int x = rand.Next(0, 11);           

            MessageBox.Show(textBox.Text + "さん" + "本日の運勢は..."  + "\n" + list[x]);
        }
    }
}