using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Koristeci_Enumerable
{
    class Linq_Koristeci_Enumerable
    {
        public static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: Linq Koristeći Enumerable ---                ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Poziv Metodi:
            Console.WriteLine("Upit String Operatora sa Enumerable:");
            UpitSaStringOperatorom();



            Console.WriteLine();
            // Moramo imati na umu da je LINQ upit samo skraćena verzija od pozivanja produžene - extenzivne metode definirane od 
            // strane Enumerable tipa!
 
            // Poziv metodi koja nam pokazuje koristeći Enumerable sa Lambdom: 
            Console.WriteLine("Upit String Operatora sa Enumerable i Lambdom:");
            UpitStringSaEnumerableILabmdama();

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region UpitSaStringOperatorom

        static void UpitSaStringOperatorom()
        {
            string[] trenutneVideoIgre = { "SimCity 4", "Hallo 2", "Warcraft 4", "Doom 3", "Tiberian Wars", "Generals", "SimCity", "StarCraft" };

            var podSet = from igra in trenutneVideoIgre
                         where igra.Contains(" ")
                         orderby igra
                         select igra;

            foreach(string s in podSet)
            {
                Console.WriteLine("Stavka: '{0}'", s);
            }
        }

        #endregion

        #region UpitStringSaEnumerableILambdama

        static void UpitStringSaEnumerableILabmdama()
        {
            string[] trenutneVideoIgre = { "SimCity 4", "Hallo 2", "Warcraft 4", "Doom 3", "Tiberian Wars", "Generals", "SimCity", "StarCraft" };

            // Napravi upit extenziju koristeći produžene "ex" metode
            // dodano matrici preko Enumerable tipa
            var podSet = trenutneVideoIgre.Where(igra => igra.Contains(" "))
                .OrderBy(igra => igra).Select(igra => igra);

            // Isprintaj Rezultate:
            foreach(var igra in podSet)
            {
                Console.WriteLine("Stavka: '{0}'", igra);
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
