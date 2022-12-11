namespace 課題3_4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Month = new System.Windows.Forms.TextBox();
            this.textBox_Day = new System.Windows.Forms.TextBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "氏名、誕生日を入力してください";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "氏名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "月";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "日";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(232, 99);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(218, 31);
            this.textBox_Name.TabIndex = 2;
            // 
            // textBox_Month
            // 
            this.textBox_Month.Location = new System.Drawing.Point(232, 165);
            this.textBox_Month.Name = "textBox_Month";
            this.textBox_Month.Size = new System.Drawing.Size(218, 31);
            this.textBox_Month.TabIndex = 2;
            // 
            // textBox_Day
            // 
            this.textBox_Day.Location = new System.Drawing.Point(232, 239);
            this.textBox_Day.Name = "textBox_Day";
            this.textBox_Day.Size = new System.Drawing.Size(218, 31);
            this.textBox_Day.TabIndex = 2;
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(267, 327);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(183, 40);
            this.button_Display.TabIndex = 3;
            this.button_Display.Text = "表示";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 431);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.textBox_Day);
            this.Controls.Add(this.textBox_Month);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Month;
        private System.Windows.Forms.TextBox textBox_Day;
        private System.Windows.Forms.Button button_Display;
    }
}

