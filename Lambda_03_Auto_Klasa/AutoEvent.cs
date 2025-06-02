using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_03_Auto_Klasa
{
    class AutoEvent 
    {
        // Interni podatci o stanju vozila "Osobine":
        public int TrenutnaBrzina { get; set; }
        public int MaximalnaBrzina { get; set; }
        public string ImeAuta { get; set; }

        // Da li je vozilo u voznom stanju:
        private bool pregrijan;

        // Klasni konstruktori:
        public AutoEvent(string imeAuta, int maxBrzina, int trenBrzina)
        {
            ImeAuta = imeAuta;
            MaximalnaBrzina = maxBrzina;
            TrenutnaBrzina = trenBrzina;
        }

        public AutoEvent()
        {
            MaximalnaBrzina = 100;
        }

        // 1) Definiranje tipa delegata:
        // Primarni primjer:
        //public delegate void AutoMotorHandler(string porZaPozivaca);

       

        // Sada radimo sa EVENTIMA - događaji.
        // Ovo su događaji za ovaj auto, te se u ovoj klasi
        // potpuno odričemo delgata kojeg više nema idemo direktno preko
        // AutoEventArgs klase.
        public event EventHandler<AutoEventArgs> Prokuhao;
        public event EventHandler<AutoEventArgs> SamoStoNijeProkuhao;





        // 4) Implementiramo Ubrzanje() Metodu kao i prije da bi pozvala delgatnu pozivnu listu
        // ali samo u odgovarajućim okolnostima:
        public void Ubrzanje(int ubrzaj)
        {
            // Ako je motor pregrijan, pošalji poruku da je "mrtav"...
            if(pregrijan)
            {
                if(Prokuhao != null) // I ovdje je došlo do prijena: uvedena je ključna riječ this, i new AutoEventArgs("pa onda poruka");
                    Prokuhao(this, new AutoEventArgs("Oprostite, Auto je Pregrijan i trenutno mrtav!"));
            }
            else
            {
                TrenutnaBrzina += ubrzaj;

                // Da li je auto još malo pa prregrijan?
                if(20 == (MaximalnaBrzina - TrenutnaBrzina) && SamoStoNijeProkuhao != null)
                {
                    SamoStoNijeProkuhao(this, new AutoEventArgs("Pažljivo, još malo pa će se pregrijati!"));
                }
                if(TrenutnaBrzina >= MaximalnaBrzina)
                    pregrijan = true;
                else
                    Console.WriteLine("Trenutna Brzina = {0}", TrenutnaBrzina);

            }
        }

        /// <summary>
        /// Delagat Klasa isto tako definira Metodu Remove() koja omogućava pozivatelju da dinamički ukloni
        /// metodu sa invokacijske delegatne liste. Ovo omogućuje pozivatelju da napravi tzv. "unsubscribe" na
        /// delegat u danom vremenu. Iako mi možemo pozvati Delegeate.Remove() motodu kao takvu direktno u kodu
        /// C# programeri mogu koristiti skraćenicu -= operator, kao zgodnu skraćeničnu notaciju. 
        /// </summary>



    }
}
