using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Lifetime_01
{

    class Program
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║           --- DOBRODOŠLI U: 'REVIZIJU' LINQ -( GROUND UP ) MSDN  ---           ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.Write("1. Da li želite pokrenuti Primjer \"Car Metodu\" DA/NE:");
            string odgovor_1 = Console.ReadLine();
            if(odgovor_1.ToLower() == "da")
            {
                // Poziv Metodi:
                CarMetoda();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                Console.WriteLine("Ovo je moja ljubav...");
            }

            
        }

        static void CarMetoda()
        {
            Car refToMyCar = new Car("BMW 525i", 260);

            Console.WriteLine(refToMyCar.ToString());
            Console.ReadKey();
        }

        #region Metode

        private static void NapisiPunuCrtu(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion
    }
}
