using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Generic_Struct
{
    /// <summary>
    /// Generična struktura Point. Prijašnja Tačka. sada sam je postavio na engleskom.
    /// </summary>
    public struct Point<T>
    {
        // Generična polja.
        private T xPos;
        private T yPos;

        // Generični Konstruktor.
        public Point(T xVal, T yVal)
        {
            xPos = xVal;
            yPos = yVal;
        }

        // Generične osobine - properies:
        public T X
        {
            get { return xPos; }
            set
            {
            	xPos = value;
            }
        }

        public T Y
        {
            get
            {
                return yPos;
            }
            set
            {
            	yPos = value;
            }
        }

        // Override string metoda:
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", xPos, yPos);
        }

        // Resetiraj polja na osnovnu vrijednost od tipnog paramentra.
        public void ResetPoint()
        {
            xPos = default(T);
            yPos = default(T);
        }
    }
}
