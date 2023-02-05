namespace 問題13
{
    partial class Form1
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
            this.label_Mark = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Mark
            // 
            this.label_Mark.AutoSize = true;
            this.label_Mark.Location = new System.Drawing.Point(195, 141);
            this.label_Mark.Name = "label_Mark";
            this.label_Mark.Size = new System.Drawing.Size(0, 24);
            this.label_Mark.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 31);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 31);
            this.textBox2.TabIndex = 3;
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(451, 141);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(127, 31);
            this.textBox_Result.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "=";
            // 
            // button_Multiply
            // 
            this.button_Multiply.Location = new System.Drawing.Point(451, 234);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(127, 35);
            this.button_Multiply.TabIndex = 7;
            this.button_Multiply.Text = "掛ける";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_Division
            // 
            this.button_Division.Location = new System.Drawing.Point(451, 284);
            this.button_Division.Name = "button_Division";
            this.button_Division.Size = new System.Drawing.Size(127, 35);
            this.button_Division.TabIndex = 6;
            this.button_Division.Text = "割る";
            this.button_Division.UseVisualStyleBackColor = true;
            this.button_Division.Click += new System.EventHandler(this.button_Division_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 352);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Division);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Mark);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Mark;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Division;
    }
}

