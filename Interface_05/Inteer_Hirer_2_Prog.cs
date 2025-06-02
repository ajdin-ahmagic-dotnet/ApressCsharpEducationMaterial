using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_05
{
    class Inteer_Hirer_2_Prog
    {
        static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                   --- DOBRODOŠLI U: INTERFACES PRIMJER 4 ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // U Rectangle klasi je interface implementiran implicitno!
            Console.WriteLine("=> RECTANGLE KLASA, IMPLICITNO IMPLEMENTIRANI INTERFACE:");
            Rectangle rect = new Rectangle("Četverokut");
            rect.GetNumberOfSides();
            rect.Draw();
            rect.Print();
            Console.WriteLine("Broj strana je: {0}", rect.GetNumberOfSides());


            #region DELIMITER
            Console.WriteLine();
            #endregion


            Console.WriteLine("=> SQUARE KLASA, EXPLICITNO IMPLEMENTIRANI INTERFACE:");
            Square squ = new Square("Kocka");
            squ.Print();
            ((IPrintable)squ).Draw();
            ((IDrawable)squ).Draw();
            Console.WriteLine("Broj strana je: {0}", squ.GetNumberOfSides());

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
