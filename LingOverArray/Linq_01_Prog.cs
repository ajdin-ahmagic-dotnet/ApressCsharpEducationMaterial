using System;
using System.Collections.Generic;
using System.Linq;

namespace LingOverArray
{
    class Linq_01_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                      --- DOBRODOŠLI U: LINQ PRIMJER 1---                       ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> RAD SA LINQ to OBJECTS:");
            Console.WriteLine();

            // Poziv Metodi:
            UpitNaStrings();


            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("-> Ista Stvar kao i gore ali ostvarena bez upotrebe LINQ-a:");
            Console.WriteLine();

            // Poziv Metodi:
            UpitNaStringsNaDuze();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("-> Upit na Array integera:");
            Console.WriteLine();

            // Poziv Metodi:
            UpitNaInteger();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("-> Upit na Array Integera sa implicitnim tipiranjem:");
            Console.WriteLine();

            // Poziv metodi:
            UpitNaIntegerImplicitno();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("-> Izvršavanje odmah! :");
            Console.WriteLine();

            // Poziv Metodi:
            IzvrsenjeOdmah();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("-> Poziv klasi 'LainqBaziranaPolja' gdje smo prinuđeni koristiti statični tiping:");
            Console.WriteLine();

                      

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }
        #region UpitNaStrings Metoda - Prvi Primjer LINQ-a
        static void UpitNaStrings()
        {
            // Pretpostavimo da imamo matricu string-ova:
            string[] trenutneVideoIgre = { "Morrowind", "Hallo", "Hellraiser", "Uncharted 2", "Fallout 3", "Super Mario Bros 2", "Dead Space 2", "Generals 2" };

            // Napravi query - upitni izraz da nađeš stavke u matrici koje imaju prazni prosotor:
            IEnumerable<string> podset = from i in trenutneVideoIgre
                                         where i.Contains(" ")
                                         orderby i
                                         select i;

            // Ispiši van rezultate:
            foreach(string s in podset)
            {
                Console.WriteLine("Stavka: {0}", s);
            }

            // Poziv ReflektirajPrekoUpitRezultata Metodi:
            ReflektirajPrekoUpitRezultata(podset);
        }
        #endregion

        #region Ista Metoda kao i gornja Ali bez LINQ-a
        static void UpitNaStringsNaDuze()
        {
            // Mi ne moramo koristiti LINQ nije obavezan tako da rezultate možemo dobaviti 
            // id drugim ali puno težim putem!

            // Pretopstavimo da imamo array string-sa:
            string[] trenutneVideoIgre = { "Morrowind", "Hallo", "Hellraiser", "Uncharted 2", "Fallout 3", "Super Mario Bros 2", "Dead Space 2", "Generals 2" };

            string[] igreSaPrazProstorom = new string[8];

            for(int i = 0; i < trenutneVideoIgre.Length; i++)
            {
                if(trenutneVideoIgre[i].Contains(" "))
                    igreSaPrazProstorom[i] = trenutneVideoIgre[i];
            }

            // Sada stavke trebamo sortirati:
            Array.Sort(igreSaPrazProstorom);

            // Ispiši rezultate:
            foreach(string s in igreSaPrazProstorom)
            {
                if(s != null)
                    Console.WriteLine("Stavka: {0}", s);
            }
            Console.WriteLine();
        }
        #endregion

        #region Metoda koja nam daje Info o upitu

        static void ReflektirajPrekoUpitRezultata(object rezultatSet)
        {
            Console.WriteLine("****************** Info o vašem upitu ******************");
            Console.WriteLine();
            Console.WriteLine("rezultatSet je tipa: {0}.", rezultatSet.GetType().Name);
            Console.WriteLine("rezultatSet lokacija: {0}.", rezultatSet.GetType().Assembly.GetName().Name); 
        }

        #endregion

        #region UpitNaInteger Metoda

        static void UpitNaInteger()
        {
            // Array integera:
            int[] brojevi = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 1, 3, 5, 7, 9 };

            // Ispiši samo stavke manje od 10:
            IEnumerable<int> podset = from i in brojevi
                                      where i < 10
                                      select i;

            // Za svaku stavku u IEnumerable<int> ipiši vrijednost:
            foreach(int stavka in podset)
            {
                Console.WriteLine("Stavka: {0}.", stavka);
            }
            ReflektirajPrekoUpitRezultata(podset);
        }

        #endregion

        #region UpitNaIntegerImplicitno

        static void UpitNaIntegerImplicitno()
        {
            // Bitno je napomenuti da kad god a to će biti stalo koristimo implicitno tipiranje,
            // iza scene se odvija generični IEnumerable<T> iterface. Svaki put kad kažemo "var query = from b in brojevi..." 
            // generični IEnum odrađuje u kompjal time-u iza scene možemo ga zvati explicitno ali implicitno nam skraćuje
            // pisanje koda...


            // Array inetegera:
            int[] brojevi = { 10, 20, 30, 40, 42, 44, 45, 48, 50, 60, 70, 80, 90 };

            // Sada pravi LINQ sa implicitnim tipiranjem:
            var upit = from b in brojevi
                       where b < 50 && b > 40 // Uzmi sve brojeve koji su manji od 50 a veći od 40.
                       select b;

            // Evaluacija LINQ izraza:
            foreach(var stavka in upit)
            {
                Console.WriteLine("Stavka: {0}.", stavka);
            }

            Console.WriteLine();
            Console.WriteLine("Ponovna Iteracija:");
            Console.WriteLine();

            brojevi[0] = 41;

            // Ponovna evaluacija:
            foreach(var stavka in upit)
            {
                Console.WriteLine("Stavka: {0}.", stavka);
            }


            ReflektirajPrekoUpitRezultata(upit);

        }

        #endregion

        #region Uloga Izvršenja Odmah!

        static void IzvrsenjeOdmah()
        {
            // Array Integera:
            int[] brojevi = { 10, 20, 30, 40, 50, 51, 53, 55, 57, 59, 60, 70, 80, 90 };

            // Dobavi podatke ODMAH kao int[]! Ovdje možemo reći i ToArray<T> što je ToArray(); 
            int[] podsetKaoIntArray = (from b in brojevi where b < 60 && b > 50 select b).ToArray<int>();

            // Dobavi podatke ODMAH kao List<int>! Sa listom je isto...
            List<int> podsetKaoListInta = (from b in brojevi where b < 60 && b > 50 select b).ToList<int>();

            // Iteracija:
            foreach(var stavka in podsetKaoIntArray)
            {
                Console.WriteLine("Stavka: {0}.", stavka);
            }

            Console.WriteLine();
            ReflektirajPrekoUpitRezultata(podsetKaoIntArray);
            Console.WriteLine();

            foreach(var stavka in podsetKaoListInta)
            {
                Console.WriteLine("Stavka: {0}.", stavka);
            }

            Console.WriteLine();
            ReflektirajPrekoUpitRezultata(podsetKaoListInta);
            Console.WriteLine();
        }

        #endregion


        #region NapisiPunuCrtu40 METODA

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }

        #endregion
    }
}
