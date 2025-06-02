using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Inter_Custom_Yield
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
        // IZMJENA ZA YIELD!
        public IEnumerator GetEnumerator()
        {
            foreach(AutoE a in autoArray)
            {
                yield return a;
            }
        }

        #endregion

        public IEnumerable DobaviAute(bool VratiUnatrag)
        {
            // Vrati stavke unatrag...
            if(VratiUnatrag)
            {
                for(int i = autoArray.Length; i != 0;  i--)
                {
                    yield return autoArray[i - 1];
                }
            }
            else
            {
                // vrati stavke kakve su bile u matrici...
                foreach(AutoE a in autoArray)
                {
                    yield return a;
                }
            }
        }
    }
}
