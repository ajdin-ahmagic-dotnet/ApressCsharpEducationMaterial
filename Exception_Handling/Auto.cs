using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Proces_Multiple
{
    /// <summary>
    /// KLASA BEZ BILO KAKVOG EXCEPTION HENDLINGA...
    /// </summary>
    class Auto
    {
       // Konstanta definira maksimalnu brzinu auta.
        public const int MaksBrzina = 180;
        
        // Osobine - Properies.
        public int TrenutnaBrzina { get; set; }
        public string ImeAuta { get; set; }

        // Da je li auto i dalje u voznom stanju'
        public bool AutoJeMrtvo;

        // Auto ima radio.
        private Radio muzika = new Radio();

        // Konstruktori.
        public Auto() { }

        public Auto(string imeAuta,int trenutnaBrzina)
        {
            ImeAuta = imeAuta;
            TrenutnaBrzina = trenutnaBrzina;
        }

        // Metoda za paljenje radia.
        public void RadioOnOf(bool stanje)
        {
            // Kao deleganti zahtjev prema unutrašnjem objektu.
            muzika.DaLiJeUpaljen(stanje);
        }

        // Pogledaj da li se auto pregrijao?
        public void Ubrzanje(int ubrzanje)
        {
            if(AutoJeMrtvo)
            {
                Console.WriteLine("{0} je pregrijan i nije u voznom stanju.", ImeAuta);
            }
            else
            {
                TrenutnaBrzina += ubrzanje;
                if(TrenutnaBrzina > MaksBrzina)
                {
                    Console.WriteLine("Maksimalna brizna Auta je 180 km/h!");
                    Console.WriteLine("Hladnjak ne može podnjeti pritisak!");
                    Console.WriteLine("{0} je pregrijan!", ImeAuta);
                    TrenutnaBrzina = 0;
                    AutoJeMrtvo = true;
                }
                else
                {
                    Console.WriteLine("=> TrnutnaBrzina = {0}.", TrenutnaBrzina);
                }
            }
        }

    }
}
