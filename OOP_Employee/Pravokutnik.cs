using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class Pravokutnik
    {
        private Tacka najLijevo = new Tacka();
        private Tacka doleDesno = new Tacka();

        public Tacka NajLijevo
        {
            get { return najLijevo; }
            set
            {
            	najLijevo = value;
            }
        }

        public Tacka DoleDesno
        {
            get { return doleDesno; }
            set
            {
                doleDesno = value;
            }
        }

        public void PrikaziPodatke()
        {
            Console.WriteLine("[NajLijevo: {0}, {1}, {2} DoleLijevo: {3}, {4}, {5}]", najLijevo.X, najLijevo.Y, najLijevo.Boja, 
                doleDesno.X, doleDesno.Y, doleDesno.Boja);
        }
    }
}
