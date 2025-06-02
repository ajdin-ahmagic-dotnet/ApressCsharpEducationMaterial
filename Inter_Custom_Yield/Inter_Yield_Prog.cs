using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Inter_Custom_Yield
{
    class Inter_Yield_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: INTERFACES CUSTOM YIELD ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);


            Console.WriteLine("=> Promjena u Garage klasi, Yield return je pozvan na GetEnumerator() Metodi:");
            Console.WriteLine();


            Garage autoGar = new Garage();

            // Predaj sve aute u kolekciji:
            foreach(AutoE auto in autoGar)
            {
                Console.WriteLine("{0} ide {1} km/h.", auto.ImeAuta, auto.TrenutnaBrzina);
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            Console.WriteLine("-> Poziv preko IENumerator Interface-a:");
            IEnumerator i = autoGar.GetEnumerator();
            i.MoveNext();
            AutoE mojAuto = (AutoE)i.Current;
            Console.WriteLine("{0} ide {1} km/h.", mojAuto.ImeAuta, mojAuto.TrenutnaBrzina);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Dobavi stavke koristeći imenovani iterator eng. named iterator:
            Console.WriteLine("-> Ovo je Primjer kako pomoću imenovanih iteratora možemo obrnuti redosljed u Matrici:");
            foreach(AutoE a in autoGar.DobaviAute(true))
            {
                Console.WriteLine("{0} ide {1} Km/h.", a.ImeAuta, a.TrenutnaBrzina);
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
