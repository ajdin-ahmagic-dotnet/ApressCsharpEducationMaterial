using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    class MyGenericListProg
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║               --- DOBRODOŠLI U: Custom Generic List of <T> ---                 ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1 - Kolekcija objekata jedne sije klase!

            Console.Write("1. Da li želite pokrenuti Primjer \"Moja Custom Generična Lista ( Kolekcija Zaposlenika\" DA/NE:");
            string odgovor1 = Console.ReadLine();
            if (odgovor1?.ToLower() == "da")
            {
                MojaLista<Zaposlenik> zap = new MojaLista<Zaposlenik>()
                {
                    new Zaposlenik {Ime ="Ajdin", Prezime = "Ahmagić", Godine = 30, OIB = "2811983181509", Adresa = "Aleja Matice Hr. 41", Placa = 2.500m},
                    new Zaposlenik {Ime ="Ajdin", Prezime = "Ahmagić", Godine = 30, OIB = "2811983181509", Adresa = "Aleja Matice Hr. 41", Placa = 2.500m},
                    new Zaposlenik {Ime ="Ajdin", Prezime = "Ahmagić", Godine = 30, OIB = "2811983181509", Adresa = "Aleja Matice Hr. 41", Placa = 2.500m},
                    new Zaposlenik {Ime ="Ajdin", Prezime = "Ahmagić", Godine = 30, OIB = "2811983181509", Adresa = "Aleja Matice Hr. 41", Placa = 2.500m},
                    new Zaposlenik {Ime ="Ajdin", Prezime = "Ahmagić", Godine = 30, OIB = "2811983181509", Adresa = "Aleja Matice Hr. 41", Placa = 2.500m},
                };

                foreach (Zaposlenik z in zap)
                {
                    Console.WriteLine(z);
                }

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

            #region PRIMJER 2 - Dalje experimentiranje sa mojom generičnom kolekcijom

            Console.Write("2. Da li želite pokrenuti Primjer \"Moja custom Generična Lista ( Dodavanje, Brisanje, Umetanje)\" DA/NE:");

            string odgovor2 = Console.ReadLine();

            if (odgovor2 != null && odgovor2.ToLower() == "da")
            {
                // Deklariramo instancu kolekcije sa parametrom "string":
                MojaLista<string> imena = new MojaLista<string>();

                // dodajemo listi stavke preko metode Add:
                imena?.Add("Aydin");
                imena?.Add("Marlena");
                imena?.Add("Edin");
                imena?.Add("Tahir");
                imena?.Add("Petra");
                imena?.Add("Filip");

                Console.WriteLine("Sadržaj liste \"Imena\" je:");
                foreach (string s in imena)
                {
                    Console.WriteLine("Ime: {0}", s);
                }

                // sada brišemo neke stavke iz kolkecije:
                Console.WriteLine("Brišemo neka imena iz kolekcije \"Imena\":");
                Console.WriteLine("Brišemo: {0}", imena.Remove());
                Console.WriteLine("Brišemo: {0}", imena.Remove());

                Console.WriteLine();

                // poslje brisanja sadržaj liste je.
                Console.WriteLine("Sadržaj liste \"Imena\" je:");
                foreach (string s in imena)
                {
                    Console.WriteLine("Ime: {0}", s);
                }

                List<string> ime = new List<string>()
                {
                    "Aydin", "Edin", "Marlena"
                };



                foreach (string s in ime)
                {
                    Console.WriteLine(s);
                }
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

        #region Napisi Punu Crtu Metoda
        private static void NapisiPunuCrtu(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion
    }
}
