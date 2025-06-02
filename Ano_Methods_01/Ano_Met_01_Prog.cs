using System;
using System.Collections.Generic;
using System.Linq;

namespace Ano_Methods_01
{
    class Ano_Met_01_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║          --- DOBRODOŠLI U: ANONIMNE METODE ( AutoEvent Primjer ) ---           ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> RAD SA ANONIMNIM METODAMA:");
            Console.WriteLine();

            // Postavljamo Counter za zbroj pokrenutih događaja:
            int SamoStoNijeProkuhaoBrojac = 0;

            AutoEvent c1 = new AutoEvent("Polo Clasic", 100, 10);

            // Registriranje eventa sa Anonimnom metodom:
            c1.SamoStoNijeProkuhao += delegate
                {
                    SamoStoNijeProkuhaoBrojac++;
                    Console.WriteLine("Idete Prebrzo, molim vas usporite..."); 
                };
            c1.SamoStoNijeProkuhao += delegate(object sender, AutoEventArgs e)
                {
                    SamoStoNijeProkuhaoBrojac++;
                    Console.WriteLine("Poruka od Auta: {0}.", e.por);
                };

            c1.Prokuhao += delegate(object sender, AutoEventArgs e)
                {
                    if(sender is AutoEvent)
                    {
                        AutoEvent c = (AutoEvent)sender;
                        Console.WriteLine("Fatalna Poruka od Auta! Ime Auta: {0}. Poruka: {1}.",c.ImeAuta, e.por);
                    }
                };

            for(int i = 0; i < 8; i++)
            {
                c1.Ubrzanje(20);
            }

            Console.WriteLine("SamoStoNijeProkuhao je pozvan: {0}.", SamoStoNijeProkuhaoBrojac);

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
