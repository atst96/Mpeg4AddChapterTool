namespace Mpeg4AddChapterTool
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ColumnHeader columnHeader1;
            System.Windows.Forms.ColumnHeader columnHeader2;
            System.Windows.Forms.ColumnHeader columnHeader3;
            System.Windows.Forms.TextBox textBox1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Button selectMp4BoxButton;
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chapterItemList = new System.Windows.Forms.ListView();
            this.chapterRemoveButton = new System.Windows.Forms.Button();
            this.addFolderButton = new System.Windows.Forms.Button();
            this.chapterAddButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.abortButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            selectMp4BoxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "動画ファイル";
            columnHeader1.Width = 240;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "チャプター情報1";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "チャプター情報2";
            columnHeader3.Width = 120;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "Mp4BoxPath", true));
            textBox1.Location = new System.Drawing.Point(6, 36);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(524, 25);
            textBox1.TabIndex = 1;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Mpeg4AddChapterTool.Settings);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(6, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 18);
            label1.TabIndex = 0;
            label1.Text = "MP4Boxのパス";
            // 
            // selectMp4BoxButton
            // 
            selectMp4BoxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            selectMp4BoxButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            selectMp4BoxButton.Location = new System.Drawing.Point(536, 34);
            selectMp4BoxButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            selectMp4BoxButton.Name = "selectMp4BoxButton";
            selectMp4BoxButton.Size = new System.Drawing.Size(77, 29);
            selectMp4BoxButton.TabIndex = 0;
            selectMp4BoxButton.Text = "参照";
            selectMp4BoxButton.UseVisualStyleBackColor = true;
            selectMp4BoxButton.Click += new System.EventHandler(this.OnSelectMp4BoxButtonClicked);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.closeButton.Location = new System.Drawing.Point(534, 333);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(103, 29);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.OnCloseButtonClicked);
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.runButton.Enabled = false;
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.runButton.Location = new System.Drawing.Point(425, 333);
            this.runButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(103, 29);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "実行";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.OnRunButtonClicked);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 312);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chapterItemList);
            this.tabPage1.Controls.Add(this.chapterRemoveButton);
            this.tabPage1.Controls.Add(this.addFolderButton);
            this.tabPage1.Controls.Add(this.chapterAddButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(621, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "チャプター一覧";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chapterItemList
            // 
            this.chapterItemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterItemList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            columnHeader1,
            columnHeader2,
            columnHeader3});
            this.chapterItemList.FullRowSelect = true;
            this.chapterItemList.Location = new System.Drawing.Point(6, 7);
            this.chapterItemList.Name = "chapterItemList";
            this.chapterItemList.Size = new System.Drawing.Size(503, 267);
            this.chapterItemList.TabIndex = 1;
            this.chapterItemList.UseCompatibleStateImageBehavior = false;
            this.chapterItemList.View = System.Windows.Forms.View.Details;
            this.chapterItemList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OnChapterItemSelectionChanged);
            this.chapterItemList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            // 
            // chapterRemoveButton
            // 
            this.chapterRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterRemoveButton.Enabled = false;
            this.chapterRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chapterRemoveButton.Location = new System.Drawing.Point(515, 45);
            this.chapterRemoveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chapterRemoveButton.Name = "chapterRemoveButton";
            this.chapterRemoveButton.Size = new System.Drawing.Size(100, 29);
            this.chapterRemoveButton.TabIndex = 2;
            this.chapterRemoveButton.Text = "削除";
            this.chapterRemoveButton.UseVisualStyleBackColor = true;
            this.chapterRemoveButton.Click += new System.EventHandler(this.OnChapterRemoveButtonClicked);
            // 
            // addFolderButton
            // 
            this.addFolderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addFolderButton.Location = new System.Drawing.Point(515, 98);
            this.addFolderButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addFolderButton.Name = "addFolderButton";
            this.addFolderButton.Size = new System.Drawing.Size(100, 29);
            this.addFolderButton.TabIndex = 3;
            this.addFolderButton.Text = "一括追加";
            this.addFolderButton.UseVisualStyleBackColor = true;
            this.addFolderButton.Click += new System.EventHandler(this.OnAddFolderButtonClicked);
            // 
            // chapterAddButton
            // 
            this.chapterAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chapterAddButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chapterAddButton.Location = new System.Drawing.Point(515, 8);
            this.chapterAddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chapterAddButton.Name = "chapterAddButton";
            this.chapterAddButton.Size = new System.Drawing.Size(100, 29);
            this.chapterAddButton.TabIndex = 3;
            this.chapterAddButton.Text = "追加";
            this.chapterAddButton.UseVisualStyleBackColor = true;
            this.chapterAddButton.Click += new System.EventHandler(this.OnChapterAddButtonClicked);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.consoleTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(621, 286);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "実行結果";
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleTextBox.Font = new System.Drawing.Font("ＭＳ ゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.consoleTextBox.ForeColor = System.Drawing.Color.Azure;
            this.consoleTextBox.Location = new System.Drawing.Point(4, 4);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.ReadOnly = true;
            this.consoleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.consoleTextBox.Size = new System.Drawing.Size(613, 278);
            this.consoleTextBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(textBox1);
            this.tabPage3.Controls.Add(label1);
            this.tabPage3.Controls.Add(selectMp4BoxButton);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(621, 286);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSource, "RemoveSucceedItems", true));
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(6, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(285, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "処理が正常に終了した項目を一覧から削除する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // abortButton
            // 
            this.abortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.abortButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.abortButton.Location = new System.Drawing.Point(534, 333);
            this.abortButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.abortButton.Name = "abortButton";
            this.abortButton.Size = new System.Drawing.Size(103, 29);
            this.abortButton.TabIndex = 0;
            this.abortButton.Text = "中止(&A)";
            this.abortButton.UseVisualStyleBackColor = true;
            this.abortButton.Visible = false;
            this.abortButton.Click += new System.EventHandler(this.OnAbortButtonClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(12, 333);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(222, 29);
            this.progressBar1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(653, 375);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.abortButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.closeButton);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView chapterItemList;
        private System.Windows.Forms.Button chapterRemoveButton;
        private System.Windows.Forms.Button chapterAddButton;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Button abortButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addFolderButton;
    }
}

