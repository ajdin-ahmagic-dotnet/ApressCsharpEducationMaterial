using System;
using System.Collections.Generic;
using System.Linq;

namespace Exending_Interface
{
    static class IntefaceEkstenzija
    {
        public static void Ispisi_Podatke_I_Bipni(this System.Collections.IEnumerable iterator)
        {
            foreach(var stavka in iterator)
            {
                Console.WriteLine(stavka);
                Console.Beep();
            }
        }
    }
}
