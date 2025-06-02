using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Program
    {
        static void Main()
        {
            #region KLASE PRIMJER 1
            Console.WriteLine("=> KLASE PRIMJERI");

            // Alociranje i konfiguracije "Auto" objekta.
            Auto a1 = new Auto();
            a1.Ime = "BMW 525i";
            a1.Brzina = 230;

           

            // Ubrzja Auto nekoliko puta i ispiši novo stanje...
            for(int i = 0; i <= 10; i++)
            {
                a1.Ubrzanje(5);
                a1.IspisiStanje();
            }
            #endregion// KLASE PRIMJER 1

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region KLASE PRIMJER 2
            Console.WriteLine("=> KLASE PRIMJER 2 DODAN KONSTRUKTOR KLASI AUTO:");
            Console.WriteLine();

            Auto a2 = new Auto();
            a2.IspisiStanje();
            
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region KLASE PRIMJER 3
            Console.WriteLine("KLASE PRIMJER 3, VIŠE KONSTRUKTORA:");
            Console.WriteLine();

            // Pošto sada imamo velik raspon konstruktora, možemo
            // Inicijalizirati objekt Auto na više načina:
            Auto a3 = new Auto();   // Sa osnovim konstruktorom koji ima ime i brzinu određenu...
            a3.IspisiStanje();

            Console.WriteLine();
           
            Auto a4 = new Auto("BMW M3");   // poziva Konstruktor koji uzima ime i piše nulu za brzinu ali mi ovdje postavljamo brzinu...
            //a4.Brzina = 290;
            a4.IspisiStanje();

            Console.WriteLine();

            Auto a5 = new Auto("BMW M5", 330);
            a5.IspisiStanje();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region KLASE PRIMJER 4 - MOTOR KLASA 
            Console.WriteLine("=> KLASE PRIMJER 4 - MOTOR KLASA:");
            Console.WriteLine();

            // Inicijalizacija motor klase.
            Motor m1 = new Motor();

            // Poziv metodi Vozi().
            m1.Vozi();

            // Poziv metodi PostaviImeVozaca().
            m1.PostaviImeVozaca("Aydin");
            Console.WriteLine("Ime vozača je {0}.", m1.imeVozaca);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region KLASE PRIMJER 5 - MOTOR KLASA 
            Console.WriteLine("=> KLASE PRIMJER 5 - MOTOR KLASA:");
            Console.WriteLine();

            // Poziv osnovnom konstruktoru.
            Motor m2 = new Motor();
            m2.Vozi();

            Console.WriteLine();

            // Poziv Kontruktoru koji uzima samo ime.
            Motor m3 = new Motor("Edin");
            m3.Vozi();
            Console.WriteLine("Ime vozača je: {0}.", m3.imeVozaca);

            Console.WriteLine();

            Motor m4 = new Motor(8, "Edina");
            m4.Vozi();
            Console.WriteLine("Intenzitet vozača je: {0}.", m4.intenzitetVozaca);
            Console.WriteLine("Ime vozača je: {0}.", m4.imeVozaca);

            Console.WriteLine();

            // Poziv glavnom kontruktoru sa ovom inicijalizacijom.
            Motor m5 = new Motor();
            m5.PostaviImeVozaca("Marlena");
            m5.Vozi();
            Console.WriteLine("Ime vozača je: {0}.", m5.imeVozaca);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region KLASE PRIMJER 6 - MOTOR KLASA

            Console.WriteLine("=> KLASE PRIMJER 6 - MOTOR KLASA (OPCIONLNI ARGUMENTI KONTRUKTORA)");
            Console.WriteLine();

            // imeVozaca = "" | intenzitetVozaca = 0
            Motor mo1 = new Motor();
            Console.WriteLine("Ime vozača je: {0} | Intenzitet je: {1}", mo1.imeVozaca, mo1.intenzitetVozaca);

            Console.WriteLine();

            // imeVozaca = "Aydin" | intenzitetVozaca = 0
            Motor mo2 = new Motor(ime: "Aydin");
            Console.WriteLine("Ime vozača je: {0} | Intenzitet je: {1}", mo2.imeVozaca, mo2.intenzitetVozaca);

            Console.WriteLine();

            // imeVozaca = "" | intenzitetVozaca = 8
            Motor mo3 = new Motor(intenzitet: 8);
            Console.WriteLine("Ime vozača je: {0} | Intenzitet je: {1}", mo3.imeVozaca, mo3.intenzitetVozaca);

            Console.WriteLine();

            // imeVozaca = "Aydin" | intenzitetVozaca = 10
            Motor mo4 = new Motor(ime:"Aydin", intenzitet: 10);
            Console.WriteLine("Ime vozača je: {0} | Intenzitet je: {1}", mo4.imeVozaca, mo4.intenzitetVozaca);

            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }
    }
}
