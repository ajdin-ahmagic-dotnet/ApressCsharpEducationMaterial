using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Inter_IEnumerable
{
    /// <summary>
    /// Da bi ovaj naš primjer radio moramo da nasljedimo od IEnumerable interface-a.
    /// </summary>
    public class Garage : IEnumerable
    {
        // System.Array već implementira IEnumerator!
        private AutoE[] autoArray = new AutoE[4];

        // Napuni garažu sa nekoliko AutoE objekata.
        public Garage()
        {
            autoArray[0] = new AutoE("BMW ", 50);
            autoArray[1] = new AutoE("Audi", 30);
            autoArray[2] = new AutoE("Glof", 35);
            autoArray[3] = new AutoE("Opel", 30);
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            // Vrati array objektni IEnumerator.
            return autoArray.GetEnumerator();
        }

        #endregion
    }
}
