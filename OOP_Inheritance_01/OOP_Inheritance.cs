using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_01
{
    class OOP_Inheritance
    {
        static void Main(string[] args)
        {
            #region PRIMJER - OSNOVNE BAZNE KLASE
            Console.WriteLine("=> PRIMJER - OSNOVNA BAZNA KLASA: ");
            Console.WriteLine();

            #region Objašnjenje

            // Inicijaliziramo klasu Auto.
            // Ovje postavljam ako nije bez argumenta i ne poziva osnovni konstruktor
            // koji zadaje maks brzinu od 235km/h ja kažem ovjde da je maks 180!
            // ako kasnije pozovem veću brzinu u osobini od 180, neće je prihvatiti!
            // maksimalna brzina u ovom slučaju je zadana i ona je 180!

            #endregion
            Auto mojAuto = new Auto(180); 
            
            // Postavljamo trenutnu brzinu i ispisujemo je.
            mojAuto.Brzina = 130;
            Console.WriteLine("Moj auto ide brzinom od: {0} km/h. Maximalna brzina je: {1} km/h", mojAuto.Brzina, mojAuto.maksBrzina);

            #endregion// PRIMJER - OSNOVNE BAZNE KLASE

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - OSNOVNE BAZNE KLASE 2
            Console.WriteLine("=> PRIMJER - OSNOVNA BAZNA KLASA: ");
            Console.WriteLine();

            Kombi mojKombi = new Kombi(80);

            mojKombi.Brzina = 69;
            Console.WriteLine("Moj Kombi trenutno ide: {0} km/h. Maximalna brzina je: {1} km/h", mojKombi.Brzina, mojKombi.maksBrzina);

            #endregion// PRIMJER - OSNOVNE BAZNE KLASE 2

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion



            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }
    }
}
