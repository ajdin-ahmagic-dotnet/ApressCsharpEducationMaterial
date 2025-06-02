using System;
using System.Collections.Generic;
using System.Linq;

namespace LingOverArray
{
    public class LinqBaziranaPolja
    {
        // Moguće je definirati polje unutar klase ili strukture čije vrijednosti rezultiraju LINQ upitom.
        // Ali da bi to napravili moramo, koristiti statično tipiranje. Nije moguće koristiti se implictnim
        // tipiranjem, zato što var se ne može koristiti kao polje, a odredište LINQ upita ne može biti 
        // instancno bazirani podatak, tako da mora biti statičan. 

        // Primjer:
        private static string[] trenutneIgre = { "Morrowind", "Uncharted 2", "Hellraiser", "Fallout 3", "Super Mario bros 2", "Hallo 2", "Generals 3" };

        // Nije moguće koristi implicitno tipiranje ovdje. Moramo znati koji je podset!
        private IEnumerable<string> podset = from i in trenutneIgre
                                             where i.Contains(" ")
                                             orderby i
                                             select i;

        public void IspisiIgrice()
        {
            foreach(var stavka in podset)
            {
                Console.WriteLine("Igre su: {0}", stavka);
            }
        }

    }
}
