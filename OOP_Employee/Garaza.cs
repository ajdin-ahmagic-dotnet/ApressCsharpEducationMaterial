using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class Garaza
    {
        // U klasičnom primjeru ovo je rađeno bez LIST<> kolekcije.
        // Ali sam ja uradio primjer sa kolekcijom list zbog mogućnosti dodavanja
        // više instanci od jednom...
        public int BrojAuta { get; set; }
        public List<Auto> MojAuto { get; set; }
     
        // Moramo koristiti konstruktore da overridiramo osnovne vrijednosti
        // u osobinama koje su nula.
        public Garaza()
        {
            MojAuto = new List<Auto>();
            BrojAuta = 1;
        }

        public Garaza(int broj, List<Auto> auto)
        {
            BrojAuta = broj;
            MojAuto = auto;
        }

     
    }
}
