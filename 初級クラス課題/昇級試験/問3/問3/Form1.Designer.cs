namespace 問3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sum = new System.Windows.Forms.Button();
            this.label_sum = new System.Windows.Forms.Label();
            this.label_tax_display = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_end = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label_tax = new System.Windows.Forms.Label();
            this.label_sum_display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_sum
            // 
            this.button_sum.Location = new System.Drawing.Point(435, 139);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(150, 46);
            this.button_sum.TabIndex = 0;
            this.button_sum.Text = "加算";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_sum
            // 
            this.label_sum.AutoSize = true;
            this.label_sum.Location = new System.Drawing.Point(50, 72);
            this.label_sum.Name = "label_sum";
            this.label_sum.Size = new System.Drawing.Size(62, 32);
            this.label_sum.TabIndex = 1;
            this.label_sum.Text = "合計";
            // 
            // label_tax_display
            // 
            this.label_tax_display.AutoSize = true;
            this.label_tax_display.Location = new System.Drawing.Point(152, 139);
            this.label_tax_display.Name = "label_tax_display";
            this.label_tax_display.Size = new System.Drawing.Size(27, 32);
            this.label_tax_display.TabIndex = 1;
            this.label_tax_display.Text = "0";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(435, 200);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(150, 46);
            this.button_reset.TabIndex = 0;
            this.button_reset.Text = "初期化";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(435, 265);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(150, 46);
            this.button_end.TabIndex = 0;
            this.button_end.Text = "終了";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(435, 65);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 39);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "0";
            // 
            // label_tax
            // 
            this.label_tax.AutoSize = true;
            this.label_tax.Location = new System.Drawing.Point(50, 139);
            this.label_tax.Name = "label_tax";
            this.label_tax.Size = new System.Drawing.Size(83, 32);
            this.label_tax.TabIndex = 1;
            this.label_tax.Text = "税込み";
            // 
            // label_sum_display
            // 
            this.label_sum_display.AutoSize = true;
            this.label_sum_display.Location = new System.Drawing.Point(152, 72);
            this.label_sum_display.Name = "label_sum_display";
            this.label_sum_display.Size = new System.Drawing.Size(27, 32);
            this.label_sum_display.TabIndex = 1;
            this.label_sum_display.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label_sum_display);
            this.Controls.Add(this.label_tax_display);
            this.Controls.Add(this.label_tax);
            this.Controls.Add(this.label_sum);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_sum;
        private Label label_sum;
        private Label label_tax_display;
        private Button button_reset;
        private Button button_end;
        private TextBox textBox;
        private Label label_tax;
        private Label label_sum_display;
    }
}