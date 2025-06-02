using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee_Simulation
{
    // Primjer nasljeđivanja klasa.
    // SalesPerson mora znati njihov broj prodaje...
    class SalesPerson : EmployeeProp
    {
        // Osobine- Properties.
        public int SalesNumber { get; set; }

        // Konstuktori...
        public SalesPerson()
        {
            
        }
        public SalesPerson(string name, int id, float pay, string ssn)
            : base(name, id, pay, ssn)
        {
            
        }
        // Glavni konstruktor, nasljeđuje sve potrebno iz bazne klase tako da 
        // se ovdje u njegovo tjelo stavlja samo ono specifično za ovu klasu.
        public SalesPerson(string name, int id, int age, float pay, string ssn, int numbOfSales)
            : base(name, id, age, pay, ssn)
        {
            SalesNumber = numbOfSales;
        }
       


        // Overridirana metoda iz  bazne klase.
        // Kao prodavač bonus za njega je pod utjecajem broja prodane robe...
        // Kako možemo zapečatiti cijelu klasu sa ključnom riječi "sealed"
        // isto tako možemo zapečatiti i metodu za koji smatramo da više ne
        // treba biti prepravljana... pa tako iz toga sljedi zapećaćena 
        // override metoda koja dalje neće moći biti prepravljena.
        public override sealed void GiveBonus(float amount)
        {
            // Izračun bonusa na osnovu prodanih artikala.
            int salesBonus = 0;
            if(salesBonus >= 0 && SalesNumber <= 100)
            {
                salesBonus = 10;
            }
            else
            {
                if(SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            // Bonus je dan recimo 6000kn + 121 artikl što spada u bonus 15 
            // pa 6000 * 15 = 90000kn + recimo plaća je 20000kn pa je onda 90000 + 20000 = 110000kn
            base.GiveBonus(amount * salesBonus);
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Broj Prodaje je: {0} ", SalesNumber);
        }
    }
}
