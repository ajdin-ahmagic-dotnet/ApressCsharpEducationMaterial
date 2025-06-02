using System;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Coll_List
{
    class SortEmployeesByAge : IComparer<Employee>
    {
        #region IComparer<Employee> Members

        public int Compare(Employee fisrtEmployee, Employee secondEmployee)
        {
            if(fisrtEmployee.Age > secondEmployee.Age)
                return 1;
            if(fisrtEmployee.Age < secondEmployee.Age)
                return -1;
            else
                return 0;
        }

        #endregion
    }
}
