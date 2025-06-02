using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_01
{
    class Auto
    {
        // Ako bolje primjetimo vijedćemo da ova klasa koristi enkapsulaciju
        // kako bi neka polja ostavila vidjljiva samo ovoj klasi.
        // npr: private int trenBrzina.

        // Polja- Fields
        public readonly int maksBrzina;
        private int trenBrzina;

        // Konstruktor.
        public Auto(int maks)
        {
            maksBrzina = maks;
        }

        // Osnovni konstruktor.
        public Auto()
        {
            maksBrzina = 235;
        }

        // Osobine - Properties
        public int Brzina
        {
            get
            {
                return trenBrzina;
            }
            set
            {
                trenBrzina = value;
                if(trenBrzina > maksBrzina)
                {
                    trenBrzina = maksBrzina;
                }
            }
        }
    }
}
