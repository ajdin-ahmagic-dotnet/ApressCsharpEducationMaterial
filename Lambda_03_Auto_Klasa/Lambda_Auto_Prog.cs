using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_03_Auto_Klasa
{
    class Lambda_Auto_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║         --- DOBRODOŠLI U: LAMBDA IZRAZE ( Auto Klasa sa Lambdom ) ---          ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Rad sa Auto Klasom ovaj put koristeći lambda izraze:
            Console.WriteLine("=> RAD SA LAMBDA IZRAZOM ( Auto Klasa ):");
            Console.WriteLine();

            AutoEvent c1 = new AutoEvent("Lamurgini Diablo", 340, 40);

            // Sada spajamo evente ali ovaj put sa Lambda izrazima:
            c1.SamoStoNijeProkuhao += (sender, e) => { Console.WriteLine(e.por); };
            c1.Prokuhao += (sender, e) => 
            {
                if(sender is AutoEvent)
                {
                    AutoEvent c = (AutoEvent)sender;
                    Console.WriteLine("Poruka od Auta: {0}, Ime Auta: {1}.", e.por, c.ImeAuta);
                }
            };

            // For petlja tj. metoda u njoj Ubrzanje će opaliti event:
            for(int i = 0; i < 9; i++)
            {
                c1.Ubrzanje(40);
            }

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }




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
