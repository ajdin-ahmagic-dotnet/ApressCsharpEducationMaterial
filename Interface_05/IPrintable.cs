using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_05
{
    interface IPrintable
    {
        void Print();
        void Draw();    // <-- Primjetite moguću koliziju imena.
    }
}
