using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_05
{
    /// <summary>
    /// Višestruko interface nasljeđivanje.
    /// </summary>
    interface IShape : IDrawable, IPrintable
    {
        int GetNumberOfSides();
    }
}
