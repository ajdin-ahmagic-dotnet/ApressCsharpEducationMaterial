using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collection_EX_02
{
    /// <summary>
    /// Strongly-tiped kolekcija objekta Animal. Collection Baze Kolekcija.
    /// </summary>
    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void Remove(Animal newAnimal)
        {
            List.Remove(newAnimal);
        }

        public Animal this[int animalIndex]
        {
            get
            {
                return(Animal)List[animalIndex];
            }
            set
            {
            	List[animalIndex] = value;
            }
        }
    }
}
