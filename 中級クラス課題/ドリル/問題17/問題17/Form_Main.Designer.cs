namespace 問題17
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
            this.textBox_Input = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.textBox_Judge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox_Input
            // 
            this.textBox_Input.Location = new System.Drawing.Point(115, 117);
            this.textBox_Input.Name = "textBox_Input";
            this.textBox_Input.Size = new System.Drawing.Size(171, 31);
            this.textBox_Input.TabIndex = 0;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(406, 236);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(171, 40);
            this.button.TabIndex = 1;
            this.button.Text = "判定";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox_Judge
            // 
            this.textBox_Judge.Location = new System.Drawing.Point(406, 117);
            this.textBox_Judge.Name = "textBox_Judge";
            this.textBox_Judge.Size = new System.Drawing.Size(171, 31);
            this.textBox_Judge.TabIndex = 0;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox_Judge);
            this.Controls.Add(this.textBox_Input);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Input;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox_Judge;
    }
}

