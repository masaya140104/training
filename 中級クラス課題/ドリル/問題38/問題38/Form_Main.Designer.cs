namespace 問題38
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
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.textBox_Male = new System.Windows.Forms.TextBox();
            this.radioButton_Female = new System.Windows.Forms.RadioButton();
            this.textBox_Female = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Location = new System.Drawing.Point(216, 123);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Male.TabIndex = 0;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "男性";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            this.radioButton_Male.CheckedChanged += new System.EventHandler(this.radioButton_Male_CheckedChanged);
            // 
            // textBox_Male
            // 
            this.textBox_Male.Enabled = false;
            this.textBox_Male.Location = new System.Drawing.Point(436, 123);
            this.textBox_Male.Name = "textBox_Male";
            this.textBox_Male.Size = new System.Drawing.Size(174, 31);
            this.textBox_Male.TabIndex = 1;
            // 
            // radioButton_Female
            // 
            this.radioButton_Female.AutoSize = true;
            this.radioButton_Female.Location = new System.Drawing.Point(216, 183);
            this.radioButton_Female.Name = "radioButton_Female";
            this.radioButton_Female.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Female.TabIndex = 0;
            this.radioButton_Female.TabStop = true;
            this.radioButton_Female.Text = "女性";
            this.radioButton_Female.UseVisualStyleBackColor = true;
            this.radioButton_Female.CheckedChanged += new System.EventHandler(this.radioButton_Female_CheckedChanged);
            // 
            // textBox_Female
            // 
            this.textBox_Female.Enabled = false;
            this.textBox_Female.Location = new System.Drawing.Point(436, 183);
            this.textBox_Female.Name = "textBox_Female";
            this.textBox_Female.Size = new System.Drawing.Size(174, 31);
            this.textBox_Female.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Female);
            this.Controls.Add(this.radioButton_Female);
            this.Controls.Add(this.textBox_Male);
            this.Controls.Add(this.radioButton_Male);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.TextBox textBox_Male;
        private System.Windows.Forms.RadioButton radioButton_Female;
        private System.Windows.Forms.TextBox textBox_Female;
    }
}

