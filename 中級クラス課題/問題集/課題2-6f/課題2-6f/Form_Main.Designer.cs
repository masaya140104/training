namespace 課題2_6a
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
            this.button_Display = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox_Members = new System.Windows.Forms.ComboBox();
            this.comboBox_Subject = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(379, 374);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(110, 45);
            this.button_Display.TabIndex = 1;
            this.button_Display.Text = "表示";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(154, 112);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(286, 232);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "点数";
            this.columnHeader4.Width = 50;
            // 
            // comboBox_Members
            // 
            this.comboBox_Members.FormattingEnabled = true;
            this.comboBox_Members.Location = new System.Drawing.Point(84, 374);
            this.comboBox_Members.Name = "comboBox_Members";
            this.comboBox_Members.Size = new System.Drawing.Size(184, 32);
            this.comboBox_Members.TabIndex = 3;
            // 
            // comboBox_Subject
            // 
            this.comboBox_Subject.FormattingEnabled = true;
            this.comboBox_Subject.Items.AddRange(new object[] {
            "国語",
            "数学",
            "英語"});
            this.comboBox_Subject.Location = new System.Drawing.Point(71, 59);
            this.comboBox_Subject.Name = "comboBox_Subject";
            this.comboBox_Subject.Size = new System.Drawing.Size(169, 32);
            this.comboBox_Subject.TabIndex = 4;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 494);
            this.Controls.Add(this.comboBox_Subject);
            this.Controls.Add(this.comboBox_Members);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button_Display);
            this.Name = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox comboBox_Members;
        private System.Windows.Forms.ComboBox comboBox_Subject;
    }
}

