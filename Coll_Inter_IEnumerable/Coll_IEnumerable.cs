using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Inter_IEnumerable
{
    class CollIEnumerable
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║           --- DOBRODOŠLI U: Collection Intefaces ( IEnumerable ) ---           ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1
            Console.Write("Da li želite da pokrenete Primjer 1 DA/NE: ");
            string odgovor = Console.ReadLine();
            if (odgovor.ToLower() == "da")
            {
                PrimjerMetoda1();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2
            Console.Write("Da li želite da pokrenete Primjer 2 DA/NE: ");
            string odgovor2 = Console.ReadLine();
            if (odgovor2.ToLower() == "da")
            {
                PrimjerMetoda2();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 3
            Console.Write("Da li želite da pokrenete Primjer 3 DA/NE: ");
            string odgovor3 = Console.ReadLine();
            if (odgovor3.ToLower() == "da")
            {
                PrimjerMetoda3();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }
            #endregion



            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region PRIMJER 1 Metoda

        public static void PrimjerMetoda1()
        {
            // Ovdje želimo pokazati da sve kolekcije implementiraju IEnumerable<T> interface. Svaka foreach petlja
            // nama skriva iza leđa što se zapravo događa. A događa se IEnumerable<T> svaki put kad napišemo foreach petlju.
            // Kada nebi pisali foreach petlju ovako bi to izgledalo i potpuno je legalno ovako pisati kod...

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            // umjesto foreach petlje sada koristimo IEnumerable:
            IEnumerable<string> dani = from dan in daniUTjednu
                                       select dan;

            foreach (string dan in dani)
            {
                Console.WriteLine(dan);
            }

        }

        #endregion

        #region PRIMJER Metoda 2

        public static void PrimjerMetoda2()
        {
            // Primjer ICollection Interfacea

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            // poziva ICollection inteface tipa string dodjeljuje ga lokalnoj varijabli "coll" uzima Array "daniUTjednu"...
            ICollection<string> coll = (ICollection<string>)daniUTjednu;

            // Poziva Metodu ICollection inteface-a "Count". Što znači prebroji sve elemenete u kolekciji...
            Console.WriteLine("Broj dana u tjednu je: {0}.", coll.Count);

            // Ovdje smo isto tako mogli pozvati Array property Length i dobili bi isti rezultat:
            Console.WriteLine("Broj dana u tjednu je: {0}.", daniUTjednu.Length);

            // Tes smo isto mogli napraviti sa Linq produženom metodom Count i dobili bi isti rezultat:
            Console.WriteLine("Broj dana u tjednu je: {0}.", daniUTjednu.Count());


        }

        #endregion

        #region PRIMJER Metoda 3

        static void PrimjerMetoda3()
        {
            // U ovom primjeru ispitujemo isReadOnly Porpreti od ICollection interface-a.

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            // Kastiramo dane u tjednu ICollection interface-u:
            ICollection<string> collection = (ICollection<string>)daniUTjednu;

            // Iako znamo da u array ne možemo dodati nove elemente, možemo ih zamjeniti!
            (collection as string[])[5] = "Party Dan";

            // Sada ispitujemo dali je moguće dodati novi dan u ovu kolekciju? Iako znamo da su arrays fiksirane veličine...
            if (!collection.IsReadOnly)
            {
                collection.Add("Party Dan");
            }
            else
            {
                Console.WriteLine("Kolekcija je \"read-only\"");
            }

            foreach (string dan in collection)
            {
                Console.WriteLine(dan);
            }
        }

        #endregion

        #region PRIMJER Metoda 4

        //static void PrimjerMetoda4()
        //{

        //}

        #endregion

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
