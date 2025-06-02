using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collections_Arrays_02
{
    class Collections_Arrays_02
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                  --- DOBRODOŠLI U: Collections Arrays 2 ---                    ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1

            Console.Write("Da li želite da pozovte Primjer 1 Metodu DA/NE:");
            string odgovor = Console.ReadLine();
            if(odgovor.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer1();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program nastavlja dalje...");
            }
            
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2

            Console.Write("Da li želite da pozovte Primjer 2 Metodu DA/NE:");
            string odgovor2 = Console.ReadLine();
            if(odgovor2.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer2();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 3

            Console.Write("Da li želite da pozovte Primjer 3 Metodu DA/NE:");
            string odgovor3 = Console.ReadLine();
            if(odgovor3.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer3();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 4

            Console.Write("Da li želite da pozovte Primjer 4 Metodu DA/NE:");
            string odgovor4 = Console.ReadLine();
            if(odgovor4.ToLower() == "da")
            {
                // Array of String-a Dani u tjednu:
                string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

                // Poziv Metodi:
                Primjer4(daniUTjednu);
                
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 5

            Console.Write("Da li želite da pozovte Primjer 5 Metodu DA/NE:");
            string odgovor5 = Console.ReadLine();
            if(odgovor5.ToLower() == "da")
            {

                // Poziv Metodi:
                Primjer5();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 6

            Console.Write("Da li želite da pokrenete Primjer 6 DA/NE: ");
            string odgovor6 = Console.ReadLine();
            if(odgovor6.ToLower() == "da")
            {
                // U ovom primjeru radimo sa IComaparer inetrfaceom i pokušavamo da sortiramo array po dužini slova svakod dana.

                // Array of String-a Dani u tjednu:
                string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };
                

                var comparer = new StringLengthComparer();

                Array.Sort(daniUTjednu, comparer);


                foreach(string dan in daniUTjednu)
                {
                    Console.WriteLine(dan);
                }
            }
            else
            {
                Console.WriteLine("Odabrali ste \"NE\" kao odgovor. Program nastavalja dalje...");
            }


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 7
            
            // Trženje indexa array. Primjer:
            Console.Write("Da li želite da pokrenete Primjer 7 DA/NE: ");
            string odgovor7 = Console.ReadLine();
            if(odgovor7.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer7();
            }
            else
            {
                Console.WriteLine("Odabrali ste \"NE\" kao odgovor. Program Nastavlja dalje...");
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 8

            Console.Write("Da li želite da pokrenete Primjer 8 DA/NE: ");
            string odgovor8 = Console.ReadLine();
            if (odgovor8.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer8();
            }
            else
            {
                Console.WriteLine("Odabrali ste \"NE\" kao odgovor. Program nastavlja dalje...");
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 9

            Console.Write("Da li želite da pokrenete Primjer 9 DA/NE: ");
            string odgovor9 = Console.ReadLine();
            if(odgovor9.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer9();
            }
            else
            {
                Console.WriteLine("Odabrali ste \"NE\" kao odgovor. Program nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 10

            Console.Write("Da li želite da pokrenete Primjer 10 DA/NE: ");
            string odgovor10 = Console.ReadLine();
            if(odgovor10.ToLower() == "da")
            {
                // Poziv Metodi:
                Primjer10();
            }
            else
            {
                Console.WriteLine("Odabrali ste \"NE\" kao odgovor. Program nastavlja dalje...");
            }

            #endregion



            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region PRIMJER 1 METODA

        static void Primjer1()
        {
            // U Ovom primjeru pokazujemo kako Array može nasljediti od bazne kalse u deriviranu.
            // Pravimo array tipa object:
            object[] objArray = new object[4]
            {
            	"Vozdra iz C#!",
                666,
                new Button {Text = " { Klikni Me } "},
                'C'
            };

            Type objArrayType = objArray.GetType();

            foreach(object item in objArray)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region PRIMJER 2 METODA

        static void Primjer2()
        {
            // Primjer Kopiranja Arrays:

            // Pravimo Standardnu Array:
            int[] korijeni = { 1, 4, 9, 16 };


            // Pravimo Kopiju:
            int[] kopija = new int[4];
            korijeni.CopyTo(kopija, 0); // Dodjeljujemo kopiji staru Array "korijeni".

            // Takođe imamo i "Copy" metodu:
            int[] kopija2 = korijeni.ToArray();


            foreach(int vrijednost in kopija)
            {
                Console.WriteLine(vrijednost);
            }

            Console.WriteLine(string.Format("korijeni == kopija? {0}", korijeni == kopija));

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            foreach(int vrijednost in kopija2)
            {
                Console.WriteLine(vrijednost);
            }

            Console.WriteLine(string.Format("korijeni == kopija? {0}", korijeni == kopija2));
        }

        #endregion

        #region PRIMJER 3 Metoda

        static void Primjer3()
        {
            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            Array.Reverse(daniUTjednu);

            foreach(string dan in daniUTjednu)
            {
                Console.WriteLine(dan);
            }

        }

   

        #endregion

        #region PRIMJER 4 Metoda

        private static void Primjer4(string[] daniUTjednu)
        {
            // Reverse možemo napraviti i preko Produžene LINQ Metode Reverse.
            Console.WriteLine("LINQ reverse:");

            var reverse = daniUTjednu.Reverse();

            foreach(var dan in reverse)
            {
                Console.WriteLine(dan);
            }
        }

        #endregion

        #region PRIMJER 5 Metoda

        static void Primjer5()
        {
            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Srijeda", "Utorak", "Ponedjeljak", "Četvrtak", "Nedjelja", "Subota", "Petak" };

            Array.Sort(daniUTjednu);

            foreach(string dan in daniUTjednu)
            {
                Console.WriteLine(dan);
            }
        }

        #endregion

        #region PRIMJER 6 Klasa
        class StringLengthComparer : IComparer<string>
        {
            // Primjerna IComaparer Interface-a da bi sortirali array po veličini tj. dužini slova svakog dana...

            public int Compare(string x, string y)
            {
                return x.Length.CompareTo(y.Length);
            }
        }
        #endregion

        #region PRIMJER 7 Metoda

        static void Primjer7()
        {
            // Ovaj Primjer poakzuje kako pristupiti array preko indexa...

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            int indexOdSrij = Array.IndexOf(daniUTjednu, "Srijeda");
            Console.WriteLine("Srijeda se nalazi na indexu: {0}", indexOdSrij);
        }

        #endregion

        #region PRIMJER 8 Metoda

        static void Primjer8()
        {
            // Ovaj Primjer pokazuje kako pomoću lambda izraza pronaći tražene stavke u array koje počinju sa 'S'.

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            int indexOdTjedna = Array.FindIndex(daniUTjednu, x => x[0] == 'S');
            Console.WriteLine("Index je na broja: {0}", indexOdTjedna);
            Console.WriteLine("Dan na tom indexu je: {0}", daniUTjednu[indexOdTjedna]);
        }

        #endregion

        #region PRIMJER 9 Metoda 
        
        static void Primjer9()
        {
            // Ovaj primjer poakazuje "FindAll" metodu.

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            string[] sviSaSestSlova = Array.FindAll(daniUTjednu, x => x.Length == 6); // Pronađi sve one koji imaju 6 slova!

            Console.WriteLine("Dani sa 6 slova su:");
            foreach(string dan in sviSaSestSlova)
            {
                Console.WriteLine(dan);
            }

            Console.WriteLine();

            string[] sviSaViseOdSest = Array.FindAll(daniUTjednu, x => x.Length > 6);

            Console.WriteLine("Svi sa više od 6 slova:");
            foreach(string dan in sviSaViseOdSest)
            {
                Console.WriteLine(dan);
            }
               
        }

        #endregion

        #region PRIMJER 10 Metoda

        static void Primjer10()
        {
            // Jednostavni primjer Binary Search-a:

            int[] sortBrojevi = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50 };

            int indexOdbr = Array.BinarySearch(sortBrojevi, 28);
            Console.WriteLine();
            Console.WriteLine("Naš broj nalazi se na indexu: {0}.", indexOdbr);
            Console.WriteLine("Vrijednost koju broj drži je: {0}.", sortBrojevi[indexOdbr]);

            // Pokušaj da napravimo Binary search na nesortiranom array:
            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            int indexOdDan = Array.BinarySearch(daniUTjednu, "Petak"); // Binarni search radi i na nesortiranoj array!
            Console.WriteLine();
            Console.WriteLine("Dan je na indexu: {0}.", indexOdDan);
            Console.WriteLine("Ime dana je: {0}.", daniUTjednu[indexOdDan]);
            
        }

        #endregion

        #region PRIMJER 11 Metoda

        static void Primjer11()
        {
           
        }

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
