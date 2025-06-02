using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        #region Metode za Delegat 1 Poziv


        delegate void MojDelegat(int vrijednost); // Deklariramo delegat kao TIP!

        static void IspisiVisokuVrij(int vrijednost)
        {
            Console.WriteLine("Visoka Vrijednost! {0}.", vrijednost);
        }

        static void IspisiNiskuVrij(int vrijednost)
        {
            Console.WriteLine("Niska Vrijednost! {0}.", vrijednost);
        }

        static void IspisiNajVisuVrij(int vrijednost)
        {
            Console.WriteLine("Jako Visoka Vrijednost! {0}.", vrijednost);
        }

        static void IspisiNajNizuVrij(int vrijednost)
        {
            Console.WriteLine("Jako niska vrijednost! {0}.", vrijednost);
        }


        #endregion// Metode za Delegat 1 Poziv

        static void Main(string[] args)
        {
            // Poziv prvoj delagat Metodi.
            DelegatPoziv1();

            Console.ReadKey();
        }

        #region DELEGAT 1 POZIVNA METODA

        static void DelegatPoziv1()
        {
            MojDelegat delegat;     // Deklariramo delegat varijablu.

            #region Originalni primjer

            // U originalnom primjeru rađeno je random-number generator.
            /// <summary>
            /// Random rand = new Random();
            /// int randVrijednost = rand.Next(99);
            /// 
            /// 
            /// Originalni primjer kasnije navodi:
            /// delegat = randVrijednost < 50 
            ///                 ? new MojDelegat(IspisiVise)
            ///                 : new MojDelegat(IspisiNize)
            /// </summary>

            #endregion

            // Kreiramo upit za korisnika:
            Console.Write("Molim vas unesite jedan broj od 0 do 100: ");
            int odgovor = int.Parse(Console.ReadLine());

            //delegat = odgovor < 50
            //    ? new MojDelegat(IspišiNize)
            //    : new MojDelegat(IspišiVise);

            if(odgovor > 80)
            {
                delegat = new MojDelegat(IspisiNajVisuVrij);
                delegat(odgovor);
            }
            if(odgovor > 50 && odgovor < 80)
            {
                delegat = new MojDelegat(IspisiVisokuVrij);
                delegat(odgovor);
            }
            if(odgovor < 50 && odgovor > 20)
            {
                delegat = new MojDelegat(IspisiNiskuVrij);
                delegat(odgovor);
            }
            if(odgovor < 20)
            {
                delegat = new MojDelegat(IspisiNajNizuVrij);
                delegat(odgovor);
            }
            else
            {
                Console.WriteLine("Niste odabrali niti jenu od opcija!");
            }
            
            // Ovdje u ovom slučaju kad delegat nije radio trebalo je samo izvršenje delegata
            // prebaciti u svaki od if narebi.
            //delegat(odgovor); // Izvrši delegat!
        }

        #endregion
    }
}
