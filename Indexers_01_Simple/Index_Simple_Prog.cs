using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace Indexers_01_Simple
{
    class Index_Simple_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║         --- DOBRODOŠLI U: INDEKSERE ( Jednostavni Indeks Primjer ) ---         ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1 - Osnovne funkcionalnosti

            Console.Write("Args su: ");
            string unos = Console.ReadLine();
            // Prođi kroz nadolazeće command-line argumente
            // koristeći index operator:
            for(int i = 0; i < unos.Length; i++)
            {
                Console.WriteLine("Unos: {0} ", unos[i]);
            }

            // Deklariraj Array integera:
            int[] mojInt = { 10, 20, 30, 40, 50, 60, 70 };

            // Iskoristi index operator da pristupiš svakom od njih:
            for(int i = 0; i < mojInt.Length; i++)
            {
                Console.WriteLine("Index: {0} = {1}", i, mojInt[i]);
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2 - Rad sa Person Klasom 1
            Console.WriteLine("=> RAD SA PERSON KLASOM 1:");
            Console.WriteLine();

            PersonCollection myPeople = new PersonCollection();

            // Dodaj objekete u kolekciju sa indexer sitaksom:
            myPeople[0] = new Person("Aydin", "Rose", 30);
            myPeople[1] = new Person("Edin", "Džafić", 47);
            myPeople[2] = new Person("Marlena", "G.Ahmagić", 37);
            myPeople[3] = new Person("Edina", "Mehmedalić", 55);
            myPeople[4] = new Person("Tahir", "Mehmedalić", 68);

            // Sada pridobij i prikaži svaku stavku koristeći indexer:
            for(int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Broj Osobe: {0}.", i);
                Console.WriteLine("Ime: {0} {1}.", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Godine: {0}.", myPeople[i].Age);
                Console.WriteLine();
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 3 - Korištenje generične Liste
            Console.WriteLine("=> KORIŠTENJE GENERIČNE LISTE:");
            KorisitGenericnuListuLjudi();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 4 - GENERIČNA KOLEKCIJA DICTIONARY<T, K>
            Console.WriteLine("=> RAD SA GENERIČNOM KOLEKCIJOM DICTIONARY:");
            Console.WriteLine();

            // Kada koristimo Ovu Generičnu kaslu Dictionary<TKey, TValue> mi direktno dobivamo
            // indexer metodnu funkcionalnost bez da moramo pisati posebne ne generične klase koje 
            // podržavaju string indexer!

            PersonCollectionDict myPeopleDict = new PersonCollectionDict();

            myPeopleDict["Aydin"] = new Person("Aydin", "Rose", 30);
            myPeopleDict["Marlena"] = new Person("Marlena", "Ahmagić", 37);
            myPeopleDict["Edin"] = new Person("Edin", "Džafić", 47);
            myPeopleDict["Edina"] = new Person("Edina", "Mehmedalić", 55);

            // Dobavi i izpiši na konzolu:
            Person aydin = myPeopleDict["Aydin"];
            Person marlena = myPeopleDict["Marlena"];
            Person edin = myPeopleDict["Edin"];
            Person edina = myPeopleDict["Edina"];

            Console.WriteLine(aydin.ToString());
            Console.WriteLine(marlena.ToString());
            Console.WriteLine(edin.ToString());
            Console.WriteLine(edina.ToString());

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - Korištenje ADO.NET u memoriji DataTable-a
            // Poziv metodi koja kreira DataTable:
            Console.WriteLine("=> MULTIDIMENZIONALNI INDEXER U DATA-TABLE-U:");
            Console.WriteLine();
            MultiIndexerSaDataTableom();

            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        static void KorisitGenericnuListuLjudi()
        {
            // Iako je indexer zgodan način da se prave custom kolekcije List<T> nam tu
            // mogućnost daje sama po sebi "out of the box"!

            // Napravi generičnu listu ljudi:
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Aydin", "Rose", 30));
            myPeople.Add(new Person("Marlena", "G.Ahmagić", 37));
            myPeople.Add(new Person("Edina", "Mehemedalić", 55));
            myPeople.Add(new Person("Edin", "Džafić", 47));

            // Promjeni drugu osobu sa indexerom:
            myPeople[1] = new Person("Marlena", "Ahmagić", 37);

            // Sada dobavi i prikaži svaku stvaku u listi:
            for(int i = 0; i < myPeople.Count; i++)
            {
                Console.WriteLine("Broj Osobe: {0}.", i);
                Console.WriteLine("Ime: {0} {1}.", myPeople[i].FirstName, myPeople[i].LastName);
                Console.WriteLine("Godine: {0}.", myPeople[i].Age);
                Console.WriteLine();
            }
        }

        static void MultiIndexerSaDataTableom()
        {
            // Napravi jednostavnu Data Tabelu sa tri kolone:
            DataTable mojTable = new DataTable();
            mojTable.Columns.Add(new DataColumn("Ime"));
            mojTable.Columns.Add(new DataColumn("Prezime"));
            mojTable.Columns.Add(new DataColumn("Starost"));

            // Sada moramo dodati red "row" u DataTable:
            mojTable.Rows.Add("Aydin", "Rose", 30);

            // Iskoristi mlutidimenzionalni indexer da dobiješ detalje prvog reda:
            Console.WriteLine("Ime: {0}.", mojTable.Rows[0][0]);
            Console.WriteLine("Prezime: {0}.", mojTable.Rows[0][1]);
            Console.WriteLine("Starost: {0}.", mojTable.Rows[0][2]);
        }

        #region NapisiPunuCrtu40 Metoda

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion
    }
}
