using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearArraySearch
{
    internal class LienarAray
    {
        // Array Vrijednosti
        private readonly int[] podatci;

        // Random - nasumični generator
        private static readonly Random Generator = new Random();

        // Kreiramo array dane veličine i popunjavamo je sa nasumičnim integerima
        public LienarAray(int velicina)
        {
            podatci = new int[velicina]; // Kreira prostor za Array

            for(int i = 0; i < velicina; i++)
            {
                podatci[i] = Generator.Next(10, 100);
            }
        }

        // Napravi LINEARNI SEARCH na podatcima:
        public int LinearSearch(int traziKljuc)
        {
            // Prođi kroz array sekvencijalno:
            for(int index = 0; index < podatci.Length; index++)
            {
                if(podatci[index] == traziKljuc)
                    return index; // Vrati index od integera.
            }
            return -1; // Vrati -1 ako integer nije pronađen.
        }

        public override string ToString()
        {
            string temp = string.Empty;

            // Iteriraj kroz array:
            foreach(int element in podatci)
            {
                temp += element + " ";
            }

            temp += "\n"; // Dodaj novi red.
            return temp;
        }

    }

    internal class LinearSearch
    {
        public static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: Array Lienar Search ---                      ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Testiranje Lienar Search Algoritma.
            int traziInt; // Tarži Ključ.
            int pozicija; // Lokacija ključa u array.

            // Kreiraj Array i izbaci je:
            LienarAray traziArray = new LienarAray(20);


            Console.WriteLine(traziArray); // Prikaži Array.

            // Ubaci prvi int od korisnika:
            Console.Write("Molim vas unesite integer vrijednost (-1 je izlaz): ");
            traziInt = Convert.ToInt32(Console.ReadLine());

            // Ponavljajući ubacuj integer; -1 prekida program:
            while(traziInt != -1)
            {
                // Napravi Lienarni Search
                pozicija = traziArray.LinearSearch(traziInt);

                // Ako je integer nađen:
                if (pozicija != -1)
                {
                    Console.WriteLine("Integer {0} je pronađen nalokaciji {1}.\n", traziInt, pozicija);
                }
                // Ako integer nije nađen:
                else
                {
                    Console.WriteLine("Integer {0} nije pronađen.\n", traziInt);
                }

                // Ubaci idući int od korinika:
                Console.Write("Molim vas unesite integer vrijednost (-1 je izlaz): ");
                traziInt = Convert.ToInt32(Console.ReadLine());
            }




            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.SetWindowSize(134, 35);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
