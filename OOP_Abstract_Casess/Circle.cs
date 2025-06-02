using System;
using Interface_02;

namespace OOP_Abstract_Casess
{
    class Circle : Shape
    {
        // Konstruktori.
        public Circle(string name = "Bez Imena")
            : base(name) { }

        public Circle() { }

        public override void DrawAbstract()
        {
            Console.WriteLine("Crtam: | {0,10:} | Krug.    Koja je abstraktna za Krug.", Name);
        }

    }
}
