using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcija_Pokus_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> imena = new List<string>();

            int counter = 0;

            while(counter != -1)
            {

                Console.Write("Upišite ime:");
                string ime = Console.ReadLine();

                imena.Add(ime);
                Console.Write("Za prekid upišite -1 za nastavak 1: ");
                counter = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Imena su:");
            foreach(string s in imena)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey(); 
        }
    }
}
