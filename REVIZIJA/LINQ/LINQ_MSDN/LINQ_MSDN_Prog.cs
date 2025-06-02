using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_MSDN
{
    class LINQ_MSDN_Prog
    {
        #region Main
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║                 --- DOBRODOŠLI U: 'REVIZIJU' LINQ MSDN ---                     ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1
            Console.Write("Da li želite pokrenuti Primjer \"Izbroj koliko puta se riječ pojavljuje u stringu\" DA/NE:");
            string odgovor_1 = Console.ReadLine();
            if(odgovor_1.ToLower() == "da")
            {
                // Poziv Metodi:
                IzbrojRijeciUStringu();
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

            #region Primjer 2
            Console.Write("Da li želite pokrenuti Primjer \"Upiti za recenice koje sadrže određene riječi\" DA/NE:");
            string odgovor_2 = Console.ReadLine();
            if(odgovor_2.ToLower() == "da")
            {
            	// Odličan način kako naći rečenicu po određenim kriterijima zadanim u upitu.
                PronadjiRecenicu();
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

            Console.Write("Da li želite pokrenuti Primjer \"Query-Upit za slova i brojeve u stringu\" DA/NE:");
            string odgovor_3 = Console.ReadLine();
            if(odgovor_3.ToLower() == "da")
            {
                // Poziv Metodi:
                UpitZaKaraktereUStringu();
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
            Console.Write("Da li želite pokrenuti Primjer \"Nađi Set razliku između dvije liste\" DA/NE:");
            string odgovor_4 = Console.ReadLine();
            if(odgovor_4.ToLower() == "da")
            {
                // Poziv Metodi:
                PronadjiRazlikeUListama();
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

            #region PRIMJER 5

            Console.Write("Da li želite pokrenuti Primjer \"Sortiranje i filtriranje bilo kojeg teksta Excel format\" DA/NE:");
            string odgovor_5 = Console.ReadLine();
            if(odgovor_5.ToLower() == "da")
            {
                // Poziv Metodi:
                SortFilterExcelText();
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

            #region PRIMJER 6
            Console.Write("Da li želite pokrenuti Primjer \"Preuredi Polja razdvojene datoteke tj. posloži po redosljedu\" DA/NE:");
            string odgovor_6 = Console.ReadLine();
            if(odgovor_6.ToLower() == "da")
            {
                // Poziv Metodi:
                PreurediPolja();
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

            #region PRIMJER 7
            Console.Write("Da li želite pokrenuti Primjer \"Spoji i sortiraj String Kolekcije\" DA/NE:");
            string odgovor_7 = Console.ReadLine();
            if(odgovor_7.ToLower() == "da")
            {
                // Poziv Metodi:
                KomparacijaStringKolekcija();
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

            #region PRIMJER 8

            Console.Write("Da li želite pokrenuti Primjer \"Punjenje Obejktnih Kolekcija sa Različitim izvornim datotekama\" DA/NE:");
            string odgovor_8 = Console.ReadLine();
            if(odgovor_8.ToLower() == "da")
            {
                // Poziv Metodi:
                KolekcijeIzRazlicitihIzvora();
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

            #region PRIMJER 9
            Console.Write("Da li želite pokrenuti Primjer \"Podjeli Datoteku u Više Manjih Datoteka Koristeći Grupe\" DA/NE:");
            string odgovor_9 = Console.ReadLine();
            if(odgovor_9.ToLower() == "da")
            {
                // Poziv Metodi:
                PodjeliSaGrupama();
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
        #endregion

        #region PRIMJER 1 Metoda- Izboj koliko se puta određena riječ pojavljuje u string-u

        static void IzbrojRijeciUStringu()
        {
            string text = @"Historically, the world of data and the world of objects C#" +
            @" have not been well integrated. Programmers work in C# or Visual Basic" +
            @" and also in SQL or XQuery. On the one side are concepts such as classes," +
            @" objects, fields, inheritance, and .NET Framework APIs. On the other side" +
            @" are tables, columns, rows, nodes, and separate languages for dealing with C#" +
            @" them. Data types often require translation between the two worlds; there are" +
            @" different standard functions. Because the object world has no notion of query with C#, a" +
            @" query can only be represented as a string without compile-time type checking or" +
            @" IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
            @" objects in memory in C# is often tedious and error-prone.";

            const string uslovTrazenja = "C#";

            // Pretvori string u array riječi:
            string[] izvor = text.Split(new char[] { '.', ',', '!', '?', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);
            
            // Kreiraj upit. Koristi ToLowerInvariant da podudariš "data" sa "Data":
            var podudarniUpit = from rijec in izvor
                        where rijec.ToLowerInvariant() == uslovTrazenja.ToLowerInvariant()
                        select rijec;

            // Izbroj podudaranja, koji izvršavaju upit.
            int brojRijeci = podudarniUpit.Count();
            Console.WriteLine("{0} pojavljivanja riječi od traženog upita je nađeno \"{1}\".", brojRijeci, uslovTrazenja );


            
        }

        #endregion

        #region PRIMJER 2 Metoda - Nađi rečenicu sa zadanim riječima u string-u

        static void PronadjiRecenicu()
        {
            string text = @"Kad bih samo dobio posao u firmi koja je volja da ulaže dalje u mene jer ja imam veliki potencijal u to znam." +
                @"Strašno je što već na dva razgovora sam bio i nisam uspio ništa da napravim zamrznem se kao biljka i sve je ukočeno mozak mi ne radi." +
                @"Ja sam Visual C# programer i ASP.NET programer ali sam jako puno vremena izgubio na gluposti, veliki razlog moje sjebaje su žene kad sam." +
                @"Trebao da budem na čvrstim nogama i da se fokusiram na programiranje uvjek mi neka žena uleti i sve mi sjebe, jer ona traži da se o njoj brineš." +
                @"da je jebeš i ako nisi za to, onda nastaju veliki problemi za tebe, jer onda se dodatno frustriram i sve polako opet kreće da propada." +
                @"Što se programiranja tiče da sam kad sam krenuo 2006 godine nastavio pravom stazom sad bi imao BMW najnovijeg kuću ženu i najmanje dvoje svoje djece!" +
                @"A sad nije da se žalim ja Marlenu jako volim, ali ta djeca mi smetaju i ona praktički ne ostavlja prostora da meni rodi djete što me sjebaje dodatno" +
                @"Tako da vjerujem da će ovaj brak doći vrlo brzo do velike krize koju će morati ili preživiti nekako ili će se raspasti kao i sve do sada...";


            // Prepolovi text blok u array rečenica...
            string[] recenice = text.Split(new char[] { '.', ',', '!', '?' });

            // Definiraj uslove traženja. Ova lista takođe može biti dinamično napunjena u run-timeu.
            string[] nadjiRijeci = { "programiranje", "žena" };

            // Nađi rečenice koje se poklapaju sa traženim riječima. 
            // Dase primjetiti da broj uslova traženja nije specificiran u kopajl-vremenu.
            var recenicaUpit = from recenica in recenice
                        let w = recenica.Split(new char[] {'.', ',', '?', '!', ' ', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)
                        where w.Distinct().Intersect(nadjiRijeci).Count() == nadjiRijeci.Count()
                        select recenica;

            Console.WriteLine("Rezultati traženja rečenice koja sadrži riječi koje smo zadali u tražilici:");
            Console.WriteLine();

            // Izvrši upit. Da se primjetiti da se može explicitno upisati
            // iteracijska varijabla iako je recenicaUpit implicitno tipirana.
            foreach(string str in recenicaUpit)
            {
                Console.WriteLine(str);
            }
        }

        #endregion

        #region PRIMJER 3 Metoda - Upit za karaktere u stringu

        #region UpitZaKaraktereUStringu
        static void UpitZaKaraktereUStringu()
        {
            const string aString = "ABCDEF987-J83-12-86A-ASD23DFG";

            Console.WriteLine("Ovaj string sadrži: {0}", aString);
            Console.WriteLine();

            #region Selektiraj samo brojeve u stringu upit 

            // Selektiraj samo one karaktere koji imaju brojeve:
            IEnumerable<char> stringUpit = from ch in aString
                                           where Char.IsDigit(ch)
                                           select ch;

            // Izvrši upit - query:
            foreach(char c in stringUpit)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine();

            // Pozovi Count() metodu na postojeći upit-query:
            int brojBrojeva = stringUpit.Count();

            // Ispiši na konzolu koliko je to brojeva u stringu:
            Console.WriteLine("Broj brojeva u stringu je: {0}", brojBrojeva);
            Console.WriteLine();

            #endregion

            #region Selektiraj sva slova u string upit 
            // Selektiraj sva slova u stringu:
            IEnumerable<char> stringUpit3 = from ch in aString
                                            where Char.IsLetter(ch)
                                            select ch;

            // Pozovi Count() Metodu da izbrojiš sva slova u stringu:
            int brojSlova = stringUpit3.Count();



            // Izvrši upit - query:
            foreach(char c in stringUpit3)
            {
                Console.Write(c);
            }

            Console.WriteLine();

            Console.WriteLine("Broj slova u stringu je: {0}", brojSlova);
            Console.WriteLine();
            #endregion

            #region TakeWhile Metoda
            Console.WriteLine("Selektiraj sve do prve povlake:");

            // Selektiraj sve karaktere prije prvog "-":
            IEnumerable<char> stringUpit2 = aString.TakeWhile(c => c != '-');


            // Izvrši drugi upit - query:
            foreach(char c in stringUpit2)
            {
                Console.Write(c);
            }

            Console.WriteLine();

            #endregion

            #region Take Metoda 
            Console.WriteLine("Selektiraj prvih 20 karaktera stringa:");

            // Selektiraj sve karaktere prije prvog "-":
            IEnumerable<char> stringUpit4 = aString.Take(20);


            // Izvrši drugi upit - query:
            foreach(char c in stringUpit4)
            {
                Console.Write(c);
            }

            #endregion
        }
        #endregion

        #endregion

        #region PRIMJER 4 Metoda - Pronadji Razlike U Listama
        private static void PronadjiRazlikeUListama()
        {

            // Array imena smještenih u .txt file:
            string[] names1 = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\names1.txt", Encoding.Default);
            string[] names2 = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\names2.txt", Encoding.Default);

            // Kreiraj upit- query. Da se primjetiti da se metodna sintaksa mora koristiti ovdje:
            IEnumerable<string> razlikeUpit = names1.Except(names2);

            // Izvrši upit-query:
            Console.WriteLine("Iduća imena su u \"names1.txt\" ali ne i u \"names2.txt\".");
            Console.WriteLine();

            foreach(string s in razlikeUpit)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ \"Concat()\" Metoda spaja dvije liste:");
            Console.WriteLine();
            // LINQ Concat metoda spaja dvije liste, matrice itd...
            var rezultat = names1.Concat(names2);

            foreach(string s in rezultat)
            {
                Console.WriteLine(s);
            }
            
            
        }
        #endregion

        #region PRIMJER 5 Metoda - Sortiraj i Filtriraj bilo koji Textuatlni podatak iz excela po bilo kojoj riječi u polju

        static void SortFilterExcelText()
        {
            // Kreiraj IEnumerable izvor podataka:
            string[] bodovi = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\bodovi.csv.txt");

            // Promjeni ovo u bilo koju vrijednost od 0 do 4:
            int sortPolje = 0;

            Console.WriteLine("Sortiraj naveće do najmanje po poljima: [{0}]", sortPolje);
            
            // Demostirira kako vratiti upit od metode.
            // Upit se izvršava ovdje:
            foreach(string str in PokreniUpit(bodovi, sortPolje))
            {
                Console.WriteLine(str);
            }

        }

        static IEnumerable<string> PokreniUpit(IEnumerable<string> izvor, int broj)
        {
            // Podjeli string i sortiraj polja[broj]:
            var bodoviUpit = from linija in izvor
                             let polja = linija.Split(',')
                             orderby polja[broj] descending
                             select linija;

            return bodoviUpit;
        }
        #endregion

        #region PRIMJER 6 Metoda - Preuredi polja razdvojenog file-a zarezom.

        static void PreurediPolja()
        {
            // Kreiraj IEnumerable izvor podataka: 
            string[] linije = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\spreadsheet.csv", Encoding.Default);

            // Kreiraj upit. Stavi polje 2 prvo, onda preokreni i spoji polja o i 1 od starog polja:
            IEnumerable<string> upit = from linija in linije
                                       let x = linija.Split(',')
                                       orderby x[0]
                                       select x[0] + ", " + x[1];

            // Izvrši upit i napiši novu datoteku. Primjeti da WriteAllLines uzima string[]
            // array, pa je onda ToArray pozvan na upit:
            System.IO.File.WriteAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\spreadsheet2.csv", upit.ToArray(), Encoding.Default);

            Console.WriteLine("Spreadsheet2.csv je spremljena na disk!");

        }

        #endregion

        #region PRIMJER 7 Metoda - Kombinicija i Komaracija String Kolekcija

        static void KomparacijaStringKolekcija()
        {
            // Stavljamo Datoteke u Projekt:
            string[] datotekaA = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\names1.txt", Encoding.Default);
            string[] datotekaB = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\names2.txt", Encoding.Default);

            // Jednostavno spajanje i sortiranje:
            IEnumerable<string> spojUpit = datotekaA.Concat(datotekaB).OrderBy(s => s);

            // Prosljeđivanje upit varijable drugoj funkciji za izvršavanje:
            IzbaciUpitneRezultate(spojUpit, "Jednostavno spajanje i sortiranje. Duplikati su sačuvani:");

            Console.WriteLine();

            // Spoji i izbriši duplikatna imena bazirano na osnovnom kopareru:
            IEnumerable<string> unikImenaUpit = datotekaA.Union(datotekaB).OrderBy(s => s);

            // Prosljeđivanje upit varijable drugoj funkciji za izvršavanje:
            IzbaciUpitneRezultate(unikImenaUpit, "\"Union()\" uklanja duplikatna imena u datotekama:");

            Console.WriteLine();

            // Nai imena koja se ponavljaju u obje datoteke ( bazirano na osnovnom string komapreru):
            IEnumerable<string> zajednickaImenaUpit = datotekaA.Intersect(datotekaB);

            IzbaciUpitneRezultate(zajednickaImenaUpit, "Spoji bazirano na \"Intesect\" metodi:");

            Console.WriteLine();

            // Pronađi zajednička polja u svakoj listi. Spoji dva rezultata koristeći "Concat()", i 
            // sortiraj koristeći osnovni string komaprer:
            const string podudarnoIme = "Aydin";

            IEnumerable<string> tempUpit1 = from ime in datotekaA
                                            let i = ime.Split(' ')
                                            where i[0] == podudarnoIme
                                            select ime;

            IEnumerable<string> tempUpit2 = from ime2 in datotekaB
                                            let i2 = ime2.Split(' ')
                                            where i2[0] == podudarnoIme
                                            select ime2;

            IEnumerable<string> podudarnoImeUpit = tempUpit1.Concat(tempUpit2).OrderBy(s => s);

            IzbaciUpitneRezultate(podudarnoImeUpit, String.Format("Spajanje bazirano na parcijalnom podudaranju imena: \"{0}\":", podudarnoIme));

        }

        static void IzbaciUpitneRezultate(IEnumerable<string> upit, string poruka)
        {
            Console.WriteLine(System.Environment.NewLine + poruka);

            foreach(string stavka in upit)
            {
                Console.WriteLine(stavka);
            }

            Console.WriteLine("{0} Sva imena na listi.", upit.Count());
        }

        #endregion

        #region PRIMJER 8 Metoda - Punjenje Obejktnih Kolekcija sa Različitim izvornim datotekama

        #region KLASA ZA PRIMJER 8

        public class Student
        {
            public string Ime { get; set; }
            public string Prezime { get; set; }  
            public int ID { get; set; }
            public List<int> RezultatiIspita { get; set; }
        }

        #endregion



        static void KolekcijeIzRazlicitihIzvora()
        {
            // Kreiramo poveznicu u array kolekcijskom obliku na text datoteke:
            string[] imenaSt = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\imenaStudenata.txt", Encoding.Default);

            string[] bodoviSt = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\bodoviStudenata.txt", Encoding.Default);

            // Spoji datoteke i podatke korištenjem imenovanog tipa.
            // "var" se može koristiti umjesto eksplicitne kombinacije ovdje.
            // Primjeti dinamičnu kreaciju liste int-a za Ispitne Rezultate. 

           IEnumerable<Student> imenaUpit = from imeLinije in imenaSt
                                            let podIme = imeLinije.Split(',')
                                            from bodoviLinije in bodoviSt
                                            let podBodovi = bodoviLinije.Split(',')
                                            where podIme[2] == podBodovi[0]
                                            select new Student()
                                            {
                                                Ime = podIme[0],
                                                Prezime = podIme[1],
                                                ID = Convert.ToInt32(podIme[2]),
                                                RezultatiIspita = (from bodKaoText in podBodovi.Skip(1)
                                                                   select Convert.ToInt32(bodKaoText)).ToList()
                                            };

                            List<Student> studenti = imenaUpit.ToList();

                            foreach(var student in studenti)
                            {
                                Console.WriteLine("Prosjek bodova od: | {0,-12} {1,-8} | Je: {2,-5:n}% |", student.Ime, student.Prezime, student.RezultatiIspita.Average());
                            }


        }

        #endregion

        #region PRIMJER 9 - Podjeli datoteku u puno datoteka koristeći grupe 
         
        static void PodjeliSaGrupama()
        {
            // Uzmi datoteke u txt obliku i učitaj ih u memoriju u obliku string matrica:

            string[] imena1 = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\TXT\imena1.txt");

            string[] imena2 = System.IO.File.ReadAllLines(@"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\TXT\imena2.txt");

            // Spoji i ukloni duplikatna imena bazirana na osnovnom kopareru:
            var spojiUpit = imena1.Union(imena2);

            // Grupiraj imena po prvom slovu prezimena:
            var grupniUpit = from ime in spojiUpit
                             let i = ime.Split(',')
                             group ime by i[0][0] into g
                             orderby g.Key
                             select g;

            // Kreiraj novu datoteku za svaku grupu koja je kreirana.
            // Da se primjetiti da su nam potrebne ugnježđenje foreach petlje da 
            // dobijemo pristup individualnim stavkama u svakoj grupi!
            foreach(var g in grupniUpit)
            {
                // Kreiraj novu datoteku:
                string imeDatoteke = @"C:\Users\Wylde\Documents\Visual Studio 2013\Projects\APRESS_CCharp5_0_FULL\REVIZIJA\LINQ\LINQ_MSDN\TXT\NovaImena" + g.Key + ".txt";

                // Izbaci na displej:
                Console.WriteLine(g.Key);

                using(System.IO.StreamWriter sw = new System.IO.StreamWriter(imeDatoteke))
                {
                    foreach(var stavka in g)
                    {
                        sw.WriteLine(stavka);
                        // Izbaci na konzolu da bi mogli vidjeti kao primjer:
                        Console.WriteLine("   {0}", stavka);
                    }
                }
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
