using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class Auto
    {
        // Redefinirana klasa auto sa auto-implenetiranim osobinama!
        public string Ime { get; set; }
        public string Brzina { get; set; }
        public string Boja { get; set; }
       
        // Osnovni Konstruktor.
        public Auto() { }

        // U ovom Konstruktoru brzina će dobiti osnovnu
        // vrijednost od nula.
        public Auto(string ime)
        {
            Ime = ime;
        }

        // Sada proširujemo Konstruktore, ovo je puni konstruktor!
        public Auto(string ime, string brzina, string boja)
        {
            Ime = ime;
            Brzina = brzina;
            Boja = boja;
        }

        // Metode Klase Auto. "Funkcionalnosti" klase Auto.
        public void IspisiStanje()
        {
            Console.WriteLine("|'{0,-12}'|", Ime);
            Console.WriteLine("|'{0,-12}'|", Brzina);
            Console.WriteLine("|'{0,-8}'|", Boja);
        }

        // Metoda koja ubrzava Auto.
        public void Ubrzanje(int ubrzanje)
        {
            Brzina += ubrzanje;
        }

        // Ova funkcionalnost je za liste daje listi prikaz svih auta...
        public override string ToString()
        {
            return String.Format("|{0,-8:} | {1,10:} | {2,10:}|", Ime, Brzina, Boja);
        }

    }
}
