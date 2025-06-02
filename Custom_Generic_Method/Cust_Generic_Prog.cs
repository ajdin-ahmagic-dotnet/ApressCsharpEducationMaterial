using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Generic_Method
{
    class Cust_Generic_Prog
    {
        /// <summary>
        /// Primjer custom - generične metode. Moje metode koja nije definirana od frameworka.
        /// Kada želimo koristiti generične metode? Pa kada recimo imamo više ulaznih tj. različitih tipova
        /// za koje bi nam trebalo puno metoda da napravi posao a možemo to napraviti sa jednom generičnom metodom 
        /// koja uzima parametre bilo kojeg tipa i procesuira ih. recimo obična "swap" hr. zamjeni metoda. Za svaki
        /// tip bi je morali posebno pisati, ali uz pomoć generčnog tipa obrade podataka možemo napisati samo jednu 
        /// za sve tipove, to ćemo u ovom primjeru uraditi...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║            --- DOBRODOŠLI U GENERIČNE KOLEKCIJE: CUSTOM KOLEKCIJA ---          ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> GENERIČNE METODE:");
            Console.WriteLine();

            // Zamjeni 2 integrala:
            int a = 10, b = 60;
            Console.WriteLine("Prije zamjene: {0}, {1}.", a, b);
            Swap<int>(ref a, ref b);
            Console.WriteLine("Poslje zamjene: {0}, {1}.", a, b);
            Console.WriteLine();


            // Zamjeni dva stringa:
            string s1 = "Kudi", s2 = "Kamo";
            Console.WriteLine("Prije zamjene: {0} {1}!", s1, s2);
            Swap<string>(ref s1, ref s2);
            Console.WriteLine("Poslje zamjene: {0} {1}!", s1, s2);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // U ovom slučaju moramo dati parametre ako metoda
            // ne uzima "params".
            DisplayBaseClass<int>();
            DisplayBaseClass<string>();

            // Ovo je koplajl-time greška:
            // DisplayBaseClass();




            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }


        // Generična Swap Metoda:
        static void Swap<T>(ref T a, ref T b)
        {
            Console.WriteLine("Posalo si Swap metodi {0}", typeof(T));
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void DisplayBaseClass<T>()
        {
            // Bazni tip je metoda korištena u refleksiji 
            // o kojoj će biti riječi u 15 poglavlju...
            Console.WriteLine("Bazna klasa od: {0} je: {1}", typeof(T), typeof(T).BaseType);
        }

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
