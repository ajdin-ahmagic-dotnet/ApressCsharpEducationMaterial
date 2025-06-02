using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;


namespace Exten_Methods_01
{
    class Exten_Methods_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                  --- DOBRODOŠLI U: EKSTENZIJSKE METODE ---                     ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region Ukratko
           /*|--------------------------------------------------------------------------|  
             | C# 3.5 je predstavio koncept koji se zove eng. "Extension methods"       |
             |  koji nam omogućava da dodamo nove metode ili osobinama jednoj klasi     |
             |  ili strukturi bez modificiranja originalnog tipa u bilo kojem drugom    |
             |  smislu. Npr:                                                            |
             |  Ako imamo zatvorenu klasu ili strukturu u već postojećem programu a     |
             |  želimo dodati još funkcionalnosti nismo u mogućnosti ili jesmo ali      |
             |  morali bi dervirati novu klasu itd. Sa ekenziranim metodama možemo      |
             |  upravo to. Promjeniti nešto bez gubitka podataka tj. bez                |
             |  modificiranja tipa direktno. Ovaj Program demonstrira tu funkcionalnost.|
             | Kada Krenemo u definiranje tih metoda prvo od restrikcija je to da metoda|
             | mora biti definirana u statičkoj klasi! A svaka metoda mora biti označena|
             | sa "static" ključnom riječi! Te da mora biti obilježena sa "this" klj.r. |
             |--------------------------------------------------------------------------|
             */
            #endregion

            Console.WriteLine("=> RAD SA EKTENZIBILNIM METODAMA:");
            Console.WriteLine();

            // Int je dobio novi identitet ima nove metode:
            int mojInt = 12345678;
            mojInt.Prikazi_Definirani_Assembly();
            
            // Isto tako i DataSet:
            System.Data.DataSet d = new System.Data.DataSet();
            d.Prikazi_Definirani_Assembly();

            // Isto tako i SoundPlayer:
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer();
            sp.Prikazi_Definirani_Assembly();

            // Sada koristimo novu integer funkcionalnost!!!
            Console.WriteLine("Vrijednost od mojInt: {0}", mojInt);
            Console.WriteLine("Preokrenuti Brojevi od mojInt: {0}", mojInt.Preokreni_Brojke());



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
