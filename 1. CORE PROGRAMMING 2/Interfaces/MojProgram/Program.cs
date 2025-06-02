using System;
using System.Collections.Generic;
using System.Linq;
using MojaBiblioteka;
using System.Drawing;

namespace MojProgram
{
    internal class Program
    {
        public static void Main()
        {

            #region Inerfejsi

            // pravimo kolekciju interfejsa sa klasama auta....
            IAuto[] auti =
                {
                    new BMW(),
                    new Audi{Color = Color.Azure}, // daljnje osobine ne možemo kostiti jer nismo im dali seter...
                    
                };

            // jedino što nismo implementirali boju auta a možemo to ovako...kroz inedex, ali 
            // pošto je to stari način pristpua možemo to direktrno u inicializaciji kolekcije napraviti sa svim osobinama...
            auti[0].Color = Color.Black; // nulti auto je bmw...jer je na nultom indexu...



            // prolazimo koru petlju i ispisujemo vrijednosti metoda i osobina...
            foreach (IAuto auto in auti)
            {
                IpisiInfoAuta(auto);
                auto.Kreni();
                auto.PritisniGas(20.0);
                auto.PritisniGas(30.0);
                auto.PritisniKocnicu(10.0);
                auto.PritisniGas(40.0);

            }

            #endregion


            #region DELIMITER
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion


            // Sada koristimo base klase...
            BazaAuto[] clsAuti =
                {
                    new Mercedes(),
                    new Golf(),
                };

            foreach (BazaAuto auto in clsAuti)
            {
                IpisiInfoAuta(auto);
                auto.Kreni();
                auto.PritisniGas(10.0);
                auto.PritisniGas(20.0);
                auto.PritisniGas(50.0);
                auto.PritisniKocnicu(30.0);
                auto.PritisniGas(10.0);
            }


            Console.ReadKey();
        }
        // Metoda sa osnovim karakteristikama auta...za baznu klasu
        private static void IpisiInfoAuta(BazaAuto auto)
        {
            Console.WriteLine("Ovo je {0} {1} {2} {3}", auto.Color.Name, auto.GodProizvodnje, auto.Napravi, auto.Model);
        }
        // Metoda sa osnovim karakteristikama auta...za interfejs
        static void IpisiInfoAuta(IAuto auto)
        {
            Console.WriteLine("Ovo je {0} {1} {2} {3}", auto.Color.Name, auto.GodProizvodnje, auto.Napravi, auto.Model);
        }
    }
}
