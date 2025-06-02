using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Motor
    {
        public int intenzitetVozaca;
        public string imeVozaca;


        #region KONSTRUKTORI


        /// <summary>
        /// Osnovni Konstruktor.
        /// </summary>
        /// <param name=""></param>
        public Motor()
        {
            // Nije implementiran, namjerno...   
            Console.WriteLine("U osnovnom Konstruktoru.");
        }

        /// <summary>
        /// Konstruktor koji uzima samo intenzitet Vozaca.
        /// </summary>
        /// <param name="intenzitet"></param>
        public Motor(int intenzitet)
            : this(intenzitet, "")
        {
            Console.WriteLine("Konstruktor koji uzima koji int 'intenzitetVozaca'.");
            intenzitetVozaca = intenzitet;
        }

        /// <summary>
        /// Kostruktor Koji uzima samo string ime.
        /// </summary>
        /// <param name="ime"></param>
        public Motor(string ime)
            : this(0, ime)
        {
            Console.WriteLine("Konstruktor koji uzima string 'ime'.");
            imeVozaca = ime;
        }

        ///// <summary>
        ///// OVO JE PRAVI KONTRUKTOR KOJI RADI PRAVI POSAO!
        ///// </summary>
        ///// <param name="intenzitet"></param>
        //public Motor(int intenzitet, string ime)
        //{
        //    Console.WriteLine("U GLAVNOM KONTRUKTORU.");
        //    if(intenzitet > 10)
        //    {
        //        intenzitet = 10;
        //    }
        //    intenzitetVozaca = intenzitet;
        //    imeVozaca = ime;
        //}

        
        /// <summary>
        /// u .NET-u 4.0 pa nadalje možemo koristi opcionalne argumente u konstruktoru
        /// tj. isroristiti tu opciju ako nam je pogorna...
        /// Pa pošto sada imamo ovakav konstruktor sa opcionalnim argumentima, možemo
        /// inicijalizirati objekt tj. klasu Motor malo drugačije, pogledaj Program.cs 
        /// Primjer Klase 6 - Motor Klasa
        /// </summary>
        /// <param name="intenzitet"></param>
        /// <param name="ime"></param>
        public Motor(int intenzitet = 0, string ime = "")
        {
            Console.WriteLine("U GLAVNOM KONTRUKTORU 2.");
            if(intenzitet > 10)
            {
                intenzitet = 10;
            }
            intenzitetVozaca = intenzitet;
            imeVozaca = ime;
        }

        #endregion


        public void Vozi()
        {
            for(int i = 0; i <= intenzitetVozaca; i++)
            {
                Console.WriteLine("Start! Krenuo sam...");
            }
        }

        public void PostaviImeVozaca(string ime)
        {
            // ime varijable string "ime" isto je kao i ime prosljeđene string varijable "ime" u metodi
            // ako ne bi stavili ključnu riječ "this". To možemo riješiti ako promjenimo ime polja string "ime"
            // u recimo imeVozaca...
            this.imeVozaca = ime;
            // je isto što i:
            imeVozaca = ime;
        }



    }
}
