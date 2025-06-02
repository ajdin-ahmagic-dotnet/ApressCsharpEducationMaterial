using System;
namespace Interface_02
{
    // Ovaj interface sam pomoću Visual Studio Extract Interface opcije ektrktirao.
    // Pa ćemo ga sad pokušati primjeniti na jednu novu klasu...
    interface IHexagon
    {
        void Draw3D();
        void DrawAbstract();
        byte Points { get; }
    }
}
