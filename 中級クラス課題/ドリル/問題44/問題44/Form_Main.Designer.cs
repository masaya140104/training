namespace 問題44
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
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_Left = new System.Windows.Forms.Button();
            this.button_Right = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "東京",
            "大阪",
            "愛知",
            "福岡",
            "沖縄"});
            this.comboBox.Location = new System.Drawing.Point(75, 85);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 32);
            this.comboBox.TabIndex = 0;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 24;
            this.listBox.Location = new System.Drawing.Point(444, 85);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(241, 196);
            this.listBox.TabIndex = 1;
            // 
            // button_Left
            // 
            this.button_Left.Location = new System.Drawing.Point(256, 173);
            this.button_Left.Name = "button_Left";
            this.button_Left.Size = new System.Drawing.Size(124, 32);
            this.button_Left.TabIndex = 2;
            this.button_Left.Text = "←";
            this.button_Left.UseVisualStyleBackColor = true;
            this.button_Left.Click += new System.EventHandler(this.button_Left_Click);
            // 
            // button_Right
            // 
            this.button_Right.Location = new System.Drawing.Point(256, 85);
            this.button_Right.Name = "button_Right";
            this.button_Right.Size = new System.Drawing.Size(124, 32);
            this.button_Right.TabIndex = 2;
            this.button_Right.Text = "→";
            this.button_Right.UseVisualStyleBackColor = true;
            this.button_Right.Click += new System.EventHandler(this.button_Right_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Right);
            this.Controls.Add(this.button_Left);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.comboBox);
            this.Name = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_Left;
        private System.Windows.Forms.Button button_Right;
    }
}

