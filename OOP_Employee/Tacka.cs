using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    // Enuneracija za Tacka klasu.
    public enum BojaIspisa
    {
        SvijetloPlava,
        KrvavoCrvena,
        Zlatna
    }

    class Tacka
    {
        // Auto-implementirane osobine.
        public int X { get; set; }
        public int Y { get; set; }
        public BojaIspisa Boja {get; set;}

        // Konstruktor.
        public Tacka(int xVal, int yVal)
        {
            X = xVal;
            Y = yVal;
            Boja = BojaIspisa.KrvavoCrvena;
        }

        // Kostruktor za boju.
        public Tacka(BojaIspisa biBoja)
        {
            Boja = biBoja;
        }

        // Osnovni Konstruktor.
        public Tacka()
            :this(BojaIspisa.Zlatna)
        {
            //Console.WriteLine("U osnovnom konstruktoru...");
        }



        // Metoda koja prikazuje rezultate...
        public void PrikaziPodatke()
        {
            Console.WriteLine("[{0}, {1}]", X, Y);
            Console.WriteLine("Tačka je: {0}", Boja);
        }
    }
}
