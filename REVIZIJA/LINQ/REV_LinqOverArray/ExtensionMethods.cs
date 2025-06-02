using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace REV_LinqOverArray
{
    public static class ExtensionMethods
    {
        public static string RemoveSpaces(this string text)
        {
            return text.Replace(" ", "");
        }

        public static string StringReverse(this string text)
        {
            string[] rijeci = text.Split(' '); 
 
            string reverse = rijeci.Aggregate((radnaRecenica, iduca) => iduca + " " + radnaRecenica);

            return reverse + "\n";
           
        }

        public static string CharReverse(this string text)
        {
            char[] arr = text.ToCharArray();
            Array.Reverse(arr);

            return new string(arr);
        }

        public static void DisplayFileInfoTimestamps(this FileInfo fileInfo)
        {
            Console.WriteLine(fileInfo.CreationTime.ToString());
            Console.WriteLine(fileInfo.LastAccessTime.ToString());
            Console.WriteLine(fileInfo.LastWriteTime.ToString());
        }
    }
}
