using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_03
{
    /// <summary>
    /// U ovom primjeru oktagona svi interface-i djele istu tj. impmentiraju istu metodu tako da
    /// se ne zna kad je koji poziva!
    /// </summary>
    class Octagon : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {
        public void Draw()
        {
            // Djeljena logika cratanja...
            Console.WriteLine("Cratanje Oktagona...");
        }
    }
}
