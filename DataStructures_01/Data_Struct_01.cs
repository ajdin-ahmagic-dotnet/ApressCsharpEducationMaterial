using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_01
{
    internal class DataStruct01
    {
        public static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                     --- DOBRODOŠLI U: Data Strukture ---                       ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; //Console.SetBufferSize(134, 100);

            #region Array Primjeri

            // Poziv Metodi ArrayPrimjer1:
            ArrayPrimjer1();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Poziv Metodi ArrayPrimjer2:
            ArrayPrimjer2();

            #endregion


            #region List Primjeri

            // Poziv Metodi ListPrimjer1

            #endregion

        }

        #region Array Metode

        public static void ArrayPrimjer1()
        {
            // Liberty Array Primjer:
            var stavke = new Stavke[5];

            // Pseudo nasumični generator klasa:
            Random ran = new Random();

            // For petlja koja postavlja nasumične brojeve u matricu:
            for(int i = 0; i < stavke.Length; i++)
            {
                stavke[i] = new Stavke(ran.Next(0, 1000000));
            }

            Console.WriteLine("Stavke: ");
            foreach(Stavke stavka in stavke)
            {
                Console.WriteLine("StavkaID: {0}", stavka.Id);
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Pristupanje Kolekciji putem indexa:
            var mojeStavke = stavke[1];
            Console.WriteLine("ID Druge stavke je: '{0}'", mojeStavke.Id);

            Stavke mojeStavke2 = stavke[4];
            Console.WriteLine("ID Druge stavke je: '{0}'", mojeStavke2.Id);
        }

        public static void ArrayPrimjer2()
        {
            var autori = new string[5];

            autori[0] = "Aydin";
            autori[1] = "Edin";
            autori[2] = "Marlena";
            autori[3] = "Jusuf";
            autori[4] = "Tahir";

            Console.WriteLine("Autori Matrica:");
            foreach(string s in autori)
            {
                Console.WriteLine("Autori: '{0}'", s);
            }

            Array.Sort(autori);


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        #endregion

        #region List Metode




        #endregion



        #region NapisiPunuCrtu40 Metoda

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.SetWindowSize(134,35);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion

    }
}
