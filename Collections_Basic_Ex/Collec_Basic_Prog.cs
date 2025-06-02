using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Collections_Basic_Ex
{
    class Collec_Basic_Prog
    {
        /// <summary>
        /// Osnovni tip kolekcija su Matrice. eng. Arrays u ovom primjeru ćemo se
        /// malo poigrati i podsjetiti matrica ali sada u oličju kolekcija koje one i jesu...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                   --- DOBRODOŠLI U: KOLEKCIJE OSNOVE 1 ---                     ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);


            // Jednostavna matrica tipa string koja sadrži imena osoba.
            string[] imena = { "aydin", "edin", "marlena", "edina", "filip", "petra", "azra", "jusuf", "dževida" };

            // Prikaži broj stvaki u matrci koristeći Length osobinu.
            Console.WriteLine("Ova Matrica ima {0} stavki.", imena.Length);
            Console.WriteLine();

            // Prikaži sadržaj matrice koristeći enumerator.
            foreach(string ime in imena)
            {
                Console.WriteLine("Imena su: {0}.", ime);
            }

            Console.WriteLine();
            Console.WriteLine("-> Matrica Izokrenuta: ");
            Console.WriteLine();
            // preokreni redosljed u matrici.
            Array.Reverse(imena);
            foreach(string ime in imena)
            {
                Console.WriteLine("Imena su: {0}.", ime);
            }

            Console.WriteLine();

            Console.WriteLine("-> Matrica Sortirana:");
            Console.WriteLine();

            Array.Sort(imena);
            foreach(string ime in imena)
            {
                Console.WriteLine("Sortirana: {0}.", ime);
            }

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
