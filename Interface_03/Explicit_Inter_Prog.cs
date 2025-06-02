using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_03
{
    class Explicit_Inter_Prog
    {
        /// <summary>
        /// OVAJ PRIMJER POKAZUJE NAM ZAŠTO TREBAMO EXPLICITNU IMPLEMENTACIJU INTERFACE-A.
        /// ONA JE TU ZBOG IMENA KOJA BI SE U VIŠE RAZLIČITIH INTERFACE-A MOGLA SUDRATI JER SU ISTA.
        /// I ZATO RADIMO U TIM I TAKVIM SLUČAJEVIMA EXPLICITNU IMPLEMENTACIJU.
        /// </summary>
        static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                   --- DOBRODOŠLI U: INTERFACES PRIMJER 2 ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> CRANJE OKTAGONA OD SVA TRI INTERFEJSA IMPLEMENTIRANA IMPLICITNO:");
            // Svi ovi pozivi pozivaju jednu te istu metodu Draw().
            Octagon oct = new Octagon();

            // Pozivi interfejsima:
            IDrawToForm itfForm = (IDrawToForm)oct;
            itfForm.Draw();

            IDrawToMemory itfMemory = (IDrawToMemory)oct;
            itfMemory.Draw();

            IDrawToPrinter itfPrinter = (IDrawToPrinter)oct;
            itfPrinter.Draw();

            #region DELIMITER
            Console.WriteLine();
            #endregion


            Console.WriteLine("=> CRANJE OKTAGONA OD SVA TRI INTERFEJSA IMPLEMENTIRANA EXPLICITNO:");
            OctagonExplicit octEx = new OctagonExplicit();

            // Pozivi interfejsima:
            IDrawToForm itfForm2 = (IDrawToForm)octEx;
            itfForm2.Draw();

            IDrawToMemory itfMemory2 = (IDrawToMemory)octEx;
            itfMemory2.Draw();

            IDrawToPrinter itfPrinter2 = (IDrawToPrinter)octEx;
            itfPrinter2.Draw();

            #region DELIMITER
            Console.WriteLine();
            #endregion

           
            // JEDNA KRATKA NOTACIJA JE MOGUĆA AKO NEĆEMO KORISTITI 
            // INTERFACE VARIJABLU DALJE JE:
            Console.WriteLine("-> SKRAĆENA POZIVNA SINTAKSA:");
            ((IDrawToForm)octEx).Draw();


            #region DELIMITER
            Console.WriteLine();
            #endregion

            // ISTO TAKO MOGUĆE JE KORISTI "is" KLJUČNU RIJEČ:
            Console.WriteLine("-> KORIŠTENJE \"is\" KLJUČNE RIJEČI:");
            if(octEx is IDrawToMemory)
                ((IDrawToMemory)octEx).Draw();
            

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
