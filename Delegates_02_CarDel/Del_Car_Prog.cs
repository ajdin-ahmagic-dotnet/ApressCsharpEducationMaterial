using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegates_02_CarDel
{
    class Del_Car_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: DELEGATE -( AUTO ) PRIMJER ---                ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region Primjer 1

            // Prvo pravimo Auto objekt:
            Auto mojAuto = new Auto("BMW 525i", 100, 10);

            // Sada moramo reći autu koju poruku da pozove 
            // kada nam želi poslati poruke:
            mojAuto.RegistrirajSaAutoMotorom(new Auto.AutoMotorHandler(AutoMotorDogadjaj));
            mojAuto.RegistrirajSaAutoMotorom(new Auto.AutoMotorHandler(AutoMotorDogadjaj2));
            // Ubrzaj Auto (sve dok ne potakne događaj):
            for(int i = 0; i < 6; i++)
            {
                mojAuto.Ubrzanje(20);
            }


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2
            Auto a1 = new Auto("Audi A8", 100, 10);
            a1.RegistrirajSaAutoMotorom(new Auto.AutoMotorHandler(AutoMotorDogadjaj));

            // Ovaj puta, drži delegatni objekt tako da
            // se možemo odregistrirati od njega.
            Auto.AutoMotorHandler handler2 = new Auto.AutoMotorHandler(AutoMotorDogadjaj2);
            a1.RegistrirajSaAutoMotorom(handler2);

            // Ubrzaj auto ( ovo će pokrenuti event )
            Console.WriteLine("*********** Ubrzavam ************");
            for(int i = 0; i < 6; i++)
            {
                a1.Ubrzanje(20);
            }

            // Odregistriraj se sa drugog handlera:
            a1.OdRegistrirajSaAutoMotorom(handler2);

            // Sada nećemo vidjeti poruku "VELIKIM" slovima!
            Console.WriteLine("*********** Ubrzavam ************");
            for(int i = 0; i < 6; i++)
            {
                a1.Ubrzanje(20);
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Delegate Tagets Metode

        // Metoda koju pozivamo preko delgata:
        public static void AutoMotorDogadjaj(string por)
        {
            Console.WriteLine("\n************** Poruka od Auto Objekta ****************");
            Console.WriteLine("=> {0}", por);
            Console.WriteLine("******************************************************");
        }

        public static void AutoMotorDogadjaj2(string por)
        {
            Console.WriteLine("=> {0}", por.ToUpper());
        }

        #endregion

        #region Koznolna NapisiPunuCrtu40 Metoda

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }

        #endregion
    }
}
