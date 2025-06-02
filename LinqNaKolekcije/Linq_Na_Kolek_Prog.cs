using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;


namespace LinqNaKolekcije
{
    class Linq_Na_Kolek_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                   --- DOBRODOŠLI U: LINQ na KOLEKCIJE ---                      ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // U ovom primjeru radimo LINQ na kolekcije:
            Console.WriteLine("=> LINQ NA KOLEKCIJE:");
            Console.WriteLine();

           
            
            // Napravi generičnu kolekciju List<T> Auto objekata:
            List<Auto> auto = new List<Auto>()
            {
                new Auto { Ime = "BMW",      Model = "525",     Brzina = 250, Boja = "Crna"      },
                new Auto { Ime = "Opel",     Model = "Vectra",  Brzina = 130, Boja = "Crvena"    },
                new Auto { Ime = "Mercedes", Model = "SL 500",  Brzina = 230, Boja = "Zelena"    },
                new Auto { Ime = "Audi",     Model = "A 6",     Brzina = 210, Boja = "Siva"      },
                new Auto { Ime = "Citroen",  Model = "Xara",    Brzina = 120, Boja = "Bijela"    },
                new Auto { Ime = "Glof",     Model = "6 TDI",   Brzina = 165, Boja = "Žuta"      },
                new Auto { Ime = "Opel",     Model = "Astra",   Brzina = 140, Boja = "Zelena"    },
                new Auto { Ime = "Mercedes", Model = "C 200",   Brzina = 190, Boja = "Crna"      },
                new Auto { Ime = "Audi",     Model = "A 3",     Brzina = 110, Boja = "Crvena"    },
                new Auto { Ime = "Citroen",  Model = "BX 14",   Brzina = 145, Boja = "Plava"     },
                new Auto { Ime = "Glof",     Model = "6 GTI",   Brzina = 170, Boja = "Ljubičasta"},
                new Auto { Ime = "BMW",      Model = "635",     Brzina = 280, Boja = "Siva"      },
                new Auto { Ime = "BMW",      Model = "730",     Brzina = 260, Boja = "Crvena"    },
                new Auto { Ime = "BMW",      Model = "325",     Brzina = 210, Boja = "Žuta"      },
            };

            // LINQ upit na kolekcije nije ništa drugačiji od LINQ upita na Array jer na sve što implementira
            // IEnumerable možemo primjeniti isti princip.

            // Poziv Metodi koja Vraća upit, kojoj proljeđujemo listu auta:
            DajMiBrzeAute(auto);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Poziv metodi Koja vraća samo BMW brze aute:
            DajMiBMWAute(auto);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Poziv Metodi LinqNaArrayList:
            LINQNaArrayList();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Poziv metodi OfTypeKaoFilter:
            OfTypeKaoFilter();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region STUDENT IMPLEMENTACIJA

            StudentiMetoda();

            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region DajMiBrzeAute Metoda

        static void DajMiBrzeAute(List<Auto> mojiAuti)
        {
            // Pronađi sve aute u List<Auto> gdje je brzina veća od 150:
            var brziAuti = from a in mojiAuti
                       where a.Brzina > 169
                       orderby a.Ime
                       select a;

            foreach(var auto in brziAuti)
            {
                Console.WriteLine("Brzi Auti su: {0,-10} | Model: {1,-8} | Brzina: {2} ", auto.Ime, auto.Model, auto.Brzina);
            }

        }

        #endregion

        #region DajMiBMWAute Metoda

        static void DajMiBMWAute(List<Auto> mojiAuti)
        {
            var brziAuti = from a in mojiAuti
                           where a.Ime == "BMW" && a.Brzina > 200
                           select a;

            foreach(var auto in brziAuti)
            {
                Console.WriteLine("BMW najbži Auti su: {0}. | Model: {1}. | Brzina: {2}.", auto.Ime, auto.Model, auto.Brzina );
            }

        }

        #endregion

        #region LinqNaArrayList Metoda

        static void LINQNaArrayList()
        {
            Console.WriteLine("-> Linq Na ArrayList:");
            Console.WriteLine();

            ArrayList mojiAuti = new ArrayList()
            {
                new Auto { Ime = "BMW",      Model = "525",     Brzina = 250, Boja = "Crna"      },
                new Auto { Ime = "Opel",     Model = "Vectra",  Brzina = 130, Boja = "Crvena"    },
                new Auto { Ime = "Mercedes", Model = "SL 500",  Brzina = 230, Boja = "Zelena"    },
                new Auto { Ime = "Audi",     Model = "A 6",     Brzina = 210, Boja = "Siva"      },
                new Auto { Ime = "Citroen",  Model = "Xara",    Brzina = 120, Boja = "Bijela"    },
                new Auto { Ime = "Glof",     Model = "6 TDI",   Brzina = 165, Boja = "Žuta"      },
                new Auto { Ime = "Opel",     Model = "Astra",   Brzina = 140, Boja = "Zelena"    },
                new Auto { Ime = "Mercedes", Model = "C 200",   Brzina = 190, Boja = "Crna"      },
                new Auto { Ime = "Audi",     Model = "A 3",     Brzina = 110, Boja = "Crvena"    },
                new Auto { Ime = "Citroen",  Model = "BX 14",   Brzina = 145, Boja = "Plava"     },
                new Auto { Ime = "Glof",     Model = "6 GTI",   Brzina = 170, Boja = "Ljubičasta"},
                new Auto { Ime = "BMW",      Model = "635",     Brzina = 280, Boja = "Siva"      },
                new Auto { Ime = "BMW",      Model = "730",     Brzina = 260, Boja = "Crvena"    },
                new Auto { Ime = "BMW",      Model = "325",     Brzina = 210, Boja = "Žuta"      },
            };

            // Tako da možemo raditi i sa ne generičnim kolekcijama uz pomoć produžene metode Enumerable.OfType<T>
            // Sa ovom metodom možemo pretovori ne genirčnu listu u IEnumerable kompatibilan tip!

            // Ova linija koda trasformira ArraList u IEnumerable<T> - kompatibilan tip:
            var mojiAutiEnum = mojiAuti.OfType<Auto>();

            // Kreiraj upit-query na osnovu izraza odredišnog kompatibilnog tipa:
            var brziAuti = from a in mojiAutiEnum
                           where a.Brzina > 170
                           select a;

            foreach(var auto in brziAuti)
            {
                Console.WriteLine("{0} ide jako jako brzo!", auto.Ime);
            }
        }

        #endregion

        #region OfType<T> Kao Filter!

        static void OfTypeKaoFilter()
        {
            // Pomoću Oftype() metode možemo iz Kolekcije poput ArrayList izvaditi specifične tipove koje želimo,
            // ukoliko se nađemo u takvoj situaciji...

            // izvadi integere iz ArrayList-e:
            ArrayList aList = new ArrayList();

            // Pomoću metode AddRange() dodaj novu matricu objeka:
            aList.AddRange(new object[] { 10, 40, 400, 8, false, new Auto(), "string podatak" });

            // Napravi OfType filter:
            var mojInt = aList.OfType<int>();

            foreach(int stavka in mojInt)
            {
                Console.WriteLine("U ArrayList su pronađeni ovi itegeri: {0}.", stavka);
            }

        }

        #endregion

        #region STUDENT METODA

        static void StudentiMetoda()
        {
            Console.WriteLine("-> Lista Studenti:");
            Console.WriteLine();

            // Kreiranje Liste studenata na osnovu klase Student:
            List<Student> studenti = new List<Student>
            {
                new Student { ID = 101, Ime = "Aydin",     Prezime = "Rose",         Rezultat = new List<int> {97,91,83,86}},
                new Student { ID = 102, Ime = "Merlna",    Prezime = "G.Ahmagić",    Rezultat = new List<int> {91,92,85,86}},
                new Student { ID = 103, Ime = "Edina",     Prezime = "Mehmedalić",   Rezultat = new List<int> {90,92,85,71}},
                new Student { ID = 104, Ime = "Edin",      Prezime = "Džafić",       Rezultat = new List<int> {97,98,93,86}},
                new Student { ID = 105, Ime = "Džemal",    Prezime = "Alibegović",   Rezultat = new List<int> {81,71,73,76}},
                new Student { ID = 106, Ime = "Jusuf",     Prezime = "Džafić",       Rezultat = new List<int> {86,72,93,78}},
                new Student { ID = 107, Ime = "Anto",      Prezime = "Kopić",        Rezultat = new List<int> {69,69,73,79}},
                new Student { ID = 108, Ime = "Radoslav",  Prezime = "Vukić",        Rezultat = new List<int> {89,67,81,88}},
                new Student { ID = 109, Ime = "Pero",      Prezime = "Marković",     Rezultat = new List<int> {78,91,63,86}},
                new Student { ID = 110, Ime = "Blaženko",  Prezime = "Živković",     Rezultat = new List<int> {79,73,71,81}},
                new Student { ID = 111, Ime = "Bedir",     Prezime = "Rapi",         Rezultat = new List<int> {94,58,62,68}},
                new Student { ID = 112, Ime = "Filip",     Prezime = "Galović",      Rezultat = new List<int> {67,91,52,76}},
            };

            // Strongly Typed upit za studente koji imaju ocjene veće od 90 itd...
            IEnumerable<Student> studentUpit = from s in studenti   // Ovdje kaže: svi oni na indexu 0 koji imaju rezultat veći od 90 i na indexu 3 manji od 90... upit možemo posatiti na mnogo načina
                                             where s.Rezultat[0] > 90 && s.Rezultat[3] < 90  // && s.Rezultat[2] > 90 && s.Rezultat[3] > 80 ... Oni na prvom idrugom indexu su ovaluriani... 
                                             orderby s.Rezultat[0] descending // Ovdje kažemo po redu od 100 pa nadalje poredaj rezulatate na indexu 0.
                                             select s;

            // Iteracija:
            foreach(Student student in studentUpit)
            {
                  Console.WriteLine("Ime: {0,-9} | Prezime: {1,-14} | ID: {2,-3} | Rezultat: {3} | {4} | {5} | {6} | ", student.Ime, student.Prezime, student.ID, student.Rezultat[0], student.Rezultat[1], student.Rezultat[2], student.Rezultat[3]);
            }

            Console.WriteLine("-> Grupiranje Studenata U Grupe sa Prezimenima: ");
            Console.WriteLine();

            // Sada implicitni upit na List<Student> sa LINQ sintaktičnim izrazom "group". Koji nam dozvoljava da grupiramo studente u grupe:
            var studentUpit2 = from s in studenti
                               group s by s.Prezime[0];
                               

            foreach(var grupaStudenata in studentUpit2)
            {
                Console.WriteLine(grupaStudenata.Key);
                foreach(Student student in grupaStudenata)
                {
                    Console.WriteLine("     {0} | {1}", student.Ime, student.Prezime);
                }
            }

            Console.WriteLine();
            Console.WriteLine("-> A-Ž Alfabetički posloženi Studenti:");
            Console.WriteLine();

            // Gornji uit je dobar ali kada ga pogledamo vidjet ćemo da u njemu studenti nisu poredani A-Ž!
            // Koristimo se novim sintaktičnim LINQ izrazom "into"!
            // Evo upita koji će to ispraviti:
            var studentUpit3 = from s in studenti
                               group s by s.Prezime[0] into studentGrupa
                               orderby studentGrupa.Key
                               select studentGrupa;

            // Iteracija:
            foreach(var grupaStudenta in studentUpit3)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("Pod: {0}", grupaStudenta.Key);
                
                foreach(Student student in grupaStudenta)
                {
                    Console.WriteLine("     {0,-8} | {1}", student.Ime, student.Prezime);
                   
                }
            }

            Console.WriteLine();
            Console.WriteLine("-> Studenti Koji imaju prvi test rezultat veći od prosječnog rezultata:");
            Console.WriteLine();

            // Upit za studente koji imaju prvi test rezultat veći od prosječnog rezultata, a možemo napraviti uvođenjem novog
            // LINQ sintaktičkog izraza "let":

            var studentUpit4 = from s in studenti
                               let totalRezultat = s.Rezultat[0] + s.Rezultat[1] +
                               s.Rezultat[2] + s.Rezultat[3]
                               where totalRezultat / 4 > s.Rezultat[0]
                               select s;

            foreach(var student in studentUpit4)
            {
                Console.WriteLine("Ime: {0,-9} | Prezime: {1,-14} | ID: {2,-3} | Rezultat: {3} | {4} | {5} | {6} | ", student.Ime, student.Prezime, student.ID, student.Rezultat[0], student.Rezultat[1], student.Rezultat[2], student.Rezultat[3]);
            }

            Console.WriteLine();
            Console.WriteLine("-> Razredni prosjek ocjena:");
            Console.WriteLine();


            // Upit konstruiran tako da napravi projek razreda tako što zbraja sve ocjene:
            var studentUpit5 = from s in studenti
                               let totalRezultat = s.Rezultat[0] + s.Rezultat[1] +
                               s.Rezultat[2] + s.Rezultat[3]
                               select totalRezultat;

            // Ovdje putem proširene metode Average() možemo dobiti prosjek tog dobivenog zbroja ocjena: 
            double razredniProsjek = studentUpit5.Average();

            // Ispis prosjeka na konzolu:
            Console.WriteLine("Razredni Prosjek je: {0}.", razredniProsjek);

            Console.WriteLine();
            Console.WriteLine("-> Studenti sa Ocjenama većim od Prosjeka Razreda:");
            Console.WriteLine();

            var studentUpit6 = from s in studenti
                               let x = s.Rezultat[0] + s.Rezultat[1] + s.Rezultat[2] + s.Rezultat[3]
                               where x > razredniProsjek
                               select new { Ime = s.Ime, ID = s.ID, Rezultat = x }; // Korištenje anonimnih metoda ovdje na djelu!

            foreach(var student in studentUpit6)
            {
                Console.WriteLine("| Ime: {0,-8} | ID: {1,-3} | Rezultat: {2} |", student.Ime, student.ID, student.Rezultat);
            }




        }

     
        #endregion


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
