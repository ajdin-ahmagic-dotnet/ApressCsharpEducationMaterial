using System;
using System.Collections.Generic;
using System.Linq;

namespace Inter_IClonable
{
    class IClonable_Prog
    {
        /// <summary>
        /// PRIMJER IClonable INTERFACE-A. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                  --- DOBRODOŠLI U: INTERFACES IClonable ---                    ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> IClonable interface:");
            Console.WriteLine();

            // Dvije reference na isti objekt!
            Tacka t1 = new Tacka(50, 50, "Edin");
            Tacka t2 = t1;
            t2.X = 0;
            Console.WriteLine(t1);
            Console.WriteLine(t2);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Primjetite Clone() vraća čisti objekt tip!
            // Moramo napraviti expicitni cast da bi dobavili derivirani tip!
            // Dorađena nakon upisa TackaOpis klase.
            Console.WriteLine("-> Kloirana t3 i pohranjena u novu Tačku t4:");
            Tacka t3 = new Tacka(100, 100, "Aydin");
            Tacka t4 = (Tacka)t3.Clone();

            // Prije modfikacije:
            Console.WriteLine("-> Prije Modifikacije: ");
            Console.WriteLine("t3: {0}", t3);
            Console.WriteLine("t4: {0}", t4);
            t4.opis.Ime = "Moja Nova Tačka";
            t4.X = 90;

            // Promjeni t4.X ( a koji neće promjeniti t3.X )
            //t4.X = 0;

            Console.WriteLine("\nPromjenjna t4.opis.Ime i t4.X");
            Console.WriteLine("-> Poslje Modifikacije: ");
            Console.WriteLine("t3: {0}", t3);
            Console.WriteLine("t4: {0}", t4);


            // Ispiši objekte:
            //Console.WriteLine(t3);
            //Console.WriteLine(t4);


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
     
    }
}
