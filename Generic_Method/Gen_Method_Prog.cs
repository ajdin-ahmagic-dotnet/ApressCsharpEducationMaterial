using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Method
{
    class Gen_Method_Prog
    {
        /// <summary>
        /// Primjer korištenja overloadirane metode da bi se ispisala Array drugačijih tipova a moguće je samo 
        /// sa generičnom metodom.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║             --- DOBRODOŠLI U: GENERICS ( Generična Metoda ) ---                ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Kreiraj Array's tipa double, char i int:
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
            char[] charArray = { 'P', 'O', 'Z', 'D', 'R', 'A', 'V', '!' };

            Console.WriteLine("\nArray intArray sadržava:");
            IspisiArray(intArray); // Prosljedi Array kao parametar.
            Console.WriteLine("\nArray doubleArray sadržava:");
            IspisiArray(doubleArray); // Prosljedi Array kao parametar.
            Console.WriteLine("\nArray charArray sadržava:");
            IspisiArray(charArray); // Prosljedi Array kao parametar.

            // Isto tako generičnoj metodi možemo prosljediti tip koji želimo:
            Console.WriteLine("\nArray sa int argumentom:");
            IspisiArray<int>(intArray);

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region GENERIČNA METODA ZA SVE TIPOVE MATRICA
        static void IspisiArray<E>(E[] ulaznaArray)
        {
            foreach(E elemenet in ulaznaArray)
            {
                Console.Write(elemenet + " ");
            }
        }
        #endregion



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
