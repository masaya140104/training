﻿namespace 課題2_1
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
            this.button = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(390, 145);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(150, 46);
            this.button.TabIndex = 0;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(86, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(219, 32);
            this.label.TabIndex = 1;
            this.label.Text = "年齢はいくつですか？";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(340, 61);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(200, 39);
            this.textBox.TabIndex = 2;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 264);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button);
            this.Name = "Form_Main";
            this.Text = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button;
        private Label label;
        private TextBox textBox;
    }
}