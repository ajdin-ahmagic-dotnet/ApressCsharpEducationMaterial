using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel;
using System.Threading;

namespace BrowseFileSytem
{
   public static class ExtensionMethods
   {
       #region Skrivanje i otrkivanje datoteke, prikaz modificiranja, preimenovanje datoteka metoda...
        // Metoda koja provjerava kad je datoteka zadnji put korištena, modificirana itd...
        public static void PrikaziIzmjeneDatoteke(this FileInfo fileInfo)
        {
            Console.WriteLine("Kreirana je: {0}", fileInfo.CreationTime.ToString());
            Console.WriteLine("Zadnji Pristup: {0}", fileInfo.LastAccessTime.ToString());
            Console.WriteLine("Zadnje Pisanje: {0}", fileInfo.LastWriteTime.ToString());
        }

        // Metoda koja otrkiva da li je datoteka skrivena:
        public static void PrikaziSkrivenuDatoteku(this FileInfo fileinfo)
        {
            // Prikazujemo rezultat da li datoteka skrivena:
            Console.WriteLine("Da li je datoteka skrivena? = " + ((fileinfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden));
        }


        // Metoda koja skriva datoteke:
        public static void SakrijDatoteku(this FileInfo fileinfo)
        {
            // Modificiraj atribute ove datoteke:
            fileinfo.Attributes |= FileAttributes.Hidden;

        }


        // Metoda koja otkriva skrivene datoteke:
        public static void OtkrijDatoteku(this FileInfo fileinfo, string fi)
        {
            var attributes = File.GetAttributes(fi);
            if((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {
                attributes &= ~FileAttributes.Hidden;
                File.SetAttributes(fi, attributes);
            }
        }

        // Rename file Metoda
        public static void Rename(this FileInfo fileInfo, string novoIme)
        {
            // BITNO JE NAPOENUTI DA ZA RENAME NE POSTOJI NITI JEDNA METODA, MOVE I MOVETO METODE SE PNAŠAJU
            // KAO RENAME METODE SAMO KADA PUT OSTAJE ISTI!

            fileInfo.MoveTo(String.Format("{0}\\{1}", fileInfo.Directory.FullName, novoIme));
        }
        #endregion
 
       #region Prikaži izmjene direktorija, skrivanje i otkrivanje te preimenovanje direktorija
       [Description("Prikazuje kako prikazati kada je direktorij modiciciran i kreiran")]
       public static void PrikaziIzmjneDirektorija(this DirectoryInfo dirInfo)
       {
           Console.WriteLine("Kreiran Dir: {0}", dirInfo.CreationTime.ToString());
           Console.WriteLine("Zadnji Pris: {0}", dirInfo.LastAccessTime.ToString());
           Console.WriteLine("Zadnje Pisa: {0}", dirInfo.LastWriteTime.ToString());
       }

       [Description("Prikazuje kako preko atributa sakriti direktorij")]
       public static void PrikziDaLiJeSarkiven(this DirectoryInfo dirInfo)
       {
           Console.WriteLine("Da li je Direktorij skriven? = " + ((dirInfo.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden));
       }

       [Description("Skrivanje drektorija")]
       public static void SakrijDirektorij(this DirectoryInfo dirInfo)
       {
           dirInfo.Attributes |= FileAttributes.Hidden;
       }

       [Description("Meoda koja otkriva Direktorij")]
       public static void OtkrijDirektorij(this DirectoryInfo dirInfo, string dir)
       {
           var attributes = File.GetAttributes(dir);
           if((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
           {
               attributes &= ~FileAttributes.Hidden;
               File.SetAttributes(dir, attributes);
           }
       }

       [Description("Metoda preimenuje direktorij")]
       public static void PreimenujDirektorij(this DirectoryInfo dirInfo, string novoIme)
       {
           // BITNO JE NAPOENUTI DA ZA RENAME NE POSTOJI NITI JEDNA METODA, MOVE I MOVETO METODE SE PNAŠAJU
           // KAO RENAME METODE SAMO KADA PUT OSTAJE ISTI!
           try
           {
               // Primjenuj putem MoveTo Metode:
               dirInfo.MoveTo(novoIme);
           }
           catch(Exception ex)
           {
               Console.WriteLine(ex.Message);
           }
       }

       #endregion

       #region FILE INFO  TODISPLAYSTRING PRODUŽENA METODA

       public static string ToDisplayString(this FileSystemInfo fileSystemInfo)
       {
           string type = fileSystemInfo.GetType().ToString();
           if(fileSystemInfo is DirectoryInfo)
           {
               type = "DIREKTORIJ:";
           }
           else if(fileSystemInfo is FileInfo)
           {
               type = "FILE:";
           }

           return string.Format(Thread.CurrentThread.CurrentCulture, "{0}: {1}", type, fileSystemInfo.Name);
       }

       #endregion
   }
}
