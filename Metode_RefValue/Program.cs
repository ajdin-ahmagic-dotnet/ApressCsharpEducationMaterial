using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_RefValue
{
    class Program
    {
        static void Main()
        {
            // Klasična Swap metoda koristeći ref parametar.
            string prvo = "Prvo";
            string drugo = "Drugo";
            Zamjeni(ref prvo, ref drugo);

            Console.WriteLine("prvo je: {0}, drugo je: {1}", prvo, drugo);

            Console.ReadKey();
        }
        private static void Zamjeni(ref string prvo, ref string drugo)
        {
            string temp = prvo;
            prvo = drugo;
            drugo = temp;
        }
    }
}
