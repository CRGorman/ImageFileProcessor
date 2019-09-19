using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ImageFileProcessor.Core
{
    class Fixer
    {
        public void Fix(string directoryToFix)
        {
            Regex GeneralExpression = new Regex("[A-Z]{3}_[0-9]{4}");
            DirectoryInfo DI = new DirectoryInfo(directoryToFix);
            DI.GetFiles("IMG_????.*", SearchOption.AllDirectories).Where(y => GeneralExpression.IsMatch(y.Name)).ToList().ForEach(x =>
            {
                //For each file, add in the 100 if its nessisary.
                String NewName = x.Name.Substring(0, 4) + "100_" + x.Name.Substring(4);
                NewName = Path.Combine(x.DirectoryName, NewName);
                File.Move(x.FullName, NewName);
            });

            //Next, fix the move error.
            GeneralExpression = new Regex("[A-Z]{3}_[0-9]{3}_[0-9]{4}");
            DI = new DirectoryInfo(directoryToFix);
            DI.GetFiles("IMG_???_????*", SearchOption.AllDirectories).Where(y => GeneralExpression.IsMatch(y.Name)).ToList().ForEach(x =>
            {
                //For each file, add in the 100 if its nessisary.
                String NewName = x.Name.Substring(0, 4) + x.Directory.Name.Substring(0, 3) + "_" + x.Name.Substring(x.Name.Length - 8);
                NewName = Path.Combine(x.DirectoryName, NewName);
                File.Move(x.FullName, NewName);
            });
        }
    }
}
