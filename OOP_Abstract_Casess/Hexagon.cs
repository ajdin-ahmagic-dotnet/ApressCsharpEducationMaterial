using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_02
{
    class Hexagon : Shape
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
            Console.WriteLine("Crtam: | {0,10:} | Hexagon. Koja je abstraktna za Hexagon.", Name);
        }

    }
}
