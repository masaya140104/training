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
            StreamReader srNames = new StreamReader(@"C:\Users\Public\Documents\names.txt", Encoding.UTF8);
            List<string> listNames = new List<string>();
            while (-1 < srNames.Peek())
            {
                listNames.Add(srNames.ReadLine());
            }
            srNames.Close();

            StreamReader srResults = new StreamReader(@"C:\Users\Public\Documents\results.txt", Encoding.UTF8);
            List<string[]> listResults = new List<string[]>();
            while (-1 < srResults.Peek())
            {
                string[] s = srResults.ReadLine().Split(' ');
                listResults.Add(s);
            }
            srResults.Close();



            List<string[]> listJapanese = new List<string[]>();
            for (int i = 0; i < listNames.Count; i++)
            {
                string[] s = listResults[i];
                string[] data = {listNames[i], s[0] };
                listJapanese.Add(data);
            }

            List<string[]> listMath = new List<string[]>();
            for (int i = 0; i < listNames.Count; i++)
            {
                string[] s = listResults[i];
                string[] data = { listNames[i], s[1] };
                listMath.Add(data);
            }

            List<string[]> listEnglish = new List<string[]>();
            for (int i = 0; i < listNames.Count; i++)
            {
                string[] s = listResults[i];
                string[] data = { listNames[i], s[0] };
                listEnglish.Add(data);
            }

            displayDataJapanese(listJapanese);
            displayDataMath(listMath);
            displayDataEnglish(listEnglish);
        }

        private void displayDataJapanese(List<string[]> listData)
        {
            this.listView_Japanese.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                ListViewItem item = new ListViewItem(listData[i]);
                this.listView_Japanese.Items.Add(item);
            }
        }

        private void displayDataMath(List<string[]> listData)
        {
            this.listView_Math.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                ListViewItem item = new ListViewItem(listData[i]);
                this.listView_Math.Items.Add(item);
            }
        }

        private void displayDataEnglish(List<string[]> listData)
        {
            this.listView_English.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                ListViewItem item = new ListViewItem(listData[i]);
                this.listView_English.Items.Add(item);
            }
        }
    }
}
