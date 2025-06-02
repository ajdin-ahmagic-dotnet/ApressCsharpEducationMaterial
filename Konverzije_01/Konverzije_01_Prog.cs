using System;
using System.Collections.Generic;
using System.Linq;

namespace Konverzije_01
{
    #region Klase za Primjer 1

    class Baza { }

    class Derivacija : Baza { }

    #endregion

    #region Strukture za Primjer 2
    public struct Pravokutnik
    {
        // Osobine:
        public int Sirina { get; set; }
        public int Visina { get; set; }
     

        // Konstruktor:
        public Pravokutnik(int sirina, int visina) : this()
        {
            Sirina = sirina; Visina = visina;
        }

        // Metoda:
        public void Nacrtaj()
        {
            for(int i = 0; i < Visina; i++)
            {
                for(int j = 0; j < Sirina; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }

        // Override Metoda:
        public override string ToString()
        {
            return string.Format("[Širina: {0} Visina: {1}]", Sirina, Visina);
        }

        // Sa dodavanjem ove metode u mogućnosti smo da kastiramo implicitno!
        public static implicit operator Pravokutnik(Kvadrat k)
        {
            Pravokutnik c = new Pravokutnik();
            c.Visina = k.Duzina;

            // Pretpostavimo da je dužina Pravokutnika (Dužina x 2):
            c.Sirina = k.Duzina * 2;
            return c;
        }
    }

    public struct Kvadrat
    {
        // Osobine:
        public int Duzina { get; set; }

        // Konstruktor:
        public Kvadrat(int d) : this()
        {
            Duzina = d;
        }

        // Metoda:
        public void Nacrtaj()
        {
            for(int i = 0; i < Duzina; i++)
            {
                for(int j = 0; j < Duzina; j++)
                {
                    Console.Write(" *"); // Ovdje sam namjerno ostavio jedan white-space da bi Kvadrat izgledala kako spada.
                }
                Console.WriteLine();
            }
        }
        // Override Metoda:
        public override string ToString()
        {
            return string.Format("[Dužina = {0}]", Duzina);
        }


        /// <summary>
        /// Kao što se da primjetiti metoda koristi "opertator" ključnu riječ zajedno sa "explicit" i mora biti "static". 
        /// To je osnovna rutina u konverzijama. Dolazeći parametar je entitet od kojeg kovertiramo, dok je operator entitek u 
        /// kojeg konveriramo. Znači konvertiramo Pravokutnik u Kocku.
        /// </summary>
        public static explicit operator Kvadrat(Pravokutnik r)
        {
            Kvadrat k = new Kvadrat()
            {
                Duzina = r.Visina
            };
            return k;
        }

        // UPDATE! Kocke da može kovertirati u int:
        public static explicit operator Kvadrat(int duzinaStr)
        {
            Kvadrat novaKoc = new Kvadrat();
            novaKoc.Duzina = duzinaStr;
            return novaKoc;
        }

        // Konverzija iz tipa int u Kocku:
        public static explicit operator int (Kvadrat k)
        {
            return k.Duzina;
        }
    }

    #endregion
    class Konverzije_01_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: KONVERZIJE TIPOVA I KLASA ---                 ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1 - Vrlo Jednostavan Primjer

            // JEDNOSTAVNE KONVERZIJE:
            // Implicitni "cast" između derivirane i bazne klase:
            Baza mojBazniTip;
            mojBazniTip = new Derivacija();

            // Mora biti explicitna konverzija da pohrani baznu referencu:
            Derivacija mojDeriviraniTip = (Derivacija)mojBazniTip;

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2 - Konverzije Struktura 
            Console.WriteLine("=> RAD SA KONVERZIJAMA:");
            Console.WriteLine();

            // Pravimo jedan Pravokutnik:
            Pravokutnik c = new Pravokutnik(20, 5);
            Console.WriteLine(c.ToString()); // Poziv override metodi...
            c.Nacrtaj();

            Console.WriteLine();

            // Konvertiraj "c" u Kocku, bazirano na visini Pravokutnika:
            Kvadrat k = (Kvadrat)c;
            Console.WriteLine(k.ToString()); // poziv override metodi...
            k.Nacrtaj();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Metoda koja uzima Kocku kao parametar i crta je
            // Sad "cast"-iramo kocku u tjelu metode kao parametar te 
            // pretvaramo Pravokutnik u kocku!
            Console.WriteLine("-> EXPLICITNO KONVERTIRAMO PRAVOKUTNIK U KVADRAT:");
            // Inicijaliziramo novi Četvrokut:
            Pravokutnik c2 = new Pravokutnik(20, 10);

            //Pozivamo metodu i prosljeđujemo kocku kao parametar i kastiramo:
            NacrtajKocku((Kvadrat)c2);
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER Kocke sa Int-om
            // Recimo da želimo dadamo eksplicitnu konverziju koja dozvoljava
            // pozivaocu da kastira od tipa int u Kocku? Evo logike koja to omogućava:
            Console.WriteLine("-> DODJELJIVANJE INT TIPA KVADRATU I CAST:");
            // Konverzija int tipa u Kocku:
            Kvadrat k3 = (Kvadrat)15;
            Console.WriteLine("k3 = {0}.", k3);

            // Knverzija iz tipa int u Kocku:
            int stranica = (int)k3;
            Console.WriteLine("Stranica od k3 je dugačka: {0}.", stranica);
            k3.Nacrtaj();


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Implictne Koverzije
            // Kvadrat k4 = new Kvadrat();
            // k4.Duzina = 83;

            // Pokušaj da napravimo implicitni cast:
            // Pravokutnik c2 = k4; 

            // Ovaj kod se neće kompajlirati. 
            // Moramo u Strukturi Pravokutnik napraviti overload implicit operatora! 
            // Pošto u strukturama nema nasljeđivanja konverzije moramo ručno odraditi.

            // Sada kada smo napravili metodu u strukturi Ceverokut koja overloadira implicit operator
            // možemo komotno raditi implicitni cast:
            Console.WriteLine("-> IMPLICITNA KOVERZIJA KVADRATA U PRAVOKUTNIK:");
            Kvadrat k5 = new Kvadrat();
            k5.Duzina = 12;
            Pravokutnik c3 = k5;
            Console.WriteLine("c2 = {0}", c3);
            c3.Nacrtaj();

            // Eksplicitni "cast" je i dalje u redu!
            Kvadrat k6 = new Kvadrat();
            k6.Duzina = 5;

            Console.WriteLine("-> EKSPLICITNI CAST PONOVNO:");
            // Koverzija:
            Pravokutnik p1 = (Kvadrat)k6;
            Console.WriteLine("p1 = {0}", p1);
            p1.Nacrtaj();

            #endregion
            
            
            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        // Nije baš od pomoći imati konverziju Pravokutnika u Kocku u istom "Skopu", pa pretpostavimo da 
        // imamo metodu koja uzima Kocku kao parametar:
        static void NacrtajKocku(Kvadrat Kvadrat)
        {
            Console.WriteLine(Kvadrat.ToString());
            Kvadrat.Nacrtaj();
        }


        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
