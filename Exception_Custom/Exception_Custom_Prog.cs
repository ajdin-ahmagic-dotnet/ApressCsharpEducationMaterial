using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Proces_Multiple
{
    class Exception_Custom_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: CUSTOM EXCEPTION PRIMJER ---                 ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Yellow; Console.SetBufferSize(134, 100);

            AutoE mojAuto = new AutoE("Audi A6", 90);

            try
            {
                mojAuto.Ubrzanje(100);
            }
            catch(AutoJeMrtvoGreska ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.VrijemNaljepGreske);
                Console.WriteLine(ex.IzvorGreske);
            }

            

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
            
        }
        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(ulaz);

            //Console.ResetColor();
        }


    }
}
