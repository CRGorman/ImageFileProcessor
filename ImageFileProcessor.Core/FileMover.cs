using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ImageFileProcessor.Core
{
    public class FileMover
    {
        public Boolean MoveFileset(String source, String destination, Boolean copyOnly)
        {
            try
            {
                //First, add three digits to all the destination files if they're needed.
                //IMG_0000

                //Next, compile what needs moving.
                var DI = new DirectoryInfo(source);
                var ImageFiles = DI.GetFiles("IMG_????.*", SearchOption.AllDirectories).ToList();
                ImageFiles.ForEach(x =>
                {
                    String SetDirectory = x.Directory.Name.Substring(0, 3);
                    String NewName = x.Name.Substring(0, 4) + SetDirectory + "_" + x.Name.Substring(4);
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

                //Videos MVI
                var VideoFiles = DI.GetFiles("MVI_????.*", SearchOption.AllDirectories).ToList();
                VideoFiles.ForEach(x =>
                {
                    String SetDirectory = x.Directory.Name.Substring(0, 3);
                    String NewName = x.Name.Substring(0, 4) + SetDirectory + "_" + x.Name.Substring(4);
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
