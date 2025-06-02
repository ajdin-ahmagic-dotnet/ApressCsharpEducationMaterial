using System;
using System.Collections.Generic;
using System.Linq;
namespace Interfaces1_Ilu_2012
{
    class ClassB : IInfo
    {
        // Osobine- Properies.
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Pay { get; set; }
        public DateTime Started { get; set; }

        /// <summary>
        /// Konstruktori...
        /// </summary>
        public ClassB(string name, int age, decimal pay, DateTime started)
        {
            Name = name;
            Age = age;
            Pay = pay;
            Started = started;
        }

        public ClassB() { }

        // Override metoda koja se ne koristi trenutno, interface obavlja sav posao...
        public override string ToString()
        {
            return string.Format("| Name: {0,-17:} | Age: {1} | Pay: {2,-13:C2} | Started: {3,-18:} |", Name, Age, Pay, Started);
        }


        #region IInfo Members

        public string GetName()
        {
            return Name;
        }

        public int GetAge()
        {
            return Age;
        }

        public decimal GetPay()
        {
            return Pay;
        }

        public DateTime GetStarted()
        {
            return Started;
        }

        #endregion
    }
}
