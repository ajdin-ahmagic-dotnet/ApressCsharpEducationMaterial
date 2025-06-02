using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Uvezen Using posebno radi Extenzivnih Mtoda:
using ExtenzivneMetode;

namespace LINQ_GroundUp_MSDN
{
    /// <summary>
    /// U ovom primjeru što se tiče name konvencije korisit ću se engleskom naming konvencijom za varijable, metode, klase itd...
    /// LINQ GROUND UP MSDN počinje sa jako jednostavnim primjerima linq-a do jako komplikovanih primjera, ali se ovdje zadržavamo na LINQ-om sa objektima u memoriji.
    /// </summary>
    class LINQ_GroundUpProg
    {
        

        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║           --- DOBRODOŠLI U: 'REVIZIJU' LINQ -( GROUND UP ) MSDN  ---           ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            #region PRIMJER 1 - Standardni Query
            Console.Write("1. Da li želite pokrenuti Primjer \"Simple Query\" DA/NE:");
            string odgovor_1 = Console.ReadLine();
            if(odgovor_1.ToLower() == "da")
            {
                // Poziv Metodi:
                SimpleQuery();
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

            #region PRIMJER 2 - Expression Trees
            Console.Write("2. Da li želite pokrenuti Primjer \"Expression Trees\" DA/NE:");
            string odgovor_2 = Console.ReadLine();
            if(odgovor_2.ToLower() == "da")
            {
                // Poziv Metodi:
                ExpressionTrees();
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
            

            #region PRIMJER 3 - Extenzivne Metode 1
            Console.Write("3. Da li želite pokrenuti Primjer \"Extenzivne Metode Primjer 1\" DA/NE:");
            string odgovor_3 = Console.ReadLine();
            if(odgovor_3.ToLower() == "da")
            {
                // Poziv Metodi:
                ExtensionMethods();
                

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

            #region PRIMJER 4 - Extnezivne metode 2
            Console.Write("4. Da li želite pokrenuti Primjer \"Extenzivne Metode Primjer 2\" DA/NE:");
            string odgovor_4 = Console.ReadLine();
            if(odgovor_4.ToLower() == "da")
            {
                // Poziv Metodi:
                Console.WriteLine();
                Console.WriteLine("Extenzivne metode jednostavni primjer:");
                const string s = "Pozdrav Extenzivnim Metodama, bez obzira na sve? I dalje neće moći ovako! Dalje ne ide.";
                int i = s.CountWords();

                Console.WriteLine("Rečenica glasi: {0}", s);
                Console.WriteLine("Riječi ima: {0}", i.ToString());
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

            #region PRIMJER 5 - OfType Operator

            Console.Write("5. Da li želite pokrenuti Primjer \"OfType Oprator Primjer 1\" DA/NE:");
            string odgovor_5 = Console.ReadLine();
            if(odgovor_5.ToLower() == "da")
            {
                // Poziv Metodi:
                OfTypeMethod();
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

            #region PRIMJER 6 - ToArray Primjer
            Console.Write("6. Da li želite pokrenuti Primjer \"ToArray ToList Primjer\" DA/NE:");
            string odgovor_6 = Console.ReadLine();
            if(odgovor_6.ToLower() == "da")
            {
                // Poziv Metodi:
                ToArrayToListMethod();
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

            #region PRIMJER 7 - IQueryable Interface
            Console.Write("7. Da li želite pokrenuti Primjer \"IQueryable Interface\" DA/NE:");
            string odgovor_7 = Console.ReadLine();
            if(odgovor_7.ToLower() == "da")
            {
                // Objekt inicijalizator nam dopušta da napravimo instancu objekta Person i damu mu vrijednosti.
                
                Person p = new Person
                {
                    Name = "Aydin Rose", Age = 30, CanCode = true
                };

                // Semantički ovaj gore izraz je jednak ovom starijem.
                
                Person p1 = new Person();
                p1.Name = "Aydin Rose";
                p1.Age = 30;
                p1.CanCode = true;

                // obajkt inicijalizer je važna stavka za LINQ zato što dozvoljava konstrukciju novih strukturiranih vrijednosti u kontekstu gdje samo izrazi
                // su dozvoljeni ( kao što su lambda izrazi i expression trees ) nrp. evo primjera  koji konstruira objek Person za svaku vrijednost u ulaznoj sekvenci:

                var names = new[]
                     {
                     	new { Name = "Aydin",   Age = 30, CanCode = true},
                     	new { Name = "Edin",    Age = 48, CanCode = true},
                     	new { Name = "Merlena", Age = 37, CanCode = true},
                     	new { Name = "Petra",   Age = 11, CanCode = true},
                     	new { Name = "Filip",   Age = 7, CanCode = true},
                     	new { Name = "Tahir",   Age = 35, CanCode = true},
                     	new { Name = "Edina",   Age = 30, CanCode = true},

                     };

                 IEnumerable<Person> upit = names.Select(s => new Person
                 {
                     Name = s.Name, Age = 30, CanCode = s.Name.Length == 5
                 }
                 );

                 foreach(Person person in upit)
                 {
                     Console.WriteLine("\n{0}\n{1}\n{2}", person.Name, person.Age, person.CanCode);
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

            #region PRIMJER 8 - IQueryable Interface 2
            Console.Write("8. Da li želite pokrenuti Primjer \"IQueryable Interface 2\" DA/NE:");
            string odgovor_8 = Console.ReadLine();
            if(odgovor_8.ToLower() == "da")
            {
                // Nastavak Prethodnog Prijmera podjeljen radi čitljivosti...

                var query = from p in people
                            where p.CanCode == true
                            select p;

                Console.WriteLine("Oni Koji znaju Kodirati su: ");
                foreach(var item in query)
                {
                    Console.WriteLine("Koderi: {0}\n Da li Znaju: {1}", item.Name, item.CanCode);
                }

                Console.WriteLine();

                var query2 = from p in people
                             where p.CanCode == false
                             select p;

                Console.WriteLine("Oni Koji ne znaju Kodirati su:");
                foreach(var item in query2)
                {
                    Console.WriteLine("NeKoderi: {0}\n Da li zanju: {1}", item.Name, item.CanCode);
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

            #region PRIMJER 9 - Strukturirane vrijednosti i tipovi ( ano metode )
            Console.Write("9. Da li želite pokrenuti Primjer \"Strukturirane Vrijednosti i Tipovi\" DA/NE:");
            string odgovor_9 = Console.ReadLine();
            if(odgovor_9.ToLower() == "da")
            {
                // Primjer anonimnih tipova u C#-pu.
                
                // Prvo normalna deklaracija:
                object[] p1 = new Person[]
                {
                   new Person { Name = "Aydin",   Age = 30, CanCode = true},
                   new Person { Name = "Marlena", Age = 37, CanCode = false},
                   new Person { Name = "Edin",    Age = 48, CanCode = true},
                };

                // Sada anonimna deklariacija ( primjetite da nema imena tipa ):
                object[] p2 = new[]
                {
                    new { Name = "Aydin",   Age = 30, CanCode = true},
                    new { Name = "Marlena", Age = 37, CanCode = false},
                    new { Name = "Edin",    Age = 48, CanCode = true},
                };

                // Kreirati upit za anonimne objekte trenutno nije moguće.

                var query = from p in p1
                            select p;


                foreach(Person item in query)
                {
                	Console.WriteLine("Ime: {0}, CanCode: {1}", item.Name, item.CanCode);
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

            #region PRIMJER 10 - Impicitno tipiranje ( uvod ) 
            
            Console.Write("10. Da li želite pokrenuti Primjer \"Implicitno Tipiranje 1\" DA/NE:");
            string odgovor_10 = Console.ReadLine();
            if(odgovor_10.ToLower() == "da")
            {
                // Poziv Metodi:
                ImpricitnoTipiranje_1();
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
            /// Kad su u pitanju matrice ili array koristićemo prvo explicitnu deklaraciju a kasnije ćemo sve primjere raditi u implicitnoj. ///
           
        #region PRIMJER 1 - Standardni Query
        static void SimpleQuery()
        {
            // Deklariramo explicitno array sa imenima:
            string[] names = { "Aydin", "Marlena", "Edin", "Tahir", "Jusuf", "Petra", "Filip", "Edina", "Dževida", "Adi" };


            // Explicitno pozivamo IEnumerable< od string tipa > i postavljamo upit:
            IEnumerable<string> query = from n in names
                                        where n.Length == 5
                                        orderby n
                                        select n.ToUpper();

            // Ovaj query možemo postaviti i na način koji se zove "method base query". Gdje su argumenti Where, OrderBy i Select operatori koji se zovu
            // "Lambda expressions-izrazi", koji su zapravo fragmenti koda, vrlo slični delegatima. Oni dozvoljavaju standardnim query operatorima da 
            // budu definirani individualno kao metode i poveznai zajedno koristeći . tačka notaciju. Zajedno ove metode su baza i osnova Language Integrated Query-ja.
            // Evo Primjera:
            IEnumerable<string> lQuery = names
                                         .Where(s => s.Length == 5)
                                         .OrderBy(s => s)
                                         .Select(s => s.ToUpper());


            // Koristimo foreah petlju sa explicitno zadanim "string"-om i prosljeđujemo IEnumerable 
            // query te ispisujemo imena koja imaju 5 slova, koje je zadao upit. 
            Console.WriteLine("Imena koristeći Standardi Explicitni IEnumerable Query:");
            foreach(string s in query)
            {
                Console.WriteLine("Names: {0}", s);
            }

            Console.WriteLine();
            Console.WriteLine("Imena koristeći Lambda Explicitni IEnumerable Query:");
            foreach(string s in lQuery)
            {
                Console.WriteLine("Names: {0}", s);
            }

            // Mnogi query opertari dozvoljavaju korisniku funkciju da napravi filtering, projekciju ili "key extraction". Upiti se baziraju na 
            // konceptu Lambda izraza, koji nama programerima dozvoljavaju da pišemo funkcije koje mogu biti prosljeđene kao argumenti za evaluaciju.
            // Lambda izrazi su jako slični CLR delegatima. Sada ćemo malo proširiti Primjer 1 da vidimo što se krije ispod haube motora:

            Func<string, bool>   filter  = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> fQuery = names.Where(filter)
                                         .OrderBy(extract)
                                         .Select(project);

            Console.WriteLine();
            Console.WriteLine("Imena koristeći Func<> Delegat sa Labmdom Query:");
            foreach(string s in fQuery)
            {
                Console.WriteLine("Names: {0}", s);
            }

            // Lambda izrazi su naturalna evlocija Anonimnih metoda! Koje su u C# 2.0 prvi put predstavljene. Mogli smo ovaj primjer napisati i ovako 
            // koristeći se anonimnim metodama, za koje je sadašnja Lambda skraćenica u neku ruku:
            Func<string, bool> anoFilter = delegate(string s)
                {
                    return s.Length == 5;
                };

            Func<string, string> anoExtract = s => s;

            Func<string, string> anoProject = delegate(string s)
                {
                    return s.ToUpper();
                };


            Console.WriteLine();
            Console.WriteLine("Imena koristeći Fuck<> Delegat sa Anonimnim Metodama Query:");
            IEnumerable<string> aQuery = names.Where(anoFilter)
                                         .OrderBy(anoExtract)
                                         .Select(anoProject);

            foreach(string s in aQuery)
            {
                Console.WriteLine("Names: {0}", s);
            }
            
        }
        #endregion

        #region PRIMJER 2 - Istraživanje Query-ja - upita
        static void ExpressionTrees()
        {
            // Dodali smo using Ling.Expressions i sada radimo na istraživanju linq-a:

            Expression<Func<int, bool>> filter = n => n < 5;

            BinaryExpression    body  = (BinaryExpression)filter.Body;
            ParameterExpression left  = (ParameterExpression)body.Left;
            ConstantExpression  right = (ConstantExpression)body.Right;

            Console.WriteLine("{0} {1} {2}", left.Name, body.NodeType, right.Value);
        }
        #endregion

        #region PRIMJER 3 - Extenzivne Metode Primjer 1
        static void ExtensionMethods()
        {
            // Lambda izrazi su jedan vrlo važan dio upitne infrastrukture. Extenzivne Metode su drugi važan dio infrastrukture. Pa ćemo se nakratko
            // pozabaviti "Produženim Metodama".
            // Produžene metode su definirane u statičnim kalsama i kao statične metode, a kao parametar se uvijek mora koristiti "this" modifikator
            // uvjek kao prvi parametar! 
            

            // Primjer LINQ Extenzivne metode ( namjerno implicitno deklarirana array):
            var integeri = new[] { 10, 12, 23, 34, 54, 25, 56, 59, 85, 73, 22, 45, 56, 78, 91, 23, 45, 56, 26, 31 };

            // Primjena exenzivne metode "OrderBy" na implicitnu matricu:
            var rezultat = integeri.OrderBy(i => i);

            foreach(var r in rezultat)
            {
                Console.Write(r + " ");
            }

            // Izlaz bi trebao da poreda brojeve od najmanjeg prema najvećem....
        } 
        #endregion
         
        // PRIMJER 4: JE KLASA "MOJE EXTENZIJE" //

        #region PRIMJER 5 - OfType Operator 
        static void OfTypeMethod()
        {
            // Array Objekata:
            object[] values = { 1, "Pozdrav", true, "Svijete", 'C', "Iz C# Programskog", 3.800m, "Jezika" };

            // OfType nam omogućava da iz array objekata raznih varijabli izdvojimo samo one koje su nama potrebne!
            IEnumerable<string> justStrings = values.OfType<string>();

            // Iteracija kroz upit: 
            foreach(string s in justStrings)
            {
                Console.WriteLine(s);
            }
        }
        #endregion

        #region PRIMJER 6 - ToArray Primjer Metoda
        static void ToArrayToListMethod()
        {
            // Deklariramo matricu tipa string:
            string[] names = { "Aydin", "Marlena", "Edina", "Tahir", "Petra", "Jusuf", "Filip", "Edin" };

            // Kreiramo explicitni upit košitenjem lambda izraza:
            IEnumerable<string> sviSaA = names.Where(s => s[0] == 'E').ToArray(); // Kad stavimo ovaj izraz ovjde vidjećemo uvjek samo prvu kopiju podataka izmjene imena na indexima [0] i [3] nećemo vidjeti!

            Console.WriteLine("Imena sa liste koja počinju slovom E:");
            // Evaluriramo upit:
            foreach(string s in sviSaA)
            {
                Console.WriteLine(s);
            }

            // Modificiramo određeni rekord u matrici:
            names[0] = "Elena";
            names[3] = "Ena";

            Console.WriteLine();
            Console.WriteLine("Imena sa liste sa promenjenom konstrukcijom koja počinju sa E:");
            // Evaluramo upit ponovno:
            foreach(string s in sviSaA)
            {
                Console.WriteLine(s);
            }

            // Ovaj upit je evaluiran svaki put kada varijabla "sviSaA" je iterirana. Da indiciramo da je "chashed copy" potreban samo moramo
            // naznačiti ToArray() ili ToList(). Oba izraza tjeraju upit da bude evaluiran odmah. Isto je tačno i za neke druge npr: "First"
            // "ElementAt", "Sum", "Average", "All" i "Any". 
        } 
        #endregion

        #region PRIMJER - 8 IQueryable Interface ( PEOPLE ARRAY )
        // Objekt inicijalizator je jako dobar za inicijaliziranje strukturiranih matrica vrijednosti npr:
        readonly static Person[] people = 
        {
            new Person { Name = "Aydin",   Age = 30, CanCode = true},
            new Person { Name = "Marelna", Age = 37, CanCode = false},
            new Person { Name = "Filip",   Age = 7,  CanCode = false},
            new Person { Name = "Edin",    Age = 48, CanCode = true},
            new Person { Name = "Tahir",   Age = 30, CanCode = false},
            new Person { Name = "Alen",    Age = 35, CanCode = true},
        };

        #endregion

        // PRIMJER 9 NEMA METODNU IMPLEMENTACIJU //

        #region PRIMJER 10 - Implicitno Tipiranje
        static void ImpricitnoTipiranje_1()
        {
            // Uvod u ključnu riječ "var". Var je prikladna za varijable čiji tip ima značajno ime, ali je neophodno da varijable referiraju 
            // anonimnim tipovima.

            // Primjer:
            var value = new
            {
                Name = "Aydin", Age = 30, CanCode = true
            };

            // Anonimni tipovi ne mogu biti djeljeni po assembly-jima! 
            // Evo prmjera koji kreira novu strukturiranu vrijednost tako što kombinira osobine drugih vrijednosti:

            // Primjer 1:

            var ajdin = new Person { Name = "Aydin", Age = 30, CanCode = true };
            
            // Anonimni ekvivalent:
            var edina = new { Name = "Edina", Age = 55, CanCode = false };

            // Primjer 2:
            var par = new[]
            {
                new { ajdin.Name, ajdin.Age, ajdin.CanCode},
                new { edina.Name, edina.Age, edina.CanCode},
            };

            var ljudi = new
            {
                Aydin   = new { Name = "Aydin",   Age = 30},
                Edin    = new { Name = "Edin",    Age = 48},
                Edina   = new { Name = "Edina",   Age = 55},
                Marlena = new { Name = "Marlena", Age = 38},
                Tahir   = new { Name = "Tahir",   Age = 69}, 
                Jusuf   = new { Name = "Jusuf",   Age = 86},
            };

            // Kako napraviti upit za "ljudi" nisam pronašao...

            var query = from p in par
                        select p;

            foreach(var item in query)
            {
                Console.WriteLine("Ime: {0}\nDa li zna Kodirati: {1}", item.Name, item.CanCode);
            }


            Console.WriteLine();
            Console.WriteLine("povratak na \"People\" array:");

            // Korištenje ano metode vrlo efikasno identificira osobu koja ima 7 godina i dole u foreach petlji na temelju ovdje iraza koji kaže
            // da svaki "Koder" koji ima 7 godina je loš koder. 
            var query2 = people.Select(p => new { p.Name, BadCoder = p.Age == 7 });

            foreach(var item in query2)
            {
                Console.WriteLine("{0} je {1} Koder.", item.Name, item.BadCoder ? "loš" : "dobar");
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
