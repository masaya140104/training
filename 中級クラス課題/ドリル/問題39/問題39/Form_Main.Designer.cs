namespace 問題39
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
            this.groupBox_Human = new System.Windows.Forms.GroupBox();
            this.radioButton_Adult = new System.Windows.Forms.RadioButton();
            this.radioButton_Child = new System.Windows.Forms.RadioButton();
            this.groupBox_Place = new System.Windows.Forms.GroupBox();
            this.radioButton_Sibuya = new System.Windows.Forms.RadioButton();
            this.radioButton_Ikebukuro = new System.Windows.Forms.RadioButton();
            this.radioButton_Tokyo = new System.Windows.Forms.RadioButton();
            this.radioButton_Ueno = new System.Windows.Forms.RadioButton();
            this.radioButton_Sinagawa = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.groupBox_Human.SuspendLayout();
            this.groupBox_Place.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Human
            // 
            this.groupBox_Human.Controls.Add(this.radioButton_Child);
            this.groupBox_Human.Controls.Add(this.radioButton_Adult);
            this.groupBox_Human.Location = new System.Drawing.Point(109, 61);
            this.groupBox_Human.Name = "groupBox_Human";
            this.groupBox_Human.Size = new System.Drawing.Size(176, 239);
            this.groupBox_Human.TabIndex = 0;
            this.groupBox_Human.TabStop = false;
            this.groupBox_Human.Text = "大人・子供";
            // 
            // radioButton_Adult
            // 
            this.radioButton_Adult.AutoSize = true;
            this.radioButton_Adult.Location = new System.Drawing.Point(17, 64);
            this.radioButton_Adult.Name = "radioButton_Adult";
            this.radioButton_Adult.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Adult.TabIndex = 1;
            this.radioButton_Adult.TabStop = true;
            this.radioButton_Adult.Text = "大人";
            this.radioButton_Adult.UseVisualStyleBackColor = true;
            // 
            // radioButton_Child
            // 
            this.radioButton_Child.AutoSize = true;
            this.radioButton_Child.Location = new System.Drawing.Point(17, 123);
            this.radioButton_Child.Name = "radioButton_Child";
            this.radioButton_Child.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Child.TabIndex = 1;
            this.radioButton_Child.TabStop = true;
            this.radioButton_Child.Text = "子供";
            this.radioButton_Child.UseVisualStyleBackColor = true;
            // 
            // groupBox_Place
            // 
            this.groupBox_Place.Controls.Add(this.radioButton_Ueno);
            this.groupBox_Place.Controls.Add(this.radioButton_Sinagawa);
            this.groupBox_Place.Controls.Add(this.radioButton_Sibuya);
            this.groupBox_Place.Controls.Add(this.radioButton_Tokyo);
            this.groupBox_Place.Controls.Add(this.radioButton_Ikebukuro);
            this.groupBox_Place.Location = new System.Drawing.Point(346, 61);
            this.groupBox_Place.Name = "groupBox_Place";
            this.groupBox_Place.Size = new System.Drawing.Size(283, 239);
            this.groupBox_Place.TabIndex = 1;
            this.groupBox_Place.TabStop = false;
            this.groupBox_Place.Text = "行き先";
            // 
            // radioButton_Sibuya
            // 
            this.radioButton_Sibuya.AutoSize = true;
            this.radioButton_Sibuya.Location = new System.Drawing.Point(17, 123);
            this.radioButton_Sibuya.Name = "radioButton_Sibuya";
            this.radioButton_Sibuya.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Sibuya.TabIndex = 1;
            this.radioButton_Sibuya.TabStop = true;
            this.radioButton_Sibuya.Text = "渋谷";
            this.radioButton_Sibuya.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ikebukuro
            // 
            this.radioButton_Ikebukuro.AutoSize = true;
            this.radioButton_Ikebukuro.Location = new System.Drawing.Point(17, 64);
            this.radioButton_Ikebukuro.Name = "radioButton_Ikebukuro";
            this.radioButton_Ikebukuro.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Ikebukuro.TabIndex = 1;
            this.radioButton_Ikebukuro.TabStop = true;
            this.radioButton_Ikebukuro.Text = "池袋";
            this.radioButton_Ikebukuro.UseVisualStyleBackColor = true;
            // 
            // radioButton_Tokyo
            // 
            this.radioButton_Tokyo.AutoSize = true;
            this.radioButton_Tokyo.Location = new System.Drawing.Point(164, 64);
            this.radioButton_Tokyo.Name = "radioButton_Tokyo";
            this.radioButton_Tokyo.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Tokyo.TabIndex = 1;
            this.radioButton_Tokyo.TabStop = true;
            this.radioButton_Tokyo.Text = "東京";
            this.radioButton_Tokyo.UseVisualStyleBackColor = true;
            // 
            // radioButton_Ueno
            // 
            this.radioButton_Ueno.AutoSize = true;
            this.radioButton_Ueno.Location = new System.Drawing.Point(164, 123);
            this.radioButton_Ueno.Name = "radioButton_Ueno";
            this.radioButton_Ueno.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Ueno.TabIndex = 1;
            this.radioButton_Ueno.TabStop = true;
            this.radioButton_Ueno.Text = "上野";
            this.radioButton_Ueno.UseVisualStyleBackColor = true;
            // 
            // radioButton_Sinagawa
            // 
            this.radioButton_Sinagawa.AutoSize = true;
            this.radioButton_Sinagawa.Location = new System.Drawing.Point(17, 180);
            this.radioButton_Sinagawa.Name = "radioButton_Sinagawa";
            this.radioButton_Sinagawa.Size = new System.Drawing.Size(89, 28);
            this.radioButton_Sinagawa.TabIndex = 1;
            this.radioButton_Sinagawa.TabStop = true;
            this.radioButton_Sinagawa.Text = "品川";
            this.radioButton_Sinagawa.UseVisualStyleBackColor = true;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(486, 331);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(143, 44);
            this.button.TabIndex = 2;
            this.button.Text = "運賃表示";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.groupBox_Place);
            this.Controls.Add(this.groupBox_Human);
            this.Name = "Form_Main";
            this.groupBox_Human.ResumeLayout(false);
            this.groupBox_Human.PerformLayout();
            this.groupBox_Place.ResumeLayout(false);
            this.groupBox_Place.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Human;
        private System.Windows.Forms.RadioButton radioButton_Child;
        private System.Windows.Forms.RadioButton radioButton_Adult;
        private System.Windows.Forms.GroupBox groupBox_Place;
        private System.Windows.Forms.RadioButton radioButton_Ueno;
        private System.Windows.Forms.RadioButton radioButton_Sinagawa;
        private System.Windows.Forms.RadioButton radioButton_Sibuya;
        private System.Windows.Forms.RadioButton radioButton_Tokyo;
        private System.Windows.Forms.RadioButton radioButton_Ikebukuro;
        private System.Windows.Forms.Button button;
    }
}

