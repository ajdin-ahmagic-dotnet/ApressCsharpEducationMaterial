using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_03_Generic
{
    // OVAJ GENERIČNI DELAGAT MOŽE POZVATI BILO KOJU METODU 
    // KOJA VRAĆA "VOID" I UZIMA JEDAN PARAMETAR BILO KOJEG TIPA!
    public delegate void MojGenericniDelegat<T>(T arg);


    class Generic_Del_Prog
    {
        /// <summary>
        /// Primjer kako rade generični delegati koji uz generiranje tipova mogu uzeti bilo koji parametar
        /// bilo kojeg tipa, string, bool, int, decimal, Person itd...
        /// Gerenični delagti mogu biti vrlo korisni pogotovo što im se kao parametar može prosljediti objekt!
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║             --- DOBRODOŠLI U: DELEGATES ( GENERIC DELEGATES ) ---              ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> GENERIČNI DELAGATI:");
            Console.WriteLine();
            
            // Primjer uzimanja sa string parametrom:
            MojGenericniDelegat<string> strTarget = new MojGenericniDelegat<string>(StringTarget);

            strTarget("Neki string podatci...");

            MojGenericniDelegat<int> intTarget = new MojGenericniDelegat<int>(IntTarget);

            intTarget(100);


            // Sad ćemo pokušati delegatu dodjeliti objekt Person!
            // I pošto je generičan bez ikakvih problema je prihvatio objekt-klasu Person kao parametar!
            MojGenericniDelegat<Person> objectTarget = new MojGenericniDelegat<Person>(PersonTarget);

            objectTarget(new Person("Ajdin Rose", 30, 4500m));
            
            

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Metode za Generični Delegat

        private static void StringTarget(string arg)
        {
            Console.WriteLine("arg u velikim slovima je: {0}.", arg.ToUpper());
        }

        private static void IntTarget(int arg)
        {
            Console.WriteLine("++arg je: {0}.", ++arg);
        }
        private static void PersonTarget(Person arg)
        {
            Console.WriteLine(arg);
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
