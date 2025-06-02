using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Inter_IClonable
{
    /// <summary>
    /// Klasa Tacka. Sa dodanom TackaOpis dodanom referencom.
    /// </summary>
    class Tacka : ICloneable
    {
        // Osobine - Properties.
        public int X { get; set; }
        public int Y { get; set; }

        // DODANA TACKA OPIS KLASA:
        public TackaOpis opis = new TackaOpis();


        // Konstruktori...
        public Tacka(int x, int y, string ime)
        {
            X = x;
            Y = y;
            opis.Ime = ime;
        }
        public Tacka(){ }


        // Ovrride Obejct.String Metode:
        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; IME: {2};\nID: {3};", X, Y, opis.Ime, opis.TackaID);
        }

        // Vrati kopiju trenutnog objekta:


        #region ICloneable Members

        public object Clone()
        {
            //return new Tacka(this.X, this.Y);
            // Možemo se izraziti i ovako, tako da kloniramo Tačkin član po član:
            //return this.MemberwiseClone();

            // Dalji primjeri koji uključuju TačkaOpis isključuju gore navedene,
            // pa su zato komentirani...
            // prvo napravimo "shalow copy"...
            Tacka novaTacka = (Tacka)this.MemberwiseClone();

            // Onda popunimo praznine:
            TackaOpis trenOpis = new TackaOpis();
            trenOpis.Ime = this.opis.Ime;
            novaTacka.opis = trenOpis;
            return novaTacka;
        }

        #endregion
    }
}
