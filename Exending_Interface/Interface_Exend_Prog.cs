using System;
using System.Collections.Generic;
using System.Linq;

namespace Exending_Interface
{
    class Interface_Exend_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: EKSTENZIJU INTERFACE-A ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> RAD SA EKSTENDIRANIM INTEFACE-OM:");
            Console.WriteLine();

            // System.Array implementira IEnumerable:
            string[] podatci = { "Da", "ovo", "je", "na", "neki", "način", "dosadno", ", ali", "opet", "je", "zabavno." };

            // Poziv ekstendiranoj metodi:
            podatci.Ispisi_Podatke_I_Bipni();

            Console.WriteLine();

            // List<T> isto tako implementira Ienumerable:
            List<int> mojInt = new List<int>() { 10, 15, 20, 25, 30, 35, 40, 45, 50 };

            // Poziv ekstendiranoj metodi:
            mojInt.Ispisi_Podatke_I_Bipni();

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
