using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnviroment3
{
    public class Osoba
    {
        public string imeOsobe;
        public int godineOsobe;

       
        /// <summary>
        /// Kostruktor inicijalizira novu instancu Osoba class-e.
        /// </summary>
        /// <param name="imeOsobe"></param>
        /// <param name="godineOsobe"></param>
        public Osoba(string imeOsobe, int godineOsobe)
        {
            this.imeOsobe = imeOsobe;
            this.godineOsobe = godineOsobe;
        }

        public Osoba()
        {

        }

        public void Prikazi()
        {
            Console.WriteLine(String.Format("|Ime: {0} | Godine: {1}|", imeOsobe, godineOsobe));
        }
    }
}
