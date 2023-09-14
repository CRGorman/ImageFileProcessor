using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ImageFileProcessor.Core
{
    public class FileMover
    {
        const string NAME_OVERRIDE = "IMG_";

        public bool MoveFileset(string source, string destination, bool copyOnly, ref BackgroundWorker backgroundWorker)
        {
            try
            {
                //First, add three digits to all the destination files if they're needed.
                //IMG_0000

                //Next, compile what needs moving.
                var dI = new DirectoryInfo(source);
                var imageFiles = dI.GetFiles("IMG_????.*", SearchOption.AllDirectories).ToList();
                if (!imageFiles.Any())
                {
                    //Dud, try to be a little less zelous when searching.
                    imageFiles = dI.GetFiles("???_????.*", SearchOption.AllDirectories).ToList();
                }
                if (!imageFiles.Any())
                {
                    //Dud, failure.
                    imageFiles = dI.GetFiles("???_????.*", SearchOption.AllDirectories).ToList();
                }

                int imageCount = imageFiles.Count;
                int progressCount = 0;

                for (int i = 0; i < imageCount; i++)
                {
                    var image = imageFiles[i];
                    string setDirectory = image.Directory.Name.Substring(0, 3);
                    string newName = (!string.IsNullOrWhiteSpace(NAME_OVERRIDE) ? NAME_OVERRIDE : image.Name.Substring(0, 4)) + setDirectory + "_" + image.Name.Substring(4);
                    newName = Path.Combine(destination, newName);
                    if (copyOnly)
                    {
                        File.Copy(image.FullName, newName);
                    }
                    else
                    {
                        File.Move(image.FullName, newName);
                    }
                    progressCount++;
                    backgroundWorker.ReportProgress(progressCount / imageCount * 100);
                }

                //Videos MVI
                var videoFiles = dI.GetFiles("MVI_????.*", SearchOption.AllDirectories).ToList();
                videoFiles.ForEach(x =>
                {
                    string SetDirectory = x.Directory.Name.Substring(0, 3);
                    string NewName = x.Name.Substring(0, 4) + SetDirectory + "_" + x.Name.Substring(4);
                    NewName = Path.Combine(destination, NewName);
                    if (copyOnly)
                    {
                        File.Copy(x.FullName, NewName);
                    }
                    else
                    {
                        File.Move(x.FullName, NewName);
                    }
                });
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
