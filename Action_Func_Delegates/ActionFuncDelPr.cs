using System;
using System.Collections.Generic;
using System.Linq;

namespace Action_Func_Delegates
{
    public class ActionFuncDelPr
    {
        /// <summary>
        /// U ovom programu demostriramo korištenje Action<T> i Func<T> .Net framework delegata.
        /// Jer nekad jednostavno želimo samo neki delegat koji ima vraćanja mora biti "void".
        /// I da ne bi morali kreirati naš custom delegat za to možemo koristiti action delegat.
        /// U ovim slučajevima se možemo koristiti framework-ovim već postavljenim delegatima Action i Func.
        /// U slučaju da imamo return tip koji nije "void" tu nastupa Func delagat!
        /// Ovo je Program koji ilustrira njihovo korištenje.
        /// </summary>
        public static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║            --- DOBRODOŠLI U: DLEGATES ( Action<T> & Func<T> ) ---              ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green;

            // Sada umjesto da kreiramo delegat pa ga upućujemo prema
            // PrikaziPoruku Metodi, kreiramo Action generični delegat:
            Console.WriteLine("Action Delegat:");
            Action<string, ConsoleColor, int> actionTarget = PrikaziPoruku;

            actionTarget("Action Poruka!", ConsoleColor.Magenta, 10);

            Console.WriteLine();
            // Tako da nam Action delegat pomaže da skratimo vrijeme, umjesto da moramo definirati
            // svoj custom delegat već imamo gotovi koji možemo koristiti za ovakve svrhe...
            // Ali samo da još jednom naglasim da Action<T> delegat može uzeti samo "void" return tip!

            // Za return tip koji nije void odgovoran je Func<T> delegat!
            Console.WriteLine("Func Delegat:");
            Func<int, int, int> funcTarget = Zbroji;
            int rezultat = funcTarget.Invoke(40, 40);
            Console.WriteLine("40 + 40 = {0}", rezultat);

            Console.WriteLine();
            Console.WriteLine("Func Delegat:");
            Func<int, int, int> funcTarget2 = Oduzmi;
            int rezultat2 = funcTarget2.Invoke(200, 50);
            Console.WriteLine("200 - 50 = {0}", rezultat2);


            Console.WriteLine();
            Console.WriteLine("Func Delegat:");
            Func<int, int, string> funcTarget3 = SumaUString;
            string suma = funcTarget3(90, 300);
            Console.WriteLine(suma);



            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Metoda za Action Delegat

        public static void PrikaziPoruku(string por, ConsoleColor bojaTexta, int ispisiBroj)
        {
            // Postavi Boju Konzole:
            ConsoleColor prijasnja = Console.ForegroundColor;
            Console.ForegroundColor = bojaTexta;

            // For petlja koja na osnovu unosa od strane parametra određuje
            // koliko će puta poruka biti ispisana:
            for(int i = 0; i < ispisiBroj; i++)
            {
                Console.WriteLine(por);
            }

            // Resetiraj boju:
            Console.ForegroundColor = prijasnja;
        }

        #endregion

        #region Metoda za Func Delegat
        static int Zbroji(int x, int y)
        {
            return x + y;
        }

        static int Oduzmi(int x, int y)
        {
            return x - y;
        }
        static string SumaUString(int x, int y)
        {
            int z = x + y;
            // old way return string.Format("{0} + {1} = {2}", x, y, z); //(x + y).ToString();
            return string.Format(format: $"{x} + {y} = {z}");
        }
        #endregion


        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.SetWindowSize(width: 134,height: 45);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }

    }
}
