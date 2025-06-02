using System;
using System.Collections.Generic;
using System.Linq;


namespace Interface_02
{
    class PitchFork : IPointy
    {
        #region IPointy Members

        public byte Points
        {
            get { return 3; }
        }

        #endregion
    }
}
