using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Collection_EX_02
{
    /// <summary>
    /// Animal kolekcija samo sa Dictionary baze produžetkom umjesto Collection Base
    /// </summary>
    class AnimalsDict : DictionaryBase
    {
        public void Add(string newID, Animal newAnimal)
        {
            Dictionary.Add(newID, newAnimal);
        }

        public void Remove(string animalID)
        {
            Dictionary.Remove(animalID);
        }

        public Animal this[string animalID]
        {
            get
            {
                return (Animal)Dictionary[animalID];
            }
            set
            {
            	Dictionary[animalID] = value;
            }
        }

        public new IEnumerator GetEnumerator()
        {
            foreach(object animal in Dictionary.Values)
            {
                yield return (Animal)animal;
            }
        }
    }
}
