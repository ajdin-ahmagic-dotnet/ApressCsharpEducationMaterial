using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonim_Types_01
{
    class Anonim_Tip_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                    --- DOBRODOŠLI U: ANONIMENE TIPOVE ---                      ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region UVOD
            /*---------------------------------------------------------------
             | Anonimni Tipovi su poznati u JavaScrip-i već dugo vremena. U |
             | C# su uvedeni u verziji .NET 3.0. Nekad nam se javlja potreba|
             | za kreiranjem lokalih objekata koji se neće koristi nigdje   |
             | drugo osim lokalno. Za kreiranje tih objeka nema smisla krei-|
             | rati novu klasu. Tu nam uskaču anonimni tipovi, koji omoguć- |
             | avaju da se ne trebaju pisati defeinicije novih klasa. Kopa- |
             | jler će autatski kreirati odgovarajući tip u Runtime-u za tip|
             | koji je anoniman a ozanačavamo ga ključnom riječju "var"!    |
             | Kompajler je dovoljo pametan da skonta koji je to tip recimo |
             | var = "ajdin"; kompajler će tu varijablu protumačiti kao str-|
             | ing. var = 2.3; kao double itd... Za više ref. u Knjizi.     |
             --------------------------------------------------------------*/
            #endregion

            // DA NEMA ANONIMNIH TIPOVA ZA OVU IMPLEMENTACIJU BI MORALI KREIRATI NOVU KLASU!
            // OVAKO SVE SMO URADILI SA JEDNO MMETODOM, ALI SVE ZATO OSTAJE NA LOKALNOM NIVOU.

            Console.WriteLine("=> RAD SA ANONIMNIM TIPOVIMA:");
            Console.WriteLine();

            #region Primjer 1 - Auto

            // Napravi anonimni tip koji predstavlja Auto:
            var mojAuto = new { Model = "BMW", Boja = "Crna", TrnutnaBrzina = 130 };

            

            // Sada Prikaži boju i Model auta:
            Console.WriteLine("Moj auto je: {0} Boja: {1}.", mojAuto.Model, mojAuto.Boja);

            // Sada pozovi pomoćnu metodu da napravi anonimni tip pomoću argumenata args.
            NapraviAnonimniTip("Opel", "Zelena", 80);
            Console.WriteLine();

            Console.WriteLine("-> Izori anonimnog tipa:");
            Console.WriteLine();
            // Reflektiraj Preko onoga što je kompjler generirao:
            ReflektPrekoAnoTipa(mojAuto);
            Console.WriteLine();
            Console.WriteLine("-> Ispit jednakosti Anonimnih tipova:");
            TestJednakosti();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 2 - Zaposlenik
            // Poziv ano. metodi:
            AnonimnaMetoda2("Aydin Rose", 30, 2811983181509, "Aleja Matice Hr. 41", 4500m);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Anoinimni tipovi u Anonimnim Tipovima!
            
            // Moguće je kreirati anonimni tip i onda u njega staviti novi anonimni tip.
            // Evo primjera jedne takve situacije:
            var kupiStavku = new
            {
                VrijemeKupovine = DateTime.Now,
                StavkaKupljena = new { Model = "BMW 525d", Boja = "Crvena", TrenutnaBrzina = 180 },
            };

            Console.WriteLine("Vrijeme kupovine: {0}.\nKupljen: {1}.", kupiStavku.VrijemeKupovine, kupiStavku.StavkaKupljena.Model);

            ReflektPrekoAnoTipa(kupiStavku);
            #endregion

            #region ZAKLJUČAK I PAR ČINJENICA
            /*--------------------------------------------------------------------------------------------------
             * U ovom trenutku zasigurno se pitate zašto i kada koristiti ovu značajku C# jezika? Anonimne     *
             * tipve bi trebali koristiti u parovama najčešće u LINQ naredbama o kojim će biti riječi kasnije. * 
             * Nikad ne bi trebali da napustimo jako tipirane klase i strukture, jer anonimni tipovi imaju     * 
             * mnoge limitacije od kojih možemo nabrojati:                                                     *
             * 1. Vi ne kontrolirate ime anonimnog tipa.                                                       *
             * 2. Anonimni tipvi uvjek produžavaju System.Obejct.                                              *
             * 3. Polja i Osobine anonimnih tipova su uvjek "read-only".                                       *
             * 4. Anonimni tipve ne podržavaju događaje, posebne metode, posebne operatore, i posebne overajde.*
             * 5. Anonimni tipovi su uvjek implicitno zaključani "sealed".                                     *
             * 6. Anonimni tipovi su uvjek konstruirani sa osnovnim konstruktorom.                             *
             *-------------------------------------------------------------------------------------------------*/ 
            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Anonimna Metoda 1
        static void NapraviAnonimniTip(string model, string boja, int trBrz)
        {
            // Napravi anonimni tip koristeći dolazeće argumente "args"
            var auto = new { Model = model, Boja = boja, Brzina = trBrz };
 
            // Možemo primjetiti da sa ovim možemo koristiti podatke iz osobina!
            Console.WriteLine("Vi imate: {0} Boje: {1} Km/h: {2} ", auto.Model, auto.Boja, auto.Brzina);

            // Anonimni tipvi ima posebnu implementaciju za svaku virtualnu metodu od System.Object-a npr:
            // Pošto kad kreiramo anonimni tip, kompajler iza scene napravi klasu za nas koja ima implementaciju overloada 
            // ToString() metode onda dobijemo rezulat koji se vidi kad se program pokrene...
            Console.WriteLine("ToString() == {0}.", auto.ToString());
        }
        #endregion

        #region ANONIMNA METODA 2
        static void AnonimnaMetoda2(string imeIPrezime, int godine, long oIB, string adresa, decimal placa)
        {
            // ŠTO BI NAM INAČE TREBALA CIJELA KLASA SADA OD C# 3.0 IMAMO U JEDNOJ METODI!
            var zaposlenik = new { Ime = imeIPrezime, Godine = godine, OIB = oIB, Adresa = adresa, Placa = placa };

            Console.WriteLine("| {0,-13:} | {1,-2:} | {2,-13:} | {3,-20:} | {4:C2} |", zaposlenik.Ime, zaposlenik.Godine, zaposlenik.OIB, zaposlenik.Adresa, zaposlenik.Placa);

           
        }
        #endregion

        #region Reflekt Preko Anonimnog Tipa
        static void ReflektPrekoAnoTipa(object obj)
        {
            Console.WriteLine("obj je instanca od: {0}.", obj.GetType().Name);
            Console.WriteLine("Bazna klasa od: {0} je: {1}.", obj.GetType().Name, obj.GetType().BaseType);
            Console.WriteLine("obj.ToString() == {0}", obj.ToString());
            Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
            Console.WriteLine();
        }
        #endregion

        #region Test Jednakosti - Semantika Anonimnih Tipova

        static void TestJednakosti()
        {
            // Napravi 2 anonimne klase sa identičnim ime/vrijednost parametrima:
            var prviAuto = new { Model = "BMW 525", Boja = "Crna", TrnutnaBrzina = 235 };
            var drugiAuto = new { Model = "BMW 525", Boja = "Crna", TrnutnaBrzina = 235 };

            // Da ih se smatra jednakim kad se koristi Equals():
            if(prviAuto.Equals(drugiAuto))
                Console.WriteLine("Isti Anonimni Objekt");
            else
                Console.WriteLine("Nije Isti Anonimni Objekt");
            
            // Da li ih se smatra jednakim kad se koristi operator jednakosti "==":
            // Ova usporadba neće rezultirati jednakim rezulataom zato što anonimni tipovi
            // ne prihvaćaju overloadiranu verziju "==" i "!=" opratora, te upoređuju reference
            // objekta a ne vrijednosti koje objekt drži, tako da je rezultat negativan.
            if(prviAuto == drugiAuto)
                Console.WriteLine("Isti Anonimni Objekt");
            else
                Console.WriteLine("Nije Isti Anonimni Objekt");

            // Da li ih se smatra jednakim kad se koristi isti osnovni tip:
            if(prviAuto.GetType().Name == drugiAuto.GetType().Name)
                Console.WriteLine("Istog smo Tipa!");
            else
                Console.WriteLine("Nismo istog Tipa!");

            // Prikaži nam rezulatat:
            Console.WriteLine();
            ReflektPrekoAnoTipa(prviAuto);
            ReflektPrekoAnoTipa(drugiAuto);
        }

        #endregion



        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
