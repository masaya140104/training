namespace 問題37
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
            this.textBox_Male = new System.Windows.Forms.TextBox();
            this.textBox_Female = new System.Windows.Forms.TextBox();
            this.checkBox_Female = new System.Windows.Forms.CheckBox();
            this.checkBox_Male = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_Male
            // 
            this.textBox_Male.Enabled = false;
            this.textBox_Male.Location = new System.Drawing.Point(322, 97);
            this.textBox_Male.Name = "textBox_Male";
            this.textBox_Male.Size = new System.Drawing.Size(151, 31);
            this.textBox_Male.TabIndex = 1;
            // 
            // textBox_Female
            // 
            this.textBox_Female.Enabled = false;
            this.textBox_Female.Location = new System.Drawing.Point(322, 154);
            this.textBox_Female.Name = "textBox_Female";
            this.textBox_Female.Size = new System.Drawing.Size(151, 31);
            this.textBox_Female.TabIndex = 1;
            // 
            // checkBox_Female
            // 
            this.checkBox_Female.AutoSize = true;
            this.checkBox_Female.Location = new System.Drawing.Point(131, 154);
            this.checkBox_Female.Name = "checkBox_Female";
            this.checkBox_Female.Size = new System.Drawing.Size(90, 28);
            this.checkBox_Female.TabIndex = 2;
            this.checkBox_Female.Text = "女性";
            this.checkBox_Female.UseVisualStyleBackColor = true;
            this.checkBox_Female.CheckedChanged += new System.EventHandler(this.checkBox_Female_CheckedChanged);
            // 
            // checkBox_Male
            // 
            this.checkBox_Male.AutoSize = true;
            this.checkBox_Male.Location = new System.Drawing.Point(131, 97);
            this.checkBox_Male.Name = "checkBox_Male";
            this.checkBox_Male.Size = new System.Drawing.Size(90, 28);
            this.checkBox_Male.TabIndex = 3;
            this.checkBox_Male.Text = "男性";
            this.checkBox_Male.UseVisualStyleBackColor = true;
            this.checkBox_Male.CheckedChanged += new System.EventHandler(this.checkBox_Male_CheckedChanged);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_Female);
            this.Controls.Add(this.checkBox_Male);
            this.Controls.Add(this.textBox_Female);
            this.Controls.Add(this.textBox_Male);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_Male;
        private System.Windows.Forms.TextBox textBox_Female;
        private System.Windows.Forms.CheckBox checkBox_Female;
        private System.Windows.Forms.CheckBox checkBox_Male;
    }
}

