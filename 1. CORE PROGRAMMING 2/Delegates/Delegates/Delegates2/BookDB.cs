using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Delegates2
{
    // Struct opisuje knjige u listi knjiga.
    public struct Knjige
    {
        public string Naslov;
        public string Autor;
        public decimal Cijena;
        public bool JelMekiUvez;

        public Knjige(string naslov, string autor, decimal cijena, bool jelMekiUvez)
        {
            Naslov = naslov;
            Autor = autor;
            Cijena = cijena;
            JelMekiUvez = jelMekiUvez;
        }
    }

    // Deklariraj delegat tip za procesuiranje knjiga.
    public delegate void ProcesKnjigaDelegat(Knjige knjige);

    public class KnjigaDB
    {
        // Napravi listu svih knjiga za bazu.
        ArrayList listaKnjiga = new ArrayList();

        // Dodaj knjigu u bazu putem metode.
        public void DodajKnjige(string naslov, string autor, decimal cijena, bool jelMekiUvez)
        {
            listaKnjiga.Add(new Knjige(naslov, autor, cijena, jelMekiUvez));
        }

        // pozovi prosljeđeni delegat za svaku knjigu da li je meni uvez?
        public void ProcesMekiUvezKnjige(ProcesKnjigaDelegat procesKnjige)
        {
            foreach(Knjige knjiga in listaKnjiga)
            {
                if(knjiga.JelMekiUvez)
                {
                    procesKnjige(knjiga);
                }
            }
        }
    }

}

