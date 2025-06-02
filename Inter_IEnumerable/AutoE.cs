using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_IEnumerable
{
    /// <summary>
    /// IZMJENJENA AUTO KLASA SA DODANIM EXCEPTION HANDLINGOM...
    /// </summary>
    class AutoE
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
        public AutoE() { }

        public AutoE(string imeAuta, int trenutnaBrzina)
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
                   
                    TrenutnaBrzina = 0;
                    AutoJeMrtvo = true;

                    // DODAJEMO "throw" KLJUČNU RIJEČ I BACAMO EXCEPTION! 
                    // Kada želimo da kompajler izbaci ovakvu grešku i izađe iz izvršavanja programa 
                    // koristimo ključnu riječ "throw"!

                    // U svrhu donjeg primjera ovaj smo dio zakomentirali...
                    // throw new Exception(string.Format("{0} je Pregrijan!", ImeAuta));

                    // HelpLink property od System.Exception je jako korisna jer možemo time korisniku
                    // dati url na web stranicu da pogleda problem ili eventualno riješenje.
                    // Da bi iskoristili tu osobinu prvo moramo napraviti varijablu koja će držati objekt.
                    //AutoJeMrtvoGreska ex = new AutoJeMrtvoGreska(string.Format("{0} je Pregrijan!", ImeAuta), "Vozili ste predugo sa pregrijanim autom!", DateTime.Now);
                    //ex.HelpLink = "http://www.weebly.purnet.com";

                    Exception ex = new Exception(string.Format("{0} je Pregrijan!", ImeAuta));
                    ex.HelpLink = "http://www.weebly.purnet.com";
                    ex.Data.Add("Vremenska Markica", string.Format("Autu je explodirao hladnjak u: {0}.", DateTime.Now));
                    ex.Data.Add("Uzrok:", "Prebrzo ste išli dugo vremena!");
                    throw ex;
                }
                else
                {
                    Console.WriteLine("=> TrnutnaBrzina = {0}.", TrenutnaBrzina);
                }
            }
        }

    }
}
