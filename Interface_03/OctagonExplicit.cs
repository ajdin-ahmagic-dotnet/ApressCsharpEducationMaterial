using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_03
{
    /// <summary>
    /// EXPLICITNO IMPLEMENTIRANI INTERFACE-I TAKO DA NEMA KOLIZIJE IMENA METODA!
    /// </summary>
    class OctagonExplicit : IDrawToForm, IDrawToMemory, IDrawToPrinter
    {

        #region IDrawToForm Members

        void IDrawToForm.Draw()
        {
            Console.WriteLine("Crtanje u Formi...");
        }

        #endregion

        #region IDrawToMemory Members

        void IDrawToMemory.Draw()
        {
            Console.WriteLine("Crtanje u Memoriji...");
        }

        #endregion

        #region IDrawToPrinter Members

        void IDrawToPrinter.Draw()
        {
            Console.WriteLine("Crtanje u štapmaču...");
        }

        #endregion
    }
}
