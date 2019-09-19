using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using ImageFileProcessor.Core;

namespace ImageFileProcessor
{
    public partial class TransferForm : Form
    {
        public TransferForm()
        {
            InitializeComponent();
            DestinationTextBox.Text = Properties.Settings.Default.DestinationDirectory;
            SourceTextBox.Text = Properties.Settings.Default.SourceDirectory;
        }

        #region Transfer

        private void DestinationBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.DestinationDirectory))
            {
                FBD.SelectedPath = Properties.Settings.Default.DestinationDirectory;
            }
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.DestinationDirectory = FBD.SelectedPath;
            }
            DestinationTextBox.Text = Properties.Settings.Default.DestinationDirectory;
        }

        private void SourceBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (!String.IsNullOrWhiteSpace(Properties.Settings.Default.SourceDirectory))
            {
                FBD.SelectedPath = Properties.Settings.Default.SourceDirectory;
            }
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.SourceDirectory = FBD.SelectedPath;
            }
            SourceTextBox.Text = Properties.Settings.Default.SourceDirectory;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            FileMover fileMover = new FileMover();
            fileMover.MoveFileset(SourceTextBox.Text, DestinationTextBox.Text, CopyOnlyCheckbox.Checked);
        }
        #endregion

        #region Sorting

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (!String.IsNullOrWhiteSpace(PictureFolderTextBox.Text))
            {
                if (Directory.Exists(PictureFolderTextBox.Text))
                {
                    FBD.SelectedPath = PictureFolderTextBox.Text;
                }
            }
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                PictureFolderTextBox.Text = FBD.SelectedPath;
            }
            //OpenFileDialog OFD = new OpenFileDialog();
            //OFD.
        }

        private void SortOutButton_Click(object sender, EventArgs e)
        {
            SelectionProcessor selectionProcessor = new SelectionProcessor();
            selectionProcessor.SortList(PictureFolderTextBox.Text, SelectedImagesTextBox.Text, IncludeFiles.Checked);
        }

        #endregion
    }
}
