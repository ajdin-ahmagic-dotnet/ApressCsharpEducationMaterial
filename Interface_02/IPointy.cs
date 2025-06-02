using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_02
{
    interface IPointy
    {
      
        // Dodjelićemo ovom interface-u još jedan read-only property.
        byte Points { get; }
        
    }
}
