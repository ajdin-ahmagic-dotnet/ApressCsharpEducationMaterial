using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    class Program
    {
        /// <summary>
        /// Razlike između statičkih i nestatičkih polja su većinom u tome što statička
        /// bile to metode, polja, konstruktori ili varijable djele među svim objektima
        /// koji se inicijaliziraju istu vriejdnost, dok nestatička polja za svaki objekt
        /// imaju različite podatkte u primjeru će sve postati jasnije...
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region PRIMJER - STATIČNI PODATCI 
            Console.WriteLine("=> PRIMJER - STATIČNI PODATCI:");
            Console.WriteLine();

            // U memoriji sve tri instance klase imaju istu zajedničku-
            // kamatnu stopu jer smo je označili "static".
            StedniRacun s1 = new StedniRacun(50.0);
            
            // Ispiši trenutnu kamatu.
            Console.WriteLine("Trenutna kamata je: {0}", StedniRacun.DobaviKamatnuStopu());
            Console.WriteLine();

            // Postavljanje kamatne stope putem metode statične.
            StedniRacun.PostaviKamatnuStopu(0.07);

            StedniRacun s2 = new StedniRacun(100.0);
            Console.WriteLine("Trenutna kamata je: {0}", StedniRacun.DobaviKamatnuStopu());


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - STATIČNI KONTRUKTORI
            Console.WriteLine("=> PRIMJER - STATIČNI PODATCI 2:");
            Console.WriteLine();

            // Napravi račun.
            StedniRacun st = new StedniRacun(50);

            // Ispiši trenutnu kamatu.
            Console.WriteLine("Trenutna kamata je: {0}.", StedniRacun.DobaviKamatnuStopu());
            Console.WriteLine();

            // Pokušaj da promjeniš trenutnu kamatu preko "property" osobine.
            StedniRacun.PostaviKamatnuStopu(0.08);

            // Napravi drugi (novi) račun.
            StedniRacun st2 = new StedniRacun(100);
            
            // Da li će sada biti ispisano 00.8 kao nova trenutna kamata?
            Console.WriteLine("Trenutna kamata je: {0}.", StedniRacun.DobaviKamatnuStopu());
            Console.WriteLine();

            // Novi štedni račun.
            StedniRacun st3 = new StedniRacun(200.0);

            Console.WriteLine("Trenutna kamata je: {0}.", StedniRacun.DobaviKamatnuStopu());
            


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - STATIČNE KLASE
            Console.WriteLine("=> PRIMJER STATIČNE KLASE");
            Console.WriteLine();

            // U STATIČNIM KLASAMA SVI UOBJEKTI MORAJU BITI STATIČNI
            // TE SE NJIHOVO POZIVANJE VRŠI BEZ "new" KLJUČNE RIJEČI.
            UnityStaticClass.IspisiVrijeme();
            UnityStaticClass.IspsiDatum();

            #endregion

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }
    }
}
