using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_IEnumerable
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
