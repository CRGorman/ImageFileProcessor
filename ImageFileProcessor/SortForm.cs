using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageFileProcessor
{
    public partial class SortForm : Form
    {
        public SortForm()
        {
            InitializeComponent();
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            FBD.RootFolder = Environment.SpecialFolder.MyPictures;
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
                    List<FileInfo> ImageFiles = DI.GetFiles("IMG_*").ToList();
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
                List<String> SplitListA = SelectedImagesTextBox.Text.Split(',').ToList();
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
    }
}
