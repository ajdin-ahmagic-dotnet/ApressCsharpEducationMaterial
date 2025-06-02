using System;
using System.Collections.Generic;
using System.Linq;

namespace Events_01_AutoEvent
{
    class Auto_Event_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║              --- DOBRODOŠLI U: EVENTS ( AUTO EVENT PRIMJER ) ---               ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region Primjer 1
            Console.WriteLine("=> RAD SA EVENTIMA:");
            Console.WriteLine();
            // Instanciranje klae Auto:
            Auto c1 = new Auto("Glof 5", 120, 10);

            // Registriranje event handlera:
            // Stara Sintaksa poziva.
            //c1.SamoStoNijeProkuhao += new Auto.AutoMotorHandler(AutoJeSkoroPokvaren);
            //c1.SamoStoNijeProkuhao += new Auto.AutoMotorHandler(AutoCeProkuhati);

            //Auto.AutoMotorHandler d = new Auto.AutoMotorHandler(AutoJePokvaren);
            //c1.Prokuhao += d;

            // nova sintaksa poziva, a pošto smo napravili klasu koja po Microsoft standardima 
            // uzima dva paramatra sada se i metode tj. tijelo metoda mjenja pa stare ne važe, 
            // te smo prinuđeni napisati nove metode:
            c1.SamoStoNijeProkuhao += AutoJeSkoroPokvaren;
            c1.SamoStoNijeProkuhao += AutoCeProkuhati;
            c1.Prokuhao += AutoJePokvaren;

            Console.WriteLine("*********** UBRZAVAM ***********");
            for(int i = 0; i < 7; i++)
            {
                c1.Ubrzanje(20);
            }

            // Izbriši AutoJePokvaren iz pozivačke liste:
            // Stara sintaksa:
            //c1.Prokuhao -= d;

            // Nova sintaksa:
            c1.Prokuhao -= AutoJePokvaren;

            Console.WriteLine("*********** UBRZAVAM ***********");
            for(int i = 0; i < 7; i++)
            {
                c1.Ubrzanje(20);
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2

            Console.WriteLine("RAD SA EVENTIMA 2:");
            Console.WriteLine();

            // Pravimo Auto klasu kao uobičajeno:
            AutoEvent c2 = new AutoEvent("Ferari F40", 330, 40);

            // Registriramo evente:
            c2.SamoStoNijeProkuhao += c2_SamoStoNijeProkuhao;
            c2.SamoStoNijeProkuhao += c2_SamoStoNijeProkuhao;
            EventHandler<AutoEventArgs> d = c2_Prokuhao;
            c2.Prokuhao += d;

            Console.WriteLine("*********** UBRZAVAM ***********");
            for(int i = 0; i < 16; i++)
            {
                c2.Ubrzanje(20);
            }


            c2.Prokuhao -= c2_Prokuhao;
           

            Console.WriteLine("*********** UBRZAVAM ***********");
            for(int i = 0; i < 10; i++)
            {
                c2.Ubrzanje(20);
            }

            #endregion


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }
        static void c2_Prokuhao(object sender, AutoEventArgs e)
        {
            if(sender is AutoEvent)
            {
                AutoEvent c = (AutoEvent)sender;
                Console.WriteLine(e.por);
            }
        }

        static void c2_SamoStoNijeProkuhao(object sender, AutoEventArgs e)
        {
            if(sender is AutoEvent)
            {
                AutoEvent c = (AutoEvent)sender;
                Console.WriteLine("-> Kritična poruka iz Auto Klase! Ime Auta: {0}, Poruka: {1}.", c.ImeAuta, e.por);
            }
        }

        private static void AutoJeSkoroPokvaren(object sender, AutoEventArgs e)
        {
            // Provjera da vidimo da li sender stvarno Auto Klasa:
            if(sender is Auto)
            {
                Auto c = (Auto)sender;
                Console.WriteLine("-> Kritična poruka iz Auto Klase! Ime Auta: {0}, Poruka: {1}.", c.ImeAuta, e.por );
            }
        }

        private static void AutoCeProkuhati(object sender, AutoEventArgs e)
        {
            // Provjera da vidimo da li sender stvarno Auto Klasa:
            if(sender is Auto)
            {
                Auto c = (Auto)sender;
                Console.WriteLine(e.por);
            }
        }

        private static void AutoJePokvaren(object sender, AutoEventArgs e)
        {
            // Provjera da vidimo da li sender stvarno Auto Klasa:
            if(sender is Auto)
            {
                Auto c = (Auto)sender;
                Console.WriteLine(e.por);
            }
        }

        #region EVENT HANDLER METODE

        private static void AutoJePokvaren(string porZaPozivaca)
        {
            Console.WriteLine(porZaPozivaca);
        }
        private static void AutoCeProkuhati(string porZaPozivaca)
        {
            Console.WriteLine(porZaPozivaca);
        }
        private static void AutoJeSkoroPokvaren(string porZaPozivaca)
        {
            Console.WriteLine("-> Kritična Poruka od Auta: {0}.", porZaPozivaca);
        }

        #endregion

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
