using System;
using System.Collections.Generic;
using System.Linq;


namespace Interface_02
{
    class Circle : Shape
    {
        // Konstruktori.
        public Circle(string name = "Bez Imena")
            : base(name) { }

        public Circle() { }

        public override void DrawAbstract()
        {
            Console.WriteLine("Crtam: | {0,-4:} | Krug.", Name);
        }

    }
}
