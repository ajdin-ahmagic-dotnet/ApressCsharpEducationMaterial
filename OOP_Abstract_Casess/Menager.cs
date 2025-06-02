using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_02
{
    // Primjer nasljeđivanja klasa:
    // Manager mora znati sve o njihovim dionačarskim opcijama
    class Menager : EmployeeAbstract
    { 
        // Osobine - Properties
        public int StockOptions { get; set; }


        // Konstruktori...
        public Menager()
        {
            
        }
        public Menager(string name, int id, float pay, string ssn)
            : base(name, id, pay, ssn)
        {
            
        }
        // U ovaj konstruktor koji nasljeđuje od bazne klase sve potreno treba dodati
        // osobinu Menager klase:
        public Menager(string name, int id, int age, float pay, string ssn, int numbOfpts)
            : base(name, id, age, pay, ssn)
        {
            // Specifično samo za ovu klasu...
            StockOptions = numbOfpts;
        }     

        // Overide metoda za Manager klasu.
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StockOptions += r.Next(500); 
           
        }

        public override void DisplayStatus()
        {
            base.DisplayStatus();
            Console.WriteLine("Broj Dioničarskih Opcija: {0}.", StockOptions);
        }
    }
}
