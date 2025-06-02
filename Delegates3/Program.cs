using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates3
{
    class Program
    {
        // Deklariramo delgat.
        delegate void Del(int i, double j);


        static void Main(string[] args)
        {
            // Inicijalizacija delegata koristeći PomonožiBrojeve
            Del d = PomnoziBrojeve;

            Console.WriteLine("Pozivanje delegata koristeći 'PomnoziBrojeve' metodu:");
            for(int i = 2; i <= 10; i++)
            {
                d(i, 2);
            }

            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        static void PomnoziBrojeve(int h, double l)
        {
            Console.WriteLine(h * l + " ");
        }
    }
}
