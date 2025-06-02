using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnviroment3
{
    struct Tacka
    {
        // Polja strukture.
        public int X;
        public int Y;

        // Konstruktor
        public Tacka(int xPoz, int yPoz)
        {
            X = xPoz;
            Y = yPoz;
        }


        // Dodaj 1 na pozicije (X,Y).
        public void Uvecaj()
        {
            X++; Y++;
        }

        public void Umanji()
        {
            X--; Y--;
        }

        public void Umanji2()
        {
            X -= 2; Y -= 2; 
        }

        // Prikaži trenutnu poziciju.
        public void Prikazi()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }


    }

    class TackaRef
    {
        public int X;
        public int Y;

        // Konstruktor
        public TackaRef(int xPoz, int yPoz)
        {
            X = xPoz;
            Y = yPoz;
        }


        // Dodaj 1 na pozicije (X,Y).
        public void Uvecaj()
        {
            X++; Y++;
        }

        public void Umanji()
        {
            X--; Y--;
        }

        public void Umanji2()
        {
            X -= 2; Y -= 2;
        }

        // Prikaži trenutnu poziciju.
        public void Prikazi()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }

    }


    class Program
    {
        static void Main()
        {
            #region CORE PROGRAMMING 2 - (Nastavak)

            #region STRUKTURE PRIMJER 1

            Console.WriteLine("=> Prvi pogled na strukture.");
            Console.WriteLine();
            // Kreiraj inicjalnu tačku.
            Console.WriteLine("Prije poziva metode Uvećaj!");
            Tacka mojaTacka;
            mojaTacka.X = 349;
            mojaTacka.Y = 80;
            mojaTacka.Prikazi();

            // Sad primjeni metode strukture na varijable X i Y.
            Console.WriteLine("Poslje poziva metode Uvećaj!");
            mojaTacka.Uvecaj();
            //mojaTacka.Umanji();
            mojaTacka.Prikazi();

            Console.WriteLine("Poslje poziva metode Umanji2!");
            mojaTacka.Umanji2();
            mojaTacka.Prikazi();

            Console.WriteLine();
            Console.WriteLine("Sada sa Konstruktorom.");
            Tacka t1 = new Tacka(20, 50);
            t1.Prikazi();
            t1.Umanji2();
            t1.Prikazi();

            #endregion// STRUKTURE PRIMJER 1

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region STRUKTURE PRIMJER 2
            Console.WriteLine("=> Strukture Primjer 2.");
            Console.WriteLine();

            Tacka t2 = new Tacka(10, 10);
            Tacka t3 = t2;

            // Ispiši obje tačke.
            t2.Prikazi();
            t3.Prikazi();

            // Promjeni t2.X i ispiši opet. t3.X se nije promjenio.
            t2.X = 123;
            Console.WriteLine("\n=> Promjenjena tačka t2.X\n");
            t2.Prikazi();
            t3.Prikazi();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region STRUKTURE PRIMJER 3 - RAZLIKA SA KLASAMA
            Console.WriteLine("=> Razlika između struktura i klasa u value-reference odnosu...");
            Console.WriteLine();

            TackaRef tRef1 = new TackaRef(10, 10);
            TackaRef tRef2 = tRef1;

            // Ispiši obje tačke.
            tRef1.Prikazi();
            tRef2.Prikazi();

            // Promjeni tRef1.X i ispiši opet.
            tRef1.X = 123;
            Console.WriteLine("\nPromjenjena tRef1.X\n");
            tRef1.Prikazi();
            tRef2.Prikazi();

            #endregion

            #region Malo govora...
            /// <summary>
            /// Sada kada imamo malo bolje razumijevanje između vrijednosnih i referencnih tipova,
            /// možemo stvari malo drugačije posložiti pa ćemo napraviti jednu klasu sa strukturom i klasom
            /// te ćemo je ovdje pozvati u sljedećem primjeru.
            /// </summary>
            #endregion

            #region STRUKTURE PRIMJER 4

            Console.WriteLine("=> PRIMJER 4 STRUKTURE SA REFERENCNIM VARIJBLAMA IZ KLASE:");
            
            // Poziv prvom pravokutniku.
            Pravokutnik p1 = new Pravokutnik("Prvi Pravokutnik", 10, 10, 50, 50);

            // Sada ćemo prvi pravokutnik dodjeliti drugom.
            Console.WriteLine("-> Dodjeljujemo p2 pravokutniku p1:");
            Pravokutnik p2 = p1;

            // Promjenićemo neke vrijednosti pravokutnika p2.
            p2.pravInfo.infoString = "Ovo su nove informacije!";
            p2.pravDole = 99;

            p1.Prikazi();
            p2.Prikazi();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region STRUKTURE PRIMJER - OSOBA KLASA ( po vrijednosti )
            // PROSLJEDIĐIVANJE REF-TIPOVA PO VRIJEDNOSTI.
            Console.WriteLine("=> PROSLJEĐIVANJE OBJEKTA \"OSOBA\" PO VRIJEDNOSTI:");
            Osoba os = new Osoba("Ajdin", 30);
            Console.WriteLine("Prije poziva metode Osoba je:");
            os.Prikazi();

            ProsljediOsobuPrekoVrijednosti(os);
            Console.WriteLine("\nPoslje \"poziva po vrijednosti\" Osoba je:");
            os.Prikazi();

            #endregion// STRUKTURE PRIMJER - OSOBA KLASA ( po vrijednosti )

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region STRUKTURE PRIMJER - OSOBA KLASA ( po referenci )
            Console.WriteLine("=> PROSLJEĐIVANJE OBJEKTA \"OSOBA\" PO REFERENCI:");

            Osoba os2 = new Osoba("Edin", 46);
            Console.WriteLine("Prije poziva metode Osoba je:");
            os2.Prikazi();

            // Da bi prosljedili osobu putem reference treba nam uvjek ref ključna riječ
            // kako u deklaraciji metode tako i u pozivu.
            ProsljediOsobuPrekoReference(ref os2);
            Console.WriteLine("\nPoslje \"poziva po referenci\" Osoba je:");
            os2.Prikazi();

            #endregion// STRUKTURE PRIMJER - OSOBA KLASA ( po referenci )

            #endregion// CORE PROGRAMMING 2 - (Nastavak)
            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz.");
            Console.ReadKey();

        }

        #region METODE 

        #region METODA ZA KLASU OSOBA

        static void ProsljediOsobuPrekoVrijednosti(Osoba o)
        {
            // Promjeni godine osobe.
            o.godineOsobe = 56;

            // Dali će pozivaoc vidjeti ovaj reasajment?
            o = new Osoba("Edin", 46);
        }

        // Prosljeđivanje referencnim putem kroz metode se isključivo radi sa "ref" ključnom riječi.
        static void ProsljediOsobuPrekoReference(ref Osoba o)
        {
            o.godineOsobe = 87;

            // Ovdje će definitivno vidjeti ovaj reasajment!
            o = new Osoba("Aydin", 92);
        }

        #endregion// METODA ZA KLASU OSOBA

        #endregion// METODE 
    }

    
}
