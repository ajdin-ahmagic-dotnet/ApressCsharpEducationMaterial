using System;

namespace Collection_EX_01
{
    public abstract class Animal
    {
        // Polje:
        protected string name;

        // Osobina:
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
            	name = value;
            }
        }

        // Konstruktor 1:
        public Animal(string newName)
        {
            name = newName;
        }
        // Default Konstruktor 2:
        public Animal()
        {
            name = "Životinja bez imena";
        }

        public void Feed()
        {
            Console.WriteLine("{0} je nahranjena.", name);
        }
    }
}
