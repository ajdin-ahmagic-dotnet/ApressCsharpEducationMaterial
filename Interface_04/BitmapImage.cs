using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_04
{
    class BitmapImage : IAdvancedDraw
    {
        #region IDrawable Members

        public void Draw()
        {
            Console.WriteLine("Drawing...");
        }

        #endregion

        #region IAdvancedDraw Members

        public void DrawInBoundingBox(int top, int left, int bottom, int right)
        {
            Console.WriteLine("Drawing a Box...");
        }

        public void DrawUpsideDown()
        {
            Console.WriteLine("Drawing Upside down!");
        }

        #endregion

    }
}
