using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace LinqIzrazi
{
    class Linq_Izrazi_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                    --- DOBRODOŠLI U: JEBENE LINQ IZRAZE ---                    ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 300);

            /* Rad sa izrazima u LINQ-u. LINQ ima svoje izraze od kojih su nakorišteniji: "from", "in", "where", "select".
             * I malo kompleksniji: "join", "on", "equals", "into", "orferby" ( uz orderby idu "ascending" i "descending" ), "group", "by".
             * U opisu ću dati puno više objašnjenja gdje se koji koriste za sada je bitno znati koji su to a kroz primjere ćemo pokazati
             * gdje se koriste i zašto.
            */

            ProduktInfo[] stavkeNaLageru = new[] 
                {
                    new ProduktInfo { Ime = "Windows XP",         Opis = "Operacioni Sistem", BrojNaLagaeru = 15},
                    new ProduktInfo { Ime = "Windows Vista",      Opis = "Operacioni Sistem", BrojNaLagaeru = 3},
                    new ProduktInfo { Ime = "Windows 7 Home",     Opis = "Operacioni Sistem", BrojNaLagaeru = 2},
                    new ProduktInfo { Ime = "Windows 7 Pro",      Opis = "Operacioni Sistem", BrojNaLagaeru = 13},
                    new ProduktInfo { Ime = "Windows 8",          Opis = "Operacioni Sistem", BrojNaLagaeru = 6},
                    new ProduktInfo { Ime = "Windows 8.1 Pro",    Opis = "Operacioni Sistem", BrojNaLagaeru = 11},
                    new ProduktInfo { Ime = "Windows 8.1 Ent",    Opis = "Operacioni Sistem", BrojNaLagaeru = 4},
                    new ProduktInfo { Ime = "Windows Server 2012",Opis = "Operacioni Sistem", BrojNaLagaeru = 2},
                };

            /* Da bi se ispunila sintaktiča pravila jednog LINQ upita moraju se zadovoljiti osnovna pravila u samom upitu a ona su:
             * var rezultat = "from" podudarnaStavak "in" Kontejner "select" podudarnastavka;
             * Da bi dobili specifični podset unutar kontejnera koristimo "where" izraz, tako da template za taj izraz izgleda ovako:
             * var rezultat = "from" Stavak "in" Kontejner "where" BoolovIzraz "select" Stavak;
             */


            #region POZIV METODI SelektirajSve

            // Poziv Metodi:
            SelektirajSve(stavkeNaLageru);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI IzlistajImeProdukta
            
            // Poziv Metodi:
            IzlistajImeProdukta(stavkeNaLageru);
            
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PreviseNaLageru
            
            // Poziv Metodi:
            PreviseNaLageru(stavkeNaLageru);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI DobaviImenaIOpise
            // Isto tako je moguće napraviti nove forme podataka u postojećem izvoru podataka. Pretpostavimo da želimo dolazeći ProductInfo[]
            // parametar uzeti i dobiti rezultat za ime i opis svakog proizvoda. Da bi to mogli učiniti moramo definitirati "select" izraz tako
            // da nam napravi "yield" novog anonimnog tipa, tj. anonimne metode. Evo poziva toj metodi:

            DobaviImenaIOpise(stavkeNaLageru);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI DobaviProjektiraniPodset

            Console.WriteLine("LINQ Projekcija preko Array: ");

            // Ovu Metodu u Main() Metodi pozivamo malo drugačije:
            Array objk = DobaviProjektiraniPodset(stavkeNaLageru);

            // Sad iteracija:
            foreach(object o in objk)
            {
                Console.WriteLine(o); // Poziva ToString() za svaki anonimni objekt.
            }
            
            /* Možemo primjetiti da ne smijemo koristiti Array deklaracijsku sintaksu nego samo literal System.Array, 
             * s tim u vez mi ne znamo temeljni tip podataka, pošto radimo sa kopajler generiranom anonimnom klasom!
             * Ito možemo primjetiti da ne prosljeđujemo parametar generičnoj ToArray<T> metodi, zato što ne znamo 
             * temeljni tip podataka sve do kompajl vremena, a što je kasno za naše potrebe tako da ne znamo koji tip
             * da prosljedimo.
             */ 

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI DobaviBrojStavkiIzUpita
            
            // Poziv Metodi:
            DobaviBrojStavkiIzUpita(stavkeNaLageru);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PreokreniSve
            
            // Poziv Metodi:
            PreokreniSve(stavkeNaLageru);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI AflabetičkiPosloženiProdukti
            
            // Poziv Metodi:
            PosloziAlfabeticki(stavkeNaLageru);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PrikaziExcept
            
            // Poziv Metodi:
            PrikaziExcept();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PrikaziIntersect
            
            // Poziv Metodi:
            PrikaziIntersect();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PrikaziUnion
            
            // Poziv Metodi:
            PrikaziUnion();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PrikaziConcat
            
            // Poziv Metodi:
            PrikaziConcat();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI PrikaziConcatBezDuplikata
            
            // Poziv Metodi:
            PrikaziConcatBezDuplikata();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POZIV METODI AgregatneOperacije

            // Poziv Metodi:
            AgregatneOpracije();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        // Jednostavni LINQ upit koji kaže jednostavno izlistaj mi sve proizvode:
        static void SelektirajSve(ProduktInfo[] proizvodi)
        {
            // Dobavi sve!
            Console.WriteLine("Sve detalji proizvoda: ");

            var sviProdukti = from p in proizvodi
                              select p;

            // Iteracija Kroz upit:
            foreach(var produkt in sviProdukti)
            {
                Console.WriteLine(produkt.ToString());
            }
        }

        // Ovaj jednotsavni LINQ upit samo izlistava imena proizvoda, pošto za sada radimo sa
        // osnovnim LINQ izrazima:
        static void IzlistajImeProdukta(ProduktInfo[] proizvodi)
        {
            // Sada dobavi samo imena proizvoda:
            Console.WriteLine("Samo imena proizvoda: ");
            
            // LINQ upit:
            var imenaPro = from p in proizvodi
                           select p.Ime;

            // Iteracija Kroz upit:
            foreach(var produkt in imenaPro)
            {
                Console.WriteLine("| Ime: {0,-20} |", produkt.ToString());
            }
        }

        // Kad uključimo "where" izraz gdje možemo reći daj mi samo one proizvode 
        // gdje je broj na lageru veći od 10 u upuit onda ga možemo posatviti ovako:
        static void PreviseNaLageru(ProduktInfo[] proizvodi)
        {
           
            Console.WriteLine("Proizvodi kojih ima previše na lageru: ");

            // Daj mi proizvode kojih ima previše na lageru tj. > 10:
            var previsePro = from p in proizvodi
                             where p.BrojNaLagaeru > 10
                             select p;

            // Iteracija Kroz upit:
            foreach(ProduktInfo p in previsePro)
            {
                Console.WriteLine(p.ToString());
            }

        }

        // Dinamično vraćanje kroz anonimne tipove:
        static void DobaviImenaIOpise(ProduktInfo[] proizvodi)
        {
            Console.WriteLine("Imena i Opisi proizvoda putem anonimnih tipova:");
            
            // LINQ Upit:
            var imeDecs = from p in proizvodi
                          select new { p.Ime, p.Opis };

            // Iteracija kroz Linq upit:
            foreach(var stavka in imeDecs)
            {
                // Mogli smo isto tako koristiti Ime i Opis osobine direktno. 
                Console.WriteLine(stavka.ToString());
            }

        }

        // Kada želimo da vratimo projektiranu verziju pozivaocu, jedan od načina je da upitni - query
        // rezultat vratimo u obliku .NET System.Array objekta koristeći ToArray() proširenu metodu.
        // Evo primjera:
        static Array DobaviProjektiraniPodset(ProduktInfo[] proizvodi)
        {
            // LINQ Upit:
            var imeDesc = from p in proizvodi
                          select new { p.Ime, p.Opis };

            // Pridruži set anonimnih objekata na Array objekt:
            return imeDesc.ToArray();
        }

        // Kada Projektiramo gomile podataka vjerovatno želimo da znamo njihov broj, koliko stavki 
        // smo dobili od upita. Tako da svaki put kada želimo da dobijemo broj stvaki u upitu, možemo
        // korisiti "Count()" proširenu metodu od "Enumerable" klase. Evo Primjera:
        static void DobaviBrojStavkiIzUpita(ProduktInfo[] proizvodi)
        {
            // Ovdje smo zadali "where" klauzulu a možemo i bez nje postaviti ovaj upit, koja kaže svi proizvodi 
            // čije je Ime duže od 6 karaktera...
            int upit = (from p in proizvodi where p.Ime.Length > 6 select p).Count();
            
            Console.WriteLine("Proizvoda ima: {0}.", upit); 
        }

        // Možemo preokrenuti rezultate upita jednostavno ako to želimo putem Reverse<T> produžene metode od 
        // "Enumerable" klase. Evo Primjera:
        static void PreokreniSve(ProduktInfo[] proizvodi)
        {
            Console.WriteLine("Produkti preokrenuti:");
            
            // LINQ upit:
            var sviProizvodi = from p in proizvodi
                               select p;

            // Reverse<T> radimo u iteraciji:
            foreach(var produkt in sviProizvodi.Reverse())
            {
                Console.WriteLine(produkt.ToString());
            }
        }

        // Kao što već znamo korištenjem "orderby" klauzule ili izraza možemo sortirati stavke
        // upita alfabetički, ako želimo preokernuti u Ž-A umjesto A-Ž jednostavno iskoristimo
        // descending operator, ako želimo po broju ili bilo kako samo kažemo ( orderby p.Osobina koju želimo )
        // Evo jednostavan primjer:
        static void PosloziAlfabeticki(ProduktInfo[] proizvodi)
        {
            Console.WriteLine("Proizvodi posloženi Alfabetički:");
            
            // Linq upit:
            var upit = from p in proizvodi
                       orderby p.Ime
                       select p;

            // Iteracija kroz upit:
            foreach(var produkt in upit)
            {
                Console.WriteLine(produkt.ToString());
            }


            Console.WriteLine();

            Console.WriteLine("Sada posloži po Broju na Lageru:");
            
            // Ako izostavimo "descending" upit će nam posložiti proizvode od najmanjeg do najvećeg,
            // a mi želimo u ovom slučaju od najvećeg do najmanjeg, i tu uključujemo "descending" operator.
            // Linq upit:
            var lUpit = from p in proizvodi
                        orderby p.BrojNaLagaeru descending
                        select p;

            // Iteracija kroz lUpit:
            foreach(var produkt in lUpit)
            {
                Console.WriteLine(produkt.ToString());
            }
        }

        // EXCEPT() produžena metoda. Enumerable klasa podržava set produženih metoda koje nam dozvoljavaju da koristimo 
        // više LINQ upita kao bazu da pronađemo jedinjenja, razlike, povezne podatke, te križanja podataka. Prvo ćemo 
        // pogledati Except() metodu, Koja vraća LINQ rezultat set koji sadrži razlike između dva kontejnera podataka. 
        // Evo Primjera:
        static void PrikaziExcept()
        {
            Console.WriteLine("Razlika između ove dvije Liste je:");
           
            List<string> auti  = new List<string>() { "BMW", "Mercedes", "Porsche" };
            List<string> auti2 = new List<string>() { "Porsche", "Mercedes", "Opel" };

            // Linq upit:
            var autoRaz = (from a in auti select a)
                .Except(from a2 in auti2 select a2);

           
            foreach(string s in autoRaz)
            {
                Console.WriteLine(s);
            }


        }

        // Intersect() produžena metoda vraća set rezultata koji sadrže zajedničke stavke podataka u setu kontejnera.
        // Npr. Sljedeći primjer vraća sekvencu "BMW" i "Porsche":
        static void PrikaziIntersect()
        {
            Console.WriteLine("Prikaži križanja u listama:");

            List<string> auti = new List<string>() { "BMW", "Mrecedes", "Porsche" };
            List<string> auti2 = new List<string>() { "Porsche", "Mercedes", "BMW" };

            // Linq upit, Dobavi zajedničke članove:
            var autoKrizanja = (from a in auti select a)
                .Intersect(from a2 in auti2 select a2);

            // Iteracija:
            foreach(string s in autoKrizanja)
            {
                Console.WriteLine(s);
            }

        }

        // Union() produžena metoda kao što joj i ime kaže, sjedinjava gomile Linq upita. Tako da metoda ispod će ispisati
        // "BMW", "Mercedes", "Prosche"...
        static void PrikaziUnion()
        {
            Console.WriteLine("Prikaži zajedniče stavke u listama:");

            List<string> auti = new List<string>() { "BMW", "Mercedes", "Porsche" };
            List<string> auti2 = new List<string>() { "Opel", "Mercedes", "BMW" };

            // Ling upit, sjedinjenja u listama:
            var autoSjedinjenja = (from a in auti select a)
                .Union(from a2 in auti2 select a2);

            // Iteracija kroz upit:
            foreach(string s in autoSjedinjenja)
            {
                Console.WriteLine(s);
            }
        }

        // Concat() produžena metoda vraća set rezultata koji je direktna lančana poveznica od upita LINQ-a.
        // Tako da će ova metoda vratiti sljedeće: Mercedes-Porsche-BMW-BMW-Opel-Porsche
        static void PrikaziConcat()
        {
            Console.WriteLine("Prikaži zajedniče stavke u listama:");

            List<string> auti = new List<string>() { "Mercedes", "Porsche", "BMW" };
            List<string> auti2 = new List<string>() { "BMW", "Opel", "Porsche", };

            // Linq upit:
            var autiPovezani = (from a in auti select a)
                .Concat(from a2 in auti2 select a2);

            // Iteracija:
            foreach(string s in autiPovezani)
            {
                Console.WriteLine(s);
            }

        }

       [Category("LINQ Operatori")]
       [Description("Disticnt() produžena metoda nam omogućava da kad koristimo Concat() produženu metodu, uklonimo duplikate.")]
        static void PrikaziConcatBezDuplikata()
        {
            Console.WriteLine("Metoda Distinct() uklanja duplikate stavki u listama:");

            List<string> auti = new List<string>() { "Mercedes", "Porsche", "BMW" };
            List<string> auti2 = new List<string>() { "BMW", "Opel", "Porsche", };

            // Linq upit:
            var upit = (from a in auti select a)
                .Concat(from a2 in auti2 select a2);

            // Ispisuje: "Mercedes", "Porsche", "BMW", "Opel". Svako auto samo jedan put, svi 
            // duplikati su zanemarani!
            foreach(string s in upit.Distinct())
            {
                Console.WriteLine(s);
            }
        }

        // LINQ upiti mogu piti dizajnirani tako da naprave sakupljanje različitih operacija u rezultat set. Count() 
        // produžena metoda je primjer jednog takvog sakupljanja. Druge mogućnosti uključuju dobivanje Makismuma, minimuma,
        // ili sume vrijednosti koristeći: "Max()", "Min()", "Average()" i "Sum()" produžene metode a koji su svi članovi
        // Enumerable klase. Evo Primjera:
        static void AgregatneOpracije()
        {
            double[] zimskeTemp = { 2.0, -21.3, -3.2, 8, 3.4, -5.2 };

            // Razni "Agregatni" primjeri:

            // Max():
            Console.WriteLine("Maksimalne temperature: {0}.", (from t in zimskeTemp select t).Max());

            // Min():
            Console.WriteLine("Minimalne temperature: {0}.", (from t in zimskeTemp select t).Min());

            // Average():
            Console.WriteLine("Prosječne temperature. {0}.", (from t in zimskeTemp select t).Average());

            // Sum():
            Console.WriteLine("Suma svih temperatura: {0}.", (from t in zimskeTemp select t).Sum());

        }

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
