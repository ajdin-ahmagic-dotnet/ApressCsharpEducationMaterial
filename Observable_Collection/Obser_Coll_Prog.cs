using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace Observable_Collection
{
    class Obser_Coll_Prog
    {
        public enum NotifyCollectionChangedAction
        {
            Add = 0,
            Remove = 1,
            Replace = 2,
            Move = 3,
            Reset = 4,
        }

        /// <summary>
        /// PRIMJER RADA SA OBSERVABLE Collection KOLEKCIJOM KOJU SMO INTENZIVNO KORISTILI KAD SMO RADILI
        /// SA ENTITY FRAMEWORKOM! JER SMO MJENJALI TU LISTU DA BI MOGLI SPREMITI PROMJENE NA PODATCIMA...
        /// SADA ĆEMO MALO PROSTUDIRATI SAMU KOLEKCIJU I NJENA SVOJSTVA I KORIŠTENJA...
        /// NAPOMENA: ZA RAD NAM JE POTREBAN USING SYSTE.COLLECTIONS.OBJECTMODEL.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║         --- DOBRODOŠLI U GENERIČNE KOLEKCIJE: OBSERVABLE KOLEKCIJA ---         ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Napravi kolekciju da je možemo "obeserve" promatrati, te dodaj nekoliko zaposlenika:
            ObservableCollection<Employee> emp = new ObservableCollection<Employee>()
            {
                new Employee{ ID = 0, Name = "Aydin Rose",        Age = 30, Pay = 4500m},
                new Employee{ ID = 1, Name = "Marlena G.Ahmagić", Age = 37, Pay = 6500m},
                new Employee{ ID = 2, Name = "Edina Mehemdalić",  Age = 54, Pay = 4200m},
                new Employee{ ID = 3, Name = "Tahir Mehmedalić",  Age = 68, Pay = 3400m},
            };

            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Zaljepi event handler CollectionChanged za kolekciju:
            emp.CollectionChanged += emp_CollectionChanged;

            emp.Add(new Employee { ID = 4, Name = "Fahmo Delagić", Age = 62, Pay = 5400m });

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Brisanje iz kolekcije:
            emp.RemoveAt(2);
            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Zamjena replace iz kolekcije:
            emp[1] = new Employee { ID = 1, Name = "Bakir Izetbegović", Age = 99, Pay = 2400m };
            foreach(Employee e in emp)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        // Primjena Event handlera:
        private static void emp_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            // Koja je to Akcija koja je aktivirala događaj-event?
            Console.WriteLine("Akcije za ovaj događaj-event: {0}.", e.Action);

            // Netko je nešto izbrisao-remove:
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("Ovdje su STARE stvake: ");
                foreach(Employee em in e.OldItems)
                {
                    Console.WriteLine(em.ToString());
                }
                Console.WriteLine();
            }

            // Netko je dodao nešto-add:
            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                // Sada pokaži nove stavke koje su ubačene:
                Console.WriteLine("Ovdje su NOVE stavke: ");
                foreach(Employee em in e.NewItems)
                {
                    Console.WriteLine(em.ToString());
                }
            }

            if(e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
            {
                // Prikaži zamjenjene stvake:
                Console.WriteLine("Ovdje su ZAMJENJENE stavke:");
                foreach(Employee em in e.OldItems)
                {
                    Console.WriteLine(em.ToString());
                }
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
