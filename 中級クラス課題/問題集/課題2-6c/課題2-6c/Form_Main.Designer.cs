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
            this.listView_Japanese = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Math = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_English = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(474, 383);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(110, 45);
            this.button_Display.TabIndex = 1;
            this.button_Display.Text = "表示";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // listView_Japanese
            // 
            this.listView_Japanese.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4});
            this.listView_Japanese.FullRowSelect = true;
            this.listView_Japanese.GridLines = true;
            this.listView_Japanese.HideSelection = false;
            this.listView_Japanese.Location = new System.Drawing.Point(91, 37);
            this.listView_Japanese.Name = "listView_Japanese";
            this.listView_Japanese.Size = new System.Drawing.Size(286, 290);
            this.listView_Japanese.TabIndex = 2;
            this.listView_Japanese.UseCompatibleStateImageBehavior = false;
            this.listView_Japanese.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 80;
            // 
            // listView_Math
            // 
            this.listView_Math.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader5});
            this.listView_Math.FullRowSelect = true;
            this.listView_Math.GridLines = true;
            this.listView_Math.HideSelection = false;
            this.listView_Math.Location = new System.Drawing.Point(386, 37);
            this.listView_Math.Name = "listView_Math";
            this.listView_Math.Size = new System.Drawing.Size(286, 290);
            this.listView_Math.TabIndex = 2;
            this.listView_Math.UseCompatibleStateImageBehavior = false;
            this.listView_Math.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "名前";
            this.columnHeader2.Width = 80;
            // 
            // listView_English
            // 
            this.listView_English.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader6});
            this.listView_English.FullRowSelect = true;
            this.listView_English.GridLines = true;
            this.listView_English.HideSelection = false;
            this.listView_English.Location = new System.Drawing.Point(678, 37);
            this.listView_English.Name = "listView_English";
            this.listView_English.Size = new System.Drawing.Size(286, 290);
            this.listView_English.TabIndex = 2;
            this.listView_English.UseCompatibleStateImageBehavior = false;
            this.listView_English.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "名前";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "国語";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "数学";
            this.columnHeader5.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "英語";
            this.columnHeader6.Width = 50;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 494);
            this.Controls.Add(this.listView_English);
            this.Controls.Add(this.listView_Math);
            this.Controls.Add(this.listView_Japanese);
            this.Controls.Add(this.button_Display);
            this.Name = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.ListView listView_Japanese;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ListView listView_Math;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView listView_English;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}

