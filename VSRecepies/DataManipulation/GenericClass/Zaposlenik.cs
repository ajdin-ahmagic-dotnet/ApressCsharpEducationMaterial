using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    public class Zaposlenik
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public int Godine { get; set; }
        public string OIB { get; set; }
        public string Adresa { get; set; }

        public decimal Placa { get; set; }


        /// <summary>
        /// Initializes a new instance of the Zaposlenik class.
        /// </summary>
        /// <param name="ime"></param>
        /// <param name="prezime"></param>
        /// <param name="godine"></param>
        /// <param name="oIB"></param>
        /// <param name="adresa"></param>
        /// <param name="grad"></param>
        /// <param name="zupanija"></param>
        /// <param name="email"></param>
        /// <param name="placa"></param>
        public Zaposlenik(string ime, string prezime, int godine, string oIB, string adresa, decimal placa)
        {
            Ime = ime;
            Prezime = prezime;
            Godine = godine;
            OIB = oIB;
            Adresa = adresa;
            Placa = placa;
        }
     
        public Zaposlenik()
        {
            
        }
        public override string ToString()
        {
            return String.Format("| {0,-8} | {1,-8} | {2,-3} | {3,-14} | {4,-20} | {5,-4} |", Ime, Prezime, Godine, OIB, Adresa, Placa);
        }

    }
}
