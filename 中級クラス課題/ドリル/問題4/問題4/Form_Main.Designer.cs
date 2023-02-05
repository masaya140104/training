namespace 問題4
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
            this.label_A = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.label_B = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(97, 80);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(167, 24);
            this.label_A.TabIndex = 0;
            this.label_A.Text = "テキストボックスA";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(101, 194);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(163, 31);
            this.textBox_A.TabIndex = 1;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(292, 303);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(134, 37);
            this.button.TabIndex = 2;
            this.button.Text = "移動";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(451, 80);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(167, 24);
            this.label_B.TabIndex = 0;
            this.label_B.Text = "テキストボックスB";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(455, 194);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(163, 31);
            this.textBox_B.TabIndex = 1;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textBox_B);
            this.Controls.Add(this.label_B);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.label_A);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox textBox_B;
    }
}

