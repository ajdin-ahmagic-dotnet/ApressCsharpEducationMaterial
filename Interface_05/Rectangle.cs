using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_05
{
    /// <summary>
    /// Ovdje postoji kolizija imena jer dva interface-a imaju isto ime metode,
    /// tako da se ne zna koja metoda se zapravo poziva iako se to može ispitati sa GetType()
    /// metodom, mi do Runtime-a ne znamo koji interface se implementira? Zato radimo Explicitnu 
    /// implementaciju.
    /// </summary>
    class Rectangle : IShape
    {
        #region IShape Members

        public int GetNumberOfSides()
        {
            return 4;
        }

        #endregion

        #region IDrawable Members

        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        #endregion

        #region IPrintable Members

        public void Print()
        {
            Console.WriteLine("Printing...");
        }

        #endregion

        // Polje...
        public string Ime { get; set; }

        /// <summary>
        /// Konstruktori...
        /// </summary>
        public Rectangle(string ime)
        {
            Ime = ime;
        }
        public Rectangle()
        {
            
        }


        public override string ToString()
        {
            return string.Format("| {0} |", Ime);
        }
    }
}
