namespace 問4
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
            this.button_end = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button_sum
            // 
            this.button_sum.Location = new System.Drawing.Point(187, 331);
            this.button_sum.Name = "button_sum";
            this.button_sum.Size = new System.Drawing.Size(150, 46);
            this.button_sum.TabIndex = 1;
            this.button_sum.Text = "合計表示";
            this.button_sum.UseVisualStyleBackColor = true;
            this.button_sum.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_end
            // 
            this.button_end.Location = new System.Drawing.Point(187, 383);
            this.button_end.Name = "button_end";
            this.button_end.Size = new System.Drawing.Size(150, 46);
            this.button_end.TabIndex = 1;
            this.button_end.Text = "終了";
            this.button_end.UseVisualStyleBackColor = true;
            this.button_end.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 32;
            this.listBox.Items.AddRange(new object[] {
            "5",
            "10",
            "25",
            "8",
            "14",
            "11",
            "24",
            "87",
            "56",
            "71",
            "53",
            "22",
            "31",
            "38",
            "61",
            "99",
            "77",
            "28",
            "1",
            "39"});
            this.listBox.Location = new System.Drawing.Point(187, 23);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(240, 292);
            this.listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_end);
            this.Controls.Add(this.button_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button button_sum;
        private Button button_end;
        private ListBox listBox;
    }
}