namespace 課題7
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
            this.button = new System.Windows.Forms.Button();
            this.label_Left = new System.Windows.Forms.Label();
            this.label_Right = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(296, 270);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(144, 40);
            this.button.TabIndex = 0;
            this.button.Text = "交換";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // label_Left
            // 
            this.label_Left.AutoSize = true;
            this.label_Left.Location = new System.Drawing.Point(211, 95);
            this.label_Left.Name = "label_Left";
            this.label_Left.Size = new System.Drawing.Size(34, 24);
            this.label_Left.TabIndex = 1;
            this.label_Left.Text = "赤";
            // 
            // label_Right
            // 
            this.label_Right.AutoSize = true;
            this.label_Right.Location = new System.Drawing.Point(485, 95);
            this.label_Right.Name = "label_Right";
            this.label_Right.Size = new System.Drawing.Size(34, 24);
            this.label_Right.TabIndex = 1;
            this.label_Right.Text = "青";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Right);
            this.Controls.Add(this.label_Left);
            this.Controls.Add(this.button);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label_Left;
        private System.Windows.Forms.Label label_Right;
    }
}

