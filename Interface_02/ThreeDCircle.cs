using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_02
{
    /// <summary>
    /// Pod pretpostavkom da nam kolega da klasu a da mi nemamo prisput Draw2() metodi.
    /// Možemo napraviti novu impmentaciju sa ključnom riječi "new". 
    /// Klasa extendira i sakriva nasljeđenu DrawAbstract() Metodu. 
    /// Isto tako svako implementaciju osobina, polja i konstanti možemo označiti ključnom
    /// riječju "new" i sakriti baznu implementaciju...
    /// </summary>
    class ThreeDCircle : Circle, IDraw3D
    {
        // Sakrij "Name" osobinu ispod mene.
        // Ali u ovom slučaju ćemo je komentirati...
        // public new string Name { get; set; }


        public ThreeDCircle(string name = "Bez Imena")
            : base(name)
        {
            
        }
        public ThreeDCircle()
        {
            
        }

        public new void DrawAbstract()
        {
            Console.WriteLine("Crtam: | {0,10:} | 3D Krug. Koja je tipa 'new'.", Name);
        }


        #region IDraw3D Members

        public void Draw3D()
        {
            Console.WriteLine("Crtam Krug u 3D-u!");
        }

        #endregion
    }
}
