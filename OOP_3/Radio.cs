using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Radio
    {
        public void Ukljuci(bool ukljucen)
        {
            if(ukljucen == true)
            {
                Console.WriteLine("Radio je: Uključen.");
            }
            if(ukljucen == false)
            {
                Console.WriteLine("Radio je: Ugašen.");
            }
            
        }
    }
}
