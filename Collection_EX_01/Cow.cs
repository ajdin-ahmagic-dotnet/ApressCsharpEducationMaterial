using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_EX_01
{
    public class Cow : Animal
    {
        public Cow(string newName)
            : base(newName)
        {
            
        }
        public Cow()
        {
            
        }

        public void Milk()
        {
            Console.WriteLine("{0} je pomuzena.", name);
        }
    }
}
