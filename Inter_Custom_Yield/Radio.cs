using System;
using System.Collections.Generic;
using System.Linq;

namespace Inter_Custom_Yield
{
    class Radio
    {
        public void DaLiJeUpaljen(bool on)
        {
            if(on)
            {
                Console.WriteLine("Radio je uključen.");
            }
            else
            {
                Console.WriteLine("Radio je ugašen.");
            }
        }
    }
}
