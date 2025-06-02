using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqReturnValues
{
    class Ling_Ret_Val_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                  --- DOBRODOŠLI U: LINQ - RETURN VALUES ---                    ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> LINQ TRANSFORMACIJE: ");
            Console.WriteLine();

            #region Primjer IEnumerable - Statički-Ekplicitno

            // Ovaj Primjer radi samo zato što je return tip vriejdnosti od DajStringPodset() Metode i LINQ upita
            // u metodi jako tipiran "strongly typed". Zato što je malo nezgodno raditi sa IEnumebarable<T> možemo
            // ovaj primjer implicitno tipirati. Pa umjesto da vraćamo IEnumerable<string> jednostavno možemo vratiti
            // string[] koju možemo vratiti od sekvence strongly typed matrice.

            Console.WriteLine("-> LINQ sa IEnumerable ekspicitno:");
            Console.WriteLine();

            // Poziv Metodi: 
            IEnumerable<string> podset = DajStringPodset();

            // Iteracija:
            foreach(string stavka in podset)
            {
                Console.WriteLine(stavka);
            }
            
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer - Implicitno pozvana metoda
            Console.WriteLine("-> LINQ implicitno sa Vraćanjem ODMAH:");
            Console.WriteLine();

            // Poziv Metodi:
            foreach(string stavka in DajStringPodsetKaoArray())
            {
                Console.WriteLine(stavka);
            }

            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        private static IEnumerable<string> DajStringPodset()
        {
            // Array Boja:
            string[] boje = { "Lagano Crvena", "Zelena", "Žuta", "Tamno Crvena", "Crvena", "Ljubičasta" };

            // Primjetite podset je IEnumerable<string> - kompatibilan objekt.
            IEnumerable<string> crveneBoje = from b in boje
                                             where b.Contains("Crvena")
                                             select b;
            
            return crveneBoje;
        }

        static string[] DajStringPodsetKaoArray()
        {
            // Array Boja:
            string[] boje = { "Tamno Zelena", "Zelena", "Svijetlo Zelena", "Crvena", "Ljubičasta", "Narančasta", "Crna", "Bijela", "Tirkiz Zelena" };

            // LINQ upit:
            var zeleneBoje = from b in boje
                             where b.Contains("Zelena")
                             select b;

            // Koristimo Vraćanje ODMAH!
            return zeleneBoje.ToArray();

        }

        #region NapisiPunuCrtu40 Metoda
        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion

    }
}
