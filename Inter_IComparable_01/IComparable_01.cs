using System;
using System.Collections.Generic;
using System.Linq;

namespace Inter_IComparable_01
{
    class IComparable_01
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: INTERFACES IComparable ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Primjer IComaparable interface-a:
            // Prvo ćemo napraviti array objekata AutoE onda ćemo probati
            // posložimo preko IComparable interfae-a jer sada kao kolekcija
            // objekata koji nisu definirani od strane sistema nemaju Array.Sort() podršku!
            AutoE[] auti = new AutoE[5];
            auti[0] = new AutoE("BMW", 40, 48);
            auti[1] = new AutoE("Audi", 50, 22);
            auti[2] = new AutoE("Opel", 35, 14);
            auti[3] = new AutoE("Golf", 45, 82);
            auti[4] = new AutoE("Merc", 55, 15);

            // Prikazuje nesortiranu listu auta:
            Console.WriteLine("=> NE SORTIRANA LISTA AUTA:");
            foreach(AutoE a in auti)
            {
                Console.WriteLine("{0} {1}", a.ID, a.ImeAuta);
            }

            Console.WriteLine();

            Array.Sort(auti);

            // Prikazuje sortiranu listu auta:
            Console.WriteLine("=> SORTIRANA LISTA AUTA:");
            foreach(AutoE a in auti)
            {
                Console.WriteLine("{0} {1}", a.ID, a.ImeAuta);
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
