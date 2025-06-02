using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces1_Ilu_2012
{
    class ClassA : IInfo
    {

        // Osobine - Propreties.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PersonalAge { get; set; }
        public decimal Pay { get; set; }
        public DateTime Started { get; set; }

        /// <summary>
        /// Konstruktori...
        /// </summary>
        public ClassA(string firstName, string lastName, int personalAge, decimal pay, DateTime started)
        {
            FirstName = firstName;
            LastName = lastName;
            PersonalAge = personalAge;
            Pay = pay;
            Started = started;
        }

        public ClassA(){ }

        // Override metoda koja se ne koristi trenutno, interface obavlja sav posao...
        public override string ToString()
        {
            return string.Format("| {0} | {1} | {2} | {3} | {4} |", FirstName, LastName, PersonalAge, Pay, Started);
        }


        #region IInfo Members

        public string GetName()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public int GetAge()
        {
            return PersonalAge;
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
