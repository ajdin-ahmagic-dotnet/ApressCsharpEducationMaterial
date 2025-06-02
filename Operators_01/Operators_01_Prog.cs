using System;
using System.Collections.Generic;
using System.Linq;

namespace Operators_01
{
    class Operators_01_Prog
    {
        /// <summary>
        /// OVAJ PROJEKT JE SAMO DEMONSTRATIVNOG OZRAČJA JER, OVERLOADIRANJE OPERATORA NEĆEMO RADITI TAKO ČESTO
        /// JER IPAK ZA TO TREBA POSTOJATI NEKI SMISAO! A U VEĆINI SLUČAJEVA GA NEMA ALI POŠTO TA OPCIJA POSTOJI
        /// MI SMO JE UVRSTILI U POSTOJEĆE...
        /// OVERLOADIRANJE OP. JE NAJBOLJE ZA KREIRANJE TEKSTA, TAČAKA, FRAKCIJA, ATOMSKIH RIJEŠENJA ITD...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║            --- DOBRODOŠLI U: OVERLOADIRANJE OPERATORA ---                      ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> RAD SA OVERLOADIRANJEM OPERATORA:");
            Console.WriteLine();

            Tacka t1 = new Tacka(100, 100);
            Tacka t2 = new Tacka(50, 50);

            Console.WriteLine("t1 = {0}", t1);
            Console.WriteLine("t2 = {0}", t2);

            Console.WriteLine("=> Binarno overloadiranje operatora:");
            Console.WriteLine();
            // U Pseodo Kodu ova operacija izgleda: Tacka t1 = Tacka.operator + (t1,t2)
            Tacka t3 = t1 + t2;

            Console.WriteLine("Suma zbrajanja Tacaka t1 + t2 je: {0}", t3);

            Tacka t4 = t1 - t2;

            Console.WriteLine("Suma oduzimanja Tacaka t1 - t2 je: {0}", t4);

            Console.WriteLine();

            Tacka vecaTacka = t1 + 10;
            Console.WriteLine("t1 + 10 = {0}", vecaTacka);

            Console.WriteLine("10 + vecaTacka = {0}", 10 + vecaTacka);

            Console.WriteLine();
            
            // Skraćeni overloadirani operatori += i -= : 
            Console.WriteLine("Skaraćeni overloadirani operatori += i -= :");
            Console.WriteLine();
            Tacka t5 = new Tacka(90, 5);
            Console.WriteLine("t5 = {0}", t5);
            Console.WriteLine("t5 += t2: {0}", t5 += t2); // A što je skraćenica za t5 = t5 + t2;

            Tacka t6 = new Tacka(0, 500);
            Console.WriteLine("t6 = {0}", t6);
            Console.WriteLine("t6 -= t1 = {0}", t6 -= t1); // A što je skraćenica za t6 = t6 - t1;
            Console.WriteLine();

            // OVERLOADIRANJE UNARNIH OPERATORA ++ I -- :
            Console.WriteLine("Unarno overloadiranje operatora:");
            Console.WriteLine();
            Tacka t7 = new Tacka(1, 1);
            Console.WriteLine("t7 = {0}", t7);
            Console.WriteLine("++t7 = {0}", ++t7); // Prefiksno overloadiranje!
            Console.WriteLine("--t7 = {0}", --t7);

            Tacka t8 = new Tacka(20, 20);
            Console.WriteLine("t8 = {0}", t8);
            Console.WriteLine("t8++ = {0}", t8++);
            Console.WriteLine("t8-- = {0}", t8--);

            // Overloadiranje operatora jednakosti:
            Console.WriteLine("=> Overloadiranje operatora jednakosti:");
            Console.WriteLine();

            Console.WriteLine("t1 == t2 : {0}", t1 == t2);
            Console.WriteLine("t1 != t2 : {0}", t1 != t2);

            Console.WriteLine("t1.X == t1.Y : {0}", t1.X == t1.Y);
            Console.WriteLine("t1.X != t1.Y : {0}", t1.X != t1.Y);

            Console.WriteLine("t2 == t3 : {0}", t2.Equals(t3));
            Console.WriteLine();

            // Overloadiranje komparacijskih operatora:
            Console.WriteLine("=> Overloadiranje operatora usporedbi-komaracijski operatori:");
            Console.WriteLine();






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
