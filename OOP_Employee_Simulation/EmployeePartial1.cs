using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee_Simulation
{
   partial class EmployeePartial
    {
       // RAD SA PARCIJALNIM KLASAMA...

       // U OVOM DJELU KLASE SU POLJA I KONSTRUKTORI: 


        // Polja.
        private string empName;
        private int empID;
        private float currPay;

        // Novo public polje i property.
        private int empAge;

          // Kontruktori. 
        public EmployeePartial() { } // Default-Osnovni konstruktor.


        // Ažuriran konstruktor u odnosu na novo polje i property "empAge".
        public EmployeePartial(string name, int id, float pay)
            : this(name,id,0,pay)
        { }


        /// <summary>
        /// Initializes a new instance of the EmployeeProp class.
        /// Ažurirani konstruktor u odnosu na novo polje"empAge".
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="pay"></param>
        public EmployeePartial(string name, int id, int age, float pay)
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
    }
}
