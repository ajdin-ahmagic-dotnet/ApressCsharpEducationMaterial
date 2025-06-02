using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class Employee
    {
        // Polja.
        private string empName;
        private int empID;
        private float currPay;

        // Naknadno dodano polje.
        private int empAge;

        public int GetAge()
        {
            return empAge;
        }

        public void SetAge(int age)
        {
            empAge = age;
        }

        // recimo u Javi je normalno da se postave set i get metode
        // i ovo je demostracija ekvivalenta u C#-pu.
        // Accessor Get Metoda.
        public string GetName()
        {
            return empName;
        }

        // Mutator Set Metoda.
        public void SetName(string name)
        {
            // Provjeri dolazeću vrijednost
            // prije donošenja odluke.
            if(name.Length > 15)
            {
                Console.WriteLine("Greška!  Ime mora biti manje od 16 slova!");
            }
            else
            {
                empName = name;
            }
        }



        // Kontruktori.
        public Employee() { }

        /// <summary>
        /// Initializes a new instance of the Employee class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="pay"></param>
        public Employee(string name, int id, int age, float pay)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }


        // Metode.
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStatus()
        {
            Console.WriteLine("|Ime: {0,8:}|", empName);
            Console.WriteLine("|ID: {0,9:}|", empID);
            Console.WriteLine("|Starost: {0,4:}|", empAge);
            Console.WriteLine("|Plaća: {0,6:}|", currPay);
        }
    }
}
