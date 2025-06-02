using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace ConsoleEnviroment
{

    internal class Program
    {
        /// <summary>
        /// Programiranje C# 5.0 i .NET Framework 4.5
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║            --- DOBRODOŠLI U: 'REVIZIJU' LINQ Preko Matrica ---                 ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 800);


            #region CORE PROGRAMMING PART 1

            #region 1. DIO - DateTime, BigInt i Osnovne String Manipulacije

            #region Datumi i Vrijeme metoda

            //Datumi i Vrijeme
            KoristenjeDateTimea();

            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region Veliki Integer Metoda

            // Veliki Integer
            VelikiInteger();

            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region Osnovno String Manipuliranje
            OsnovnoStringManipuliranje();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region SPJANJE STRINGOVA
            SpajanjeStringova();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region SPAJENJE STRINGOVA CONCAT METODOM
            SpajanjeStringovaSaConcatMetodom();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region STRING IZLAZNI KARAKTERI
            StringIzlazniKarakteri();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region STRING VERBATIM
            StringVerbaim();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region STRING JEDNAKOST
            StringJednakost();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region STRINGS SU NEPROMJENJIVI 1
            StringoviSuNepromjenjivi();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region STRINGS SU NEPROMJENJIVI 2
            StringoviSuNepromjenjivi2();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #region STRING BUILDER PRIMJER
            StringBuilderKlasa();
            #endregion

            #region DELIMITER-ODVAJAČ
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            #endregion//1. DIO - DateTime, BigInt i Osnovne String Manipulacije

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 2. DIO - Konverzije podataka (ŠIRENJE I SUŽAVANJE eng. NARROWING AND WIDENING)

            #region Prijmjer 1


            Console.WriteLine("***** Type Conversions - Converzije Tipova *****");
            Console.WriteLine("=> Primjer 1:");
            short broj1 = 9, broj2 = 10;
            Console.WriteLine("{0} + {1} = {2}.", broj1, broj2, Zbroji(broj1, broj2));


            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion


            #endregion

            #region Primjer 2
            Console.WriteLine("***** Type Conversions - Converzije Tipova *****");
            Console.WriteLine("=> Primjer 2:");

            short brojX = 30000, brojY = 30000;

            // Upotrebljavamo "cast" operator ovdje...
            // Iako se sve kompajlira kako treba i dalje imamo totalno netačan odgovor!
            // Iako je kompajler sretan zbog "cast" oeratora i dozvoljava nam da pokrenemo program
            // rezultat nije tačan jer ne može stati u predviđeni dio memorije koji short prima.
            // Za ovakve scenarije gdje je moguć gubitak podataka C# nam daje "checked" ključnu riječ... nastvak kasnije...
            short odgovor = (short)Zbroji(brojX, brojY);

            Console.WriteLine("{0} + {1} = {2}", brojX, brojY, odgovor); // Reultat je -5536!!!
            PokusajSazimanja();

            #endregion// Primjer 2

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 3
            // Uvođenjem ključne riječi "checked" mi eliminiramo prostor za owerflow ili underflow greške...
            Console.WriteLine("***** Type Conversions - Converzije Tipova *****");
            Console.WriteLine("=> Primjer 3 (checked keyword):");
            ProcesuirajBajtove();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 4
            /// <summary>
            /// POD PRETPOSTAVKOM DA SMO OBILJEŽILI PROGRAM NA CHECKED FLAG.
            /// TAKO MOŽEMO POSTAVITI "UNCECKED" KLJUČNU RIJEČ ZA NEKI DIO KODA...
            /// OVDJE SADA TO NEĆEMO DEMOSTRIRATI.
            /// PRIMJER IDE
            /// unchecked
            /// {
            ///     byte suma = (byte)(b1, b2)
            ///     Console.WriteLine("Suma je: {0}.", suma);
            /// }
            /// </summary>

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #endregion// 2. DIO - Konverzije podataka (ŠIRENJE I SUŽAVANJE eng. NARROWING AND WIDENING)

            #region 3. DIO - VAR KEYWORD

            #region Primjer 1

            /// <summary>
            /// Sve do sada u primjerima svo se koristili explicinim korištenjem deklariranja varijabli.
            /// npr.
            /// int mojInt = 0;
            /// bool mojBool = true;
            /// string MojString = "Aydin ne zna šta radi...hehe...";
            /// Sada ćemo razmotriti ključnu riječ "var" koji implicitno deklarira varijable...
            /// var možemo koristi i za matrice eng. arrays generične tipove, linq itd...
            /// EVO PRIMJERA ->
            /// </summary>
            Console.WriteLine("***** VAR KLJUČNA RIJEČ *****");
            Console.WriteLine("=> Primjer 1:");
            DeklarirajImplicitneVar();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 2
            /// <summary>
            /// POSTOJE RAZLIČITE RESTRIKCIJE KOD KORIŠTENJA "VAR" KLJUČNE RIJEČI.
            /// PRVO ALI NE I ZADNJE JE, IMPLICITNO TIPIRANJE SE MOŽE PRIMJENITI SAMO NA LOKALNE VARIJABLE U METODI!
            /// ILEGALNO JE KORISTITI "VAR" DA SE DEFINIRA POVRATNA VRIJEDNOST eng. (return value), ONDA KOD PARAMETARA
            /// ILI KOD POLJA eng. (field) U KLASI NEKOG TIPA.
            /// EVO JEDNOG PRIMJERA KOJI NE BI RADIO I REZULTIRAO BI SA MNOGIM GREŠKAMA...
            /// class ThisWillNeverCompile
            /// {
            ///     // GREŠKA! VAR SE NE MOŽE KORISTITI KAO POLJE SA PODATCIMA!
            ///     private var myInt = 10;
            ///     // GREŠKA! VAR SE NE MOŽE KORISTI KAO POVRATNA VRIJEDNOST ILI KAO PARAMETAR!
            ///     public var MyMethod(var x, var y){}
            /// }
            /// ISTO TAKO NE MOŽE IM SE DODJELITI VRIJEDNOST "NULL" I MORAJU BITI INICIJALIZIRANE ODMA PO DEKLARACIJI.
            /// OVO JE GREŠKA:
            /// var mojVar; // Mora postojati podatak da kompajler može doznačiti tip.
            /// OVO JE GREŠKA:
            /// var mojVar;
            /// mojVar = 10; // Mora biti dodjeljena vrijednost odma u deklaraciji.
            /// OVO JE GREŠKA:
            /// var mojVar = null; // var ne može biti null.
            /// Iako je moguće da se varijabli dodjeli vrijednost null poslje već određene vrijednosti npr:
            /// var mojeAuto = new SportskiAuto(); // Uredu jer je spauto referencnog tipa...
            /// mojeAuto = null;
            ///
            /// Isto tako dozvoljeno je(dodjeliti implicitnoj varijabli vrijednost druge imp. varijable:
            /// var mojInt = 10;
            /// var drugiInt = MojInt;
            ///
            /// string mojString = "Probudi se Aydine!";
            /// var mojPodatak = mojString;
            ///
            /// Isto tako u metoda dozvoljeno je implicitnim varijablama da vrate vrijednost
            /// public int DajTajInt()
            /// {
            ///     var vratiVrijednost = 10;
            ///     return vratiVrijednost;
            /// }
            /// </summary>

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 3 var u LINQ Konekstu...
            Console.WriteLine("***** VAR KLJUČNA RIJEČ *****");
            Console.WriteLine("=> Primjer 3:");
            LinqUpitPrekoInta();
            #endregion

            #endregion//3. DIO VAR KEYWORD

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 4. DIO KRATKI POSJET if-else i switch izrazima
            IfElse();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            SwitchDemo();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            SwitchDemoSaEnum();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region 5. DIO - ITERACIJSKE PETLJE
            ForPetlja();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            ForeachPetlja();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            WhilePetlja();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            DoWhilePetlja();
            #endregion

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region CORE PROGRAMMING PART 2

            #region UVOD U METODE

            #region Primjer 1 - Argumenti prosljeđeni po vrijednosti
            Console.WriteLine("=> ZABAVA SA METODAMA: ");
            // Prosljedi dvije varijable po vrijednosti.
            int x = 10, y = 25;
            Console.WriteLine("prije poziva X: {0} Y: {1}", x, y);
            Console.WriteLine("Odgovor je: {0}", AddMethod(x, y));
            Console.WriteLine("Poslje poziva X: {0}  Y: {1}", x, y);

            #endregion//Primjer 1

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 2 - "out" parametar
            Console.WriteLine("=> Zabava sa Metodama primjer \"out\" parametra: ");
            // Moramo dati inicijalnu vrijednost lokalnim varijablama koje su korištene.
            // kao "out" parametar koji su dani prvi puta.
            // Koristimo ih kao izlazne argumente.
            int odg;
            AddOutParametar(90, 110, out odg);
            Console.WriteLine("90 + 110 = {0}", odg);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 3 - više "out" parametara
            Console.WriteLine("=> Zabava sa Metodama primjer više \"out\" parametra:");
            int i; string str; bool b;
            NapuniOveVrijednosti(out i, out str, out b);
            Console.WriteLine("Int je: {0}", i);
            Console.WriteLine("String je: {0}", str);
            Console.WriteLine("Boolean je: {0}", b);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 4 - "ref" parametar
            // Ovaj primjer pokazuje zamjenu string varijabli kroz "ref" parametar.
            Console.WriteLine("=> ZABAVA SA METODAMA \"ref\" PARAMETAR:");
            string str1 = "Zamjeni";
            string str2 = "Zomjeni";
            Console.WriteLine("Prije zamjene: {0}, {1}.", str1, str2);
            ZamjeniStringove(ref str1, ref str2);
            Console.WriteLine("Poslje zamjene: {0}, {1}.", str1, str2);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 4 - "params" parametar
            // Možemo prosljediti zarezom odvojene liste double vrijednosti.
            Console.WriteLine("=> Metoda sa \"params\" parametrom DIO 1: ");
            Console.WriteLine();
            double prosjek;
            prosjek = IzracunajProsjek(4.0, 3.8, 3.5, 5.6, 5.9, 8.5, 9.1, 6.2);
            Console.WriteLine("Prosjek ocjena je: {0:N2}.", prosjek);

            // Možemo joj prosljediti matricu doubla.
            Console.WriteLine("=> Metoda sa \"params\" parametrom DIO 2: ");
            Console.WriteLine();
            double[] podatci = { 2.0, 3.5, 4.5, 5.0, 2.3, 4.2, 3.8 };
            prosjek = IzracunajProsjek(podatci);
            Console.WriteLine("Prosjek podataka je: {0:N2}.", prosjek);

            // Prosjek od 0 je 0!
            Console.WriteLine("=> Metoda sa \"params\" parametrom DIO 3: ");
            Console.WriteLine();
            Console.WriteLine("Prosjek podataka je: {0:P}.", IzracunajProsjek());
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 5 - Opcionalni parametri

            Console.WriteLine("=> Zabava sa metodama, Opcionalni parametri:");
            Console.WriteLine();
            UnesiLogPodatke("Oooo...Ne! Ne mogu da pronađem podatke!");
            UnesiLogPodatke("Oooo...Ne! Ne Mogu da pronađem plaće!", "Direktor");

            #endregion// Primjer 5

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 6 - Imenovani parametri
            Console.WriteLine("=> Zabava sa metodama, Imenovani parametri:");
            Console.WriteLine();
            ShowNiceMessage(poruka: "Vaaauuu! Vrlo fensi!", tekstBoja: ConsoleColor.DarkRed, pozadinskaBoja: ConsoleColor.Magenta);
            ShowNiceMessage(pozadinskaBoja: ConsoleColor.Green, poruka: "Testiramo, ovo nije sigurno!", tekstBoja: ConsoleColor.DarkBlue);
            Console.WriteLine();
            Console.WriteLine();
            // U ovom slučaju smo napravili mali override poruke u opcionalnom parametru.
            PrikaziFensiPoruku2(poruka: "Pozdrav!");
            Console.WriteLine();
            // Sada opcionalni parametar biva pozvan sa svojom onovnom porukom. ali mjenjamo boje, tj. pravimo mali override.
            PrikaziFensiPoruku2(pozadinskaBoja: ConsoleColor.Yellow);
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer 7 - Overloadiranje Metoda (Osnovno)
            // Poziv metodama.
            Console.WriteLine("=> PRIMJER OVERLOADIRANJA METODA, OSNOVE:");
            Console.WriteLine();

            // Poziva prvu Mnozi() metodu.
            Console.WriteLine(Mnozi(10, 10));
            Console.WriteLine();

            Console.WriteLine(Mnozi(9.82, 4.67));
            Console.WriteLine();

            Console.WriteLine(Mnozi(90000000, 60000000));
            Console.WriteLine();

            #endregion// Primjer 7 - Overloadiranje Metoda (Osnovno)

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #endregion

            #region UVOD U ARRAY'S

            JednostavneMatrice();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            InicijaliziranjeMatrice();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            ImplicitnoTipiraneMatrice();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            MatricaObjekata();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            MultidemenzionalnaMatrica1();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            MultidemenzionalnaMatrica2();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            MultidemenzionalnaMatrica3();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            MultidemenzionalnaMatrica4();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            PaskalovTrkot();

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer Matrice kao arumenti
            Console.WriteLine("=> Matrice Kao argumenti za vraćanje vrijednosti:");
            int[] godine = { 20, 24, 30, 7, 11, 37 };
            IspisiMatricu(godine);
            #endregion// Primjer Matrice kao arumenti


            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer Matrice kao arumenti 2
            Console.WriteLine("=> Matrice Kao argumenti za vraćanje vrijednosti 2:");

            // dobavi matricu kao return vrijednost.
            string[] strs = IspisiStringMatricu();
            foreach (var s in strs)
            {
                Console.WriteLine(s);
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer - Da li je matrica simetrična?
            DaliJeMatricaSimetricna();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer PokusMatrica
            MatricaPokus();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Primjer PokusMatrica 2
            MatricaPokus2();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region ČUDNA MATRICA
            int[] matArg = new int[] { 1, 2, 3 };

            Console.WriteLine("Prije modificiranja čudne matrice: argument je: ");
            IspisiCudnuMatricu(matArg);

            // Modificira čudnu matricu.
            ModificirajCudnuMatricu(matArg);

            Console.WriteLine("Poslje modificiranja čudne matrice argument je: ");
            IspisiCudnuMatricu(matArg);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region IZRAČUN SA MATRICOM
            Console.WriteLine("=> IZRAČUN SA MATRICOM:");
            Console.WriteLine();

            long suma = IzracunSaMatricom(2, 50);
            Console.WriteLine("Prva suma zbroja je: {0}.", suma);

            long suma2 = IzracunSaMatricom(4, 44, 34, 23, 34, 34);
            Console.WriteLine("Druga suma zbroja je: {0}.", suma2);

            long suma3 = IzracunSaMatricom();
            Console.WriteLine("treća suma zbroja je: {0}.", suma3);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Izračun sa matricom i params za knjige
            KnjigeIzracun(29.2M, 39.9M, 49.9M);
            KnjigeIzracun(109.99m, 269.89m, 389.99m, 376.99m);
            // Pošto "cijene" su matrica može se pretpostaviti da mi možemo
            // inijalizirati matricu prije poziva metode, i onda poslati matricu kao argument.
            decimal[] matrCijene = { 23.99m, 56.99m, 99.99m };

            // I sada prosljeđujemo matricu kao argument metodi.
            KnjigeIzracun(matrCijene);

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            MatriceFunkcionalnosti();


            #endregion// UVOD U ARRAY'S

            #endregion// CORE PROGRAMMING PART 2

            Console.ReadKey();
        }

        #region NapisiPunuCrtu Metoda

        private static void NapisiPunuCrtu(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }

        #endregion

        #region M E T O D E


        #region CORE PROGRAMMING PART 1

        #region DATUMI I VREMENA DATETIME

        // Datumi i vremena...
        static void KoristenjeDateTimea()
        {
            Console.WriteLine("=> Datumi i Vremena:");

            // Ovo je konstruktor koji uzima ( godinu, mjesec i dan )
            DateTime dt = new DateTime(2014, 3, 26);

            // Koji je ovo dan u mjesecu?
            Console.WriteLine("Dan u {0} je {1}", dt.Date, dt.DayOfWeek);

            // Mjesec je sada maj.
            dt = dt.AddMonths(2);
            Console.WriteLine("Promjena vremena: {0}", dt.IsDaylightSavingTime());

            // Ovaj konstruktor uzima (sate, minute i sekunde)
            TimeSpan ts = new TimeSpan(10, 26, 33);
            Console.WriteLine(ts);

            // Oduzmi 15 minuta od trenutnog time-spana i ispiši rezulatat
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }

        #endregion//DATUMI I VREMENA

        #region BIG INTEGER

        static void VelikiInteger()
        {
            Console.WriteLine("=> Koristi Veliki Integer:");
            BigInteger veliki =
                BigInteger.Parse("99999999999999999999999999999999999999999999999999");
            Console.WriteLine("Vrijednost od biggy-ja je: {0}", veliki);
            Console.WriteLine("Da li biggy na drugu: {0}", veliki.IsPowerOfTwo);

            BigInteger stvarnoVeliki = BigInteger.Multiply(veliki,
                BigInteger.Parse("888888888888888888888888888888888888888888"));

            Console.WriteLine("Vrijednost stvarnoVelikog je: {0}", stvarnoVeliki);


        }

        #endregion//BIG INTEGER

        #region STRING OSNOVNE MANIPULACIJE

        static void OsnovnoStringManipuliranje()
        {
            Console.WriteLine("=> Osnovno Strng Manipuliranje:");
            string ime = "Aydin";
            Console.WriteLine("Vrijednost od \"ime\" je: {0}", ime);
            Console.WriteLine("ime u sebi ima karaktera: {0}", ime.Length);
            Console.WriteLine("ime u velikim slovima: {0}", ime.ToUpper());
            Console.WriteLine("ime u malim slovima: {0}", ime.ToLower());
            Console.WriteLine("Da li \"ime\" sadrržava karakter \"y\": {0}", ime.Contains("y"));
            Console.WriteLine("ime poslje zamjene karaktera: {0}", ime.Replace("Ay", "Aj"));
            Console.WriteLine();

        }

        static void SpajanjeStringova()
        {
            Console.WriteLine("=> String Spajanje:");
            string s1 = "Programiranje ";
            string s2 = "u Visual C# ";
            string s3 = "programskom jeziku je najzabavinije!";

            string s4 = s1 + s2 + s3;
            Console.WriteLine(s4);
            Console.WriteLine();

        }

        static void SpajanjeStringovaSaConcatMetodom()
        {
            Console.WriteLine("=> Spajanje stringova sa Concat Metodom:");
            string s1 = "Programiranje u ";
            string s2 = "JAVI je dosadno ";
            string s3 = "i naporno!";

            string s4 = String.Concat(s1, s2, s3);
            Console.WriteLine(s4);
            Console.WriteLine();

        }

        static void StringIzlazniKarakteri()
        {
            Console.WriteLine("=> Izlazni Karakteri:\a");
            string stringSaTabovima = "Model\tVerzija\tBrzina\tBMW\a ";
            Console.WriteLine(stringSaTabovima);

            Console.WriteLine("Svi apsolutno vole \"Hello World\"\a ");
            Console.WriteLine("C:\\DATA\\AdoStepbyStep.mdf");

            // Daje 4 prazne crte i onda pišti "beep".
            Console.WriteLine("Sve završeno.\n\n\n\n\a ");
            Console.WriteLine();

        }

        static void StringVerbaim()
        {
            Console.WriteLine("=> Korištenje verbatima u skraćivanju putanje, te za jako dugačke string varijable.");
            Console.WriteLine(@"C:\ConsoleEnviroment\bin\Debug");

            // Prazni prostor je sačuvan kod verbatim stringa
            string jakoDugiString = @"Ovo je jedan jako
                 dugi string
                 koji se nastavlja u više redova
                 i formirao sam ga kao jedan LINQ query.";
            string verbatim = @"Kad koristite verbatim string ""Možete sa duplim navodnicima raditi navodnike"".";
            Console.WriteLine(jakoDugiString);
            Console.WriteLine(verbatim);
        }

        static void StringJednakost()
        {
            Console.WriteLine("=> String Jednakost:");
            string s1 = "Pozdrav!";
            string s2 = "Hej!";
            Console.WriteLine("s1 == s2: {0}", s1 == s2);
            Console.WriteLine("s1 == \"Pozdrav!\": {0}", s1 == "Pozdrav!");
            Console.WriteLine("s1 == \"POZDRAV!\": {0}", s1 == "POZDRAV!");
            Console.WriteLine("s1 == \"pozdrav!\": {0}", s1 == "pozdrav!");
            Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
            Console.WriteLine("Hej.Equals(s2): {0}", "Hej!".Equals(s2));
            Console.WriteLine();
        }

        static void StringoviSuNepromjenjivi()
        {
            // Eng. Strings are immutable
            Console.WriteLine("=> String's su Nepromjenjivi:");
            string s1 = "Ovo je moj string";
            Console.WriteLine("s1 = {0}", s1);

            // sva slova gore?
            string svaSlovaGore = s1.ToUpper();
            Console.WriteLine("svaSlovaGore = {0}", svaSlovaGore);

            // Ne. s1 je i dalje u istom formatu!
            Console.WriteLine("s1 = {0}", s1);
        }

        static void StringoviSuNepromjenjivi2()
        {
            Console.WriteLine("=> String's su Nepromjenjivi 2 (Hmmm...):");
            string s2 = "Moj drugi string";
            s2 = "Nova string vrijednost";
            Console.WriteLine(s2);
        }

        static void StringBuilderKlasa()
        {
            Console.WriteLine("=> Korištenje StringBuilder-a: ");

            StringBuilder sb = new StringBuilder("***** FANTASTIČNE IGRE *****");
            sb.AppendLine("\n");
            sb.AppendLine("Sim City 4");
            sb.AppendLine("Sim City Deluxe");
            sb.AppendLine("Hlaf Life");
            sb.AppendLine("Morrowind");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", " Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb ime {0} karaktera.", sb.Length);
            Console.WriteLine();

        }

        #endregion//STRING OSNOVNE MANIPULACIJE

        #region Konverzije tipova

        static int Zbroji(int x, int y)
        {
            return x + y;
        }

        static void PokusajSazimanja()
        {
            byte mojByte = 0;
            int mojInt = 200;

            // Eksplicitno "cast"-iraj int u byte (bez gubitka podataka)
            mojByte = (byte)mojInt;
            Console.WriteLine("Vrijednost od mojbyte je: {0}", mojByte);

        }

        static void ProcesuirajBajtove()
        {
            // Kada bi ove brojeve i sa "cast" operatorom pretovrili u int dobili bi rezulat od 94! jer
            // Bi kopajler oduzeo 350-256(max od byte-a) i dobio 94.
            // Zato ćemo da uvedemo malo exception handling-a ovdje. kroz ključnu rieč "checked"... i try-catch...

            byte b1 = 100;
            byte b2 = 250;

            // Sad redi kompajleru da doda CIL kod
            // neka izbaci grešku ako je overflow/underflow
            try
            {
                checked
                {
                    byte suma = checked((byte)Zbroji(b1, b2));
                    Console.WriteLine("Suma je: {0}.", suma);
                    // Ovo će rezultirati greškom...
                }

                // ako želimo da izforsiramo overflow checking da se dogodi ovom bloku koda možemo to izvesti ovako:
                //checked
                //{
                //    byte suma = (byte)Zbroji(b1, b2);
                //    Console.WriteLine("Suma je: {0}.", suma);
                //    // Ovo će rezultirati greškom...
                //}
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }


        #endregion//Konverzije tipova

        #region VAR KLJUČNA RIJEČ I IMPLICITNO TIPIRANJE
        // Prvi test var ključne riječi ispitivanje kojeg su tipa varijable deklarirane sa var tipom...
        static void DeklarirajImplicitneVar()
        {
            // Implicitno tipirane lokalne varijable.
            var mojInt = 0;
            var mojBool = true;
            var mojString = "Kako je lijepo imati var u svom rukavu...ah!";
            var mojDouble = 2.33;
            var mojDecimal = 2.34m;

            // Ipiši na konzolu da vidimo kojeg je tima koja varijabla...
            Console.WriteLine("mojInt     je tipa: {0}", mojInt.GetType().Name);
            Console.WriteLine("mojBool    je tipa: {0}", mojBool.GetType().Name);
            Console.WriteLine("mojString  je tipa: {0}", mojString.GetType().Name);
            Console.WriteLine("mojDouble  je tipa: {0}", mojDouble.GetType().Name);
            Console.WriteLine("mojDecimal je tipa: {0}", mojDecimal.GetType().Name);
        }

        static void LinqUpitPrekoInta()
        {
            int[] brojevi = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };

            // LINQ Query-upit
            var podSet = from i in brojevi
                         where i > 20
                         select i;

            foreach (var stavka in podSet)
            {
                Console.Write("{0} ", stavka);
            }
            Console.WriteLine();
            // Hmmm....koj li je tipa podSet?
            Console.WriteLine("podSet je: {0}", podSet.GetType().Name);
            Console.WriteLine("podSet je definiran u: {0}", podSet.GetType().Namespace);
        }

        #endregion// VAR KLJUČNA RIJEČ I IMPLICITNO TIPIRANJE

        #region KRATKI POSJET if-else I switch IZRAZIMA
        static void IfElse()
        {
            Console.Write("Želite li pokrenuti program ili preskočiti DA/NE: ");
            string odgovor = Console.ReadLine();
            if (odgovor != null && odgovor.ToLower() == "da")
            {
                int counter = 0;

                while (counter != -1)
                {
                    Console.WriteLine("=> DOBRODOŠLI U \"if-else\" PRIMJER KALKULATORA.");

                    Console.Write("Ubaci jedan broj:");
                    double broj1 = double.Parse(Console.ReadLine() ?? string.Empty);

                    Console.Write("Ubaci drugi broj:");
                    double broj2 = double.Parse(Console.ReadLine() ?? string.Empty);

                    Console.Write("Unesite Operaciju ( +, -, *, /, %, ): ");
                    string operacija = Console.ReadLine();

                    if (operacija == "+")
                    {
                        double suma = broj1 + broj2;
                        Console.WriteLine("ODABRALI STE ZBRAJANJE! SUMA BROJEVA: {0} + {1} = {2}", broj1, broj2, suma);
                    }
                    else if (operacija == "-")
                    {
                        double suma = broj1 - broj2;
                        Console.WriteLine("ODABRALI STE ODUZIMANJE! SUMA BROJEVA: {0} - {1} = {2}", broj1, broj2, suma);
                    }
                    else if (operacija == "*")
                    {
                        double suma = broj1 * broj2;
                        Console.WriteLine("ODABRALI STE MNOŽENJE! SUMA BROJEVA: {0} * {1} = {2}", broj1, broj2, suma);
                    }
                    else if (operacija == "/")
                    {
                        double suma = broj1 / broj2;
                        Console.WriteLine("ODABRALI STE DJELJENJE! SUMA BROJEVA: {0} / {1} = {2}", broj1, broj2, suma);
                    }
                    else if (operacija == "%")
                    {
                        double suma = broj1 % broj2;
                        Console.WriteLine("ODABRALI STE MODULUS! SUMA BROJEVA: {0} % {1} = {2}", broj1, broj2, suma);
                    }
                    else
                    {
                        Console.WriteLine("NISTE ODABRALI NITI JEDNU OD PONUĐENIH OPERACIJA MOLIM POKUŠAJTE PONOVNO...");
                    }

                    Console.Write("Za prekid Programa utipkajte -1, za nastavak 1: ");
                    counter = Convert.ToInt32(Console.ReadLine());
                }

            }
            else
            {
                Console.WriteLine("Možda neki drugi put...Pozdrav!");
            }
        }

        static void SwitchDemo()
        {

            Console.Write("Želite li pokrenuti program ili preskočiti DA/NE: ");
            string odgovor = Console.ReadLine();
            if (odgovor.ToLower() == "da")
            {

                int counter = 0;
                while (counter != -1)
                {
                    try
                    {
                        Console.WriteLine("=> DOBRODOŠLI U \"switch\" PRIMJER KALKULATORA");

                        Console.Write("Molim vas unesite broj: ");
                        double broj1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Molim vas unesite broj: ");
                        double broj2 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Molim vas unesite opraciju (+,-,*,/,%): ");
                        string operacija = Console.ReadLine();

                        switch (operacija)
                        {
                            case "+":
                                double zbrSuma = broj1 + broj2;
                                Console.WriteLine("ODABRALI STE ZBRAJANJE! SUMA BROJEVA: {0} + {1} = {2}", broj1, broj2, zbrSuma);
                                break;
                            case "-":
                                double oduSuma = broj1 - broj2;
                                Console.WriteLine("ODABRALI STE ODUZIMANJE! SUMA BROJEVA: {0} - {1} = {2}", broj1, broj2, oduSuma);
                                break;
                            case "*":
                                double mnoSuma = broj1 * broj2;
                                Console.WriteLine("ODABRALI STE MNOŽENJE! SUMA BROJEVA: {0} * {1} = {2}", broj1, broj2, mnoSuma);
                                break;
                            case "/":
                                double djeSuma = broj1 / broj2;
                                Console.WriteLine("ODABRALI STE DJELJENJE! SUMA BROJEVA: {0} / {1} = {2}", broj1, broj2, djeSuma);
                                break;
                            case "%":
                                double modSuma = broj1 % broj2;
                                Console.WriteLine("ODABRALI STE MODULUS! SUMA BROJEVA: {0} % {1} = {2}", broj1, broj2, modSuma);
                                break;
                            default:
                                Console.WriteLine("NISTE ODABRALI NITI JEDNU VALIDNU OPERACIJU!");
                                break;

                        }
                    }
                    catch
                    {
                        Console.WriteLine("Niste unijeli broj! Morateunijeti Brojčanu vijednost ne slovo!", Double.NaN);
                    }
                    Console.Write("Za prestanak rada sa Programom pritisnite -1 za nastavak 1: ");
                    counter = Convert.ToInt32(Console.ReadLine());
                }
            }
            else
            {
                Console.WriteLine("Možda neki drugi put...Pozdrav!");
            }

        }

        static void SwitchDemoSaEnum()
        {
            Console.Write("Želite li pokrenuti program ili preskočiti DA/NE: ");
            string odgovor = Console.ReadLine();
            if (odgovor?.ToLower() == "da")
            {


                Console.WriteLine("=> PRIMJER \"switch\" SA ENUMERIJAMA: ");
                Console.WriteLine();
                Console.WriteLine("UNESITE SVOJ OMILJENI DAN U TJEDNU NA ENG: ");
                DayOfWeek najDan;
                try
                {
                    najDan = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Neispran unos!");
                    return;
                }

                switch (najDan)
                {
                    case DayOfWeek.Friday:
                        Console.WriteLine("Petak je zakon dan!");
                        break;
                    case DayOfWeek.Monday:
                        Console.WriteLine("Ponedjeljak je težak.");
                        break;
                    case DayOfWeek.Saturday:
                        Console.WriteLine("Najbolji dan za provod!");
                        break;
                    case DayOfWeek.Sunday:
                        Console.WriteLine("Dan za odmor od svega.");
                        break;
                    case DayOfWeek.Thursday:
                        Console.WriteLine("Samo čekaš da prođe...");
                        break;
                    case DayOfWeek.Tuesday:
                        Console.WriteLine("Tek počinje napor...");
                        break;
                    case DayOfWeek.Wednesday:
                        Console.WriteLine("U sredini unakrsne vatre!");
                        break;

                }

            }
            else
            {
                Console.WriteLine("Možda neki drugi put...Pozdrav!");
            }

            Console.ReadKey();
        }
        #endregion

        #region ITRACIJEKSE PETLJE

        static void ForPetlja()
        {
            // FOR PETLJA JE ZGODNA KADA ZNATE KOLIKO ĆETE PUTA PROĆI KROZ NJU
            // ZNAČI IMA FIKSNI BROJ KOJI ĆE SE IZVRŠITI. I IMA ZGODNU TERMINIRAJUĆE STANJE.
            Console.WriteLine("=> PRIMJER FOR PERTLJE, OSNOVNI:");
            // Varijabla "i" je vidljiva samo u djelu petlje!
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Brojevi od int-a \"i\" su: {0}", i);
            }
        }

        static void ForeachPetlja()
        {
            Console.WriteLine("=> PRIMJER MALO KOMPLEKSNIJE FOREACH PETLJE:");
            // Najbolje mi je demonstritati foreach petlju kroz jedan LINQ primjer.
            // Uzmimo da imamo jednu matricu string varijabli koja sadrže imena.
            // Napravićemo tu matricu imena:
            string[] imena = { "ajdin", "marlena", "filip", "petra", "edin", "mato", "marko", "jozo", "pavo", "đavo" };

            // Sad nam treba upit za ta imena:
            var query = from i in imena
                        where i.StartsWith("a") ^ i.StartsWith("m")
                        select i;

            // Sad uzmimo da foreach implementira IEnumerable, i da želimo
            // proći kroz sva imena pojednično u petlji, vrlo jednostavno
            // postavimo foreach petlju sa implicitnim tipiranjem kao i u LINQ upitu:
            foreach (var ime in query)
            {
                Console.WriteLine("| Imena su: {0,-7:} |", ime);
            }
            Console.WriteLine("---------------------");
            // Drugi jednostavni primjer ne koristi LINQ upit
            int[] brojevi = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            foreach (int broj in brojevi)
            {
                Console.WriteLine("| Brojevi su: {0,-5:} |", broj);
            }
        }

        static void WhilePetlja()
        {
            Console.WriteLine("=> PRIMJER \"WHILE\" PETLJE:");
            string jelKorisnikGotov = "";

            // ToLower() koristimo da bi sve karaktere ako su upisni velikim slovima spustimo...
            while (jelKorisnikGotov.ToLower() != "da")
            {
                Console.WriteLine("Nalazimo se u \"WHILE\" petlji!");
                Console.Write("Da li želite izaći DA/NE: ");
                jelKorisnikGotov = Console.ReadLine();
            }
        }

        static void DoWhilePetlja()
        {
            Console.WriteLine("=> PRIMJER \"DO-WHILE\" PETLJE: ");
            // Do-while petlja je jako slična while petlji samo sa jednom bitnom razlikom.
            // 1. do-while garantira da će se izvesti makar jednom dok to while ne
            // garantira ukoliko joj je stanje unaprijed određeno!
            string jelKorisniGotov = "";
            do
            {
                Console.WriteLine("Nalazimo se u \"Do-While\" petlji...");
                Console.Write("Da li želite nastaviti sa petljom DA/NE: ");
                jelKorisniGotov = Console.ReadLine();
            } while (jelKorisniGotov.ToLower() == "da");

        }

        #endregion//ITERACIJSKE PETLJE

        #endregion//CORE PROGRAMMING PART 1

        #region CORE PROGRAMMING PART 2

        #region UVOD U METODE

        // Klasična value-type metoda...
        public static int AddMethod(int x, int y)
        {

            int odg = x + y;

            // Pozivaoc neće vidjeti promjene koje ovjdje radimo
            // zato što modificiramo kopiju originalnih podataka!
            x = 10000;
            y = 88888;
            return odg;
        }



        // Method with "out" parameter.
        public static void AddOutParametar(int x, int y, out int odg)
        {
            odg = x + y;
        }


        // Method with multiple "out" parameters....
        public static void FillTheseValues(out int a, out string b, out bool c)
        {
            a = 9;
            b = "Ajdin u string-u";
            c = true;
        }

        // Metoda sa "ref" parametrom.
        private static void SwapStrings(ref string s1, ref string s2)
        {
            // Swap string variables:
            string tempStr = s1;
            s1 = s2;
            s2 = tempStr;

            // Swap by deconstrucion:
            s1 = s2;
            s2 = s1;

        }

        // Metoda sa "params" parametrom. Može prosljediti matricu vrlo efikasno.
        static double IzracunajProsjek(params double[] vrijednosti)
        {
            Console.WriteLine("Poslao si mi {0} double-a.", vrijednosti.Length);

            double suma = 0;
            if (vrijednosti.Length == 0)
            {
                return suma;
            }

            for (int i = 0; i < vrijednosti.Length; i++)
            {
                suma = suma + vrijednosti[i];
            }
            return (suma / vrijednosti.Length);
        }

        // Metoda sa opcionalnim parametrima.
        static void UnesiLogPodatke(string poruka, string vlasnik = "Programer")
        {
            Console.Beep();
            Console.WriteLine("Greška: {0}.", poruka);
            Console.WriteLine("Vlasnik Greške: {0}.", vlasnik);
        }


        #region SKUP MEtoda sa imenovanim parametrima
        // Metoda sa imenovanim parametrima...
        public static void ShowNiceMessage(ConsoleColor tekstBoja, ConsoleColor pozadinskaBoja, string poruka)
        {
            // Store the old console colors to revert to default after printing the message.
            ConsoleColor staraTekstBoja = Console.ForegroundColor;
            ConsoleColor staraPozadinstakaBoja = Console.BackgroundColor;

            // Postavi nove boje i isprintaj poruku...
            Console.ForegroundColor = tekstBoja;
            Console.BackgroundColor = pozadinskaBoja;

            Console.WriteLine(poruka);


            // Vrati boje na staro.
            Console.ForegroundColor = staraTekstBoja;
            Console.BackgroundColor = staraPozadinstakaBoja;
        }

        // Ista metoda ali sa opcionalnim parametrima
        static void PrikaziFensiPoruku2(ConsoleColor tekstBoja = ConsoleColor.Blue, ConsoleColor pozadinskaBoja = ConsoleColor.White, string poruka = "Testna Poruka")
        {
            ConsoleColor staraTekstBoja = Console.ForegroundColor;
            ConsoleColor staraPozadinstakaBoja = Console.BackgroundColor;

            // Postavi nove boje i isprintaj poruku...
            Console.ForegroundColor = tekstBoja;
            Console.BackgroundColor = pozadinskaBoja;

            Console.WriteLine(poruka);


            // Vrati boje na staro.
            Console.ForegroundColor = staraTekstBoja;
            Console.BackgroundColor = staraPozadinstakaBoja;
        }


        #endregion// SKUP MEtoda sa imenovanim parametrima

        #region Overloadiranje Metoda
        static int Mnozi(int x, int y)
        {
            return x * y;
        }

        // Overload metode "Mnozi()".
        static double Mnozi(double x, double y)
        {
            return x * y;
        }

        // Još jedan oveload "Mnozi()".
        static long Mnozi(long x, long y)
        {
            return x * y;
        }


        static void KnjigeIzracun(params decimal[] cijene)
        {
            Console.WriteLine("=> KNJIGE IZRAČUN: ");
            decimal totalniIznos = 0;

            foreach (decimal cijenaJedneKnjige in cijene)
            {
                totalniIznos = totalniIznos + cijenaJedneKnjige;
            }

            Console.WriteLine("Totalni Iznos za sve Knjige je: {0:C2}", totalniIznos);
        }
        #endregion// Overloadiranje Metoda

        #endregion// UVOD U METODE

        #region UVOD U ARRAY'S

        static void JednostavneMatrice()
        {
            Console.WriteLine("=> Jednostavne Matrice.");

            // Kreiraj matricu tipa int sa 3 elementa indexirana sa 0, 1, 2
            int[] mojInt = new int[3]; // odmah određujemo veličinu matrice
            mojInt[0] = 100;
            mojInt[1] = 200;
            mojInt[2] = 300;

            // Sada pomoću nam već poznate foreach petlje isprintaj vrijednosti matrice.
            foreach (int stavka in mojInt)
            {
                Console.WriteLine("Ispis mojInt matrice: {0}.", stavka);
            }


            // Kreiraj string matricu sa 100 stavki inexiranu 0-99
            string[] knjige = new string[5]; // odmah određujemo veličinu matrice
            Console.WriteLine();
            knjige[0] = "Aydin Rose,  C# Core Programming";
            knjige[1] = "Paul Deitel, Visual C# How To Program";
            knjige[2] = "John Sharp, Microsoft Visual C# Step By Step";
            knjige[3] = "Tihomir Magdić, Professional JAVA";
            knjige[4] = "Linda Paul, Entity Framework Code First";

            foreach (string item in knjige)
            {
                Console.WriteLine("Knjige: | {0,-44:} |", item);
            }

        }


        static void InicijaliziranjeMatrice()
        {
            Console.WriteLine("=> Raziličito Inicijaliziranje Matrica");
            Console.WriteLine();
            // Matrica - inicijalizacijska sistaksa sa "new" ključnom riječi.
            string[] stringMatrica = new string[] { "jedan", "dva", "tri", "četiri", "pet" };
            Console.WriteLine("stringMatrica ima: {0} elemenata.", stringMatrica.Length);
            Console.WriteLine();

            // Matrica - Inicijalizacijska sintaksa bez korištenja "new" ključne riječi.
            bool[] boolMatrica = { false, true, false };
            Console.WriteLine("boolMatrica ima: {0} elemenata.", boolMatrica.Length);
            Console.WriteLine();

            // Matrica- inicijalizacijska sintaksa sa "new" ključnom riječi i sa određenom veličinom.
            int[] intMatrica = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("intMatrica ima: {0} elemenata.", intMatrica.Length);
            Console.WriteLine();
        }


        static void ImplicitnoTipiraneMatrice()
        {
            Console.WriteLine("=> Implicitno Tipirane Matrice.");
            #region Komentari...

            // Implicitno znači da ćemo se u konstrukciji koristiti ključnom riječi "var"
            // Koju smo već naučili iz poglavlja 3.
            // pa krenimo sa inicjaliziranjem skoro istih matrica kao u gornjem primjeru
            // samo što ćemo ih tipirati implicitno:

            #endregion

            var a = new[] { 1, 10, 100, 1000, 10000, 100000 };
            Console.WriteLine("a je tipa: {0}.", a.ToString());
            Console.WriteLine();

            var b = new[] { true, false, true, true };
            Console.WriteLine("b je tipa: {0}.", b.ToString());
            Console.WriteLine();

            var c = new[] { "Pozdrav", "Null", "Svijete", "Oko", "Nas" };
            Console.WriteLine("c je tipa: {0}.", c.ToString());
            Console.WriteLine();

            #region Napomena
            /// <summary>
            /// Što ne možemo raditi sa "var" ključnom riječi je to a mnogi bi pomislili
            /// da se to može i smije u C#-pu je to da možemo miksati tipove unutar implicitno
            /// deklarirane matrice npr:
            /// var d = new[] { "jedan", 22, 23.3, "dva", false };
            /// Naglašavam ovo ne možemo raditi u C#-pu!
            /// </summary>
            #endregion
        }

        static void MatricaObjekata()
        {
            Console.WriteLine("=> Matica Objekata, stoga može biti bilo što:");
            #region Komentari...

            // Pošto je System.Object baza svih tipova uključujući i fundamentalne tipove
            // u .NEt framworku. Kad uzmemu tu činjenicu u obzir, mi možemo definirati matricu
            // objekata od System.Object podatkovnog tipa, a podstvake mogu biti bilo koji tip!
            // Pa probajmo jednu takvu matricu staviti u praksu:

            #endregion

            object[] mojiObjekti = new object[6]; // zadajemo joj inicalnu veličinu.
            mojiObjekti[0] = 10;                            // Ovo je int.
            mojiObjekti[1] = false;                         // Ovo je bool.
            mojiObjekti[2] = 22.2;                          // Ovo je double.
            mojiObjekti[3] = "Aydin";                       // Ovo je string.
            mojiObjekti[4] = 'c';                           // Ovo je char.
            mojiObjekti[5] = new DateTime(2014, 03, 04, 22, 52, 34);    // Ovo je DateTime (Malo prošireni oblik koji kaže koliko je sati...)

            // Ipišimo sada sve stvake kroz poznatu nam foreach petlju.
            foreach (object obj in mojiObjekti)
            {
                Console.WriteLine("| Tip: {0,-15:} | Vrijednost: {1,-18:} |", obj.GetType(), obj);
            }

            // Kao što vidimo matrica tipa "object" može držati različite vrijednosne tipove...
        }

        static void MultidemenzionalnaMatrica1()
        {
            Console.WriteLine("=> Multidimenzionalne Matrice. Ovo je \"Rectangular\" matrica:");
            Console.WriteLine();

            // Kad deklariramo matricu multidemenzionalnog tipa npr int u
            // kockaste zagrade stvaljamo zarez koji signalizira kompajleru
            // da se radi o multidemenzionalnoj matrici.
            int[,] mojMatrix;
            mojMatrix = new int[6, 6];

            // Sada napunimo matricu ( 6 * 6 ).
            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 6; j++)
                    mojMatrix[i, j] = i * j;

            // Ipišimo ( 6 * 6 ) matricu.
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(mojMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();



        }

        static void MultidemenzionalnaMatrica2()
        {
            Console.WriteLine("=> Multidemenzionalna Matrica zvana \"Jagged\" matrica:");
            Console.WriteLine();

            // Jagged matrica je matrica od više matrica.
            // Mi ovdje imamo matricu od 5 različitih matrica!
            int[][] mojaJaggedMatrica = new int[5][]; // Stavaljamo 5 i kažemo želimo 5 jaged matrica.

            // Kreirajmo jagged matricu, klaičnim pristpum sa for petljom.
            for (int i = 0; i < mojaJaggedMatrica.Length; i++)
            {
                mojaJaggedMatrica[i] = new int[i + 7];
            }

            // Ispišimo svaki red ( zapamtite, svaki element je osnovan nulom!)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < mojaJaggedMatrica[i].Length; j++)
                {
                    Console.Write(mojaJaggedMatrica[i][j] + " ");
                }
                Console.WriteLine();

            }
            Console.WriteLine();
        }

        static void MultidemenzionalnaMatrica3()
        {
            Console.WriteLine("=> MULTIDEMINEZIONALNE MATRICE PRIMJER ISPISA NA KONZOLU: ");
            int[,] matrix =
                {
                    {2,4,6,8},  // Vriejdnosti prvog reda.
                    {1,3,5,7},  // Vriejdnosti drugog reda.
                };

            // Ispišimo matrix na konzolu.
            for (int red = 0; red < matrix.GetLength(0); red++)
            {
                for (int kolona = 0; kolona < matrix.GetLength(1); kolona++)
                {
                    Console.Write(matrix[red, kolona]);
                }
                Console.WriteLine();
            }
        }

        static void MultidemenzionalnaMatrica4()
        {
            Console.WriteLine("=> UNOŠENJE MUTLIDIMENZIONALNE MATRICE SA KONZOLE I ISPIS ISTE:");
            Console.WriteLine();
            Console.Write("Unesite broj redova: ");
            int red = int.Parse(Console.ReadLine());

            Console.Write("Unesite broj kolona: ");
            int kol = int.Parse(Console.ReadLine());

            // Ubacujemo u matricu "red, i kol" koji su pročitani sa konzole...
            int[,] matrix = new int[red, kol];

            for (int re = 0; re < red; re++)
            {
                for (int ko = 0; ko < kol; ko++)
                {
                    Console.Write("matrix[{0},{1}] = ", re, ko);
                    matrix[re, ko] = int.Parse(Console.ReadLine());
                }
            }

            for (int re = 0; re < matrix.GetLength(0); re++)
            {
                for (int ko = 0; ko < matrix.GetLength(1); ko++)
                {
                    Console.Write(" " + matrix[re, ko]);
                }
                Console.WriteLine();
            }

        }

        static void PaskalovTrkot()
        {
            Console.WriteLine("=> MULTIDIMENZIONALNE MATRICE! PASKALOV TROKUT:");
            const int VISINA = 13;

            // Alociraj matricu da bude trokutastor oblika!
            long[][] trokut = new long[VISINA + 1][];

            for (int red = 0; red < VISINA; red++)
            {
                trokut[red] = new long[red + 1];
            }

            // Izračunaj Paskalov Trokut.
            trokut[0][0] = 1;

            for (int red = 0; red < VISINA - 1; red++)
            {
                for (int kol = 0; kol <= red; kol++)
                {
                    trokut[red + 1][kol] += trokut[red][kol];
                    trokut[red + 1][kol + 1] += trokut[red][kol];
                }
            }


            // Ispiši Paskalov trokut.
            for (int red = 0; red < VISINA; red++)
            {
                Console.Write("".PadLeft((VISINA - red) * 2));
                for (int kol = 0; kol <= red; kol++)
                {
                    Console.Write("{0,3} ", trokut[red][kol]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }


        #region Matrice kao Argumenti za vraćanje vrijednosti

        static void IspisiMatricu(int[] mojInt)
        {
            for (int i = 0; i < mojInt.Length; i++)
            {
                Console.WriteLine("Stavka {0} je {1}.", i, mojInt[i]);
            }
        }

        static string[] IspisiStringMatricu()
        {
            string[] strings = { "Pozdrav", "iz", "IspišiStringMatricu" };
            return strings;
        }

        static void DaliJeMatricaSimetricna()
        {
            Console.Write("Unesite jedan pozitivan integral: ");
            int n = int.Parse(Console.ReadLine());

            int[] matrica = new int[n];

            Console.Write("Unesite vrijdenosti matrice: ");
            for (int i = 0; i < n; i++)
            {
                matrica[i] = int.Parse(Console.ReadLine());
            }

            bool simetricna = true; // Kad je matrica simetrična onda je je redosljed brojeva npr: 123321 1221 12321 itd...
            for (int i = 0; i < matrica.Length / 2; i++)
            {
                if (matrica[i] != matrica[n - i - 1])
                {
                    simetricna = false;
                    break;
                }
            }
            Console.WriteLine("Da li je simetrična? {0}.", simetricna);
        }


        // Zadatak!
        static void MatricaPokus()
        {
            // Upješno obavljen...
            int[] matrica = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40 };

            Console.Write("Izlaz: ");

            for (int index = 0; index < matrica.Length; index++)
            {
                // Sad ćemo svaki od članova pomnožiti sa pet.
                matrica[index] = 5 * matrica[index];

                Console.Write(matrica[index] + " ");
            }

        }

        // Zadatak!
        static void MatricaPokus2()
        {
            Console.Write("Unesite 5 Vrijednosti matrice: ");
            int[] a1 = new int[5];
            for (int i = 0; i < a1.Length; i++)
            {
                a1[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Unesite 5 vrijednosti matrice: ");
            int[] a2 = new int[5];
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = int.Parse(Console.ReadLine());

            }

            var query = from a in a1
                        join b in a2 on a equals b
                        select a;

            bool jednaka = a1.Length == a2.Length && query.Equals(a1) == query.Equals(a2);
            //&& query.Count() == a1.Length && query.Count() == a2.Length;

            Console.WriteLine("Da li su matrice jednake? {0}", jednaka);

        }

        #endregion// Matrice kao Argumenti za vraćanje vrijednosti

        static void ModificirajCudnuMatricu(int[] arrParam)
        {
            arrParam[0] = 5;
            Console.Write("In ModifyArray() the param is: ");
            IspisiCudnuMatricu(arrParam);
        }
        static void IspisiCudnuMatricu(int[] arrParam)
        {
            Console.WriteLine("=> ČUDNA MATRICA: ");
            Console.Write("[");
            int length = arrParam.Length;
            if (length > 0)
            {
                Console.Write(arrParam[0].ToString());
                for (int i = 1; i < length; i++)
                {
                    Console.Write(", {0}", arrParam[i]);
                }
            }
            Console.WriteLine("]");
        }

        static long IzracunSaMatricom(params int[] elements)
        {
            long sum = 0;
            foreach (var element in elements)
            {
                sum += element;
            }
            return sum;
        }

        #region Pogledajmo još samo par metoda oko matrica
        static void MatriceFunkcionalnosti()
        {
            Console.WriteLine("=> Rad sa System.Array");
            Console.WriteLine();
            // Inicijaliziramo stvake na početku.
            string[] metalBendovi = { "Black Label Society", "Metallica", "Black Sabbath" };

            // Ipisujemo imena u deklariranom redosljedu.
            Console.WriteLine("-> Ovo je Matrica: ");
            for (int i = 0; i < metalBendovi.Length; i++)
            {
                // Napiši ime.
                Console.Write(metalBendovi[i] + ", ");
            }
            Console.WriteLine("\n");

            // Preokreni redosljed.
            Array.Reverse(metalBendovi);
            Console.WriteLine("-> Obrnuta Matrica: ");
            for (int i = 0; i < metalBendovi.Length; i++)
            {
                // Napiši ime.
                Console.Write(metalBendovi[i] + ", ");
            }
            Console.WriteLine("\n");

            // Izbriši sve osim zadnjeg benda.
            Console.WriteLine("-> Obrisano sve osim jednog: ");
            Array.Clear(metalBendovi, 1, 2);
            for (int i = 0; i < metalBendovi.Length; i++)
            {
                // Napiši ime.
                Console.Write(metalBendovi[i] + ", ");
            }
            Console.WriteLine();


        }
        private static void ZamjeniStringove(ref string s1, ref string s2)
        {
            // Swap string variables using tuple deconstruction
            (s1, s2) = (s2, s1);
        }
        #endregion

        #endregion// UVOD U ARRAY'S

        #endregion// CORE PROGRAMMING PART 2


        #endregion// M E T O D E



    }
}
