using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_IComparable_01
{
    /// <summary>
    /// PRIMJER IMPLEMENTACIJE IComparable INTERFACE-A.
    /// </summary>
    class MyClass : IComparable
    {
        // Lokalno polje.
        public int Vrijednost;

        #region IComparable Members

        // Implementacija IComparable ComparTo metode.
        public int CompareTo(object obj)
        {
            MyClass mc = (MyClass)obj;
            if(this.Vrijednost < mc.Vrijednost) return -1;
            if(this.Vrijednost > mc.Vrijednost) return 1;
            return 0;
        }

        #endregion
    }
}
