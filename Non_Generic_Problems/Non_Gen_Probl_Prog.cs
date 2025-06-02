using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Non_Generic_Problems
{
    class Non_Gen_Probl_Prog
    {
        /// <summary>
        /// Ovaj Program pokazuje koji su problemi ne-generičnih kolekcija.
        /// Jedan od problema je što nisu sigurne a drugi je brzina izvođenja.
        /// Nadam se da će to ovaj primjer da ilustrira...
        /// 
        /// UZMIMO ZA PRIMJER OVO. .NET IMA VELIK RASPON KATEGORIJA PODATAKA. TO UKLJUČUJE VRIJDNOSNE TIPOVE
        /// I REFERENCNE TIPOVE. ZNAJUĆI TO, DA .NET DEFINIRA DVIJE GLAVNE KATEGORIJE TIPOVA MI PONEKAD MORAMO 
        /// ILI TREBAMO REPREZENTIRATI JEDNU VARIJABLU JEDNE KATEGORIJE KAO VARIJABLU DRUGE KATEGORIJE. DA BI
        /// TO UČINILI C# NAM DAJE JEDNOSTAVAM MEHANIZAM, NAZVAN "BOXING" DA BI POHRANILI VARIJABLU VRIJEDNOSNOG
        /// TIPA U VARIJABLU REFERENCNOG TIPA. PA PRETPOSTAVIMO DA SMO KREIRALI LOKALNU VARIJABLU TIPA "int" U METODI
        /// NAZVANOJ "SimpleBoxUnboxOperation()". AKO BI TJEKOM IZVOĐENJA PROGRAMA, MI HTJELI DA TU VRIJEDNOST REPREZENTIRAMO
        /// KAO REFERNCNI TIP, A ONA JE VRIJEDNOSNI, MI BI TU VARIJABLU "BOXALI". 
        /// BOXING SE FORMALNO MOŽE DEFINIRATI KAO PROCES EXPLICITNOG DODJELJIVANJA VRIJEDNOSNOG TIPA SYSTEM.OBJEKT-U.
        /// KADA BOXIRAMO VRIJEDNOST CLR ALOCIRA NOVI OBJEKT NA HEAP-U I KOPIRA TU VRIJEDNOST U OVOM SLUČAJU 35 U TU INSTANCU.
        /// SUPROTNA OPERACIJE JE UNBOXING. A TO JE PROCES PRETVARANJA VRIJEDNOSTI KOJA JE ZADRŽANA U OBJEKT REFERENCI NAZAD 
        /// U KOREPONDIRAJUĆI VRIJDNOSNI TIP NAZAD U STACK. SINAKTIČKI GOVOREĆI UNBOXING IZGLEDA KAO NORMALNA CASTING OPERACIJA, 
        /// ALI SEMANTIKA JE SASVIM DRUGAČIJA...
        /// </summary>
        /// <param name="args"></param>

        static void SimpleBoxUnboxOpration()
        {
            // Napravi vrijednosi tip (int) varijeblu:
            int mojInt = 35;

            // Boxiraj je u objekt referencu:
            object boxedInt = mojInt;

            // Unboxiraj vrijednost nazad u int:
            int unboxedInt = (int)boxedInt;


            // Unboxing u pogrešan tip generira runtime izuzetak-exception
            try
            {
                long unboxedInt2 = (long)boxedInt;
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WorkwithArrayList()
        {
            // Vrijednosni tipovi su automatski
            // prosljeđeni metodi koja zahtjeva obejkt.
            ArrayList mojInt = new ArrayList();
            mojInt.Add(10);
            mojInt.Add(20);
            mojInt.Add(30);
            mojInt.Add(50);

            // ArrayList je automatski kreirala prostor na heap-u i alocirala ga za vrijednosni tip.
            // ako ga budemo htjeli koristiti moraćemo unboxirati heap-alocirani objekt u stack-alocirani 
            // integer koristeću "cast" operaciju. Ne zaboravimo da indexer od ArrayList vraća System.Objekt 
            // a ne System.Int32.

            // Unboxing se događa kad se objekt pretvara opet u stack-bazirani podatak:
            int i = (int)mojInt[0];

            // Sada kad je reboxiran, može biti ispisan kako WriteLine() traži objekt tipove te je int opet postao System.object!
            Console.WriteLine("Vrijednost mog int-a je: {0}", i);

            // Ja ću malo proširiti ovaj primjer pa ću reći da želim da vidim sve vrijenosti 
            // ArrayList-e:
            foreach(var item in mojInt)
            {
                Console.WriteLine("Moji int-ovi su. {0}.", item);
            }

        }

        static void ArrayListOfRandomObjects()
        {
            // Još jedan pokazatelj nesigurnog pisanja je to što ne-generične
            // Kolkcije kao ArrayList mogu držati sve moguće objekte! 
            // Evo primjera:
            ArrayList sviMojiObjekti = new ArrayList();
            sviMojiObjekti.Add(true);
            sviMojiObjekti.Add(new OperatingSystem(PlatformID.MacOSX, new Version(12,0)));
            sviMojiObjekti.Add(66);
            sviMojiObjekti.Add("Aydin");
            sviMojiObjekti.Add(3.14);

            foreach(var item in sviMojiObjekti)
            {
                Console.WriteLine(item.GetType().Name);
            }
        }

        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║         --- DOBRODOŠLI U KOLEKCIJE: PROBLEMI NE-GENERIČNIH KOLEKCIJA ---       ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region DIO 1

            Console.WriteLine("=> PROBLEMI NE-GENERIČNIH KOLEKCIJA:");
            Console.WriteLine();

            // Poziv metodi koja baca izuzetak jer nije pravilno unboxirana...
            SimpleBoxUnboxOpration();

            Console.WriteLine();
            Console.WriteLine("-> Primjer unboxinga sa ArrayList: ");

            // ArrayList Primjer unboxiranja int-a:
            WorkwithArrayList();

            Console.WriteLine();
            Console.WriteLine("-> Primjer kako ne generična kolekcija Arraylist sadržava sve objekte:");

            // Primjer ne genirčnog problema kolekcija:
            ArrayListOfRandomObjects();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region DIO 2
            // IAKO SADAŠANJA KOLEKCIJA OSGURAVA TIPE-SIGURNOST OSTAVLJA NAS U SITUACIJI GDJE
            // MORAMO KREIRATI (SKORO IDENTIČNE) POSEBNE KOLEKCIJE ZA SVAKI UNIKATNI PODATAK.
            // TAKO DA KAD BI THEJLI OVU FUNKCIONALNOST PRIMJENITI NA KLASU AutoE TREBALO BI
            // OPET KREIRATI POSEBNO ZA NJU SLIČNU KOLEKCIJSKU KLASU...
            Console.WriteLine("=> HARD-CODE KOLEKCIJA ARRAYLIST PERSON OBJEKTA:");
            Console.WriteLine("---------------------------------------");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Aydin", "Rose", 30));
            myPeople.AddPerson(new Person("Edin", "Džafić", 47));
            myPeople.AddPerson(new Person("Marlena", "Ahmagić", 37));
            myPeople.AddPerson(new Person("Edina", "Džafić", 54));
            myPeople.AddPerson(new Person("Jusuf", "Džafić", 86));
            myPeople.AddPerson(new Person("Azra", "Džafić", 42));
            
            // Ovo bi recimo bio kompajl-vremenska greška!
            // myPeople.AddPerson(new Car());

            // Sada pošto imamo IEnumerator u našoj kolekciji 
            // možemo ispisati je pomoću foreach petlje:
            foreach(Person p in myPeople)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("---------------------------------------");
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region CAR I EMPLOYEE KOLECIJE - NE-GENERIČNE

            Console.WriteLine("=> Car Kolekcija:");
            CarCollection carColl = new CarCollection();
            Console.WriteLine("----------------------------------------------------------");
            carColl.AddCar(new Car("BMW", "525i", 1995, "245"));
            carColl.AddCar(new Car("Audi", "A6", 2000, "185"));
            carColl.AddCar(new Car("Golf", "5d", 2006, "155"));
            carColl.AddCar(new Car("Opel", "Astra", 2009, "170"));
            carColl.AddCar(new Car("BMW", "M5", 2011, "225"));

            foreach(Car c in carColl)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("----------------------------------------------------------");

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("=> Employee Kolekcija:");
            EmployeeCollection empColl = new EmployeeCollection();
            Console.WriteLine("----------------------------------------------------------------------");
            empColl.AddEmployee(new Employee(1, "Aydin Rose", 30, 4500m));
            empColl.AddEmployee(new Employee(2, "Marelna G.Ahmagić", 37, 6500m));
            empColl.AddEmployee(new Employee(3, "Edin Džafić", 47, 14800m));
            empColl.AddEmployee(new Employee(4, "Adi Mehmedalić", 22, 1500m));
            empColl.AddEmployee(new Employee(5, "Ante Đapić", 56, 11500m));
            empColl.AddEmployee(new Employee(6, "Vladimir Šeks", 62, 25000m));

            foreach(Employee e in empColl)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("----------------------------------------------------------------------");
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region DIO 3 GENERIČNE KOLEKCIJE OSNOVNI PRIMJERI 
            
            Console.WriteLine("=> GENERIČNE KOLEKCIJE TIPA LIST<T> OSNOVNI PRIMJERI:");
            List<Person> morePoeople = new List<Person>();
            morePoeople.Add(new Person("Zoran", "Milanović", 46));
            Console.WriteLine(morePoeople[0]);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Mali primjer generične Sort<T> metode...
            int[] myInts = { 23, 34, 45, 56, 67, 78, 89, 90 };

            Array.Sort(myInts);

            foreach(int i in myInts)
            {
                Console.WriteLine("Vrijednost myInts je: {0}.", i);
            }


            #endregion

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
