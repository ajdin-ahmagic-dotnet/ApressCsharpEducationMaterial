using System;
using System.Collections.Generic;
using System.Linq;


namespace Interface_02
{
    class Knife : IPointy
    {
        #region IPointy Members

        public byte Points
        {
            get { return 1; }
        }

        #endregion
    }
}
