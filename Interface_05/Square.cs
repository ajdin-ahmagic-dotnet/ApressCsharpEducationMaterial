using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_05
{
    /// <summary>
    /// Ovdje sada u explicitnoj implementaciji se vidi. koja Draw() metoda je od kojeg 
    /// interface-a.
    /// </summary>
    class Square : IShape
    {
        #region IShape Members

        public int GetNumberOfSides()
        {
            return 4;
        }

        #endregion

        #region IDrawable Members

        void IDrawable.Draw()
        {
            Console.WriteLine("Crtam u IDrawable...");
        }

        #endregion

        #region IPrintable Members

        public void Print()
        {
            Console.WriteLine("Štampam u IPrintable...");
        }

        void IPrintable.Draw()
        {
            Console.WriteLine("Crtam u IPrintable...");
        }

        #endregion

        // Polje...
        public string Ime { get; set; }

        /// <summary>
        /// Konstruktori...
        /// </summary>
        public Square(string ime)
        {
            Ime = ime;
        }

        public Square()
        {

        }

        // String override...
        public override string ToString()
        {
            return string.Format("| {0} |", Ime);
        }
    }
}
