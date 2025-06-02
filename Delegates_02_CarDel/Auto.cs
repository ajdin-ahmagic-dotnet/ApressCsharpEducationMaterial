using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_02_CarDel
{
    class Auto
    {
        // Interni podatci o stanju vozila "Osobine":
        public int TrenutnaBrzina { get; set; }
        public int MaximalnaBrzina { get; set; }
        public string ImeAuta { get; set; }

        // Da li je vozilo u voznom stanju:
        private bool pregrijan;

        // Klasni konstruktori:
        public Auto(string imeAuta, int maxBrzina, int trenBrzina)
        {
            ImeAuta = imeAuta;
            MaximalnaBrzina = maxBrzina;
            TrenutnaBrzina = trenBrzina;
        }

        public Auto()
        {
            MaximalnaBrzina = 100;
        }

        // 1) Definiranje tipa delegata:
        public delegate void AutoMotorHandler(string porZaPozivaca);

        // 2) Definiranje članske varijable za ovaj delegat:
        private AutoMotorHandler listaHandlera;

        // 3) Dodaj registracijsku funkciju pozivaocu:
        // Pošto Delegati podražavaju "multicast" što znači da delegat može podravati listu poziva metoda
        // a ne samo jednu iako je moguće, kada želimo da to bude učinjeno koristimo overloadirani += operator.
        public void RegistrirajSaAutoMotorom(AutoMotorHandler metodaZaPozvati)
        {
            // Prvi primjer poziv jednoj metodi:
            // listaHandlera = metodaZaPozvati;

            // ZA PRVI PRIMJER KORISTITI : listaHandlera += metodaZaPozvati

            // Drugi primjer multicasting ZA PRIMJER 1:
            //listaHandlera += metodaZaPozvati;
            // Kada to radimo sa += operatorom delgat poziva Delegate.Combine() Metodu koju možemo ovdje i direktno pozvati:
            // Pa Primjer 2:
            if(listaHandlera == null)
               listaHandlera = metodaZaPozvati;
            else
               Delegate.Combine(listaHandlera, metodaZaPozvati);

            // Sada možemo registrirati više odredišta za jedan poziv.
        }

        // Dodajmo Auto Klasi novu metodu koja omogućuje pozivatelju da ukloni metodu sa pozivačke liste:
        public void OdRegistrirajSaAutoMotorom(AutoMotorHandler metodaZaPozvati)
        {
            listaHandlera -= metodaZaPozvati;
        }



        // Može se primjetiti da sam ovdje direktno u klasi napravio delegat što ne mora biti
        // ali pomaže ideji da delegat radi naturalno sa ovom klasom. Ovaj naš delegat može uzeti
        // bilo koju metodu koja uzima jedan string kao ulaz i ima void kao tip vraćanja...

        // 4) Implementiramo Ubrzanje() Metodu kao i prije da bi pozvala delgatnu pozivnu listu
        // ali samo u odgovarajućim okolnostima:
        public void Ubrzanje(int ubrzaj)
        {
            // Ako je motor pregrijan, pošalji poruku da je "mrtav"...
            if(pregrijan)
            {
                if(listaHandlera != null)
                listaHandlera("Oprostite, Auto je Pregrijan i trenutno mrtav!");
            }
            else
            {
                TrenutnaBrzina += ubrzaj;

                // Da li je auto još malo pa prregrijan?
                if(10 == (MaximalnaBrzina - TrenutnaBrzina) && listaHandlera != null)
                {
                    listaHandlera("Pažljivo, još malo pa će se pregrijati!");
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
