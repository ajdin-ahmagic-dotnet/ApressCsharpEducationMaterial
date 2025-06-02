using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Delegates2
{

    // Kalsa za iračun totalnog projeka svih knjiga.
    class CijeneTotal
    {
        int brojKnjiga = 0;
        decimal cijeneKnjiga = 0;

        internal void DodajKnjigeTotalu(Knjige knjiga)
        {
            brojKnjiga += 1;
            cijeneKnjiga += knjiga.Cijena;
        }

        internal decimal ProjecnaCijena()
        {
            return cijeneKnjiga / brojKnjiga;
        }
    }


    class TestKnjigeDB
    {
        static void IsprintajNaslov(Knjige k)
        {
            Console.WriteLine("     {0}", k.Naslov);
        }

        static void Main()
        {
           
            KnjigaDB knjiga = new KnjigaDB();

            // Inicijaliziraj našu bazu sa nešto knjiga...
            DodajKnjige(knjiga);

            // Kreiraj novi delegat objekt asociran sa statičkom metodom IsprintajNaslov():
            knjiga.ProcesMekiUvezKnjige(IsprintajNaslov);

            // Daj nam proječnu cijenu mekog uveza koristeći Cijenetotal() klasu.
            CijeneTotal totalno = new CijeneTotal();

            // Kreiraj novi delegat objekt asociran sa nestatičkom 
            // metodom DodajKnjigetotalu() u totalno klasi:
            knjiga.ProcesMekiUvezKnjige(totalno.DodajKnjigeTotalu);

            Console.WriteLine("Proječna knjiga mekog uveza košta: ${0:#.##}", totalno.ProjecnaCijena());

            Console.ReadKey();
        }

        // Inicijaliziraj bazu podataka za knjige i napuni je s knjigama:
        static void DodajKnjige(KnjigaDB knjiga)
        {
            knjiga.DodajKnjige("C# Programski Jezik", "Aydin Rose", 29.99m, true);
            knjiga.DodajKnjige("Java za početnike", "tihomir Magdić", 31.69m, true);
            knjiga.DodajKnjige("C++ Napredno programiranje", "Dennis M. ritchie", 19.99m, true);
            knjiga.DodajKnjige("C# Napredno", "Aydin Rose", 35.99m, false);
            knjiga.DodajKnjige("Java Napredno", "tihomir Magdić", 38.99m, false);
            
        }
    }
    
  

}



