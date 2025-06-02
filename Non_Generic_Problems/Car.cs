using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic_Problems
{
    class Car
    {
        // Osobine...
        public string Name { get; set; }
        public string Model { get; set; }
        public int Age { get; set; }
        public string KMH { get; set; }

        // Konstruktori...
        public Car(string name, string model, int age, string kmh)
        {
            Name = name;
            Model = model;
            Age = age;
            KMH = kmh;
        }

        public Car()
        {

        }

        // Override Metode...
        public override string ToString()
        {
            return string.Format("| Ime: {0,-6:} | Model: {1,-5:} | Godište: {2} | Km/h: {3} |", Name, Model, Age, KMH);
        }
    }
}
