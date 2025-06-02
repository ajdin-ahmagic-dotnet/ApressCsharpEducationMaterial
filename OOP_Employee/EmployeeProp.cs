using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class EmployeeProp
    {
         // Polja.
        private string empName;
        private int empID;
        private float currPay;

        // Novo public polje i property.
        private int empAge;


        public int Age
        {
            get
            {
                return empAge;
            }
            set
            {
                empAge = value;
            }
        }
        // GET i SET Metode su zamjenjene sa
        // C# osobinama eng. "properies"
        public string Name
        {
            get { return empName; }
            set
            {
                if(value.Length > 15)
                {
                    Console.WriteLine("Greška!  Ime mora biti manje od 16 slova!");
                }
                else
                    empName = value;

            }
        }

        // Mi možemo dodati još puno poslovnih restrikcija za EmployeeProp klasu
        // ali za sada to nije potrebno.
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        // 'float' tip mora biti istog tipa koje je polje koje enkapsulira.
        // te mora sadržavati deklarativno ime tog polja "currPay".
        public float Pay   // Primjetite nedostatak zagrada, za razliku od metoda...
        {
            get
            { return currPay; }
            set
            { currPay = value; }
        }


        // Kontruktori. 
        public EmployeeProp() { } // Default-Osnovni konstruktor.


        // Ažuriran konstruktor u odnosu na novo polje i property "empAge".
        public EmployeeProp(string name, int id, float pay)
            : this(name,id,0,pay)
        { }


        /// <summary>
        /// Initializes a new instance of the EmployeeProp class.
        /// Ažurirani konstruktor u odnosu na novo polje"empAge".
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="pay"></param>
        public EmployeeProp(string name, int id, int age, float pay)
        {
            #region Važno je znati...

            // Pošto konstruktor uzima dolazeće parametre, provjerava da li su podatci ispravni
            // i pravi dodjele privatnim poljima, on trenutno ne provjerava da li je ime duže od 
            // 15 slova tako da i njega možemo ažurirati da provjeri...
            // Ali to je samo u slučaju kada radimo sa metodama! Kada koristimo properties
            // ne moramo praviti ovaj dupli check u konstruktoru!
            //if(name.Length > 9)    // S obzirom da ovje smanjujemo sa 16 na 10 slova!
            //{
            //    Console.WriteLine("Greška!  Ime mora biti manje od 10 slova!");
            //}
            //else
            //{
            //    empName = name;
            //}

            #endregion

            #region Stari način u konstruktoru...

            // Sada kada koristimo properties ovaj dio postaje drugačiji i veže se na osobine.
            //empName = name;
            //empID = id;
            //empAge = age;
            //currPay = pay;
            #endregion

            // Pozivanje na osobine:
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;

        }


        // Metode.
        public void GiveBonus(float amount)
        {
            Pay += amount;
        }

        // Ažurirana metoda u odnosu na novo polje"empAge".
        public void DisplayStatus()
        {
            Console.WriteLine("|Ime: {0,8:}|", empName);
            Console.WriteLine("|ID: {0,9:}|", empID);
            Console.WriteLine("|Starost: {0,4:}|", empAge);
            Console.WriteLine("|Plaća: {0,6:}|", currPay);
        }
    }
}
