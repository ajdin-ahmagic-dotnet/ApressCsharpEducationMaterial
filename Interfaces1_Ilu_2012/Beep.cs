using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces1_Ilu_2012
{
    static class Beep
    {
        public static void BeepC(this System.Collections.IEnumerable iterator)
        {
            foreach(var item in iterator)
            {
                //Console.WriteLine(iterator); 
                Console.Beep();
            }
            
           
        }
    }
}
