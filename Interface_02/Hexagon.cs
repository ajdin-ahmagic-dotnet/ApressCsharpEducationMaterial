using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_02
{
    class Hexagon : Shape, IPointy, IDraw3D, IHexagon
    {
        // Konstruktori.
        public Hexagon(string name = "Bez Imena")
            : base(name)
        {
            
        }

        public Hexagon()
        {

        }

        // Hexagon overidira metotu Draw().
        public override void Draw()
        {
            Console.WriteLine("Crtam: | {0,10} | Hexagon.", Name);
        }

        // Pošto sada u baznoj abstraktoj klasi imamo i abstraktnu metodu
        // Moramo je primjeniti ili se program neće kompjlirati.
        public override void DrawAbstract()
        {
            Console.WriteLine("Crtam: | {0,-4:} | Hexagon.", Name);
        }


        #region IPointy Members

        public byte Points
        {
            get { return 6; }
        }

        #endregion

        #region IDraw3D Members

        public void Draw3D()
        {
            Console.WriteLine("Crtam Hexagon u 3D-u!");
        }

        #endregion
    }
}
