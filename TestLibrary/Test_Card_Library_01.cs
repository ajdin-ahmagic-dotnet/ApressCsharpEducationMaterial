using System;
using System.Collections.Generic;
using System.Linq;
using Library;

namespace TestLibrary
{
    class Test_Card_Library_01
    {
        /// <summary>
        /// Test Libraria - ClassLibrary bliblioteke klasa, koja definira igranje karatama... 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                      --- DOBRODOŠLI U: IGRU SA KARTAMA ---                     ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Poziv Library bibioteci i igri sa kartama:
            Console.WriteLine("=> SVAKI PUT KAD SE PROGRAM POKRENE, PROGRAM ĆE IZBACITI DEK KARATA I PODJELITI GA SVAKI PUT RAZLIČITO:");
            Console.WriteLine();
            Deck myDeck = new Deck();
            myDeck.Shuffle();

            for(int i = 0; i < 52; i++)
            {
                Card tempCard = myDeck.GetCard(i);
                Console.Write(tempCard.ToString());
                if(i != 51)
                    Console.WriteLine(", ");
                else
                    Console.WriteLine();
            }     
     
     
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
