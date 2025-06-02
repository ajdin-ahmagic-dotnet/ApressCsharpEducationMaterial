using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_02
{
    sealed class PTSalesPreson : SalesPerson
    {
        #region Konstruktori

        // Konstruktori.
        public PTSalesPreson()
        {

        }
        public PTSalesPreson(string name, int id, float pay, string ssn)
            : base(name, id, pay, ssn)
        {
            
        }
        public PTSalesPreson(string name, int id, int age, float pay, string ssn, int numbOfSales)
            : base(name, id, age, pay, ssn, numbOfSales)
        {
            
        }

        #endregion

        


    }
}
