namespace 問題2
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
            this.label = new System.Windows.Forms.Label();
            this.button_y = new System.Windows.Forms.Button();
            this.button_x = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(337, 132);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 24);
            this.label.TabIndex = 0;
            // 
            // button_y
            // 
            this.button_y.Location = new System.Drawing.Point(414, 289);
            this.button_y.Name = "button_y";
            this.button_y.Size = new System.Drawing.Size(132, 40);
            this.button_y.TabIndex = 1;
            this.button_y.Text = "Y";
            this.button_y.UseVisualStyleBackColor = true;
            this.button_y.Click += new System.EventHandler(this.button_y_Click);
            // 
            // button_x
            // 
            this.button_x.Location = new System.Drawing.Point(196, 289);
            this.button_x.Name = "button_x";
            this.button_x.Size = new System.Drawing.Size(132, 40);
            this.button_x.TabIndex = 2;
            this.button_x.Text = "X";
            this.button_x.UseVisualStyleBackColor = true;
            this.button_x.Click += new System.EventHandler(this.button_x_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_x);
            this.Controls.Add(this.button_y);
            this.Controls.Add(this.label);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button_y;
        private System.Windows.Forms.Button button_x;
    }
}

