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
            try
            {
                //First, add three digits to all the destination files if they're needed.
                //IMG_0000
                Regex GeneralExpression = new Regex("[A-Z]{3}_[0-9]{4}");
                DirectoryInfo DI = new DirectoryInfo(DestinationTextBox.Text);
                DI.GetFiles("IMG_????.*", SearchOption.AllDirectories).Where(y => GeneralExpression.IsMatch(y.Name)).ToList().ForEach(x =>
                 {
                     //For each file, add in the 100 if its nessisary.
                     String NewName = x.Name.Substring(0, 4) + "100_" + x.Name.Substring(4);
                     NewName = Path.Combine(x.DirectoryName, NewName);
                     if (CopyOnlyCheckbox.Checked)
                     {
                         File.Copy(x.FullName, NewName);
                     }
                     else
                     {
                         File.Move(x.FullName, NewName);
                     }
                 });
                //Next, compile what needs moving.
                DI = new DirectoryInfo(SourceTextBox.Text);
                DI.GetFiles("IMG_????.*", SearchOption.AllDirectories).ToList().ForEach(x =>
                {
                    String SetDirectory = x.Directory.Name.Substring(0, 3);
                    String NewName = x.Name.Substring(0, 4) + SetDirectory + "_" + x.Name.Substring(4);
                    NewName = Path.Combine(DestinationTextBox.Text, NewName);
                    if (CopyOnlyCheckbox.Checked)
                    {
                        File.Copy(x.FullName, NewName);
                    }
                    else
                    {
                        File.Move(x.FullName, NewName);
                    }
                });
                //Videos MVI
                DI.GetFiles("MVI_????.*", SearchOption.AllDirectories).ToList().ForEach(x =>
                {
                    String SetDirectory = x.Directory.Name.Substring(0, 3);
                    String NewName = x.Name.Substring(0, 4) + SetDirectory + "_" + x.Name.Substring(4);
                    NewName = Path.Combine(DestinationTextBox.Text, NewName);
                    if (CopyOnlyCheckbox.Checked)
                    {
                        File.Copy(x.FullName, NewName);
                    }
                    else
                    {
                        File.Move(x.FullName, NewName);
                    }
                });
            }
            catch (Exception ex)
            {

            }
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
            List<Int32> SelectedList = ParseList();
            if (SelectedList.Any())
            {
                DirectoryInfo DI = new DirectoryInfo(PictureFolderTextBox.Text);
                if (DI.Exists)
                {
                    List<FileInfo> ImageFiles = new List<FileInfo>();
                    //We need to add a list of files that aren't of images to compensate for onedrive.
                    Int32 ExtraItems = 0;
                    if (IncludeFiles.Checked)
                    {
                        ExtraItems += DI.GetFiles().Count() - DI.GetFiles("IMG_*").Count();
                    }
                    //And folders.
                    if (IncludeFolders.Checked)
                    {
                        ExtraItems += DI.GetDirectories().Count();
                    }
                    //Now add them as blanks.
                    for (Int32 i = 0; i < ExtraItems; i++)
                    {
                        ImageFiles.Add(null);
                    }
                    ImageFiles.AddRange(DI.GetFiles("IMG_*"));

                    List<FileInfo> SelectedImageFiles = new List<FileInfo>();
                    SelectedList.ForEach(x =>
                    {
                        SelectedImageFiles.Add(ImageFiles[x - 1]);
                    });
                    SelectedImageFiles.ForEach(x =>
                    {
                        SelectedImagesOutput.Text += x.Name + ", ";
                    });
                    SelectedImagesOutput.Text.TrimEnd(new char[] { ' ', ',' });
                }
                else
                {
                    MessageBox.Show("Cannot find image directory.");
                }
            }
            else
            {
                MessageBox.Show("Selected list is empty.");
            }
        }

        private List<Int32> ParseList()
        {
            try
            {
                List<String> SplitListA = SelectedImagesTextBox.Text.Split(',', ' ').ToList();
                //Let's parse anything with a - into something useful
                List<String> SplitListB = new List<String>();
                SplitListA.ForEach(x =>
                {
                    if (x.Contains('-'))
                    {
                        //This is an "everything between a and b"
                        Int32 StartPoint, EndPoint;
                        try
                        {
                            Int32.TryParse(x.Substring(0, x.IndexOf('-')), out StartPoint);
                            Int32.TryParse(x.Substring(x.IndexOf('-') + 1), out EndPoint);
                            for (Int32 CurrentPoint = StartPoint; CurrentPoint <= EndPoint; CurrentPoint++)
                            {
                                SplitListB.Add(CurrentPoint.ToString());
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else
                    {
                        SplitListB.Add(x);
                    }
                });
                Int32 ExpendableNumber;
                SplitListB.RemoveAll(x => !Int32.TryParse(x, out ExpendableNumber));
                return SplitListB.Select(x => Int32.Parse(x.Trim())).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new List<Int32>();
            }
        }
        #endregion
    }
}
