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

namespace 課題2_12a
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private List<string[]> datas = new List<string[]>(); 

        private void button_Read_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void button_Write_Click(object sender, EventArgs e)
        {
            this.saveFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            readData(this.openFileDialog.FileName);
            displayData();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            writeData(this.saveFileDialog.FileName);
        }

        private void readData(string fileName)
        {
            this.datas.Clear();

            StreamReader sr = new StreamReader(fileName, Encoding.GetEncoding("shift_jis"));

            while(-1 < sr.Peek())
            {
                string[] data = sr.ReadLine().Split(',');
                this.datas.Add(data);

            }

            sr.Close();
        }

        private void displayData()
        {
            this.listView.Items.Clear();

            for (int i = 0; i < this.datas.Count; i++)
            {
                string[] data = this.datas[i];
                ListViewItem item = new ListViewItem(data);
                this.listView.Items.Add(item);
            }  
        }

        private void writeData(string fileName)
        {
            if (this.listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("保存する住所を選択してください。");
            }
            else
            {
                int[] id = new int[this.listView.SelectedItems.Count];
                int selectedItemCount = this.listView.SelectedItems.Count;
                for (int i = 0; i < selectedItemCount; i++)
                {
                    id[i] = this.listView.SelectedIndices[0];
                    this.listView.Items[id[i]].Selected = false;
                }

                StreamWriter sr = new StreamWriter(fileName, false, Encoding.GetEncoding("shift_jis"));

                for (int i = 0; i < selectedItemCount; i++)
                {
                    string[] data = this.datas[id[i]];
                    string writeData = data[0] + "," + data[1];
                    sr.WriteLine(writeData);
                }

                sr.Close();
            }
        }
    }
}
