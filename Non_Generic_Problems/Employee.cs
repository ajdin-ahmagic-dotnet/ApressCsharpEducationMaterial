using System;
using System.Collections.Generic;
using System.Linq;

namespace Non_Generic_Problems
{
    class Employee
    {
        // Osobine...
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Pay { get; set; }


        // Konstruktori...
        public Employee(int iD, string name, int age, decimal pay)
        {
            ID = iD;
            Name = name;
            Age = age;
            Pay = pay;
        }

        public Employee()
        {

        }

        // Override Metode...
        public override string ToString()
        {
            return string.Format("| ID: {0} | Ime: {1,-17:} | Starost: {2} | Plaća: {3,-12:C2} |", ID, Name, Age, Pay);
        }

    }
}
