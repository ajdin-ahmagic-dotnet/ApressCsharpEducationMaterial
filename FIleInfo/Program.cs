using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FIleInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║            --- DOBRODOŠLI U: 'REVIZIJU' LINQ Preko Matrica ---                 ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region Primjer
            Console.WriteLine("Upišite ime Datoteke: ");
            string odg = Console.ReadLine();
            if(odg.ToLower() == Console.ReadLine())
            {
                //Console.WriteLine("Molim vas dajte nam ime datoteke:");
                return;
            }

            // Prikaži Inforamcije:
            FileInfo file = new FileInfo(odg);

            Console.WriteLine("Provjera datoteke: {0}", file.Name);
            Console.WriteLine("Datoteka postoji: {0}", file.Exists.ToString());

            if(file.Exists)
            {
                Console.Write("Datoteka Kreirana: ");
                Console.WriteLine(file.CreationTime.ToString(CultureInfo.InvariantCulture));
                Console.Write("Datoteka Ažurirana: ");
                Console.WriteLine(file.LastWriteTime.ToString(CultureInfo.InvariantCulture));
                Console.Write("Datoteka Pristupljena:");
                Console.WriteLine(file.LastAccessTime.ToString(CultureInfo.InvariantCulture));
                Console.Write("Datoteka Veličine: ");
                Console.WriteLine(file.Length.ToString());
                Console.Write("Atributi Datoteke: ");
                Console.WriteLine(file.Attributes.ToString());
            }
            Console.WriteLine();

            // Prikaži Informacije Direktorija:
            DirectoryInfo dir = file.Directory;

            if (dir != null)
            {
                Console.WriteLine("Provjera Direktorija: {0}", dir.Name);
                if (dir.Parent != null) Console.WriteLine("U Direktoriju: {0}", dir.Parent.Name);
                Console.Write("Direktorij postoji: ");
                Console.WriteLine(dir.Exists.ToString());

                if (dir.Exists)
                {
                    Console.Write("Direktroij Kreiran: ");
                    Console.WriteLine(dir.CreationTime.ToString(CultureInfo.InvariantCulture));
                    Console.Write("Direktorij Ažuriran: ");
                    Console.WriteLine(dir.LastWriteTime.ToString(CultureInfo.InvariantCulture));
                    Console.Write("Direktorij Pristupljen:");
                    Console.WriteLine(dir.LastAccessTime.ToString(CultureInfo.InvariantCulture));
                    Console.Write("Atributi Direktorija: ");
                    Console.WriteLine(dir.Attributes.ToString());
                    Console.Write("Direktorij Sadrži: ");
                    Console.WriteLine(dir.GetFiles().Length.ToString() + " datoteke");
                }
            }

            Console.WriteLine();

            // Prikaži informacije Diska:
            DriveInfo drv = new DriveInfo(file.FullName);

            Console.Write("Disk: ");
            Console.WriteLine(drv.Name);

            if(drv.IsReady)
            {
                Console.Write("Disk Tipa: ");
                Console.WriteLine(drv.DriveType.ToString());
                Console.Write("Disk Format: ");
                Console.WriteLine(drv.DriveFormat.ToString());
                Console.Write("Disk Slobodni Prostor: ");
                Console.WriteLine(drv.AvailableFreeSpace.ToString());

            }
            #endregion

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region Napisi Punu Crtu Metoda
        private static void NapisiPunuCrtu(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
        #endregion
    }
}
