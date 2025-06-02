using System;
using System.Collections.Generic;
using System.Linq;


namespace Interface_02
{
    class Fork : IPointy
    {
        #region IPointy Members

        public byte Points
        {
            get { return 5; }
        }

        #endregion
    }
}
