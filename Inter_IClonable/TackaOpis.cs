using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inter_IClonable
{
    /// <summary>
    /// Uzmimo u obzir da Tačka klasa ima referencnu tipe člansku varijablu imena TackaOpis.
    /// Ova klasa, održava Tačkino prijateljsko ime, kao i identifikacijski broj izražen u 
    /// System.Guid ( globalno unikatnom indetifikatoru GUID ) koji statički unikatni 128 bitni čaln.
    /// Ovo je implementacija: 
    /// </summary>
    class TackaOpis
    {
        // Osobine...
        public string Ime { get; set; }
        public Guid TackaID { get; set; }

       // Konstruktori...
        public TackaOpis()
        {
            Ime = "Bez Imena";
            TackaID = Guid.NewGuid();
        }
    }
}
