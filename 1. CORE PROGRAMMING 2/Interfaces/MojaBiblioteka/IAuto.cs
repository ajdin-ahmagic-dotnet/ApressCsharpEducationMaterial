using System;
using System.Drawing;

namespace MojaBiblioteka
{
    // Kreiramo interface sa metodama i osobinama... koje ćemo prosljediti klasama auta...da implementiraju...
  public interface IAuto
  {
      void Kreni();
      void PritisniGas(double kolikoDuboko);
      void PritisniKocnicu(double pritisak);
      string Napravi { get; }
      string Model { get; }
      int GodProizvodnje { get; }
      Color Color { get; set; } 
  }
}
