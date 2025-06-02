using System;
using System.Collections.Generic;
using System.Linq;

namespace Interface_04
{
    class Interf_Hierar_Prog
    {
        /// <summary>
        /// Interface hierarhijski primjer. Kada interface proširuje postojeći interface o
        /// n nasljeđuje sve abstraktne članove, definirane od roditelja, ali za razliku od klasnog
        /// nasljeđivanja derivirani interface nikad ne nasljeđuje stvarnu implementaciju! 
        /// On samo proširuje svoju definiciju sa dodatnim abstraktnim članovima.
        /// interface hierarhije su jako korisne kada želimo proširiti funkcionalnost interface-a
        /// bez prekidanja postojećeg baznog koda.
        /// </summary>
        static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                   --- DOBRODOŠLI U: INTERFACES PRIMJER 3 ---                   ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> JEDNOSTAVNA INTERFACE HIERARHIJA:");
            Console.WriteLine();

            // Poziv na objektnom levelu:
            BitmapImage image = new BitmapImage();
            image.Draw();
            image.DrawInBoundingBox(10, 10, 100, 150);
            image.DrawUpsideDown();

            // Poziv IAdvancedDraw eksplicitno:
            IAdvancedDraw iAdvDraw = image as IAdvancedDraw;
            if(iAdvDraw != null)
                iAdvDraw.DrawUpsideDown();

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
