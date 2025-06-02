using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LinqIzrazi
{
    class ProduktInfo : IEnumerable
    {
        public string Ime { get; set; }
        public string Opis { get; set; }
        public int BrojNaLagaeru { get; set; }

        public override string ToString()
        {
            return string.Format("| Ime: {0,-20} | Opis: {1,-18} | Broj Na Lageru: {2,-2} |", Ime, Opis, BrojNaLagaeru);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
