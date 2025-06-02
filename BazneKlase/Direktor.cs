using System;
using System.Collections.Generic;
using System.Linq;

namespace BazneKlase
{
    public class Direktor : Zaposlenik
    {
        /// <summary>
        /// Initializes a new instance of the Direktor class.
        /// </summary>
        public Direktor(string imePrezime, string imeOca, int oIB, int starost, string tipZaposlenika, decimal placa, decimal bonus, DateTime radiOd, double radnoVrijeme)
            : base(imePrezime, imeOca, oIB, starost, tipZaposlenika, placa, bonus, radiOd, radnoVrijeme)
        {
            
        }
        public Direktor()
        {
            
        }      

      

      

    }
}
