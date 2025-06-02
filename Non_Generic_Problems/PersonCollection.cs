using System;
using System.Collections;
using System.Linq;

namespace Non_Generic_Problems
{
    /// <summary>
    /// Hard-kodirana kolekcija samo za Person objekte!
    /// Pošto je kolekcija ne generična maknuli smo using za generične kolekcije...
    /// Meotde i osobine su protutipirane samo za objekt Person u ovom slučaju.
    /// Sa ovako definiranom kolekcijom sad smo prlično tipe-sigurni jer na osnovu 
    /// ovdje navedehin podataka C# kompajler će znati što trebamo unjeti i svaki
    /// pokušaj unosa krivih podataka spriječiti.
    /// </summary>
    class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();

        // Cast za pozivaoca:
        public Person GetPerson(int pos)
        {
            return (Person)arPeople[pos];
        }

        // Ubaci samo Person objekte!
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }

        // Izbriši objekte metoda:
        public void ClearPeople()
        {
            arPeople.Clear();
        }

        // Izbroj objekte property:
        public int Count
        {
            get
            {
                return arPeople.Count;
            }
        }

        // Foreach enumeracijska podrška:
        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arPeople.GetEnumerator();
        }

        #endregion
    }
}
