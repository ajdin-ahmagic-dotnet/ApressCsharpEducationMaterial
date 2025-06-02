using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_02
{
    /// <summary>
    /// ABSTRAKTNA BAZNA KLASA NA VRHU HIERARHIJE.
    /// </summary>
    abstract class Shape
    {
        // Osobine.
        public string Name { get; set; }

        // Konstruktor.
        public Shape(string name = "Bez Imena")
        {
            Name = name;
        }

        // Virtualna metoda.
        public virtual void Draw()
        {
            Console.WriteLine("Unutar Shape.Draw()");
        }

        // Abstrakte metode. One nemaju implementaciju.
        // tjeraju sve derivirane klase da definiraju svoju verziju 
        // metode, te mogu biti definirane samo u abstraktnim klasama.
        // Abstraktne metode samo definiraju tjelo, ime, return tip ako 
        // ga uopće ima, i set parametara ako su potrebni, i kažu ja 
        // postojim ako hoćeš da deriviraš od mene ti skontaj detalje...
        public abstract void DrawAbstract();

    }
}
