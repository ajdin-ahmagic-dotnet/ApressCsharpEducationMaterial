using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_02_SMethods
{
    class String_Prog_02
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: STRINGS (String Metode ) ---                  ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            string string1;
            char[] karakterArray;

            string1 = "Pozdrav Tamo";
            karakterArray = new char[7];

            // Izbaci na Konzolu string1:
            Console.WriteLine("string1: {0}", string1);

            // Testiraj "Length" property:
            Console.WriteLine("Dužina \"Length\" od string1 je: {0}.", string1.Length);

            Console.WriteLine("string1 preokrenuto je:");
            // Prođi kroz karaktere u string1 i ispiši ih:
            for(int i = string1.Length - 1; i >= 0; i--)
            {
                Console.Write(string1[i]);
            }

            

            // Kopiraj karaktere iz string1 u karakterArray:
            string1.CopyTo(0, karakterArray, 0, karakterArray.Length);
            Console.Write("\nKarakter Array je: ");

            // Prođi kroz karakterArray:
            for(int i = 0; i < karakterArray.Length; i++)
            {
                Console.Write(karakterArray[i]);
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
