using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_02
{
    class HexExtract : Shape, IHexagon
    {
        public HexExtract(string name = "Bez Imena")
            : base(name)
        {
    
        }      
  
       #region IHexagon Members

        public void Draw3D()
        {
            Console.WriteLine("Crtamo u 3D-u! Novi objekt!");
        }

        public override void DrawAbstract()
        {
            Console.WriteLine("Crtam Novi {0} Objekt iz extraktiranog interfejsa!", Name);
        }

        public byte Points
        {
            get { return 10; }
        }

        #endregion

        //public string Name { get; set; }
    }
}
