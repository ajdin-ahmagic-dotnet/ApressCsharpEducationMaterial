using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace Metode_PassbyValue
{
    class Program
    {
        static void Main()
        {
            string punoIme;
            string slovoDiska = "C:";
            string putDoDatoteke = "DATA";
            string imeDatoteke = "index.html";

            punoIme = Kombiniraj(slovoDiska, putDoDatoteke, imeDatoteke);

            Console.WriteLine(punoIme);
            
            using(Process proc = new Process())
            {
                try
                {
                    Process.Start("iexplore", "www.micrsoft.com");
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


            Console.ReadKey();
        }
        private static string Kombiniraj(string slovoDiska, string putDoDatoteke, string imeDatoteke)
        {
            string put;
            put = String.Format("{1}{0}{2}{0}{3}", System.IO.Path.DirectorySeparatorChar, slovoDiska, putDoDatoteke, imeDatoteke);
            return put;
        }
    }
}
