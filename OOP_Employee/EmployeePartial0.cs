using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
  partial class EmployeePartial
    {
        // RAD SA PARCIJALNIM KLASAMA...

        // U OVOJ DJELU KLASE SU SAMO OSOBINE I METODE:

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
