namespace ImageFileProcessor
{
    partial class TransferForm
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
            this.DestinationBrowseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.SourceTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceBrowseButton = new System.Windows.Forms.Button();
            this.ProcessButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IncludeFolders = new System.Windows.Forms.CheckBox();
            this.IncludeFiles = new System.Windows.Forms.CheckBox();
            this.SelectedImagesOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SortOutButton = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SelectedImagesTextBox = new System.Windows.Forms.TextBox();
            this.PictureFolderTextBox = new System.Windows.Forms.TextBox();
            this.CopyOnlyCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DestinationBrowseButton
            // 
            this.DestinationBrowseButton.Location = new System.Drawing.Point(395, 11);
            this.DestinationBrowseButton.Name = "DestinationBrowseButton";
            this.DestinationBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.DestinationBrowseButton.TabIndex = 0;
            this.DestinationBrowseButton.Text = "Browse...";
            this.DestinationBrowseButton.UseVisualStyleBackColor = true;
            this.DestinationBrowseButton.Click += new System.EventHandler(this.DestinationBrowseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Destination:";
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(75, 13);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(314, 20);
            this.DestinationTextBox.TabIndex = 2;
            // 
            // SourceTextBox
            // 
            this.SourceTextBox.Location = new System.Drawing.Point(75, 42);
            this.SourceTextBox.Name = "SourceTextBox";
            this.SourceTextBox.Size = new System.Drawing.Size(314, 20);
            this.SourceTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source:";
            // 
            // SourceBrowseButton
            // 
            this.SourceBrowseButton.Location = new System.Drawing.Point(395, 40);
            this.SourceBrowseButton.Name = "SourceBrowseButton";
            this.SourceBrowseButton.Size = new System.Drawing.Size(75, 23);
            this.SourceBrowseButton.TabIndex = 3;
            this.SourceBrowseButton.Text = "Browse...";
            this.SourceBrowseButton.UseVisualStyleBackColor = true;
            this.SourceBrowseButton.Click += new System.EventHandler(this.SourceBrowseButton_Click);
            // 
            // ProcessButton
            // 
            this.ProcessButton.Location = new System.Drawing.Point(6, 68);
            this.ProcessButton.Name = "ProcessButton";
            this.ProcessButton.Size = new System.Drawing.Size(383, 23);
            this.ProcessButton.TabIndex = 6;
            this.ProcessButton.Text = "Process";
            this.ProcessButton.UseVisualStyleBackColor = true;
            this.ProcessButton.Click += new System.EventHandler(this.ProcessButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CopyOnlyCheckbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ProcessButton);
            this.groupBox1.Controls.Add(this.DestinationBrowseButton);
            this.groupBox1.Controls.Add(this.SourceTextBox);
            this.groupBox1.Controls.Add(this.DestinationTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SourceBrowseButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transfer";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.IncludeFolders);
            this.groupBox2.Controls.Add(this.IncludeFiles);
            this.groupBox2.Controls.Add(this.SelectedImagesOutput);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SortOutButton);
            this.groupBox2.Controls.Add(this.BrowseButton);
            this.groupBox2.Controls.Add(this.SelectedImagesTextBox);
            this.groupBox2.Controls.Add(this.PictureFolderTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 273);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort";
            // 
            // IncludeFolders
            // 
            this.IncludeFolders.AutoSize = true;
            this.IncludeFolders.Location = new System.Drawing.Point(111, 86);
            this.IncludeFolders.Name = "IncludeFolders";
            this.IncludeFolders.Size = new System.Drawing.Size(98, 17);
            this.IncludeFolders.TabIndex = 13;
            this.IncludeFolders.Text = "Include Folders";
            this.IncludeFolders.UseVisualStyleBackColor = true;
            // 
            // IncludeFiles
            // 
            this.IncludeFiles.AutoSize = true;
            this.IncludeFiles.Location = new System.Drawing.Point(20, 86);
            this.IncludeFiles.Name = "IncludeFiles";
            this.IncludeFiles.Size = new System.Drawing.Size(85, 17);
            this.IncludeFiles.TabIndex = 12;
            this.IncludeFiles.Text = "Include Files";
            this.IncludeFiles.UseVisualStyleBackColor = true;
            // 
            // SelectedImagesOutput
            // 
            this.SelectedImagesOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedImagesOutput.Location = new System.Drawing.Point(20, 125);
            this.SelectedImagesOutput.Multiline = true;
            this.SelectedImagesOutput.Name = "SelectedImagesOutput";
            this.SelectedImagesOutput.Size = new System.Drawing.Size(436, 142);
            this.SelectedImagesOutput.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SelectedImages";
            // 
            // SortOutButton
            // 
            this.SortOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortOutButton.Location = new System.Drawing.Point(381, 60);
            this.SortOutButton.Name = "SortOutButton";
            this.SortOutButton.Size = new System.Drawing.Size(75, 23);
            this.SortOutButton.TabIndex = 9;
            this.SortOutButton.Text = "Execute";
            this.SortOutButton.UseVisualStyleBackColor = true;
            this.SortOutButton.Click += new System.EventHandler(this.SortOutButton_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(381, 31);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 8;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SelectedImagesTextBox
            // 
            this.SelectedImagesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedImagesTextBox.Location = new System.Drawing.Point(20, 60);
            this.SelectedImagesTextBox.Name = "SelectedImagesTextBox";
            this.SelectedImagesTextBox.Size = new System.Drawing.Size(355, 20);
            this.SelectedImagesTextBox.TabIndex = 7;
            // 
            // PictureFolderTextBox
            // 
            this.PictureFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureFolderTextBox.Location = new System.Drawing.Point(20, 31);
            this.PictureFolderTextBox.Name = "PictureFolderTextBox";
            this.PictureFolderTextBox.Size = new System.Drawing.Size(355, 20);
            this.PictureFolderTextBox.TabIndex = 6;
            // 
            // CopyOnlyCheckbox
            // 
            this.CopyOnlyCheckbox.AutoSize = true;
            this.CopyOnlyCheckbox.Location = new System.Drawing.Point(395, 68);
            this.CopyOnlyCheckbox.Name = "CopyOnlyCheckbox";
            this.CopyOnlyCheckbox.Size = new System.Drawing.Size(50, 17);
            this.CopyOnlyCheckbox.TabIndex = 7;
            this.CopyOnlyCheckbox.Text = "Copy";
            this.CopyOnlyCheckbox.UseVisualStyleBackColor = true;
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TransferForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DestinationBrowseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.TextBox SourceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SourceBrowseButton;
        private System.Windows.Forms.Button ProcessButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SelectedImagesOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SortOutButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox SelectedImagesTextBox;
        private System.Windows.Forms.TextBox PictureFolderTextBox;
        private System.Windows.Forms.CheckBox IncludeFiles;
        private System.Windows.Forms.CheckBox IncludeFolders;
        private System.Windows.Forms.CheckBox CopyOnlyCheckbox;
    }
}

