using System;
using System.Collections.Generic;
using System.Linq;

namespace Labmda_01_Simple
{
    class Lambda_Sim_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║           --- DOBRODOŠLI U: LAMBDA IZARZE ( Jednostavni Labmda ) ---           ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Rad sa Lambda Izrazima:
            Console.WriteLine("=> STARA DELEGATNA SINTAKSA:");
            Console.WriteLine();

            TradicionalnaDelagatnaSintaksa();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("=> MALO BOLJA SINTAKSA ANONIMNIH METODA:");
            Console.WriteLine();
            AnonimnoMetodnaSintaksa();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("=> SUPER SINTAKSA LAMBDA:");
            Console.WriteLine();
            LambdaSintaksa();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("=> VIŠE ARGUMENATA U LAMBDA IZRAZU:");
            Console.WriteLine();
            ViseArgumentaULambdaIzrazu();

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Tradicionalna Delagatna Sintaksa 

        private static void TradicionalnaDelagatnaSintaksa()
        {
            // Napravi Listu Integera:
            List<int> list = new List<int>();
            list.AddRange(new int[] { 20, 3, 4, 2, 12, 13, 17, 15, 44, 56, 78, 95 });

            // Pozovi FindAll Metodu koriteći se tradicionalnom sintaksom:
            Predicate<int> opoziv = new Predicate<int>(DaliJeParan);

            //Pozovi metodu FindAll() kao parametar stavi delegat koji nosi kao parametar ispitnu metodu
            // da li je broj paran:
            List<int> parniBrojevi = list.FindAll(opoziv);

            Console.WriteLine("Evo vaših parnih Brojeva:");
            foreach(int paranBroj in parniBrojevi)
            {
                Console.Write("{0}\t", paranBroj);
            }
            Console.WriteLine();

        }
        // Target-odredište za delegat Perdicate<>:
        private static bool DaliJeParan(int i)
        {
            // Da li je jednak broj?
            return (i % 2) == 0;
        }

        #endregion

        #region SINATKSA ANONIMNIH METODA

        private static void AnonimnoMetodnaSintaksa()
        {
            // Napravi Listu integera:
            List<int> list = new List<int>();
            list.AddRange(new int[] { 22, 23, 25, 27, 34, 36, 88, 56, 12, 13, 16, 89, 96 });

            // Sada iskoristimo Anonimne Metode!
            List<int> parniBrojevi = list.FindAll(delegate(int i)
                {
                    return (i % 2) == 0;
                });

            Console.WriteLine("Evo vaših Parnih Brojeva:");
            foreach(int parniBroj in parniBrojevi)
            {
                Console.Write("{0}\t",parniBroj);
            }
        }

        #endregion

        #region LAMBDA SINTAKSA!!!

        private static void LambdaSintaksa()
        {
            // Napravi listu integera:
            List<int> list = new List<int>();
            list.AddRange(new int[] { 22, 23, 24, 25, 26, 45, 58, 69, 98, 86, 56, 34, 24, 12, 13, 28 });

            // Sada iskoristimo Lambdu do kraja!
            List<int> parniBrojevi = list.FindAll(i => (i % 2) == 0); // I TO JE SVE!!!

            Console.WriteLine("Evo vaših Parnih Brojeva: ");
            foreach(int parniBroj in parniBrojevi)
            {
                Console.Write("{0}\t", parniBroj);
            }

        }

        #endregion

        #region LAMBDA SA VIŠE ARGUMENATA

        private static void ViseArgumentaULambdaIzrazu()
        {
            // Napravi listu integera:
            List<int> list = new List<int>();
            list.AddRange(new int[] { 22, 24, 26, 28, 13, 15, 17, 19 });

            List<int> neparniBrojevi = list.FindAll((i) =>
                {
                    Console.WriteLine("Vrijednost od 'i' trenutno je: {0}", i);
                    bool jePanar = ((i % 2) == 1);
                    return jePanar;
                });

            Console.WriteLine("Vaša lista Neparnih Brojeva: ");
            foreach(int neparanBroj in neparniBrojevi)
            {
                Console.Write("{0}\t", neparanBroj);
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
