using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_03_Auto_Klasa
{
    class AutoEventArgs : EventArgs
    {
        public readonly string por;
        /// <summary>
        /// Glavni Konstruktor.
        /// </summary>
        /// <param name="poruka"></param>
        public AutoEventArgs(string poruka)
        {
            por = poruka;
        }

        // Nema Osnovnog konstruktora!
    }
}
