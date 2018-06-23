namespace Mpeg4AddChapterTool
{
    partial class ChapterFileSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button cancelButton;
            System.Windows.Forms.Button chapterFile1Button;
            System.Windows.Forms.Button videoFileButton;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Button chapterFile2Button;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.TextBox chapterFile1TextBox;
            System.Windows.Forms.TextBox chapterFile2TextBox;
            System.Windows.Forms.TextBox videoFileTextBox;
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acceptButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            cancelButton = new System.Windows.Forms.Button();
            chapterFile1Button = new System.Windows.Forms.Button();
            videoFileButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            chapterFile2Button = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            chapterFile1TextBox = new System.Windows.Forms.TextBox();
            chapterFile2TextBox = new System.Windows.Forms.TextBox();
            videoFileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            cancelButton.Location = new System.Drawing.Point(340, 253);
            cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(103, 29);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "キャンセル";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // chapterFile1Button
            // 
            chapterFile1Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chapterFile1Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chapterFile1Button.Location = new System.Drawing.Point(363, 93);
            chapterFile1Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chapterFile1Button.Name = "chapterFile1Button";
            chapterFile1Button.Size = new System.Drawing.Size(80, 29);
            chapterFile1Button.TabIndex = 1;
            chapterFile1Button.Text = "参照";
            chapterFile1Button.UseVisualStyleBackColor = true;
            chapterFile1Button.Click += new System.EventHandler(this.OnChapterFile1ButtonClicked);
            // 
            // videoFileButton
            // 
            videoFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            videoFileButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            videoFileButton.Location = new System.Drawing.Point(363, 34);
            videoFileButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            videoFileButton.Name = "videoFileButton";
            videoFileButton.Size = new System.Drawing.Size(80, 29);
            videoFileButton.TabIndex = 1;
            videoFileButton.Text = "参照";
            videoFileButton.UseVisualStyleBackColor = true;
            videoFileButton.Click += new System.EventHandler(this.OnVideoFileButtonClicked);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label1.Location = new System.Drawing.Point(12, 74);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(99, 18);
            label1.TabIndex = 3;
            label1.Text = "チャプター情報1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label2.Location = new System.Drawing.Point(12, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(131, 18);
            label2.TabIndex = 3;
            label2.Text = "動画ファイル (*.mp4)";
            // 
            // chapterFile2Button
            // 
            chapterFile2Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chapterFile2Button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            chapterFile2Button.Location = new System.Drawing.Point(363, 152);
            chapterFile2Button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            chapterFile2Button.Name = "chapterFile2Button";
            chapterFile2Button.Size = new System.Drawing.Size(80, 29);
            chapterFile2Button.TabIndex = 1;
            chapterFile2Button.Text = "参照";
            chapterFile2Button.UseVisualStyleBackColor = true;
            chapterFile2Button.Click += new System.EventHandler(this.OnChapterFile2ButtonClicked);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            label3.Location = new System.Drawing.Point(12, 133);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(99, 18);
            label3.TabIndex = 3;
            label3.Text = "チャプター情報2";
            // 
            // chapterFile1TextBox
            // 
            chapterFile1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chapterFile1TextBox.BackColor = System.Drawing.SystemColors.Window;
            chapterFile1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "ChapterFileName", true));
            chapterFile1TextBox.Location = new System.Drawing.Point(12, 95);
            chapterFile1TextBox.Name = "chapterFile1TextBox";
            chapterFile1TextBox.ReadOnly = true;
            chapterFile1TextBox.Size = new System.Drawing.Size(345, 25);
            chapterFile1TextBox.TabIndex = 2;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Mpeg4AddChapterTool.ChapterItem);
            // 
            // chapterFile2TextBox
            // 
            chapterFile2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chapterFile2TextBox.BackColor = System.Drawing.SystemColors.Window;
            chapterFile2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "ChapterFileName2", true));
            chapterFile2TextBox.Location = new System.Drawing.Point(12, 154);
            chapterFile2TextBox.Name = "chapterFile2TextBox";
            chapterFile2TextBox.ReadOnly = true;
            chapterFile2TextBox.Size = new System.Drawing.Size(345, 25);
            chapterFile2TextBox.TabIndex = 2;
            // 
            // videoFileTextBox
            // 
            videoFileTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            videoFileTextBox.BackColor = System.Drawing.SystemColors.Window;
            videoFileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource, "VideoFileName", true));
            videoFileTextBox.Location = new System.Drawing.Point(12, 36);
            videoFileTextBox.Name = "videoFileTextBox";
            videoFileTextBox.ReadOnly = true;
            videoFileTextBox.Size = new System.Drawing.Size(345, 25);
            videoFileTextBox.TabIndex = 2;
            // 
            // acceptButton
            // 
            this.acceptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Enabled = false;
            this.acceptButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.acceptButton.Location = new System.Drawing.Point(231, 253);
            this.acceptButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(103, 29);
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "OK";
            this.acceptButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "チャプター情報2 … Nero形式とApple形式など、複数のフォーマットのチャプターを使用する場合";
            // 
            // ChapterFileSelector
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = cancelButton;
            this.ClientSize = new System.Drawing.Size(455, 295);
            this.Controls.Add(this.label4);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(videoFileTextBox);
            this.Controls.Add(chapterFile2TextBox);
            this.Controls.Add(chapterFile1TextBox);
            this.Controls.Add(videoFileButton);
            this.Controls.Add(chapterFile2Button);
            this.Controls.Add(chapterFile1Button);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(cancelButton);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChapterFileSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "チャプター情報の選択";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}