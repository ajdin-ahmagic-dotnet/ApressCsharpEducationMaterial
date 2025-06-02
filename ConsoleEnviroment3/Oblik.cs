using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnviroment3
{
    public class Oblik
    {
        public string infoString;

        public Oblik(string info)
        {
            infoString = info;
        }
    }

    // Sada pretpostavimo da želimo zadržimo varijablu od klasnog tipa u vrijednosni tip Pravokutnik.
    // Da bi dozvolili pozivaču da postavi vrijednost u unutrašnju Oblik varijablu, mi moramo isto tako
    // dati konstruktor. Evo potpune definicije Pravokutnik tipa.

    public struct Pravokutnik
    {
        // Pravokutnik struktura sadrži član referencnog tipa.
        public Oblik pravInfo;

        public int pravGore, pravLijevo, pravDole, pravDesno;

        public Pravokutnik(string info, int gore, int lijevo, int dole, int desno)
        {
            pravInfo = new Oblik(info);
            pravGore = gore; 
            pravDole = dole;
            pravLijevo = lijevo; 
            pravDesno = desno;
        }

        public void Prikazi()
        {
            Console.WriteLine("String = {0}, Gore = {1}, Dole = {2}, Lijevo = {3}, Desno = {4}", pravInfo.infoString, pravGore, pravDole, pravLijevo, pravDesno);
        }
    }
}
