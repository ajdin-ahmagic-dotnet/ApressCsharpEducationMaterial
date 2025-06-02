using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_03_Generic
{
    class Person
    {
        // Može se primjetiti da ovdje koristim opcionalni ? operator da ispitam da je 
        // tip nullable, te da bi ga u konstruktoru ove vrijednosne tipove mogao postaviti na 
        // null vrijednost.
        public string Ime { get; set; }
        public int? Starost { get; set; }
        public decimal? Placa { get; set; }

        /// <summary>
        /// Glavni Konstruktor.
        /// </summary>
        public Person(string ime, int starost, decimal placa)
        {
            Ime = ime;
            Starost = starost;
            Placa = placa;
        }

        /// <summary>
        /// Osnovni Konstruktor.
        /// </summary>
        public Person()
        {
            Ime = null;
            Starost = null;
            Placa = null;
        }

        // Override ToString() Metoda:
        public override string ToString()
        {
            return string.Format("|{0,-13:} | {1,-2:} | {2:C2} |", Ime, Starost, Placa);
        }
    }
}
