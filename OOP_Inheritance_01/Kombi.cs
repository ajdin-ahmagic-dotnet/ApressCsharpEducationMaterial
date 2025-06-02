using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_01
{
    // Recimo da kažemo da ne želimo da dalje driviramo iz Kombi klase
    // i da kompjleru želimo reći ova klasa ne može biti derivirana!
    // to možemo napraviti sa ključnom riječi "sealed".
    // Svi pokušaji da se derivira dalje iz ove klase će rezultirati greškom!

    sealed class Kombi : Auto
    {
        public Kombi(int maks)
            : base(maks)
        {
            
        }
        public Kombi()
        {
            
        }

    }
}
