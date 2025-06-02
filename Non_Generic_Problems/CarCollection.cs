using System;
using System.Collections;
using System.Linq;


namespace Non_Generic_Problems
{
    class CarCollection : IEnumerable
    {
        // Kolekcija Auta:
        private ArrayList arCars = new ArrayList();

        // Cast za sve koji pozivaju:
        public Car GetCar(int pos)
        {
            return (Car)arCars[pos];
        }

        // Ubaci u kolekciju samo Car objekte:
        public void AddCar(Car c)
        {
            arCars.Add(c);
        }

        // Obriši iz kolekcije:
        public void ClearCars()
        {
            arCars.Clear();
        }

        // Prebroj u Kolekciji:
        public int Count
        {
            get
            {
                return arCars.Count;
            }
        }


        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arCars.GetEnumerator();
        }

        #endregion
    }
}
