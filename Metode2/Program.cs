using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;

namespace Metode2
{
    class Program
    {
        static int Main(string[] args)
        {
            int rezultat;
            string targetFileName = null;
            switch(args.Length)
            {
                case 0:
                    Console.WriteLine("GREŠKA: Morate specificirate URL za download:");
                    break;
                case 1:
                    targetFileName = Path.GetFileName(args[0]);
                    break;
                case 2:
                    targetFileName = args[1];
                    break;
                default:
                    Console.WriteLine("Ovo je switch default...");
                    break;
            }

            if(targetFileName != null)
            {
                using(WebClient webCl = new WebClient())
                {
                    webCl.DownloadFile(args[0], targetFileName);
                }
                rezultat = 0;

            }
            else
            {
                Console.WriteLine("Downloader.exe <URL> <TargetFileName>");
                rezultat = 1;
            }
            Console.ReadKey();
            return rezultat;
        }
    }
}
