using System;
using System.Collections.Generic;
using System.Linq;

namespace BazneKlase
{
    public class Zaposlenik
    {
        private decimal bonus;
        private decimal placa;

        // Properties - Osobine:
        public string ImePrezime { get; set; }
        public string ImeOca { get; set; }
        public int OIB { get; set; }
        public int Starost { get; set; }
        public string TipZaposlenika { get; set; }
        public decimal Placa 
        { 
            get
            {
                return placa;
            }
            set
            {
                placa = value;
            }
        }
        public decimal Bonus 
        { 
            get
            {
                return bonus;
            }
            set
            {
                bonus = value;
            }
        }

        public DateTime RadiOd { get; set; }
        public double RadnoVrijeme { get; set; }
         
           
        

        /// <summary>
        /// Initializes a new instance of the Zaposlenik class.
        /// </summary>
        public Zaposlenik(string imePrezime, string imeOca, int oIB, int starost, string tipZaposlenika, decimal placa, decimal bonus, DateTime radiOd, double radnoVrijeme)
        {
            ImePrezime = imePrezime;
            ImeOca = imeOca;
            OIB = oIB;
            Starost = starost;
            TipZaposlenika = tipZaposlenika;
            Placa = placa;
            Bonus = bonus;
            RadiOd = radiOd;
            RadnoVrijeme = radnoVrijeme;
        }
    

        // Osnovni Konstruktor:
        public Zaposlenik() { }

        public virtual void Izracun_Radnog_Vremena(double bonus)
        {
            
            if(RadnoVrijeme > 40.0)
            {
                const double b = 20;
                bonus = b;
                Console.WriteLine("Zaposlenik je ostavrio bonus od: {0:C2}.", bonus);
            }

        }

        public decimal Zarada()
        {
            return placa + bonus;
        }


        // String ToString Override metoda:
        public override string ToString()
        {
            return String.Format("| {0} | {1} | {2} | {3} | {4} | {5} | {6} | {7} |", ImePrezime, ImeOca, OIB, Starost, TipZaposlenika, Placa, RadiOd, RadnoVrijeme);
        }
    }
}
