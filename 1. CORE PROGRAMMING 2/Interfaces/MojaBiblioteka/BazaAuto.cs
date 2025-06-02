using System;
using System.Drawing;

namespace MojaBiblioteka
{
    public abstract class BazaAuto : IAuto
    {
        public BazaAuto(string napravi, string model, int godProizvodnje, Color color)
        {
            Napravi = napravi;
            Model = model;
            GodProizvodnje = godProizvodnje;
            Color = color;
        }


        public virtual void Kreni()
        {
            Console.WriteLine("Auto je krenuo! U staru smo!");
        }


        public abstract void PritisniGas(double kolikoDuboko);
        public abstract void PritisniKocnicu(double pritisak);




        public string Napravi { get; private set; }
        public string Model { get; private set; }
        public int GodProizvodnje { get; private set; }
        public Color Color { get; set; } 

    }
}
