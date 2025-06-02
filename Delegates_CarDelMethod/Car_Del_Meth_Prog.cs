using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_CarDelMethod
{
    class Car_Del_Meth_Prog
    {
        /// <summary>
        /// Malo pojašnjeni primjer Delegates_02_CarDel Primjera. Kad se pretplatimo na delegat da se izvrši on to i napravi
        /// ali čim tu pretplatu ukinemo više nema obavještenja jer normalno nema više pretplate...
        /// Jasniji primjer od prijašnjeg radi pojašnjenja stvari je tu...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║            --- DOBRODOŠLI U: DELEGATES ( AUTO METHOD ) PRIMJER ---             ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> DELEGATI, METHOD GROUP CONVERSIONS:");
            Console.WriteLine();

            // Instanciranje Auto Klase:
            Auto a1 = new Auto();

            // Registriranje jednostavne metode:
            a1.RegistrirajSaAutoMotorom(PozoviMe);

            Console.WriteLine("*********** UBRZAJEM ***********");
            for(int i = 0; i < 6; i++)
            {
                a1.Ubrzanje(20);
            }

            // Odregistriraj se od metode:
            a1.OdRegistrirajSaAutoMotorom(PozoviMe);

            // Nema više notifikacija! Jer više ne pozivamo delegat koji vrši 
            // obavještavanje u kakvom se Auto stanju nalazi! 
            for(int i = 0; i < 6; i++)
            {
                a1.Ubrzanje(20);
            }

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }


        private static void PozoviMe(string porZaPozivaca)
        {
            Console.WriteLine("=> Poruka od Auta: {0}.", porZaPozivaca);
        }



        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
