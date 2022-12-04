using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace 課題2_8
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            reset();
        }

        private string signal = string.Empty;

        private void button_Start_Click(object sender, EventArgs e)
        {
            this.button_Start.Enabled = false;
            this.textBox_latch.Enabled = true;
            this.button_Reset.Enabled = true;

            game();
            
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button_End_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ゲームを終了します。よろしいですか？",
                "ゲームの終了",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            ;
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }

        }

        private void button_dice_Click(object sender, EventArgs e)
        {
            this.label_Result.Text = "";

            Random random = new Random();
            int result1 = random.Next(1, 7);
            int result2 = random.Next(1, 7);
            string[] text = judge(result1, result2);
            this.label_Result.Text = result1.ToString() + "-" + result2.ToString() + "の" + text[0] + "\n" + text[1] + "です";

            if (text[1] == "勝ち")
            {
                this.textBox_Possession.Text = (int.Parse(this.textBox_Possession.Text) + int.Parse(this.textBox_latch.Text)).ToString();
            }
            else
            {
                this.textBox_Possession.Text = (int.Parse(this.textBox_Possession.Text) - int.Parse(this.textBox_latch.Text)).ToString();
                if (int.Parse(this.textBox_Possession.Text) <= 0)
                {
                    this.textBox_Possession.Text = 0.ToString();
                    gameover();
                }
            }

            this.textBox_latch.Text = "";
            this.comboBox.Enabled = false;
            this.comboBox.SelectedIndex = -1;
            this.button_dice.Enabled = false;
        }

        private void reset()
        {
            this.textBox_Possession.Text = "10000";
            this.textBox_latch.Text = "";
            this.label_Result.Text = "";

            this.button_Start.Enabled = true;
            this.button_Reset.Enabled = false;
            this.textBox_latch.Enabled = false;
            this.button_dice.Enabled = false;
            this.comboBox.Enabled = false;
            this.label_Result.Enabled = false;    
        }

        private void game()
        {
            signal = "on";
            while (signal == "on")
            {
                if (this.textBox_latch.Text != "")
                {
                    this.comboBox.Enabled = true;
                }
                if (this.comboBox.Text != "")
                {
                    this.button_dice.Enabled = true;
                }
                this.label_Result.Enabled = true;
                Application.DoEvents();
            }
        }

        private string[] judge(int result1, int result2)
        {
            int sum = result1 + result2;
            string[] text = new string[2];
            switch (this.comboBox.Text)
            {
                case "偶数":
                    text[0] = "偶数";
                    if (sum % 2 == 0)
                    {
                        text[1] = "勝ち";
                    }
                    else
                    {
                        text[1] = "負け";
                    }
                    break;
                case "奇数":
                    text[0] = "奇数";
                    if (sum % 2 == 0)
                    {
                        text[1] = "負け";
                    }
                    else
                    {
                        text[1] = "勝ち";
                    }
                    break;
            }
            return text;
        }

        private void gameover()
        {
            MessageBox.Show("ゲームオーバー");
            reset();
        }
    }
}
