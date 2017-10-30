namespace ImageFileProcessor
{
    partial class SortForm
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
            this.PictureFolderTextBox = new System.Windows.Forms.TextBox();
            this.SelectedImagesTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SortOutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectedImagesOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PictureFolderTextBox
            // 
            this.PictureFolderTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureFolderTextBox.Location = new System.Drawing.Point(12, 12);
            this.PictureFolderTextBox.Name = "PictureFolderTextBox";
            this.PictureFolderTextBox.Size = new System.Drawing.Size(355, 20);
            this.PictureFolderTextBox.TabIndex = 0;
            // 
            // SelectedImagesTextBox
            // 
            this.SelectedImagesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedImagesTextBox.Location = new System.Drawing.Point(12, 41);
            this.SelectedImagesTextBox.Name = "SelectedImagesTextBox";
            this.SelectedImagesTextBox.Size = new System.Drawing.Size(355, 20);
            this.SelectedImagesTextBox.TabIndex = 1;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.Location = new System.Drawing.Point(373, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 23);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse...";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SortOutButton
            // 
            this.SortOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SortOutButton.Location = new System.Drawing.Point(373, 41);
            this.SortOutButton.Name = "SortOutButton";
            this.SortOutButton.Size = new System.Drawing.Size(75, 23);
            this.SortOutButton.TabIndex = 3;
            this.SortOutButton.Text = "Execute";
            this.SortOutButton.UseVisualStyleBackColor = true;
            this.SortOutButton.Click += new System.EventHandler(this.SortOutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SelectedImages";
            // 
            // SelectedImagesOutput
            // 
            this.SelectedImagesOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedImagesOutput.Location = new System.Drawing.Point(12, 80);
            this.SelectedImagesOutput.Multiline = true;
            this.SelectedImagesOutput.Name = "SelectedImagesOutput";
            this.SelectedImagesOutput.Size = new System.Drawing.Size(436, 150);
            this.SelectedImagesOutput.TabIndex = 5;
            // 
            // SortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 242);
            this.Controls.Add(this.SelectedImagesOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortOutButton);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.SelectedImagesTextBox);
            this.Controls.Add(this.PictureFolderTextBox);
            this.Name = "SortForm";
            this.Text = "ControlForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SortOutButton;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox SelectedImagesTextBox;
        private System.Windows.Forms.TextBox PictureFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectedImagesOutput;
    }
}