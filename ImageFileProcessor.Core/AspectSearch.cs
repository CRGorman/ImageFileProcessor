using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using ImageMagick;

namespace ImageFileProcessor.Core
{
    public class AspectSearch
    {
        public Boolean SortInstagram(string source, bool searchSubdirectories, string destination)
        {
            try
            {
                //Figure out if the directory is real first.
                if (Directory.Exists(source))
                {
                    //Then try to create the source if it doesn't exist.
                    if (!Directory.Exists(destination))
                    {
                        Directory.CreateDirectory(destination);
                    }

                    //Now lets get every image file.
                    DirectoryInfo SourceDI = new DirectoryInfo(source);
                    DirectoryInfo DestinationDI = new DirectoryInfo(destination);
                    List<FileInfo> ImageFiles = SourceDI.GetFiles("", searchSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly).Where(f => SharedData.FileExtensions.Contains(f.Extension)).ToList();

                    ImageFiles.ForEach(image =>
                    {
                        MagickImageInfo ImageInfo = new MagickImageInfo(image.FullName);
                        Single AspectRatio = (Single)ImageInfo.Width / (Single)ImageInfo.Height;
                        if (AspectRatio < 1.02 && AspectRatio > 0.98)
                        {
                            //This one is close enough in aspect ratio, copy it to the decided directory.
                            String DestinationFilename = Path.Combine(DestinationDI.FullName, image.Name);
                            if (!File.Exists(DestinationFilename))
                            {
                                File.Copy(image.FullName, DestinationFilename);
                            }
                        }
                    });

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex) { return false; }
        }
    }
}
