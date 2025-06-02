using System;
using System.Collections.Generic;
using System.Linq;

using BazneKlase;


namespace SystemMenagment
{
    internal class Program
    {
        private static void Main()
        {
            #region Natpis za Konzolu

            Write("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Write("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            Write("║                         ║                    --- DOBRODOŠLI U: TEST BAZNIH KLASA ---                     ║                         ║");
            Write("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            Write("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #endregion

            Zaposlenik zap = new Zaposlenik
            {
                ImePrezime = "Aydin Rose",
                ImeOca = "Nedžad",
                OIB = 2811983,
                Placa = 4500m,
                Bonus = 20m,
                RadiOd = DateTime.Parse("22.11.2006"),
                Starost = 30,
                TipZaposlenika = "Programer",
                RadnoVrijeme = 45
            };

            Console.WriteLine(zap);

            zap.Izracun_Radnog_Vremena(45);

            Console.WriteLine("Zarda je: {0:C2}", zap.Zarada());

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        public static void Bla()
        {
            List<Programer> programer = new List<Programer>()
            {
                new Programer("Aydin Rose", "Nedžad", 2811983, 30, "Programer", 4500m, 20m, DateTime.Parse("12.03.2012"), 45),
            };
        }

        #region NapisiPunuCrtu40 Metoda

        private static void Write(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion
    }
}
