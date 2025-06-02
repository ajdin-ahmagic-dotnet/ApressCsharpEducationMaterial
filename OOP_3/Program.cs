using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region PRIMJER -"has-a" tj. "ima" klasne oop tehnike
            Console.WriteLine("=> PRIMJER OOP 'HAS-A' TEHNIKE U KLASAMA:");
            Console.WriteLine();

            // Inicijalizacija objekta Auto i poziv objekta
            // Radio kroz objekt Auto indirektnim putem.
            Auto bmw = new Auto("BMW 734d");
            bmw.UkljuciRadio(false);

            Console.WriteLine("Ime Auto je: {0}.", bmw.Ime);


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();


            #endregion
        }
    }
}
