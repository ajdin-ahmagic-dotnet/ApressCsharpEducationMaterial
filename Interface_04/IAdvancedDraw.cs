using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_04
{
    interface IAdvancedDraw : IDrawable
    {
        void DrawInBoundingBox(int top, int left, int bottom, int right);
        void DrawUpsideDown();
    }
}
