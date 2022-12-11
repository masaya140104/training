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
            readComboBox();
        }

        private List<string> listNames = new List<string>();

        private void button_Display_Click(object sender, EventArgs e)
        {
            string comboBoxItem = this.comboBox.Text;

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

            displayDataJapanese(listJapanese, comboBoxItem);
            displayDataMath(listMath, comboBoxItem);
            displayDataEnglish(listEnglish, comboBoxItem);
        }

        private void readComboBox()
        {
            StreamReader srNames = new StreamReader(@"C:\Users\Public\Documents\names.txt", Encoding.UTF8);
            while (-1 < srNames.Peek())
            {
                string s = srNames.ReadLine();
                this.listNames.Add(s);
                this.comboBox.Items.Add(s);
            }
            srNames.Close();
        }

        private void displayDataJapanese(List<string[]> listData, string comboBoxItem)
        {
            this.listView_Japanese.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                string[] s = listData[i];
                if (comboBoxItem == s[0])
                {
                    ListViewItem item = new ListViewItem(listData[i]);
                    this.listView_Japanese.Items.Add(item);
                }
            }
        }

        private void displayDataMath(List<string[]> listData, string comboBoxItem)
        {
            this.listView_Math.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                string[] s = listData[i];
                if (comboBoxItem == s[0])
                {
                    ListViewItem item = new ListViewItem(listData[i]);
                    this.listView_Math.Items.Add(item);
                }
            }
        }

        private void displayDataEnglish(List<string[]> listData, string comboBoxItem)
        {
            this.listView_English.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                string[] s = listData[i];
                if (comboBoxItem == s[0])
                {
                    ListViewItem item = new ListViewItem(listData[i]);
                    this.listView_English.Items.Add(item);
                }
            }
        }
    }
}
