using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtenzivneMetode
{
    public static class MojeExtenzije
    {
        // Ova Metoda broji riječi u svakom string-u. 
        public static int CountWords(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?', '!', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
