using System;
using System.Collections.Generic;
using System.Linq;

namespace BazneKlase
{
    public class Programer : Zaposlenik
    {
        /// <summary>
        /// Initializes a new instance of the Programer class.
        /// </summary>
        public Programer(string imePrezime, string imeOca, int oIB, int starost, string tipZaposlenika, decimal placa, decimal bonus, DateTime radiOd, double radnoVrijeme)
            : base(imePrezime, imeOca, oIB, starost, tipZaposlenika, placa, bonus, radiOd, radnoVrijeme)
        {
            
        }
        public Programer()
        {
            
        }

        public override void Izracun_Radnog_Vremena(double bonus)
        {
            base.Izracun_Radnog_Vremena(bonus);
        }


        public override string ToString()
        {
            return String.Format("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", ImePrezime, ImeOca, OIB, Starost, TipZaposlenika, Placa, RadiOd, RadnoVrijeme);
        }
    }
}
