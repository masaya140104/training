namespace 課題2_8
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Possession = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_latch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.button_dice = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_End = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "所持金";
            // 
            // textBox_Possession
            // 
            this.textBox_Possession.Location = new System.Drawing.Point(415, 60);
            this.textBox_Possession.Name = "textBox_Possession";
            this.textBox_Possession.Size = new System.Drawing.Size(185, 31);
            this.textBox_Possession.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "掛け金を入力してください";
            // 
            // textBox_latch
            // 
            this.textBox_latch.Location = new System.Drawing.Point(415, 97);
            this.textBox_latch.Name = "textBox_latch";
            this.textBox_latch.Size = new System.Drawing.Size(185, 31);
            this.textBox_latch.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "奇数か偶数かを選択してください";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "サイコロを振ってください";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "偶数",
            "奇数"});
            this.comboBox.Location = new System.Drawing.Point(415, 135);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 32);
            this.comboBox.TabIndex = 2;
            // 
            // button_dice
            // 
            this.button_dice.Location = new System.Drawing.Point(415, 173);
            this.button_dice.Name = "button_dice";
            this.button_dice.Size = new System.Drawing.Size(211, 35);
            this.button_dice.TabIndex = 3;
            this.button_dice.Text = "サイコロを振る";
            this.button_dice.UseVisualStyleBackColor = true;
            this.button_dice.Click += new System.EventHandler(this.button_dice_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "サイコロの目は・・・";
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(69, 390);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(211, 35);
            this.button_Start.TabIndex = 3;
            this.button_Start.Text = "ゲーム開始";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(286, 390);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(211, 35);
            this.button_Reset.TabIndex = 3;
            this.button_Reset.Text = "リセット";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_End
            // 
            this.button_End.Location = new System.Drawing.Point(503, 390);
            this.button_End.Name = "button_End";
            this.button_End.Size = new System.Drawing.Size(211, 35);
            this.button_End.TabIndex = 3;
            this.button_End.Text = "終了";
            this.button_End.UseVisualStyleBackColor = true;
            this.button_End.Click += new System.EventHandler(this.button_End_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "円";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "円";
            // 
            // label_Result
            // 
            this.label_Result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Result.Location = new System.Drawing.Point(415, 233);
            this.label_Result.Name = "label_Result";
            this.label_Result.Size = new System.Drawing.Size(299, 143);
            this.label_Result.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_End);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_dice);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_latch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Possession);
            this.Controls.Add(this.label_Result);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "Form_Main";
            this.Text = "奇数偶数ゲーム";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Possession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_latch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button button_dice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_End;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_Result;
    }
}

