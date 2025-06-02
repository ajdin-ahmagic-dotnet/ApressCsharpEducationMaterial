using System;
using System.Collections.Generic;
using System.Linq;

namespace Custom_Generic_Struct
{
    class Cust_Gen_Struct
    {
        /// <summary>
        /// Primjer custom generične strukture tačka-point koja može ne samo primiti vrijednosni tip int 
        /// nego i tip double i bilo koji vrijednosni tip...
        /// </summary>
        /// <param name="args"></param>
           static void Main(string[] args)
           {
               NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
               NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
               NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: CUSTOM GENERIČNE STRUKTURE ---                ║                         ║");
               NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
               NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
               Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

               Console.WriteLine("=> GENERIČNE STRUKTURE:");
               Console.WriteLine();
               // Point-Tačka koriteći int:
               Point<int> pI = new Point<int>(10, 10);
               Console.WriteLine("pI.ToString() = {0}.", pI.ToString());
               pI.ResetPoint();
               Console.WriteLine("pI.ToString() = {0}.", pI.ToString());

               #region DELIMITER
               Console.WriteLine();
               Console.WriteLine();
               #endregion

               // Point-Tačka koriteći double:
               Point<double> pD = new Point<double>(12.3, 15.5);
               Console.WriteLine("pD.ToString() = {0}.", pD.ToString());
               pD.ResetPoint();
               Console.WriteLine("pD.ToString() = {0}.", pD.ToString());     
        
        
               Console.WriteLine();
               Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
               Console.ReadKey();
                    
           }
        
           private static void NapisiPunuCrtu40(string ulaz)
           {
               Console.BackgroundColor = ConsoleColor.Black;
               Console.ForegroundColor = ConsoleColor.Green;
               Console.Write(ulaz);
           }
    }
}
