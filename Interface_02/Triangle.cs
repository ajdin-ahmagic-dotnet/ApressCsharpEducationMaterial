using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_02
{
    class Triangle : Shape, IPointy
    {
        // Konstruktori. 
        public Triangle(){ }
        public Triangle(string name = "Bez Imena")
            : base(name)
        {
            
        }

        // Overidiranje metode DRAW().
        public override void DrawAbstract()
        {
            Console.WriteLine("Crtam: {0} Trokut.", Name);
        }


        #region IPointy Members

        public byte Points
        {
            get { return 3; }
        }

        #endregion
    }
}
