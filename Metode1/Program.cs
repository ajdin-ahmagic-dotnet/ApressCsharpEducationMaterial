using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode1
{
    class Program
    {
        static void Main()
        {
            string ime;
            string prezime;
            string punoIme;


            Console.WriteLine("POZDRAV LJUDI! MALO VIŠE ZABAVE SA METODAMA");

            ime = UzmiKorisnikovUlaz("Molim vas recite nam svoje ime:");
            prezime = UzmiKorisnikovUlaz("Molim vas recite nam svoje prezime:");

            // Puno ime:
            punoIme = DajMiPunoIme(ime, prezime);

            PrikaziPozdrav(punoIme);

            using(Process mojProcess = new Process())
            {

                try
                {
                    mojProcess.StartInfo.UseShellExecute = true;
                    mojProcess.StartInfo.FileName = @"C:\Users\Wylde\Documents\Visual Studio 2012\Projects\MojProgramGlavni2013v\MojProgram\bin\Debug\MojProgram.exe";
                    mojProcess.StartInfo.CreateNoWindow = false;
                    mojProcess.Start();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }

        #region Metode

        private static string UzmiKorisnikovUlaz(string ulaz)
        {
            Console.Write(ulaz);
            return Console.ReadLine();
        }
        private static string DajMiPunoIme(string ime, string prezime)
        {
            return String.Format("{0} {1}", ime, prezime);
        }

        static void PrikaziPozdrav(string ime)
        {
            Console.WriteLine("Vaše puno ime je {0}.", ime);
            return;
        }

        #endregion

    }
}
