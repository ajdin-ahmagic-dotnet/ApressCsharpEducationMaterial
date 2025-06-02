using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
    /// <summary>
    /// Pravimo moju custom generičnu listu koja može primati sve vrste tipova pa kač i klase sa svim tipovima mogućim.
    /// Klasa n apočetku nije mogla prikazivati Zaposlenik klasu kao listu jer nije implementirala IEnumerable ali pošto sada
    /// implementira Ienumerable može da primi bilo koji tip pa čak i cijelu klasu.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MojaLista<T> : IEnumerable, IEnumerable<T>
    {
        // Lista koje će držati sadržaj. Lista mora biti istog tipa kao "Zaposlenik"
        private List<T> stavke = new List<T>();

        // Metoda kojom dodajemo stavke u listu:
        public void Add(T stavka)
        {
            stavke.Add(stavka);
        }



        // Metoda da dobijemo nasumičnu stavku il liste:
        public T Remove()
        {
            T stavka = default(T);

            if (stavke.Count != 0)
            {
                // Odredi koju stavku da izbrišeš iz zaposlenika:
                Random r = new Random();
                int num = r.Next(0, stavke.Count);

                // Izbriši stavku:
                stavka = stavke[num];
                stavke.RemoveAt(num);
            }
            return stavka;
        }

        // Metoda koja pribavlja Enumertator iz osnovne liste:
        public IEnumerator<T> GetEnumerator()
        {
            return stavke.GetEnumerator();
        }


        // Metoda koja briše sve stavke iz Zaposlenika i vraća ih kao array:
        public T[] RemoveAll()
        {
            T[] i = stavke.ToArray();
            stavke.Clear();
            return i;
        }



        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
    }
}
