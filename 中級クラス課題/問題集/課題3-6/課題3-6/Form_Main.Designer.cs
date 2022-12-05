namespace 課題2_2a
{
    partial class Form_Main
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
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_Execution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(41, 55);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(212, 32);
            this.label.TabIndex = 1;
            this.label.Text = "名前を入れてください";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(326, 48);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 39);
            this.textBox.TabIndex = 2;
            // 
            // button_Execution
            // 
            this.button_Execution.Location = new System.Drawing.Point(236, 131);
            this.button_Execution.Name = "button_Execution";
            this.button_Execution.Size = new System.Drawing.Size(150, 46);
            this.button_Execution.TabIndex = 3;
            this.button_Execution.Text = "おみくじを引く";
            this.button_Execution.UseVisualStyleBackColor = true;
            this.button_Execution.Click += new System.EventHandler(this.button_Execution_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 200);
            this.Controls.Add(this.button_Execution);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label;
        private TextBox textBox;
        private Button button_Execution;
    }
}