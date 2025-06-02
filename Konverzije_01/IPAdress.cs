using System;
using System.Collections.Generic;
using System.Linq;

namespace Konverzije_01
{
    public class IPAdress
    {
        private int[] ip;

        public int this[int index]
        {
            get
            {
                return ip[index];
            }
            set
            {
            	if(value == 0 || value == 1)
                {
                     ip[index] = value;
                }
                else
                    throw new Exception("Nesipravna Vrijednost!");
            }
        }
    }
}
