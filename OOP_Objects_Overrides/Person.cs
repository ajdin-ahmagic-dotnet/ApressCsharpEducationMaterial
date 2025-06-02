using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objects_Overrides
{
    /// <summary>
    /// Da malo začinimo stvari dodat ćemo klasi dodatnu funkcionalnost.
    /// </summary>
    class Person
    {
        // Osobine - Properties.
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Starost { get; set; }
        public string JMBG { get; set; }


        // Konstruktori...
        /// <summary>
        /// Inicijalizira novu instancu ove klase...
        /// </summary>
        public Person(string ime, string prezime, int starost)
        {
            Ime = ime;
            Prezime = prezime;
            Starost = starost;
        }
        public Person()
        {
              
        }


        // Overridiranje string ToString() metode.
        public override string ToString()
        {
            return string.Format("|Ime: {0,-5:} | Prezime: {1,-7:} | Starost: {2,2:}|", Ime, Prezime, Starost);
        }

        // Nastavak Overridiranje Equals() metode.
        public override bool Equals(object obj)
        {
            // Sve ovo bi morali da radimo da nije ToStrin() metode, pomoću koje ćemo dole skratiti sav ovaj kod...
            //Person temp;
            //temp = (Person)obj;

            //if(temp.Ime == this.Ime && temp.Prezime == this.Prezime && temp.Starost == this.Starost)
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            //return false;

            return obj.ToString() == this.ToString();
        }

        // Overide GetHashCode() Metode.
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
