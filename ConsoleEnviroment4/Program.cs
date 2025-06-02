using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnviroment4
{
    class DatabaseReader
    {
        // Ovo su "nullable" polja eng. fileds.
        public int? brojcanaVrijednost = null;
        public bool? boolVrijednost = true;

        // Ovo je "Nulable" returnt tip.
        public int? DajIntIzBazePodataka()
        {
            return brojcanaVrijednost;
        }

        // Ovo je "Nulable" return tip.
        public bool? DajBoolIzBazePodataka()
        {
            return boolVrijednost;
        }
    }


    class Program
    {
        static void Main()
        {
            #region CORE PROGRAMMING 2 (Nastavak)

            #region NULLABLE PRIMJER 1
            Console.WriteLine("=> NULLABLE PRIMJER:");
            Console.WriteLine();

            // Napravi instancu klase DatabaseReader.
            DatabaseReader dr = new DatabaseReader();

            // Dobavi int iz baze podataka.
            int? i = dr.DajIntIzBazePodataka();
            if(i.HasValue)
            {
                Console.WriteLine("Vrijednost od 'i' je: {0}.", i.Value);
            }
            else
            {
                Console.WriteLine("Vrijednost od 'i' je: nedefinirana!");
            }
             
            
            // Dobavi bool iz baze podataka.
            bool? b1 = dr.DajBoolIzBazePodataka();
            if(b1 != null)
            {
                Console.WriteLine("Vrijednost od 'b1' je: {0}.", b1.Value);
            }
            else
            {
                Console.WriteLine("Vrijednost od 'b1' je: nedefinirana!");
            }
            #endregion// NULLABLE PRIMJER 1

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region NULLABLE PRIMJER 2
            Console.WriteLine("=> NULLABLE PRIMJER 2:");
            Console.WriteLine();

            // Ako je vrijednost od DajIntIzBazePodataka() nula
            // dodjeli lokalnoj varijali vrijednost od: 150.
            int mojPodatak = dr.DajIntIzBazePodataka() ?? 150;
            Console.WriteLine("Vrijednost od 'mojPodatak' je: {0}.", mojPodatak);

            #endregion

            #endregion// CORE PROGRAMMING 2 (Nastavak)
            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        #region M E T O D E
        
     
        #endregion
    }
}
