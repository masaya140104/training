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

            List<string[]> listData = new List<string[]>();
            for (int i = 0; i < listNames.Count; i++)
            {
                string[] s = listResults[i];
                string[] data = {listNames[i], s[0], s[1], s[2] };
                listData.Add(data);
            }

            displayData(listData);
        }

        private void displayData(List<string[]> listData)
        {
            this.listView.Items.Clear();
            for (int i = 0; i < listData.Count; i++)
            {
                ListViewItem item = new ListViewItem(listData[i]);
                this.listView.Items.Add(item);
            }
        }
    }
}
