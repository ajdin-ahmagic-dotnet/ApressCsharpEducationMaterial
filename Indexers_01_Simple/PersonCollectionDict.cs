using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Indexers_01_Simple
{
    class PersonCollectionDict : IEnumerable
    {
       // Umjesto ArrayListe ovdje kosristimo Dictionary<T, K> Generičnu kolekciju!
        private Dictionary<string, Person> listPeople = new Dictionary<string, Person>(); 

       // Za ovu generičnu kolekciju i indexer se mjenja!
        public Person this[string name]
        {
            get
            {
                return (Person)listPeople[name];
            }
            set
            {
                listPeople[name] = value;
            }
        }

        // I SVE U OVOM BLOKU SE MJENJA VIDI PERSON KOLEKCIJU DA VIDIŠ RAZLIKE!

        // Izbriši objekte metoda:
        public void ClearPeople()
        {
            listPeople.Clear();
        }

        // Izbroj objekte property:
        public int Count
        {
            get
            {
                return listPeople.Count;
            }
        }

        // Foreach enumeracijska podrška:
        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return listPeople.GetEnumerator();
        }

        #endregion
    }
}
