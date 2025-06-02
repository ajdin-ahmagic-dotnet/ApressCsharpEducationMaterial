using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_Arrays
{
    class Collections_Arrays
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                  --- DOBRODOŠLI U: Collections Arrays ---                      ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Počinjemo sa osnovnom Kolekcijom "Array", koja ima mnoge dobre osobine osim što fixirana. Kada je zadamo više je ne možemo 
            // promjeniti, ali ima svoju primjenu u različitim scenarijima. Pa ćemo proučiti koji su to:

            #region PRIMJER 1
            Console.Write("Da li želiš pokrenuti Array Primjer 1 DA/NE: ");
            string arrOdgovor = Console.ReadLine();
            if(arrOdgovor.ToLower() == "da")
            {
                  // Poziv Metodi:
                  ArrayPrimjer1();
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

            #region PRIMJER 2

            Console.Write("Da li želite pokrenuti Array Primjer 2 DA/NE:");
            string arrOdgovor2 = Console.ReadLine();
            if(arrOdgovor2.ToLower() == "da")
            {
                // Poziv Metodi:
                ArrayPrimjer2();
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

            #region PRIMJER 3

            Console.Write("Da li želite pokrenuti Array Primjer 3 DA/NE: ");
            string arrOdgovor3 = Console.ReadLine();
            if(arrOdgovor3.ToLower() == "da")
            {
                // Poziv Metodi:
                ArrayPrimjer3();
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

            #region PRIMJER 4

            Console.Write("Da li želite pokrenuti Array Primjer 4 DA/NE: ");
            string arrOdgovor4 = Console.ReadLine();
            if(arrOdgovor4.ToLower() == "da")
            {
                // Array of String-a Dani u tjednu:
                string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

                // Poziv Metodi koja mora ići ispred foreach petlje!
                NapraviDaneUMnozini(daniUTjednu);

                foreach(string dan in daniUTjednu)
                {
                    Console.WriteLine(dan);
                }

               
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

            #region PRIMJER 5

            Console.Write("Da li želite pokrenuti Array Primjer 5 DA/NE: ");
            string arrOdgovor5 = Console.ReadLine();
            if(arrOdgovor5.ToLower() == "da")
            {
                // Nova instanca Klase Osoba:
                Osoba[] osobe = new Osoba[]
                {
                	new Osoba { Name = "Aydin", Age = 30},
                    new Osoba { Name = "Marlena", Age = 37},
                    new Osoba { Name = "Edina", Age = 55}
                };

                foreach(Osoba osoba in osobe)
                {
                    Console.WriteLine(osoba);
                }
            }
            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Array Primjer 1
        
        // Kod sam grupirao u metode koje se pozivaju Main metodi zbog čitljivosti koda.
        public static void ArrayPrimjer1()
        {
            // String ponedjeljak:
            string ponedjeljak = "Ponedjeljak";

            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };


            // Sada postavljamo lokalnu varijablu i dajemo joj index Array-a = [1], što je dan "Utorak":
            string utorak = daniUTjednu[1]; // "Utorak"
            Console.WriteLine("Dan u Tjednu: {0}", utorak);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            foreach(string s in daniUTjednu)
            {
                Console.WriteLine(s);
            }


            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Izlistavanje elementa array putem unosa indexa:
            Console.Write("Utipkaj Index za dan koji želiš izlistati: ");
            int dan = int.Parse(Console.ReadLine());
            Console.WriteLine("To je dan: {0}.", daniUTjednu[dan]);


            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion


            // Ako želimo promjeniti neki element u Array, samu dom indexu dodjelimo novu vrijednost:
            daniUTjednu[5] = "Dan Za Party";

            foreach(string s in daniUTjednu)
            {
                Console.WriteLine(s);
            }
            
        }

        #endregion

        #region Array Primjer 2

        private static void ArrayPrimjer2()
        {
            // Lokalne Varijable neiincijalizirane:
            int x1;
            int[] x2;

            // Lokalne Varijable inicijalizirane
            int x3 = 5;
            int[] x4 = new int[5];
            Console.WriteLine(x4[0]);

            // U ovom izrazu ima djelova koji se ponavljaju. 
            int[] x5 = new int[5] { 10, 20, 30, 40, 50 };

            // pa onda isti taj izraz možemo napisati i 
            // ovako te pustiti da kompjler odredi veličinu array-a.
            int[] x6 = new int[] { 10, 20, 30, 40, 50 };

            // Možemo ići i korak dalje i skratiti izraz:
            int[] x7 = { 10, 20, 30, 40, 50 };

            // Možemo uključiti implicitno tipiranje sa "var" ključnom riječju:
            var x8 = new int[] { 10, 20, 30, 40, 50 };
        }

        #endregion

        #region Array Primjer 3

        static void ArrayPrimjer3()
        {
            // Array of String-a Dani u tjednu:
            string[] daniUTjednu = { "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };

            // Kad pogledamo obje petlje, one obje daju isti rezultat. Foreach je puno lakše napisati nego For. Ali svaku
            // foreach petlju kompjler pretvara u for petlju kada radi sa arrays, ali opet zašto bi mi koristili for kada je
            // foreach puno lakši za naisati? Recimo da želimo izlistati samo 3 ili 4 dana u tjednu, foreach petlja nema sustav
            // ugrađen za te sposobnosti, dok kod for petlje možemo zadati "i < 3" ili "i < 4" i dobit ćemo ono što tražimo, dakle for
            // ima prednosti nad foreach petljom u ovom slučaju...


            Console.WriteLine();
            Console.WriteLine("For petlja:");
            // U ovom primjeru enumeracija preko array sa For petljom ali samo prva 4 dana: 
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(daniUTjednu[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Foreach petlja:");
            // Sada isto radimo ali sa Foreach petljom enumeriramo preko array:
            foreach(string dan in daniUTjednu)
            {
                Console.WriteLine(dan);
            }


            // StringBuilder Metoda koja izlistava kroz "For" petlju dane u tjednu u sljedećem formatu:
            // Ponedjeljak, Utorak, .... i Nedjelja.
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < daniUTjednu.Length; i++)
            {
                sb.Append(daniUTjednu[i]);
                if(i < daniUTjednu.Length - 2)
                {
                    sb.Append(", ");
                }
                else if(i == daniUTjednu.Length - 2)
                {
                    sb.Append(" i ");
                }
            }
            Console.WriteLine(sb.ToString());
        }

        #endregion

        #region Array Primjer 4

        // Pomoćna metoda - Napravi dane u menožini:
        static void NapraviDaneUMnozini(string[] daniUTjednu)
        {
            for(int i = 0; i < 2; i++)
            {
                daniUTjednu[i] = daniUTjednu[i] + "a";
            }

            for(int i = 3; i < 4; i++)
            {
                daniUTjednu[i] = daniUTjednu[i] + "a";
            }

            for(int i = 4; i < 5; i++)
            {
                daniUTjednu[i] = daniUTjednu[i] + "a";
            }
        }

    

        #endregion

        #region Array Primjer 5
        
        class Osoba
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public override string ToString()
            {
                return string.Format("| Name = {0,-8} | Age = {1} |", Name, Age);
            }

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
