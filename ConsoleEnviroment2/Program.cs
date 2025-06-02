using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEnviroment2
{
    class Program
    {
        enum ZaposlenikTip
        {
            Menadzer,
            Ekonomista,
            Programer,
            Direktor
        }

        enum Zaptip : byte
        {
            Mendzer = 101,
            Ekonomist,
            programer, 
            Direktor
        }

        enum Volumen : byte
        {
            VrloJako,
            Jako,
            Srednje,
            Slabo,
            JakoSlabo
        }

        /// <summary>
        /// Nastavak sa preošle seanse se ovjde nastavlja...
        /// Krećemo sa enumeracijama i strukturama ovdje.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region CORE PROGRAMMING - DIO 2 (nastavak)

            #region ENUMERACIJE PRIMJER
            Console.WriteLine("=> ENUMERIAJE PRIMJER:");
            Console.WriteLine();
            ZaposlenikTip zap = ZaposlenikTip.Programer;
            TraziBonus(zap);

            #endregion// ENUMERACIJE PRIMJER

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region ENUMERACIJE PRIMJER 2
            Console.WriteLine("=> ENUMERIAJE PRIMJER 2:");
            Console.WriteLine();
            ZaposlenikTip zap2 = ZaposlenikTip.Ekonomista;
            TraziBonus(zap2);
            Console.WriteLine("ZaposlenikTip korišten {0} za pohranu.", Enum.GetUnderlyingType(zap2.GetType()));
            // Za preciznije dobavljanje metapodataka bolje je koristi "typeof" zato što ona ne moramo dati 
            // varijablu traženog entiteta npr.
            Console.WriteLine("ZaposlenikTip korišten {0} za pohranu.", Enum.GetUnderlyingType(typeof(ZaposlenikTip)));
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region ENUMERACIJE PRIMJER 3
            // Jedan malo kompleksnije prikaz enumeracija.
            DajEnumeracijuOdKorisnika();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region ENUMERACIJE PRIMJER 4
            Console.WriteLine("ENUMERACIJE PRIMJER KADA ŽELIMO VIJEDTI VRIJEDNOST KOJU IMA STRING U ENUMERACIJI:");
            Console.WriteLine();
            Zaptip zTip = Zaptip.Ekonomist;
            Console.WriteLine("{0} = {1}", zTip.ToString(), (byte)zTip);
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion



            #endregion// CORE PROGRAMMING - DIO 2 (nastavak)


            Console.ReadKey();
        }

        #region M E T O D E


        #region ENUMERACIJE

        static void TraziBonus(ZaposlenikTip e)
        {
            switch(e)
            {
                case ZaposlenikTip.Menadzer:
                    Console.WriteLine("A može li neka druga opcija?");
                    break;
                case ZaposlenikTip.Ekonomista:
                    Console.WriteLine("Ti bar imaš para, ti sa njima radiš, ne može bonus!");
                    break;
                case ZaposlenikTip.Programer:
                    Console.WriteLine("Joj ti po cijeli dan samo radiš, mislim da bi ti dobro došlo malo povišice!");
                    break;
                case ZaposlenikTip.Direktor:
                    Console.WriteLine("Pa direktore dragi, jedino da nam sve uzmete, šta vi još možete dobiti?");
                    break;
            }
        }

        static void DajEnumeracijuOdKorisnika()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Opcije Glasnoće:");
            Console.WriteLine("----------------------");

            Console.Write(@"
                1. VrloJako
                2. Jako
                3. Srednje
                4. Slabo
                5. JakoSlabo Molim selektirajte jednu od navedenih opcija (1, 2, 3, 4, 5): ");

            string glasnocaOpcije = Console.ReadLine();
            int volInt = Int32.Parse(glasnocaOpcije);

            Volumen mojVolumen = (Volumen)volInt;

            Console.WriteLine();

            switch(mojVolumen)
            {
                case Volumen.VrloJako:
                    Console.WriteLine("Volumen je na Vrlo Jakom!");
                    break;
                case Volumen.Jako:
                    Console.WriteLine("Volumen je na Jakom.");
                    break;
                case Volumen.Srednje:
                    Console.WriteLine("Volumen je na Srednjem.");
                    break;
                case Volumen.Slabo:
                    Console.WriteLine("Volumen je na Slabom.");
                    break;
                case Volumen.JakoSlabo:
                    Console.WriteLine("Volumen je na Jako Slabom.");
                break;
            }


        }

        #endregion



        #endregion// M E T O D E

    }
}
