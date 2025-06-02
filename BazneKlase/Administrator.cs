using System;
using System.Collections.Generic;
using System.Linq;

namespace BazneKlase
{
    public class Administrator : Zaposlenik
    {
        /// <summary>
        /// Initializes a new instance of the Administrator class.
        /// </summary>
        public Administrator(string imePrezime, string imeOca, int oIb, int starost, string tipZaposlenika, decimal placa, decimal bonus, DateTime radiOd, double radnoVrijeme)
            : base(imePrezime, imeOca, oIb, starost, tipZaposlenika, placa, bonus, radiOd, radnoVrijeme)
        {
            
        }
        public Administrator()
        {
            
        }

        public override string ToString()
        {
            //return String.Format("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", ImePrezime, ImeOca, OIB, Starost, TipZaposlenika, Placa, RadiOd, RadnoVrijeme);
            return $"| {ImePrezime} | {ImeOca} | {OIB} | {Starost} | {TipZaposlenika} | {Placa} | {RadiOd} | {RadnoVrijeme} |";
        }
    }
}
