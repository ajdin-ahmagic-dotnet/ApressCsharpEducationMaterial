using System;
using System.Collections.Generic;
using System.Linq;

namespace Indexers_01_Simple
{
    /// <summary>
    /// Napravljena klasa u svhu primjera kako bi napravili kolekciju ove klase tj. Peron objekta
    /// ali kao ne generičnu kolekciju i kako bi to izgledalo. U biti želim pokazati neučinkovitost
    /// ne generičnih kolekcija za pravljenje kolekcija određenog tipa.
    /// </summary>
    public class Person
    {
        // Osobine...
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Konstruktori...
        public Person(string firstName, string lastName, int age)
        {
           
            FirstName = firstName;
            LastName = lastName; 
            Age = age;
        }
        
        public Person()
        {
           
        }

        // Override Metode
        public override string ToString()
        {
            return string.Format("| Ime: {0,-7:} {1,-13:} | Starost: {2} |", FirstName, LastName, Age);
        }
    }
}
