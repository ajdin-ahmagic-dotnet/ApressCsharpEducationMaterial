using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_02_Multi_Params
{
    public delegate string JakoJednostavniDelegat();
    class Lambda_Mu_Par_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║       --- DOBRODOŠLI U: LAMBDA IZRAZE ( Multiple lambda Parameters ) ---       ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Registracija delagata sa lambda izrazom: 
            SimpleMath m = new SimpleMath();
            m.SetMathHandler((msg, result) =>
                {
                    Console.WriteLine("Message: {0}\nResult: {1}", msg, result);
                });

            // Ovaj dio koda će izvršiti lambda izraz:
            m.Add(20, 35);

            // I još lambda koja ineraktira sa delagtom a nema parametara:
            JakoJednostavniDelegat d = () =>
                                       {
                                           return "Ovo je jako jednostavni delegat sa lambdom!";
                                       };

            Console.WriteLine(d());

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }



        #region NapsiPunuCrtu40 Metoda

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }

        #endregion
    }
}
