using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_01_Simple_Ex
{
    // Ovaj delegat može pozvati bilo koja metoda,
    // koja uzima dva integera i vraća integer...
    public delegate double BinaryOp(double x, double y);

    // Ova klasa sadži metode na koje delagat BinaryOp
    // pokazuje!
    public class SimpleMath
    {
        public static double Zbroji(double x, double y)
        {
            double z = x + y;
            return z;
        }

        public static double Oduzmi(double x, double y)
        {
            double z = x - y;
            return z;
        }

        public static double Pomnozi(double x, double y)
        {
            double z = x * y;
            return z;
        }

        public static double Podjeli(double x, double y)
        {
            double z = x / y;
            return z;
        }

        public static double Ostatak(double x, double y)
        {
            double z = x % y;
            return z;
        }

        // U ovom primjeru su metode statiče ali delegati mogu raditi
        // i sa instancnim metodama, samo što bi ona morali napraviti
        // instancu klase pa onda pozivati metode.
        public double Zbroji2(double x, double y)
        {
            double z = x + y;
            return z;
        }
    }


    /// <summary>
    /// Delegati jednostavni primjer. Pošto delgati mogu u početku biti teško razumljivi
    /// krećemo sa vrlo jednostavnim primjerom...
    /// </summary>
    public class DelSimpleProg
    {
        public static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║               --- DOBRODOŠLI U: DELEGATE ( Simple Example) ---                 ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("=> RAD SA DELEGATIMA:");
            Console.WriteLine();

            // Za korištenje instancne metode moramo
            // napraviti instancu klase:
            SimpleMath math = new SimpleMath();


            // Kreiraj BinaryOp delegat objekt koji pokazuje na
            // SimpleMath.Add() metodu:
            BinaryOp b1 = math.Zbroji2;

            // Pozovi Add metodu indirektno koristeći delegat objekt:
            Console.WriteLine("10 + 10 = {0}.", b1(10, 10));

            Console.WriteLine("Kalkulator napravljen koristeći Delegate!");
            Console.WriteLine();
            Console.Write("Da li želite pokrenuti kalkulaotr DA/NE: ");
            string odgovor = Console.ReadLine();

            // Iako sam mogao metode pozvati direktno u ovom slučaju ne vidim nikakvu korist od delegata!
            // Delegati za kalkulator:
            BinaryOp zb = SimpleMath.Zbroji;
            BinaryOp od = SimpleMath.Oduzmi;
            BinaryOp po = SimpleMath.Pomnozi;
            BinaryOp pod = SimpleMath.Podjeli;
            BinaryOp os = SimpleMath.Ostatak;

            if (!(odgovor is null) && odgovor.ToLower() == "da")
            {
                Console.Write("Unesite Broj: ");
                double br1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Unesite Broj: ");
                double br2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Unesite Operaciju (+,-,*,/,%): ");
                string op = Console.ReadLine();

                if (op == "+")
                {
                    Console.WriteLine("{0} + {1} = {2}", br1, br2, zb(br1, br2));
                }
                if (op == "-")
                {
                    Console.WriteLine("{0} - {1} = {2}", br1, br2, od(br1, br2));
                }
                if (op == "*")
                {
                    Console.WriteLine("{0} * {1} = {2}", br1, br2, po(br1, br2));
                }
                if (op == "/")
                {
                    Console.WriteLine("{0} / {1} = {2}", br1, br2, pod(br1, br2));
                }
                if (op == "%")
                {
                    Console.WriteLine("{0} % {1} = {2}", br1, br2, os(br1, br2));
                }
            }

            PrikaziInfoDelegata(zb); // Ne prikazuje ime tipa jer su metode statične!
            PrikaziInfoDelegata(od);
            PrikaziInfoDelegata(po);
            PrikaziInfoDelegata(pod);
            PrikaziInfoDelegata(os);
            PrikaziInfoDelegata(b1);

            // Ali zbog demostrativnih razloga napravićemo i intancne metode...

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        public static void PrikaziInfoDelegata(Delegate delObj)
        {
            // Ispiši imena svakog člana pozvne liste delegata:
            foreach (Delegate d in delObj.GetInvocationList())
            {
                Console.WriteLine("Ime metode: {0}.", d.Method);
                Console.WriteLine("Ime tipa: {0}.", d.Target);
            }
        }


        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.SetWindowSize(width: 134, height: 45);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
