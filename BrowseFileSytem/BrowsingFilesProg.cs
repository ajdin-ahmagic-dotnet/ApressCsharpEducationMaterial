using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;


namespace BrowseFileSytem
{
    class BrowsingFilesProg
    {

        //static System.Collections.Specialized.StringCollection log = new System.Collections.Specialized.StringCollection();
 
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║             --- DOBRODOŠLI U: '70-563' Chapter 2 Input/Output ---              ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 700);

            #region PRIMJER 1
            Console.Write("1. Da li želite pokrenuti Primjer \"Lab 1: Vježba 1 ( Browsing File System )\" DA/NE:");
            string odgovor_1 = Console.ReadLine();
            if(odgovor_1.ToLower() == "da")
            {
                // Poziv Metodi:
                BrowsingFiles();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2
            Console.Write("2. Da li želite pokrenuti Primjer \"Prikazivanje kad je Datoteka Kreirana, Modificirana i zadnji put Pristupeljeno\" DA/NE:");
            string odgovor_2 = Console.ReadLine();
            if(odgovor_2.ToLower() == "da")
            {
                Console.WriteLine("Prikaži Kad je Datoteka Kreirana, Modificirana i Zadnji put Pristupeljena:");
                Console.WriteLine("Statičnom metodom:");
                // Poziv Metodi:
                PrikaziKadjeDatotekaKreirana(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\TXT\imena1.txt");

                Console.WriteLine();


                Console.WriteLine("Extenzijskom Metodom:");

                // Kreirali smo produženu metodu u statičnoj klasi ExtensionMethods i pozivamo tu metodu na instancu varijable od FileInfo klase...
                FileInfo fi = new FileInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\TXT\imena1.txt");

                // Poziv produženoj metodi: 
                fi.PrikaziIzmjeneDatoteke();
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 3
            Console.Write("3. Da li želite pokrenuti Primjer \"Prikazivanje skrivene datoteke\" DA/NE:");
            string odgovor_3 = Console.ReadLine();
            if(odgovor_3.ToLower() == "da")
            {
                // Poziv Metodi:
                PrikaziSkrivenuDatoteku(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\SkrivenSam.txt");

                // U ovom primjeru također pozivamo produženu metodu za sakrivanje datoteka:
                Console.Write("Da li želite sakriti ovu datoteku DA/NE:");
                string odgovor = Console.ReadLine();
                if(odgovor.ToLower() == "da")
                {
                	FileInfo info = new FileInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\SakrijMe.txt");

                    info.SakrijDatoteku();
                    info.PrikaziSkrivenuDatoteku();
                }
                else
                {
                    Console.WriteLine("Odabrali ste \"NE\". Datoteka neće biti srivena.");
                }

                Console.Write("Da li želite vratiti datotreku u priješnje stanje DA/NE:");
                string odgovor2 = Console.ReadLine();
                if(odgovor2.ToLower() == "da")
                {
                    FileInfo info = new FileInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\SakrijMe.txt");

                    info.OtkrijDatoteku(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\SakrijMe.txt");
                    info.PrikaziSkrivenuDatoteku();
                }
                else
                {
                	
                }
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 4

            Console.Write("4. Da li želite pokrenuti Primjer \"Preimenovanje Datoteka\" DA/NE:");
            string odgovor_4 = Console.ReadLine();
            if(odgovor_4.ToLower() == "da")
            {
                //string filename;
                //string[] filePaths = Directory.GetFiles(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");
                //Console.WriteLine("Directory consists of " + filePaths.Length + " files.");
                //foreach(string myfile in filePaths)
                //{
                //    filename = Path.ChangeExtension(myfile, ".txt");
                //    System.IO.File.Move(myfile, filename);
                //}
               
                const string path = @"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\";
                FileInfo[] files = new DirectoryInfo(path).GetFiles("*.txt");
                for(int i = 0; i < files.Length; i++)
                {
                    string newFile = String.Format("{0}{1}.{2}", "File", (i + 1), "txt");
                    string fullNewPath = files[i].DirectoryName;
                    File.Move(files[i].FullName, Path.Combine(fullNewPath, newFile));
                    
                }
                
                

                Console.WriteLine("Da li želite vidjeti Izmjene datoteke DA/NE:");
                string enter = Console.ReadLine();
                if(enter.ToLower() == "da")
                {

                    FileInfo fileInfo = new FileInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\NovijiFile.txt");

                    fileInfo.PrikaziIzmjeneDatoteke();

                    Console.WriteLine("Ime datoteke je: {0}.", fileInfo.FullName);

                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                Console.Write("Da li želite pokrenuti Command Prompt DA/NE:");
                string odgovor = Console.ReadLine();
                if(odgovor.ToLower() == "da")
                {

                    using(Process p = new Process())
                    {
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.WorkingDirectory = @"C:\";
                        p.StartInfo.UseShellExecute = false;

                        p.Start();
                    }
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 5 - Porektanje CMD-a unutar konzole

            Console.Write("5. Da li želite pokrenuti Primjer \"Browsing Directories\" DA/NE:");
            string odgovor_5 = Console.ReadLine();
            if(odgovor_5.ToLower() == "da")
            {
                

                Console.Write("Da li želite pokrenuti Command Prompt DA/NE:");
                string odgovor = Console.ReadLine();
                if(odgovor.ToLower() == "da")
                {
                     // Ovako se pokreće CMD unutar konzole:
                    using(Process p = new Process())
                    {
                        p.StartInfo.FileName = "cmd.exe";
                        p.StartInfo.WorkingDirectory = @"C:\";
                        p.StartInfo.UseShellExecute = false;

                        p.Start();
                    }
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 6 - Direktorij - INFO, PREIMENOVANJE, SKRIVANJE, OTRKIVANJE

            Console.Write("6. Da li želite pokrenuti Primjer \"Promjene na Direktoriju\" DA/NE:");
            string odgovor_6 = Console.ReadLine();
            if(odgovor_6.ToLower() == "da")
            {
                // Poziv Metodi:
                DirectoryInfo info = new DirectoryInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");

                Console.WriteLine();
                Console.WriteLine("Informacije o Direktoriju (Produžena metoda):");

                // Sada pozivamo produženu metodu:
                info.PrikaziIzmjneDirektorija();

                Console.WriteLine();
                Console.WriteLine("Informacije o Direktoriju (Statična metoda):");
                
                // Isti efekt kao kod produžene metode, samo što je ova lokalna statična metoda...
                PrikazKadJeDirektorijKreiran(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");

                Console.Write("Da li želite sakriti ovaj Direktorij DA/NE:");
                string odgovor = Console.ReadLine();
                if(odgovor.ToLower() == "da")
                {
                    // Poziv Metodi:
                    DirectoryInfo info2 = new DirectoryInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");

                    Console.WriteLine();
                    Console.WriteLine("Informacije o Direktoriju:");

                    // Pozivamo produženu metodu da sakrije direktorij:
                    info2.SakrijDirektorij();

                    Console.WriteLine("Prikaz putem produžene metode:");
                    // Pozivamo produženu metodu da vidimo da li je direktorij zaista skriven:
                    info2.PrikziDaLiJeSarkiven();

                    Console.WriteLine();
                    Console.WriteLine("Prikaz putem obične statične metode:");
                    PrikaziSkriveniDirektorij(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                Console.Write("Da li želite otkriti Direktorij DA/NE:");
                string odgovor2 = Console.ReadLine();
                if(odgovor2.ToLower() == "da")
                {
                    // Poziv Metodi:
                    DirectoryInfo info3 = new DirectoryInfo(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");

                    Console.WriteLine();
                    Console.WriteLine("Informacije o Direktoriju:");

                    // Poziv produženoj metodi koja uzima string tog puta direkrorija kao parametar:
                    info3.OtkrijDirektorij(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");

                    Console.WriteLine("Prikaz putem produžene metode:");
                    // Produžena metoda prikazuje stanje direktorija:
                    info3.PrikziDaLiJeSarkiven();

                    Console.WriteLine();
                    Console.WriteLine("Prikaz putem obične statične metode:");
                    PrikaziSkriveniDirektorij(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\BrowseFileSytem\TXT\");

                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }


                Console.Write("Da li želite preimenovati Direktorij DA/NE:");
                string odgovor3 = Console.ReadLine();
                if(odgovor3.ToLower() == "da")
                {
                    Console.WriteLine();
                    Console.WriteLine("Poziv Statičnoj Metodi:");
                    PreimenujDirektorij(@"../../TXT", @"../../TXTNew"); // Statična metoda.

                    PrikaziKadjeDatotekaKreirana(@"../../TXT"); // Statična metoda...

                    Console.WriteLine();

                    // Sada idemo na produžene metode:
                    Console.WriteLine("Poziv Produženoj Metodi:");

                    DirectoryInfo dirInfo = new DirectoryInfo(@"../../TXT");

                    dirInfo.PreimenujDirektorij(@"../../TXT_1");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 7 - Direktorij - Pretraživanje Direktorija i Datoteka koristeći "Wildcards"

            Console.Write("7. Da li želite pokrenuti Primjer \"Pretraživanje Direktorija i Datoteka\" DA/NE:");
            string odgovor_7 = Console.ReadLine();
            if(odgovor_7.ToLower() == "da")
            {
                // Poziv Metodi:
                Console.Write("Prikaži sve Direktroije i Datoteke DA/NE:");
                string odgovor = Console.ReadLine();
                if(odgovor.ToLower() == "da")
                {
                    // Poziv Metodi:
                    PrikaziDatotekeIPodDirektorije(@"C:\Users\Wylde\Pictures");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("Prikaži sve Pod Direktorije DA/NE:");
                string odgovor2 = Console.ReadLine();
                if(odgovor2.ToLower() == "da")
                {
                    // Poziv Metodi:
                    PrikaziPodDirektorije(@"C:\Users\Wylde\Downloads");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("Prikaži sve Datoteke DA/NE:");
                string odgovor3 = Console.ReadLine();
                if(odgovor3.ToLower() == "da")
                {
                    // Poziv Metodi:
                   PrikaziDatoteke(@"C:\Users\Wylde\Downloads");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("Prikaži sve Sadržaj Direktorije DA/NE:");
                string odgovor4 = Console.ReadLine();
                if(odgovor4.ToLower() == "da")
                {
                    // Poziv Metodi:
                   PrikaziSadrzajDirektorija(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("Prikaži Direktorije DA/NE:");
                string odgovor5 = Console.ReadLine();
                if(odgovor5.ToLower() == "da")
                {
                    // Poziv Metodi:
                    PrikaziDirektorije(@"C:\Users\Wylde\Downloads");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("Prikaži sve Datoteke DA/NE:");
                string odgovor6 = Console.ReadLine();
                if(odgovor6.ToLower() == "da")
                {
                    // Poziv Metodi:
                    PrikaziDatotekeInfo(@"C:\Users\Wylde\Downloads");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("Prikaži sve Datoteke I Direktorije DA/NE:");
                string odgovor7 = Console.ReadLine();
                if(odgovor7.ToLower() == "da")
                {
                    // Poziv Metodi. Ovako možemo svim ostalim metodma zadati uvjet da traže samo određene datoteke u dirktorijima.
                    PrikaziDatotekeIDirektorije(@"C:\", "*.txt");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }
             
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 8 - Dobavljanje Direktorijskog Stabla

            Console.Write("8. Da li želite pokrenuti Primjer \"Dobavljanje Direktorijskog Stabla\" DA/NE:");
            string odgovor_8 = Console.ReadLine();
            if(odgovor_8.ToLower() == "da")
            {
                Console.Write("1. Prokreni Dobavi sve Datoteke iz \"Pictures\" Direktorija DA/NE:");
                string odgovor = Console.ReadLine();
                if(odgovor.ToLower() == "da")
                {
                    // Poziv Metodi:
                    PrikaziSveDatotekeIDirektorije(@"C:\Users\Wylde\Pictures");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                Console.Write("1. Prokreni Dobavi sve \"PNG\" Datoteke iz \"Pictures\" Direktorija DA/NE:");
                string odgovor2 = Console.ReadLine();
                if(odgovor2.ToLower() == "da")
                {
                    // Poziv Metodi:
                    PrikaziSvePNGSlike(@"C:\Users\Wylde\Pictures", ".jpg");
                }
                else
                {
                    Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
                }
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }

           
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 9 - Vraćanje podataka o datoteci ili direktoriju preko args-a ( Implementacija mora biti u Main-u )

            Console.Write("9. Da li želite pokrenuti Primjer \"Vraćanje podataka o direktoriju i Datotekama preko args-a\" DA/NE:");
            string odgovor_9 = Console.ReadLine();
            if(odgovor_9.ToLower() == "da")
            {
                Console.WriteLine(@"Upišite ime Diska\Direktorija\Datoteke: ");
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
                    Console.WriteLine(file.CreationTime.ToString());
                    Console.Write("Datoteka Ažurirana: ");
                    Console.WriteLine(file.LastWriteTime.ToString());
                    Console.Write("Datoteka Pristupljena:");
                    Console.WriteLine(file.LastAccessTime.ToString());
                    Console.Write("Datoteka Veličine: ");
                    Console.WriteLine(file.Length.ToString());
                    Console.Write("Atributi Datoteke: ");
                    Console.WriteLine(file.Attributes.ToString());
                }
                Console.WriteLine();

                // Prikaži Informacije Direktorija:
                DirectoryInfo dir = file.Directory;

                Console.WriteLine("Provjera Direktorija: {0}", dir.Name);
                Console.WriteLine("U Direktoriju: {0}", dir.Parent.Name);
                Console.Write("Direktorij postoji: ");
                Console.WriteLine(dir.Exists.ToString());

                if(dir.Exists)
                {
                    Console.Write("Direktroij Kreiran: ");
                    Console.WriteLine(dir.CreationTime.ToString());
                    Console.Write("Direktorij Ažuriran: ");
                    Console.WriteLine(dir.LastWriteTime.ToString());
                    Console.Write("Direktorij Pristupljen:");
                    Console.WriteLine(dir.LastAccessTime.ToString());
                    Console.Write("Atributi Direktorija: ");
                    Console.WriteLine(dir.Attributes.ToString());
                    Console.Write("Direktorij Sadrži: ");
                    Console.WriteLine(dir.GetFiles().Length.ToString() + " datoteke");
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
            }
            else
            {
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        #region LAB - Vježba 1 ( Browsing the file system )

        [Description("Metoda čini više stvari prvo izlistava sve diskove, onda nam daje izbor i pregleda cijeli disk koji smo odabrali.")]
        static void BrowsingFiles()
        {
            // Pišemo na konzolu broj particija diska:
            Console.WriteLine("Diskovi:");
            
            // Iteriramo kroz kolekciju:
            foreach(DriveInfo di in DriveInfo.GetDrives())
            {
                Console.WriteLine("  {0} ({1})", di.Name, di.DriveType);
            }

            // alje promtiramo korisnika da selektira volume i traži i koristi input da kreira
            // "DirectoryInfo" instancu:

            Console.WriteLine("\nPritisni slovo Diska da pretražiš mape i datoteke:");
            ConsoleKeyInfo drive = Console.ReadKey(true);
            DirectoryInfo dir = new DirectoryInfo(drive.Key.ToString() + @":\");

            // Sada nam treba kod da prikažemo sadržaj mape (folder-a):

            Console.WriteLine("\nMape:");
            foreach(DirectoryInfo dirInfo in dir.GetDirectories())
            {
                Console.WriteLine("  " + dirInfo.FullName);
            }

            // I konačno kod koji prikazuje datoteke u korijenu selektirane particije:
            Console.WriteLine("\nDatoteke:");
            foreach(FileInfo fi in dir.GetFiles())
            {
                Console.WriteLine("  " + fi.FullName);
            }

           
            
        } 

        #endregion

        #region PRIMJER 2 - prikaži kad je datoteka kreirana, modificirana, i zadnji put pristupljena

        [Description("Metoda prikazuje kad je datoteka kreirana, modificirana i zadnji put pristupljena.")]
        static void PrikaziKadjeDatotekaKreirana(string put)
        {
            // Kad je datoteka kreirana:
            Console.WriteLine("Kreirana je: {0}", File.GetCreationTime(put)); 

            // Kad je zadnji put pristupljeno datoteci:
            Console.WriteLine("Zadnji pristup: {0}", File.GetLastAccessTime(put));

            // Kad je zadnji put pisano u datoteku:
            Console.WriteLine("Zadnje Pisanje: {0}", File.GetLastWriteTime(put));
        }

        #endregion

        #region PRIMJER 3 - Prikazivanje skrivenih datoteka 

        [Description("Metoda koja otkriva da li je datoteka skrivena.")]
        static void PrikaziSkrivenuDatoteku(string put)
        {
            // Ovako prikazujemo datodeke koje je system skrio od nas.
            // prvo provjeravamo da li datoteka postoji:
            if(File.Exists(put))
            {
                // Ako postoji onda tražimo info od FileInfo klase:
                FileInfo info = new FileInfo(put);

                // Prikazujemo rezultat da li datoteka skrivena:
                Console.WriteLine("Da li je datoteka skrivena? = " + ((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden));
            }


        }

        #endregion

        #region PRIMJER 4 - Preimenuj Datoteku Metoda

        private static string GetNewFileName(FileInfo fleInfo)
        {
            var shortDate = DateTime.Now.ToShortDateString().Replace("/", string.Empty);
            var timeInMilliSec = DateTime.Now.Millisecond.ToString();
            var format = string.Format("{0}_{1}", shortDate, timeInMilliSec);
            var extension = ".txt";
            return Path.Combine(fleInfo.DirectoryName,
            string.Concat(fleInfo.Name.Split('.')[0], "_", format, extension));
        }
        static string GetNextFileName(string baseFileName)
        {
            var result = baseFileName;
            var fileNamePart = System.IO.Path.GetFileNameWithoutExtension(baseFileName);
            var extensionPart = System.IO.Path.GetExtension(baseFileName);
            var currentCount = 1;

            while(System.IO.File.Exists(result))
            {
                result = string.Format("{0} ({1}){2}",
                                       fileNamePart, ++currentCount, extensionPart);
            }

            return result;
        }
        #endregion

        #region PRIMJER 5 -- NEMA IMPLEMENTACIJE OVDJE --
     
     
      
 
        #endregion

        #region PRIMJER 6 - PRIKAZ KREIRANJA DIREKTORIJA, SKRIVANJE, OTKRIVANJE

        [Description("Statična metoda koja prikazuje kreiranje direktorija i modificiranje.")]
        static void PrikazKadJeDirektorijKreiran(string put)
        {
            Console.WriteLine("Kreiran Dir: {0}", Directory.GetCreationTime(put));
            Console.WriteLine("Zadnji Pris: {0}", Directory.GetLastAccessTime(put));
            Console.WriteLine("Zadnje Pisa: {0}", Directory.GetLastWriteTime(put));
        }

        [Description("Prikaz da li Direktorij skriven statična obična metoda.")]
        static void PrikaziSkriveniDirektorij(string put)
        {
            // Prvo provjeravamo da li direktorij zaista postoji:
            if(Directory.Exists(put))
            {
                DirectoryInfo info = new DirectoryInfo(put);

                // Sada prikazujemo da li direktorij zaista skriven.
                Console.WriteLine("Da li direktorij skriven? = " + ((info.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden));
            }
        }

        [Description("Metoda za preimenovanje direktorija")]
        static void PreimenujDirektorij(string originalIme, string novoIme)
        {
            try
            {
                // Preimenuj Direktorij:
                Directory.Move(originalIme, novoIme);
            }
            catch(Exception ex)
            {
                // Vjerovatno da će dani direktorij već postojati ili nije prazan, ali opet...
                Console.WriteLine(ex.Message);
            }
        }

        #endregion

        #region PRIMJER 7 - Direktorij - Pretraživanje Direktorija i Datoteka koristeći "Wildcards"
        [Description(@"Ova Metoda poziva GetFileSystemEntries od Directory klase i vraća array sadržavajući imena svih datoteka i direktorija unuraj jednog direktorija")]
        static void PrikaziDatotekeIPodDirektorije(string put)
        {
            string[] stavke = Directory.GetFileSystemEntries(put);

            foreach(string stavka in stavke)
            {
                Console.WriteLine(stavka);
            }
        }

        [Description(@"Ova Metoda poziva GetDirectories metodu od Directory klase koja vraća array sadržavajući imena svih direktorija unutar jednog direktorija.")]
        static void PrikaziPodDirektorije(string put)
        {
            string[] stavke = Directory.GetDirectories(put);

            foreach(string stavka in stavke)
            {
                Console.WriteLine(stavka);
            }
        }

        [Description("Ova Metoda je sličan GetDirectories metodi smo što ona prikazuje Datoteke unutar nekog Direktorija.")]
        static void PrikaziDatoteke(string put)
        {
            string[] stavke = Directory.GetFiles(put);

            foreach(string stavka in stavke)
            {
                Console.WriteLine(stavka);
            }
        }

        [Description("Metoda prikazuje sve datoteke pozivajući GetFilesSystemInfo metodu koja vraća array od fileSystemInfo objekata reprezentirajući sve u direktoriju.")]
        static void PrikaziSadrzajDirektorija(string put)
        {
            DirectoryInfo glDir = new DirectoryInfo(put);

            IEnumerable<string> datSustavPrikazInfo = from dspi in glDir.GetFileSystemInfos()
                                                      where dspi is FileSystemInfo || dspi is DirectoryInfo
                                                      select dspi.ToString();

            foreach(string s in datSustavPrikazInfo)
            {
                Console.WriteLine("Direktorij: {0}", s);
            }
        }

        [Description("Metoda varaća array od DirectoryInfo objekata reprezentirajući samo pod direktorije u jednom direktoriju.")]
        static void PrikaziDirektorije(string put)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(put);
            DirectoryInfo[] stavke = dirInfo.GetDirectories();

            foreach(DirectoryInfo di in stavke)
            {
                Console.WriteLine("DIREKTORIJ: {0}", di);
            }
        }

        [Description("Metoda vraća array od FileInfo objekata reprezentirajući samo datoteke u jednom direktoriju.")]
        private static void PrikaziDatotekeInfo(string put)
        {
            DirectoryInfo glDir = new DirectoryInfo(put);
            FileInfo[] stavke = glDir.GetFiles();

            foreach(FileInfo stavka in stavke)
            {
                Console.WriteLine("DATOTEKE: {0}", stavka);
            }
        }

        [Description("Metoda koja vraća Directory klasu i sve datoteke i direktorije unutar jednog direktorija ako zadovolji uvjet.")]
        static void PrikaziDatotekeIDirektorije(string put, string uvjet)
        {
            string[] stavke = Directory.GetFileSystemEntries(put, uvjet);

            foreach(string stavka in stavke)
            {
                Console.WriteLine(stavka);
            }
        }

        #endregion

        #region PRIMJER 8 - Direktorij - Dobavljanje Direktorijskog Stabla
        [Description("Metoda kojom pozivanjem GetFileSystemInfos možemo dobiti sve datoteke i direktorije u hirerarhiji od bilo koje polazne točke.")]
        static IEnumerable<FileSystemInfo> DajSveDirektorijeIDatoteke(string dir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(dir);

            Stack<FileSystemInfo> stack = new Stack<FileSystemInfo>();

            stack.Push(dirInfo);
            while(dirInfo != null || stack.Count > 0)
            {
                FileSystemInfo fileSystemInfo = stack.Pop();
                DirectoryInfo podDirectoryInfo = fileSystemInfo as DirectoryInfo;

                if(podDirectoryInfo != null)
                {
                    yield return podDirectoryInfo;

                    foreach(FileSystemInfo fsi in podDirectoryInfo.GetFileSystemInfos())
                    {
                        stack.Push(fsi);
                    }
                    dirInfo = podDirectoryInfo;
                }
                else
                {
                    yield return fileSystemInfo;
                    dirInfo = null;
                }
            }
        }

        [Description("Da dobijemo rezultate treba nam ova metoda...")]
        static void PrikaziSveDatotekeIDirektorije(string dir)
        {
            var strings = from fileSystemInfo in DajSveDirektorijeIDatoteke(dir)
                          select fileSystemInfo.ToString();

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        [Description("Da filtriramo neke od datoteka možemo primjeniti ovu metodu sa filtrom za *.png slike")]
        static void PrikaziSvePNGSlike(string dir, string extension)
        {
            var strings = from fileSystemInfo in DajSveDirektorijeIDatoteke(dir)
                          where fileSystemInfo is FileInfo && fileSystemInfo.FullName.Contains("Stan slike") &&
                          (string.Compare(fileSystemInfo.Extension, extension, StringComparison.OrdinalIgnoreCase) == 0)
                          select fileSystemInfo.ToString();

            foreach(string s in strings)
            {
                Console.WriteLine(s);
            }
        }

        #endregion

        

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
