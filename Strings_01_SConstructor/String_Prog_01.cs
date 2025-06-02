using System;
using System.Collections.Generic;
using System.Linq;

namespace Strings_01_SConstructor
{
    class String_Prog_01
    {
        /// <summary>
        /// Ovaj Primjer demostrira String Klasni Konstruktor...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║             --- DOBRODOŠLI U: STRINGS ( String Constructor ) ---               ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            string originalString, string1, string2, string3, string4;

            char[] karakterArray = { 'P', 'e', 't', 'r', 'a', ' ', 'M', 'r', 'z', 'i', ' ', 'A', 'j', 'd', 'i', 'n', 'a', '.' };

            // Inicalitacija String-a:
            originalString = "Dobrodošli u C# Programiranje!";
            string1 = originalString;
            string2 = new string(karakterArray);
            string3 = new string(karakterArray, 6, 12);
            string4 = new string('A', 5);

            Console.WriteLine(String.Format("string1 = \"{0}\"\nstring2 = \"{1}\"\nstring3 = \"{2}\"\nstring4 = \"{3}\"\n", string1, string2, string3, string4));



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
