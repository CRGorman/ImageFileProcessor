using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace ImageFileProcessor.Core
{
    public class SelectionProcessor
    {
        public String SortList(String directory, String selections, Boolean includeFiles)
        {
            String sortedList = String.Empty;
            List<Int32> SelectedList = ParseList(selections);
            if (SelectedList.Any())
            {
                DirectoryInfo DI = new DirectoryInfo(directory);
                if (DI.Exists)
                {
                    List<FileInfo> ImageFiles = new List<FileInfo>();
                    //We need to add a list of files that aren't of images to compensate for onedrive.
                    Int32 ExtraItems = 0;
                    if (includeFiles)
                    {
                        ExtraItems += DI.GetFiles().Count() - DI.GetFiles("*.jpg").Count();
                    }
                    //And folders.
                    if (includeFiles)
                    {
                        ExtraItems += DI.GetDirectories().Count();
                    }
                    //Now add them as blanks.
                    for (Int32 i = 0; i < ExtraItems; i++)
                    {
                        ImageFiles.Add(null);
                    }
                    ImageFiles.AddRange(DI.GetFiles("*.jpg"));

                    List<FileInfo> SelectedImageFiles = new List<FileInfo>();
                    SelectedList.ForEach(x =>
                    {
                        SelectedImageFiles.Add(ImageFiles[x - 1]);
                    });
                    SelectedImageFiles.ForEach(x =>
                    {
                        sortedList += x.Name + ", ";
                    });
                    sortedList.TrimEnd(new char[] { ' ', ',' });
                }
                else
                {
                    sortedList = "Cannot find image directory.";
                }
            }
            else
            {
                sortedList = "Selected list is empty.";
            }
            return sortedList;
        }

        private List<Int32> ParseList(String selectedImages)
        {
            try
            {
                List<String> SplitListA = selectedImages.Split(',', ' ').ToList();
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
                throw;
            }
        }
    }
}
