using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace Exception_Proces_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: SIMPLE EXCEPTION PRIMJER ---                 ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Yellow;Console.SetBufferSize(134, 100);

            #region Primjer - Klasa Auto bez "throw" exception ključne riječi

            Console.WriteLine("=> Kreiranje Auta i davanje gasa...");
            Auto mojAuto = new Auto("BMW 525i", 90);
            mojAuto.RadioOnOf(true);

            for(int i = 0; i < 10; i++)
            {
                mojAuto.Ubrzanje(10);
            }

            #endregion
            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer - Klasa Auto sa "throw" exception ključnom riječi

            Console.WriteLine("=> Kreiranje Auta i davanje gasa...");
            AutoE mojAutoE = new AutoE("BMW 525i", 90);
            mojAutoE.RadioOnOf(true);

            // Pošto imamo Exception u AutoE klasi sada nam treba handler, a to je "try-catch" blok.
            // Sada ćemo for zamotati u taj blok:
            try
            {
                for(int i = 0; i < 10; i++)
                {
                    mojAutoE.Ubrzanje(10);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("\n****GREŠKA!****");
                Console.WriteLine("Metoda: {0}.", e.TargetSite);
                // Naknadno dodano:
                Console.WriteLine("Član Definirajuće Klase: {0}.", e.TargetSite.DeclaringType);
                // Ovo isto tako:
                Console.WriteLine("Član Tipa: {0}.", e.TargetSite.MemberType);
                Console.WriteLine("Poruka: {0}.", e.Message);
                Console.WriteLine("Izvor:  {0}.", e.Source);

                // Da bi smo uhvatili helplink trebamo dodati:
                Console.WriteLine("Pomoć na: {0}", e.HelpLink);

                // Data Property:
                Console.WriteLine("-> Dodatni Podaci: ");
                // Po sonovi data je prazan pa treba provejriti za null vrijednosti...
                if(e.Data != null)
                {
                    foreach(DictionaryEntry de in e.Data)
                    {
                        Console.WriteLine("-> {0}: {1}", de.Key, de.Value);
                    }
                }

                Logger(e.ToString(), e.Source, e.StackTrace, e.TargetSite.MemberType, e.InnerException);
                
            }
                
            #endregion

            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        private static void Logger(string p1, string p2, string p3, System.Reflection.MemberTypes memberTypes, Exception exception)
        {
            StreamWriter file = new StreamWriter(@"C:\DATA\Log.txt", true, Encoding.Default);

            file.WriteLine(p1);
            file.WriteLine(p2);
            file.WriteLine(p3);
            file.WriteLine(memberTypes);
            file.WriteLine(exception);

            file.Close();
        }

     

     


        static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(ulaz);


            //Console.ResetColor();
        }


      

    }
}
