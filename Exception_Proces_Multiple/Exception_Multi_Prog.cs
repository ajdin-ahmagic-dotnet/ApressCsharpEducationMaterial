using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Proces_Multiple
{
    class Exception_Multi_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: CUSTOM EXCEPTION PRIMJER ---                 ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Yellow; Console.SetBufferSize(134, 100);

            AutoE mojAuto = new AutoE("Glof 5", 120);

            try
            {
                // Prevari arg za out range exception.
                mojAuto.Ubrzanje(-10);
            }
            catch(AutoJeMrtvoGreska ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Kada radimo sa više izuzetaka istodobno onda treba staviti na početak najspecifičnije,
            // a najgeneralnije na karj, jer u protivnom ako bi obrnuli redosljed AutoJeMrtvo i ArgumentOtOfRange neće
            // nikad biti pobuđeni. Tako da hvatanje najgeneralnijih izuzetaka ostavljamo uvjek za kraj:
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // I napokon "finally" blok koji osigurava neovisno o greki ili ne da će se određeni blok koda izvršiti!
            finally
            {
                mojAuto.RadioOnOf(false);
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
        }


    }
}
