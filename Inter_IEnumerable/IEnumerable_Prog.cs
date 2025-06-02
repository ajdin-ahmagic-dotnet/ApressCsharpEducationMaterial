using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;


namespace Inter_IEnumerable
{
    class IEnumerable_Prog
    {
        /// <summary>
        /// Sada ovaj primjer može da radi jer klasa AutoE implementira IEnumerable!
        /// I svakako moramo koristiti using System.Collecions;
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: INTERFACES IENUMERABLE ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);


            Console.WriteLine("=> IEnumerable Primjer:");
            Console.WriteLine();

            // Za sada ovo se čini kao razumljivo:
            Garage autoGar = new Garage();

            // Predaj sve aute u kolekciji:
            foreach(AutoE auto in autoGar)
            {
                Console.WriteLine("{0} ide {1} km/h.", auto.ImeAuta, auto.TrenutnaBrzina);
            }

            #region DELIMITER
            Console.WriteLine();
            #endregion

            Console.WriteLine("-> Sada možemo direktno raditi sa IEnumeratorom:");
            Console.WriteLine();

            // Pošto je GetEnumerator metoda ozačena kao "public" onda možemo direktno
            // pozivati IEnumerator:
            IEnumerator i = autoGar.GetEnumerator();
            i.MoveNext();
            AutoE mojAuto = (AutoE)i.Current;
            Console.WriteLine("{0} ide {1} km/h.", mojAuto.ImeAuta, mojAuto.TrenutnaBrzina);

            IEnumerator j = autoGar.GetEnumerator();
            j.MoveNext();
            j.MoveNext(); // Sa ovom metodom idemo dalje pa onda poziva Audi...
            AutoE mojAuto2 = (AutoE)j.Current;
            Console.WriteLine("{0} ide {1} km/h.", mojAuto2.ImeAuta, mojAuto2.TrenutnaBrzina);

            // AKO ŽELIMO SAKRITI FUNKCIONALNOST IEnmureable INTERFACE-A OD KLASE IMPLEMENTIRAMO
            // GA EXPLICITNO I NEĆE MU SE MOĆI PRISTUPITI! DOK ĆE FOREACH IMATI PRISTUP DA ENUMERIRA
            // KROZ KLASU OBJEKTA.


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
