using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrowseFileSytem
{
    public static class FileNameHelper
    {
        public static string GetNextFileName(string baseFileName)
        {
            var result = baseFileName;
            var filePath = System.IO.Path.GetDirectoryName(baseFileName);
            var extensionPart = System.IO.Path.GetExtension(baseFileName);

            while(System.IO.File.Exists(result))
            {
                var fileNamePart = System.IO.Path.GetFileNameWithoutExtension(result);
                var actuals = GetBaseAndCount(fileNamePart);
                int currentCount = actuals.Item2;
                fileNamePart = actuals.Item1;

                result = string.Format("{0} ({1}){2}",
                                       System.IO.Path.Combine(filePath, fileNamePart),
                                       ++currentCount, extensionPart);
            }

            return System.IO.Path.GetFileName(result);
        }

        private static Tuple<string, int> GetBaseAndCount(string fileNamePart)
        {
            int currentCount = 1;
            string baseName = fileNamePart;

            // if string is non-null and non empty and last char is closing parenthesis
            if(!string.IsNullOrEmpty(fileNamePart) && fileNamePart[fileNamePart.Length - 1] == ')')
            {
                int lastOpeningParenthesis = fileNamePart.LastIndexOf('(');

                if(lastOpeningParenthesis >= 0)
                {
                    // if found opening and closing parenthesis, pull out the number, if parses successfully
                    int numberLength = fileNamePart.Length - lastOpeningParenthesis - 2;
                    if(int.TryParse(fileNamePart.Substring(lastOpeningParenthesis + 1, numberLength),
                                 out currentCount))
                    {
                        baseName = fileNamePart.Substring(0, lastOpeningParenthesis);
                    }
                }
            }

            return new Tuple<string, int>(baseName, currentCount);
        }
    }
}
