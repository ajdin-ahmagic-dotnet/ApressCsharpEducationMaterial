using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_EX_01
{
    public class Chicken : Animal
    {
        public Chicken(string newName)
            : base(newName)
        {
            
        }
        public Chicken()
        {
            
        }

        public void LayEgg()
        {
            Console.WriteLine("{0} je snijela jaje.", name);
        }
    }
}
