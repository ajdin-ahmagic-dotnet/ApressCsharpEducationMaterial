using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimofizam_01
{
    // U ovom primjeru radimo sa polimorfizmom. Pokušavamo pokazati abstraktne klase, metode virtualne metode itd...
    abstract class ThumbnailerBase
    {
        // Definiramo abstraktnu metodu, koja nema implementacije u baznoj klasi:
        protected abstract void GetMetadata();

        // Definiramo klasičnu void tip return metodu:
        public void GetThumbnail()
        {
            GetMetadata();
            Console.WriteLine("ThumbnailerBase.GetThumbnail.Method");
        }
    }


    // Derivirana klasa:
    class ThumbnailerImage : ThumbnailerBase
    {
        protected override void GetMetadata()
        {
            Console.WriteLine("ThumbnailerImage.GetMetadata.Method"); 
        }

        public void GetThumbnail()
        {
            Console.WriteLine("ThumbnailerBase.GetThumbnail.Method");
        }
    }

    class Plimorf_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: Polimorfizam Objašnjen ---                    ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);




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
