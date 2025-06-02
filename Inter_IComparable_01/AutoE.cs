using System;
using System.Collections;
using System.Linq;

namespace Inter_IComparable_01
{
    /// <summary>
    /// IZMJENJENA AUTO KLASA ZA ICOMPARABLE INTERFACE!
    /// </summary>
    class AutoE : IComparable
    {
        // Konstanta definira maksimalnu brzinu auta.
        public const int MaksBrzina = 180;

        // Osobine - Properies.
        public int TrenutnaBrzina { get; set; }
        public string ImeAuta { get; set; }
        public int  ID { get; set; }

        // Da je li auto i dalje u voznom stanju'
        public bool AutoJeMrtvo;

        // Auto ima radio.
       //  private Radio muzika = new Radio();

        // Konstruktori.
        public AutoE() { }

        public AutoE(string imeAuta, int trenutnaBrzina, int id)
        {
            ImeAuta = imeAuta;
            TrenutnaBrzina = trenutnaBrzina;
            ID = id;
        }

        // Metoda za paljenje radia.
        //public void RadioOnOf(bool stanje)
        //{
        //    // Kao deleganti zahtjev prema unutrašnjem objektu.
        //    muzika.DaLiJeUpaljen(stanje);
        //}

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
                    Exception ex = new Exception(string.Format("{0} je Pregrijan!", ImeAuta));
                    ex.HelpLink = "http://www.weebly.purnet.com";

                    // Dodano za Data Propert primjer:
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


        #region IComparable Members

        int IComparable.CompareTo(object obj)
        {
            // IMPLEMENTACIJA IComparable INTERFACE-A:
            AutoE temp = obj as AutoE;
            if(temp != null)
            {
                // Ovo je strandardna stara implementacija:
                //if(this.ID > temp.ID)
                //    return 1;
                //if(this.ID < temp.ID)
                //    return -1;
                //else
                //    return 0;

                // Nova lakša implemenatcija je:
                return this.ID.CompareTo(temp.ID);
            }
            else
                throw new ArgumentException("Parametar nije Auto!");
        }

        #endregion
    }
}
