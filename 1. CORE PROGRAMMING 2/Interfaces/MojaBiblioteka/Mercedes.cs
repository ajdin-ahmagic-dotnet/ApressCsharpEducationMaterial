using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MojaBiblioteka
{
    /// <summary>
    /// Klase isto tako možemo zaključati i time reći niko više neće
    /// moći derivirati iz ove klase!
    /// </summary>

    public sealed class Mercedes : BazaAuto
    {
        public Mercedes()
            : base("Mercedes", "S500", 2009, Color.Yellow)
        {
            
        }

        // Metodu možemo zaključati sa ključnom riječi "sealed" i time 
        // reći ovo je zadnji override koje je moguć za ovu metodu!
        public sealed override void PritisniGas(double kolikoDuboko)
        {
            if(kolikoDuboko == 10.0)
            {
                Console.WriteLine("Gas na 10% više...");
            }
            else if(kolikoDuboko == 20.0)
            {
                Console.WriteLine("Gas na 20% više...");
            }
            else if(kolikoDuboko == 30.0)
            {
                Console.WriteLine("Gas na 30% više...");
            }
            else if(kolikoDuboko == 40.0)
            {
                Console.WriteLine("Gas na 40% više...");
            }
            else if(kolikoDuboko == 50.0)
            {
                Console.WriteLine("Gas na 50% više...");
            }
            else
            {
                Console.WriteLine("Gas nije pritisnut...");
            }
        }

        public override void PritisniKocnicu(double pritisak)
        {
            if(pritisak == 10.0)
            {
                Console.WriteLine("Pritisak kočnice je 10%");
            }
            else if(pritisak == 20.0)
            {
                Console.WriteLine("Pritisak kočnice je 20%");
            }
            else if(pritisak == 20.0)
            {
                Console.WriteLine("Pritisak kočnice je 20%");
            }
            else if(pritisak == 30.0)
            {
                Console.WriteLine("Pritisak kočnice je 30%");
            }
            else if(pritisak == 40.0)
            {
                Console.WriteLine("Pritisak kočnice je 40%");
            }
            else if(pritisak == 50.0)
            {
                Console.WriteLine("Pritisak kočnice je 50%");
            }
            else if(pritisak == 60.0)
            {
                Console.WriteLine("Pritisak kočnice je 60%");
            }
            else if(pritisak == 70.0)
            {
                Console.WriteLine("Pritisak kočnice je 70%");
            }
            else if(pritisak == 80.0)
            {
                Console.WriteLine("Pritisak kočnice je 80%");
            }
            else if(pritisak == 90.0)
            {
                Console.WriteLine("Pritisak kočnice je 90%");
            }
            else if(pritisak == 100.0)
            {
                Console.WriteLine("Pritisak kočnice je maximumu od 100%");
            }
            else
            {
                Console.WriteLine("Kočnica nije pritisnuta...");
            }
        }
    }
}
