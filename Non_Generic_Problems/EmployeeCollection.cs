using System;
using System.Collections;
using System.Linq;


namespace Non_Generic_Problems
{
    class EmployeeCollection : IEnumerable
    {
        private ArrayList arEmployee = new ArrayList();

        // Cast za sve pozivaoce:
        public Employee GetEmployee(int pos)
        {
            return (Employee)arEmployee[pos];
        }

        // Dodaj samo objekte Employee klase:
        public void AddEmployee(Employee e)
        {
            arEmployee.Add(e);
        }

        // Clear metoda:
        public void ClearEmployees()
        {
            arEmployee.Clear();
        }


        // Osobina prebroji:
        public int Count
        {
            get
            {
                return arEmployee.Count;
            }

        }

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arEmployee.GetEnumerator();
        }

        #endregion
    }
}
