using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Coll_List
{
    class GenListProg
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║            --- DOBRODOŠLI U GENERIČNE KOLEKCIJE: LIST KOLEKCIJA ---            ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);


            Console.Write("ŽELITE LI LOADIRATI GENERIČNU LISTU - List<T> DA/NE:");
            string odgL = Console.ReadLine();
            if(odgL.ToLower() == "da")
            {
                UseGenericList();
            }
            else
            {
                Console.WriteLine("Nastvaljamo sa Programom...");
            }


            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion


             Console.Write("ŽELITE LI LOADIRATI GENERIČNU LISTU - Stack<T> DA/NE:");
            string odgS = Console.ReadLine();
            if(odgS.ToLower() == "da")
            {
                UseGenericStack();
            }
            else
            {
                Console.WriteLine("Nastvaljamo sa Programom...");
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.Write("ŽELITE LI LOADIRATI GENERIČNU LISTU - Queue<T> DA/NE:");
            string odgQ = Console.ReadLine();
            if(odgQ.ToLower() == "da")
            {
                UseGenericQueue();
            }
            else
            {
                Console.WriteLine("Nastvaljamo sa Programom...");
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.Write("ŽELITE LI LOADIRATI GENERIČNU LISTU - SortedSet<T> DA/NE:");
            string odgSet = Console.ReadLine();
            if(odgSet.ToLower() == "da")
            {
                UseGenericSortedSet();
            }
            else
            {
                Console.WriteLine("Nastvaljamo sa Programom...");
            }

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        static void UseGenericList()
        {
            Console.WriteLine("=> RAD SA GENERIČNOM LISTOM: LIST<T>");
            // Napravi Listu Employee Objekata, sa collection/object
            // incijalizacijskom sintaksom.
            List<Employee> emp = new List<Employee>()
            {
                new Employee{ ID = 1, Name = "Aydin Rose",        Age = 30, Pay = 4500m},
                new Employee{ ID = 2, Name = "Marlena G.Ahmagić", Age = 37, Pay = 6500m},
                new Employee{ ID = 4, Name = "Edina Mehemdalić",  Age = 54, Pay = 4200m},
                new Employee{ ID = 5, Name = "Tahir Mehmedalić",  Age = 68, Pay = 3400m},
                new Employee{ ID = 6, Name = "Edin Džafić",       Age = 47, Pay = 11800m},
                new Employee{ ID = 7, Name = "Jusuf Džafić",      Age = 86, Pay = 2500m},
            };

            // Ispiši na konzolu broj stvaki u listi:
            Console.WriteLine("Stavki u listi: {0}.", emp.Count);

            // Enumeriraj kroz listu:
            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }


            // Ubaci novog zaposlenika u listu:
            // OVO JE PRVI PUT DA SM USPIO DINAMIČNO DA UBACIM ZAPOSLENIKA U LIST BUFFER.
            Console.Write("-> Ubacujem novog zaposlenika ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("-> Ime: ");
            string name = Console.ReadLine();

            Console.Write("-> Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("-> Pay: ");
            decimal pay = Convert.ToDecimal(Console.ReadLine());

            emp.Add(new Employee { ID = id, Name = name, Age = age, Pay = pay });
            Console.WriteLine("Stavki u listi: {0}", emp.Count);

            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
            Console.WriteLine();

            // Insert funkcionira vro slično add metodi:
            Console.WriteLine("=> Pravimo insert na poziciju 3 gdje fali jedan zaposlenik:");
            emp.Insert(2, new Employee { ID = 3, Name = "Filip Galović", Age = 17, Pay = 1800m });
            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Stavki u listi: {0}.", emp.Count);

            Console.WriteLine();
            Console.WriteLine();

            // Kopiraj podatke u novu array:
            Employee[] arrayOfEmployees = emp.ToArray();
            for(int i = 0; i < arrayOfEmployees.Length; i++)
            {
                Console.WriteLine("Names: {0}.", arrayOfEmployees[i].Name);
            }

        }

        static void UseGenericStack()
        {
            Console.WriteLine("=> RAD SA GENERIČNOM LISTOM: STACK<T>");
            Stack<Employee> emp = new Stack<Employee>();
            emp.Push(new Employee { ID = 10, Name = "Dževida Alibegović", Age = 85, Pay = 1500m});
            emp.Push(new Employee { ID = 11, Name = "Dženana Alibegović", Age = 88, Pay = 1500m});
            emp.Push(new Employee { ID = 12, Name = "Fadila Alibegović", Age = 81, Pay = 1500m});
            emp.Push(new Employee { ID = 13, Name = "Fuad Alibegović", Age = 79, Pay = 1500m});
            emp.Push(new Employee { ID = 14, Name = "Dževad Alibegović", Age = 87, Pay = 1500m});
            emp.Push(new Employee { ID = 15, Name = "Džemal Alibegović", Age = 83, Pay = 1500m});

            Console.WriteLine("Prvi zaposlenik je: {0}.", emp.Peek());
            Console.WriteLine("Iskočio je: {0}.", emp.Pop());

            Console.WriteLine("\nPrvi Zaposlenik je: {0}", emp.Peek());
            Console.WriteLine("Iskočio je: {0}.", emp.Pop());

            Console.WriteLine("\nPrvi Zaposlenik je: {0}", emp.Peek());
            Console.WriteLine("Iskočio je: {0}.", emp.Pop());

            Console.WriteLine("\nPrvi Zaposlenik je: {0}", emp.Peek());
            Console.WriteLine("Iskočio je: {0}.", emp.Pop());

            Console.WriteLine("\nPrvi Zaposlenik je: {0}", emp.Peek());
            Console.WriteLine("Iskočio je: {0}.", emp.Pop());

            Console.WriteLine("\nPrvi Zaposlenik je: {0}", emp.Peek());
            Console.WriteLine("Iskočio je: {0}.", emp.Pop());


            try
            {
                Console.WriteLine("\nPrvi Zaposlenik je: {0}", emp.Peek());
                Console.WriteLine("Iskočio je: {0}.", emp.Pop());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("\nGreška! {0}", ex.Message);
            }
        }

        #region USE Queue<T>

        static void GetCoffee(Employee e)
        {
            Console.WriteLine("{0} ima kafu!", e.Name);
        }

        static void UseGenericQueue()
        {
            // Napravi Q sa troje ljudi:
            // Za Queue, da bi dodali vriejdnost koristimo Enqueue(), da pozovemo član Peek(), a da izbrišemo Dequeue().
            Queue<Employee> peopleQ = new Queue<Employee>();
            peopleQ.Enqueue(new Employee { ID = 20, Name = "Aydin Rose", Age = 30, Pay = 4500m });
            peopleQ.Enqueue(new Employee { ID = 21, Name = "Edin Rose", Age = 47, Pay = 9700m });
            peopleQ.Enqueue(new Employee { ID = 22, Name = "Edina Rose", Age = 55, Pay = 5200m });

            // Peak-Proviri na prvog zaposelnika u Q:
            Console.WriteLine("{0} je Prvi u Redu!", peopleQ.Peek().Name);

            // Izbriši svaku osobu iz Q-ua. Korištenje metode za Q. ImaKafu...
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());
            GetCoffee(peopleQ.Dequeue());

            // Probaj Dequeue još jednom:
            try
            {
                GetCoffee(peopleQ.Dequeue());
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("Greška! {0}.", ex.Message);
            }

        }

        #endregion

        static void UseGenericSortedSet()
        {
            // Napravi listu zaposlenika sa različitim godinama rođenja:
            SortedSet<Employee> setOfEmp = new SortedSet<Employee>(new SortEmployeesByAge())
            {
                new Employee{ ID = 1, Name = "Aydin Rose",        Age = 30, Pay = 4500m},
                new Employee{ ID = 2, Name = "Marlena G.Ahmagić", Age = 37, Pay = 6500m},
                new Employee{ ID = 4, Name = "Edina Mehemdalić",  Age = 54, Pay = 4200m},
                new Employee{ ID = 5, Name = "Tahir Mehmedalić",  Age = 68, Pay = 3400m},
            };

            // Primjeti da su svi posloženi po godinama!
            foreach(Employee e in setOfEmp)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();

            Console.WriteLine("-> Dodana još dva zaposlenika:");
            // Dodaj još malo zaposlenika sa varijablnim godinama:
            setOfEmp.Add(new Employee { ID = 6, Name = "Axl Rose", Age = 55, Pay = 9500m });
            setOfEmp.Add(new Employee { ID = 7, Name = "Slash Hudson", Age = 43, Pay = 3500m });

            // I dalje su soritirani po godinama!
            foreach(Employee e in setOfEmp)
            {
                Console.WriteLine(e);
            }


        }


        


        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
