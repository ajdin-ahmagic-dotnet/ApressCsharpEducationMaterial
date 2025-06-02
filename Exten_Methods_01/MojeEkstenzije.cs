using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;    // Uvezeno jer radimo sa Refleksijom!

namespace Exten_Methods_01
{
    /// <summary>
    /// Ovdje se uz napomenu bavimo refleksijom, koju za sada još nećemo diskusirati, ali samo da znamo otpr. što je 
    /// refleksija. Refleksija nam dozvoljava da otkrijemo strukture i klase u asemblijima, tipovima, i svim članovima
    /// u runtimeu.
    /// </summary>
    static class MojeEkstenzije
    {
        // U ekstenzjskim metodama samo prvi parametar mora biti tretiran sa "this" svi ostali su normalnog tipa...

        // Ova metoda dozvoljava svakom objektu da prikaže "assembly" koje je definiran unutra:
        public static void Prikazi_Definirani_Assembly(this object obj)
        {
            Console.WriteLine("{0} živi ovdje: => {1}\n", obj.GetType().Name, Assembly.GetAssembly(obj.GetType()).GetName().Name);
        }

        // Ova metoda dozvoljava da svaki integer preokrene svoje brojke:
        public static int Preokreni_Brojke(this int i)
        {
            // Prevedi int u string, onda dobavi sve karaktere(slova):
            char[] brojke = i.ToString().ToCharArray();

            // Sada preokreni stvake u matrici:
            Array.Reverse(brojke);

            // Vrati nazad u string:
            string noveBrojke = new string(brojke);

            // i konačno na kraju, vrati (return) modificirani string kao int:
            return int.Parse(noveBrojke);
        }
    }
}
