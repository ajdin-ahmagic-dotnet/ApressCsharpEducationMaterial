using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Auto
    {
        // Polja klase Auto. "Stanja" klase Auto.
        public string Ime; 
        public int Brzina;
       
        // Dodavanje Konstruktora Auto lasi, bez parametara.
        public Auto()
        {
            Ime = "BMW 325";
            Brzina = 30;
        }

        // U ovom Konstruktoru brzina će dobiti osnovnu
        // vrijednost od nula.
        public Auto(string ime)
        {
            Ime = ime;
        }

        // Sada proširujemo Konstruktore, ovo je puni konstruktor!
        public Auto(string ime, int brzina)
        {
            Ime = ime;
            Brzina = brzina;
        }

        // Metode Klase Auto. "Funkcionalnosti" klase Auto.
        public void IspisiStanje()
        {
            Console.WriteLine("|'{0}' ide: {1} KM/h|", Ime, Brzina);
        }

        // Metoda koja ubrzava Auto.
        public void Ubrzanje(int ubrzanje)
        {
            Brzina += ubrzanje;
        }

    }
}
