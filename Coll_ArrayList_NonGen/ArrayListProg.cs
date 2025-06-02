using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Coll_ArrayList_NonGen
{
    class ArrayListProg
    {
        /// <summary>
        /// Prvi primjer ne generičnih kolekcija je ArrayList kolekcija.
        /// Za rad sa svim ne generičnim kolekcijama moramo uvesti using System.Collections;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                  --- DOBRODOŠLI U KOLEKCIJE: ARRAYLIST ---                     ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> ARRAYLIST KOLEKCIJA PRIMJERI:");
            // Deklaracija i dodjela kolekciji vrijednosti:
            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(new string[] { "ajdin", "edin", "marlena", "edina", "filip", "jusuf", "dževida" });

            // Prikaži broj stvaki u ArrayList-i:
            Console.WriteLine("Kolekcija ArrayList ima {0} stavki.", arrayList.Count);

            // Prikaži sve stvake kolekcije:
            foreach(string s in arrayList)
            {
                Console.WriteLine("Unos: {0}.", s);
            }

            Console.WriteLine();
            // Dodaj novu vrijednost kolekciji:
            arrayList.Add("petra");

            // Ponovno prikaži broj stavki u kolekciji:
            Console.WriteLine("Kolekcija ArrayList nakon dodatnog unosa ima {0} stavki.", arrayList.Count);
            

            // Prikaži sve stvake kolekcije:
            foreach(string s in arrayList)
            {
                Console.WriteLine("Unos: {0}.", s);
            }

            Console.WriteLine();
            Console.WriteLine("-> Kolekcija ArrayList nakon AddRange(new int[] {....}):");
           
            arrayList.AddRange(new int[] { 20, 30, 40, 50, 60, 70, 80, 90 });
            Console.WriteLine("Kolekcija ArrayList nakon dodatnog unosa ima {0} stavki.", arrayList.Count);
            // Prikaži sve stvake kolekcije nakon int unosa da bi prikazali sve vrijednosti
            // koristimo "var" ključnu riječ. 
            // ArrayList može držati više tipova podataka u isto vrijeme što znači možemo je
            // napuniti sa string i int matricama isto tako i sa ostalim vrijednosnim ili
            // referencnim tipovima...
            foreach(var i in arrayList)
            {
                Console.WriteLine("Unos: {0}.", i);
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
