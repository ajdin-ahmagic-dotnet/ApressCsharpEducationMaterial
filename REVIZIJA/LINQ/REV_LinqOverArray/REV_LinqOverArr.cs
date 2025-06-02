using System;
using System.Collections.Generic;
using System.Linq;
// Uvezneno za Primjer 13
using System.Collections;

namespace REV_LinqOverArray
{
    class REV_LinqOverArr
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu("║                         ║            --- DOBRODOŠLI U: 'REVIZIJU' LINQ Preko Matrica ---                 ║                         ║");
            NapisiPunuCrtu("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 200);

            #region PRIMJER 1 - Upit Preko String matrice sa LINQ-om
            
            Console.Write("1. Da li želite pozvati Primjer 'Upit Preko String sa LINQ-om' DA/NE: ");
            string odgovor = Console.ReadLine();
            if (odgovor.ToLower() == "da")
            {
                // Poziv Metodi:
                UpitPrekoString();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Odgovorili ste: \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 2 - Upit Preko String matrice Bez LINQ-a

            Console.Write("2. Da li želite pozvati Primjer 'Upit Preko String bez LINQ-a' DA/NE: ");
            string odgovor_2 = Console.ReadLine();
            if(odgovor_2.ToLower() == "da")
            {
                // Poziv Metodi:
                UpitPrekoStringDuzimPutem();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Odgovorili ste: \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 3 - EXTENSION METHODS

            Console.Write("3. Da li želite pozvati Primjer Remove Spaces in String DA/NE:");
            string odgovor_3 = Console.ReadLine();
            if (odgovor_3.ToLower() == "da")
            {
               // Experimentiranje sa mojim produženim metodama koje se mogu dodati na sve string varijable!

                string text2 = "jebem ti mater u šupak".CharReverse().StringReverse();

                Console.WriteLine(text2);

                string text = "Ovo je string sa prostorom da vidimo kako će metoda izvući sav prazni prostor!";
                Console.WriteLine("Ovo je string prije pozivanja metode: ");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine("Poslje pozivanje produžene Metode  \"RemoveSpaces()\":");
                Console.WriteLine();
                Console.WriteLine(text.RemoveSpaces());
                Console.WriteLine();
                Console.WriteLine(text.StringReverse());
                Console.WriteLine();
                Console.WriteLine(text.CharReverse().StringReverse());
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Odgovorili ste \"NE\". Program se nastavlja dalje...");
            }

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 4 - Query Over Int

            Console.Write("4. Da li želite pokrenuti Primjer 'Upit preko Int' DA/NE: ");
            string odgovor_4 = Console.ReadLine();
            if(odgovor_4.ToLower() == "da")
            {
            	// Poziv Metodi:
                UpitPrekoInt();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Odabrali ste \"NE\" kao odgovor. Program se nastavlja dalje...");
            }
 
            
            #endregion          

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER 5 - Upit Preko Int Implicitno
            Console.Write("5. Da li želite pokrenuti Primjer \"Upit Preko Int-a Implicitno\" DA/NE:");
            string odgovor_5 = Console.ReadLine();
            if(odgovor_5.ToLower() == "da")
            {
                // Poziv Metodi:
                UpitPrekoIntImplicit();
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

            #region PRIMJER 6 - Experiment (Implicitne Matrice sa Linq-om)
            Console.Write("6. Da li želite pokrenuti Primjer \"Implicitne Matrice sa Linq-om\" DA/NE:");
            string odgovor_6 = Console.ReadLine();
            if(odgovor_6.ToLower() == "da")
            {
                // Poziv Metodi:
                ImplicitneMatriceSaLinqom();
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

            #region PRIMJER 7 Exeriment (Implicitne Liste Sa Linq-om)
            Console.Write("7. Da li želite pokrenuti Primjer \"Implicitne Liste sa Linq-om\" DA/NE:");
            string odgovor_7 = Console.ReadLine();
            if(odgovor_7.ToLower() == "da")
            {
                // Poziv Metodi:
                ImplicitneListeSaLinqom();
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

            #region PRIMJER 8 - Immediate Execution (Izvršavanje Odmah)
            Console.Write("8. Da li želite pokrenuti Primjer \"Immediate Execution\" DA/NE:");
            string odgovor_8 = Console.ReadLine();
            if(odgovor_8.ToLower() == "da")
            {
                // Poziv Metodi:
                ImmediateExecution();

                
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

            #region PRIMJER 9 - Returning the Result of a LINQ Query
            Console.Write("9. Da li želite pokrenuti Primjer \"Returning the Result of a LINQ Query\" DA/NE:");
            string odgovor_9 = Console.ReadLine();
            if(odgovor_9.ToLower() == "da")
            {
                // Za ovaj Primjer koristit ćemo novu klasu dole, a medou moremo pozvati preko instance klase jer nije statična metoda:
                LINQPolja l = new LINQPolja();

                l.IspisiIgrice();

                
                
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

            #region PRIMJER 10 - KAKO Pozivaocu Vratiti Upit ? Ovako...
            Console.Write("10. Da li želite pokrenuti Primjer \"Kako Pozivaocu Vratiti Upit\" DA/NE:");
            string odgovor_10 = Console.ReadLine();
            if(odgovor_10.ToLower() == "da")
            {
                // Poziv Metodi:
                IEnumerable<string> podset = GetStringPodSet();

                foreach(string item in podset)
                {
                    Console.WriteLine("Boje su: {0}", item);
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

            #region PRIMJER 11 - Vraćanje LINQ Rezultata kroz Izvršavanje Odmah (Returning LINQ Results via Immediate Execution)
            Console.Write("11. Da li želite pokrenuti Primjer \"Returning LINQ Results via Immediate Execution\" DA/NE:");
            string odgovor_11 = Console.ReadLine();
            if(odgovor_11.ToLower() == "da")
            {
                // Zato što je malo nezgodno operirati sa Ienumerable<T>, mi možemo uključiti Immediate Execution. 
                // Umjesto da vratimo IEnumerable<string> možemo vratiti samo string[] array.
                
                // Sada samo prolazimo kroz foreach:
                foreach(string item in GetStringPodSetKaoArray())
                {
                    Console.WriteLine("Boje su: {0}", item);
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

            #region PRIMJER 12 - Applying LINQ Queries to Collection Objects
            Console.Write("12. Da li želite pokrenuti Primjer \"Applying LINQ Queries to Collection Objects\" DA/NE:");
            string odgovor_12 = Console.ReadLine();
            if(odgovor_12.ToLower() == "da")
            {
                // Pravimo Listu Objekata "Auto" kalse definirane dole "Primjer 12":
                List<Auto> auti = new List<Auto>()
                {
                    new Auto { Ime = "BMW 525",          Boja = "Crna",   Brzina = 260, Proizvodzac = "BMW"},
                    new Auto { Ime = "BMW 735",          Boja = "Plave",  Brzina = 250, Proizvodzac = "BMW"},
                    new Auto { Ime = "BMW 645",          Boja = "Crvena", Brzina = 280, Proizvodzac = "BMW"},
                    new Auto { Ime = "Mercedes 230c",    Boja = "Siva",   Brzina = 220, Proizvodzac = "Mercedes"},
                    new Auto { Ime = "Ferrari F50",      Boja = "Žuta",   Brzina = 360, Proizvodzac = "Ferrari"},
                    new Auto { Ime = "Golf 5 TDI",       Boja = "Crna",   Brzina = 160, Proizvodzac = "Wolksvaggen"},
                    new Auto { Ime = "Opel Vectra 1.6",  Boja = "Crvena", Brzina = 120, Proizvodzac = "Opel"},
                    new Auto { Ime = "Buggati Vejron 2", Boja = "Zelena", Brzina = 430, Proizvodzac = "Buggati"},
                };

                Console.WriteLine("Auti koji idu brže od 200km/h, a manje od 300km/h su:");

                // Pošto dole imamo pomoću metodu koja nam izračunava koje aute trebamo sada je samo trebamo pozvati,
                // ali je ključno to da joj moramo prosljediti parametar liste koju želimo da evaluiramo!
                DajBrzeAute(auti);

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                DajBrzeBMW(auti);
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

            #region PRIMJER 13 - Applying LINQ Queries To NonGeneric Collection
            Console.Write("13. Da li želite pokrenuti Primjer \"LINQ Upiti za NeGenerične kolekcije\" DA/NE:");
            string odgovor_13 = Console.ReadLine();
            if(odgovor_13.ToLower() == "da")
            {
                // Poziv Metodi:
                LINQPrekoArrayListe();
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

            #region PRIMJER 14 - Korištenje OfType Metode kao Filtera za objekte unutar ne generičnih kolekcija
            Console.Write("14. Da li želite pokrenuti Primjer \"OfType() Kao filter NeGeneričnim kolekcijama\" DA/NE:");
            string odgovor_14 = Console.ReadLine();
            if(odgovor_14.ToLower() == "da")
            {
                // Poziv Metodi:
                OfTypeKaoFilter();
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

            #region PRIMJER 15 - LINQ EXPRESSIONS - IZRAZI
            Console.Write("15. Da li želite pokrenuti Primjer \"LINQ EXPRESSIONS - IZRAZI\" DA/NE:");
            string odgovor_15 = Console.ReadLine();
            if(odgovor_15.ToLower() == "da")
            {
                // Ovdje u Main() Metodi pravimo array ProductInfo klase za naše testiranje:
                ProductInfo[] stavkeNaLageru = new[]
                {
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 2mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 10},
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 8mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 15},
                	new ProductInfo { Ime = "Apaurin KRKA 2mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 20},
                	new ProductInfo { Ime = "Apaurin KRKA 5mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 30},
                	new ProductInfo { Ime = "Apaurin KRKA 10mg",         Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 25},
                	new ProductInfo { Ime = "Heptanon PLIVA 5mg",        Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 30},
                	new ProductInfo { Ime = "Morfin KRKA 50mg",          Opis = "Narkotik za liječenje teških bolova.",            BrojNaLageru = 15},
                };

                // Metoda koja selektira sve produkte iz array: 
                SelektirajSve(stavkeNaLageru);

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                // Metoda koja selektira samo imena produkata:
                SamoImenaProdukata(stavkeNaLageru);

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                // Metoda koja selektira samo produkte koji imaju 20 i više pakala na lageru:
                PrekoDvadesetNaLageru(stavkeNaLageru);

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                // Metoda koja nam vraća samo narkotiče produkte:
                SamoNarkotici(stavkeNaLageru);
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

            #region PRIMJER 16 - Projecting New Data Types ( projektiranje novih Podatkovnih Tipova) 1
            Console.Write("16. Da li želite pokrenuti Primjer \"Projektiranje novih Podatkovnih Tipova\" DA/NE:");
            string odgovor_16 = Console.ReadLine();
            if(odgovor_16.ToLower() == "da")
            {
                // Ovdje u Main() Metodi pravimo array ProductInfo klase za naše testiranje:
                ProductInfo[] stavkeNaLageru = new[]
                {
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 2mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 10},
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 8mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 15},
                	new ProductInfo { Ime = "Apaurin KRKA 2mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 20},
                	new ProductInfo { Ime = "Apaurin KRKA 5mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 30},
                	new ProductInfo { Ime = "Apaurin KRKA 10mg",         Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 25},
                	new ProductInfo { Ime = "Heptanon PLIVA 5mg",        Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 30},
                	new ProductInfo { Ime = "Morfin KRKA 50mg",          Opis = "Narkotik za liječenje teških bolova.",            BrojNaLageru = 15},
                };

                // Ovakvo projektiranje vadi direktno iz array objekta ono što smo pozvali u formatu u kakvom je u samom kodu, jer nismo drugačije specificirali...

                // Poziv Metodi:
                DajImeIOpis(stavkeNaLageru);
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

            #region PRIMJER 17 - Projecting New Data Types ( projektiranje novih Podatkovnih Tipova) 2
            Console.Write("17. Da li želite pokrenuti Primjer \"Projektiranje Novih Podatkovnih Tipova\" DA/NE:");
            string odgovor_17 = Console.ReadLine();
            if(odgovor_17.ToLower() == "da")
            {
                // Ovdje u Main() Metodi pravimo array ProductInfo klase za naše testiranje:
                ProductInfo[] stavkeNaLageru = new[]
                {
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 2mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 10},
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 8mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 15},
                	new ProductInfo { Ime = "Apaurin KRKA 2mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 20},
                	new ProductInfo { Ime = "Apaurin KRKA 5mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 30},
                	new ProductInfo { Ime = "Apaurin KRKA 10mg",         Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 25},
                	new ProductInfo { Ime = "Heptanon PLIVA 5mg",        Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 30},
                	new ProductInfo { Ime = "Morfin KRKA 50mg",          Opis = "Narkotik za liječenje teških bolova.",            BrojNaLageru = 15},
                };

                // Poziv Metodi:
                Array objekti = DajProjektiraniPodset(stavkeNaLageru);

                foreach(object o in objekti)
                {
                    Console.WriteLine(o); // Poziva ToString() na svaki anonimni objekt!
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

            #region PRIMJER 18 - Dobivanje Broja (Count) Preko Enumerable-a
            Console.Write("18. Da li želite pokrenuti Primjer \"Dobivanje ( Count() ) Koristeći Enumerable\" DA/NE:");
            string odgovor_18 = Console.ReadLine();
            if(odgovor_18.ToLower() == "da")
            {
                // Poziv Metodi:
                DajCountIzUpita();
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

            #region PRIMJER 19 - Preokretanje Rezultatnog Seta na ProductInfo[] Array objekata
            Console.Write("19. Da li želite pokrenuti Primjer \"Preokretanje Rezultatnog Seta na ProductInfo[] Array objekata\" DA/NE:");
            string odgovor_19 = Console.ReadLine();
            if(odgovor_19.ToLower() == "da")
            {
                // Ovdje u Main() Metodi pravimo array ProductInfo klase za naše testiranje:
                ProductInfo[] stavkeNaLageru = new[]
                {
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 2mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 10},
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 8mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 15},
                	new ProductInfo { Ime = "Apaurin KRKA 2mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 20},
                	new ProductInfo { Ime = "Apaurin KRKA 5mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 30},
                	new ProductInfo { Ime = "Apaurin KRKA 10mg",         Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 25},
                	new ProductInfo { Ime = "Heptanon PLIVA 5mg",        Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 30},
                	new ProductInfo { Ime = "Morfin KRKA 50mg",          Opis = "Narkotik za liječenje teških bolova.",            BrojNaLageru = 15},
                };

                // Poziv Metodi:
                PreokreniSve(stavkeNaLageru);
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

            #region PRIMJER 20 - Sortirajući Izrazi - Sorting Expressions
            Console.Write("20. Da li želite pokrenuti Primjer \"Sortirajući Izrazi\" DA/NE:");
            string odgovor_20 = Console.ReadLine();
            if(odgovor_20.ToLower() == "da")
            {
                // Ovdje u Main() Metodi pravimo array ProductInfo klase za naše testiranje:
                ProductInfo[] stavkeNaLageru = new[]
                {
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 2mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 10},
                	new ProductInfo { Ime = "Buprenofphin Alkaloid 8mg", Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 15},
                	new ProductInfo { Ime = "Apaurin KRKA 2mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 20},
                	new ProductInfo { Ime = "Apaurin KRKA 5mg",          Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 30},
                	new ProductInfo { Ime = "Apaurin KRKA 10mg",         Opis = "Anksiolitik za liječenje anksioznih poremećaja.", BrojNaLageru = 25},
                	new ProductInfo { Ime = "Heptanon PLIVA 5mg",        Opis = "Narkotik za liječenje ovisnosti o opijatima.",    BrojNaLageru = 30},
                	new ProductInfo { Ime = "Morfin KRKA 50mg",          Opis = "Narkotik za liječenje teških bolova.",            BrojNaLageru = 15},
                };
                // Poziv Metodi:
                AlfabetizirajImenaProdukata(stavkeNaLageru);
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

            #region PRIMJER 21 - LINQ kao bolji Diagramski alat - LINQ As better diagramming Tool
            Console.Write("21. Da li želite pokrenuti Primjer \"LINQ kao bolji Diagramski Alat - LINQ As better diagramming Tool\" DA/NE:");
            string odgovor_21 = Console.ReadLine();
            if(odgovor_21.ToLower() == "da")
            {
                Console.WriteLine();

                // Poziv Metodi:
                PrikaziRazlike();

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                // Poziv Metodi:
                PrikaziIntersekciju();

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                // Poziv Metodi:
                PrikaziUnion();

                #region DELIMITER
                Console.WriteLine();
                Console.WriteLine();
                #endregion

                // Poziv Metodi:
                PrikaziConcat();
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

            #region PRIMJER 22 - Uklanjanje Duplikata - Removing Duplicates
            Console.Write("22. Da li želite pokrenuti Primjer \"Uklanjanje Duplikata\" DA/NE:");
            string odgovor_22 = Console.ReadLine();
            if(odgovor_22.ToLower() == "da")
            {
                // Poziv Metodi:
                PrikaziConcatBezDup();
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

            #region PRIMJER 23 - LINQ Operacije Sakupljanja - LINQ Aggregation Operations
            Console.Write("23. Da li želite pokrenuti Primjer \"LINQ Agregacijeske Operacije\" DA/NE:");
            string odgovor_23 = Console.ReadLine();
            if(odgovor_23.ToLower() == "da")
            {
                // Poziv Metodi:
                SakupljackeOperacije();
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

            #region PRIMJER 24 - Interna Reprezentacija LINQ upitnih izraza - The internal Representation of LINQ query Statements
             
            #endregion


            Console.WriteLine();
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

        #region PRIMJER 1 - Upit Preko String -- METODA --

        static void UpitPrekoString()
        {
            // Pretpostavimo da imamo ovakvu matricu objekata:
            string[] trenutneVideoIgre = { "Doom", "Doom 2", "Diablo 2", "Warcraft", "Stracraft 3", "Generals 2", "Battelefield 2" };

            // Pod pretpostavkom da želim izlistati ove elemente iz matrice to možemo uraditi sa Array metodama i sosobinama
            // ali malo teže, tu nam uskače LINQ koji puno pojednostavljuje proces. Recimo da želimo iz matrice izvući elemente
            // koji imaju prazan prostor npr. "Doom 2" to možemo na sljedeći način:


            // Napravi "query" izraz koji nalazi stavke u matrici koji imaju jedan prazan prostor:
            IEnumerable<string> podset = from igre in trenutneVideoIgre
                                         where igre.Contains(" ") // Where klauzula određuje da li igre imaju prazan prostor preko "Contains" Metode
                                         orderby igre // Ovako soritiramo po redosljedu elemente u matrici
                                         select igre; // Na kraju selektiramo sve igre u matrici...

            Console.WriteLine();
            Console.WriteLine("Trenutne video igre sa jednim praznim prostorom:");


            // Ispisujemo rezultate na konzolu:
            foreach(string s in podset)
            {
                Console.WriteLine("Stavka: {0}", s); 
            }

            // Pozivamo metodu Reflektiranje preko Upita:
            RefleksijaPrekoUpita(podset);

        }

        #endregion

        #region PRIMJER 2 - Upit Preko String Straim Dužim putem -- METODA --

        static void UpitPrekoStringDuzimPutem()
        {
            // Kako bi pokazali da LINQ nije obavezan iste rezultate možemo dobiti starim putem sa "if" i "for" izrazima.
            // Ali pogledajte koliko nam je koda trebalo da obavimo isti posao bez korištenja LINQ-a!
            // LINQ nije obavezan ali je svakako puno lakši za pisati...

            // Pretpostavimo da imamo ovakvu matricu objekata:
            string[] trenutneVideoIgre = { "Doom", "Doom 2", "Diablo 2", "Warcraft", "Stracraft 3", "Generals 2", "Battelefield 2" };

            // Pravimo novu matricu koja će držati elemente koji imaju jedan prostor prazan:
            string[] igreSaProstorom = new string[7];

            // Pravimo "For" petlju da iteriramo preko matrice:
            for(int i = 0; i < trenutneVideoIgre.Length; i++)
            {
                // Zadajemo uvjet "if":  
                if (trenutneVideoIgre[i].Contains(" "))
                {
                    igreSaProstorom[i] = trenutneVideoIgre[i];
                }
            }

            // Sada sortiramo matricu:
            Array.Sort(igreSaProstorom); 

            Console.WriteLine();
            Console.WriteLine("Trenutne video igre sa jednim praznim prostorom:");

            // Tek sada smo došli do ispisivanja rezultata na konzolu:
            foreach(string s in igreSaProstorom)
            {
                // Zadajemo "if" uvjet da provjerimo da li je s != null:
                if(s != null)
                {
                    Console.WriteLine("Stavka: {0}", s);
                }

                
            }
        }

        #endregion

        #region PRIMJER 3 - Reflektiranje Preko Upitnih Rezultata

        static void RefleksijaPrekoUpita(object rezultatSet)
        {
            Console.WriteLine("********** Info o Upitu **********");
            Console.WriteLine("rezultatSet je tipa: {0}", rezultatSet.GetType().Name);
            Console.WriteLine("rezultatSet lokacija: {0}", rezultatSet.GetType().Assembly.GetName().Name);
            
        }

        #endregion

        #region PRIMJER 4 - Upit Preko Int -- METODA --

        static void UpitPrekoInt()
        {
            // Pravimo matricu brojeva:
            int[] brojevi = { 10, 20, 30, 40, 50, 1, 2, 3, 7, 8, };

            // Ispisujemo samo brojeve koji su veći od 10:
            IEnumerable<int> podset = from b in brojevi
                                      where b > 10
                                      orderby b 
                                      select b;


            

            Console.WriteLine("Brojevi veći od 10:");
            foreach(int b in podset)
            {
                Console.WriteLine("Stavka: {0}", b);
            }
            RefleksijaPrekoUpita(podset);
        }

        #endregion

        #region PRIMJER 5 - UPIT PREKO INT (INPLICITNO)

        static void UpitPrekoIntImplicit()
        {
            int[] brojevi = { 10, 20, 30, 40, 50, 60, 70 };

            var brojeviImplicit = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 }; 

            var upit = from b in brojevi
                       where b < 20 || b > 40
                       select b;

            Console.WriteLine("Brojevi manji od 20 i veći od 40: ");
            foreach(var broj in upit)
            {
                Console.WriteLine("Broj: {0} < 20 i > 20", broj);
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Dodani Broj na indexu 2 matrice:
            brojevi[1] = 15;
            
            // Evalucaija opet:
            foreach(var item in upit)
            {
                Console.WriteLine("Broj: {0} < 20 i > 20", item);
            }

            RefleksijaPrekoUpita(upit);
        }

        #endregion

        #region PRIMJER 6 - Implicitne Matrice sa LINQ-om 
        
        static void ImplicitneMatriceSaLinqom()
        {
            // Deklariramo implicitnu array:
            var kontakti = new[]
            {
            	new  
                {
                    Ime = "Aydin Rose",
                    Adresa = "Aleja Matice Hr. 41",
                    Telefon = new[] { "097-762-9566", "097-762-9565"} 
                },
                new  
                {
                	Ime = "Edina Mehemedalić",
                    Adresa = "IX ulica br. 23",
                    Telefon = new[] {"063-210-835"}
                }
            };

            var upit = from k in kontakti
                       select k;

            foreach(var k in kontakti)
            {
                Console.WriteLine("Kontakti: {0}\n{1}\n{2}", k.Ime, k.Adresa, k.Telefon[0]); // Da bi bio prikazan telefon ovdje moramo naznačiti koji index pod matrice želimo!
            }
            

        }
        #endregion

        #region PRIMJER 7 - Implicitne Liste Sa Linq-om

        static void ImplicitneListeSaLinqom()
        {
           var kontakti = new[]
           {
           	   new {Ime = "Aydin Rose", Adresa = "Aleja Matice Hr. 41", Placa = "4.500"},
               new {Ime = "Marlena G.Ahmagić", Adresa = "Aleja Matice hr. 41", Placa = "6.500"},
           }.ToList();


            var upit = from k in kontakti
                       select k;
            
            foreach(var k in upit)
            {
                Console.WriteLine("\nKontakt: " + "\n{0}\n{1}\n{2}", k.Ime, k.Adresa, k.Placa );
            }
        }

        #endregion

        #region PRIMJER 8 - IMMEDIATE EXECUTION ( IZVRŠAVANJE ODMAH )

        static void ImmediateExecution()
        {
            // Int array brojeva:
            int[] brojevi = { 10, 20, 30, 40, 50, 1, 2, 3, 4, 5, 6, 8, 9, 12, 15 };

            // DAJ PODATKE ODMAH KAO Array int[]:
            int[] podsetKaoIntArray = (from b in brojevi where b < 20  select b).ToArray<int>(); // Komotno može i bez parametara...

            // DAJ PODATKE ODMAH KAO List<int>:
            List<int> podsetKaoIntList = (from b in brojevi where b < 20  select b).ToList(); // Kao ovdje...

            // Da se primjetiti da nema Query tj. upita on je ugnježđen...

            foreach(int item in podsetKaoIntArray)
            {
                Console.WriteLine("Broj Broj: {0} < 20", item);
            }
            
            // Isti princip je i sa drugim primjerom...
        }

        #endregion

        #region PRIMJER 9 - Vraćanje Rezultata LINQ upita (Returning the Result of a LINQ Query)
        // Pošto ovo ovako radimo samo da naznačim da je ovo ugnježđena klasa...
        internal class LINQPolja
        {
            private static string[] trenutneIgre = { "Doom 2", "Super Mario Bros 3", "Red Alert 3", "Battelefield", "Morrowind", "Bleifuss" };

            // Ne možemo koristiti implicitno tipiranje ovdje! Moramo koristiti znani tip podseta!
            private IEnumerable<string> podset = from i in trenutneIgre
                                                 where i.Contains(" ")
                                                 orderby i
                                                 select i;

            public void IspisiIgrice()
            {
                foreach(var item in podset)
                {
                    Console.WriteLine("Igrice su: {0}", item);
                }
            }
        }

      
        #endregion

        #region PRIMJER 10 - Kako vratiti pozivaocu LINQ upit? 
        // Pravimo metodu u kojoj je tip IEnumerable interface od tipa string!
        static IEnumerable<string> GetStringPodSet()
        {
            string[] boje = { "Crna", "Crvena", "Zelena", "Žuta", "Narančasta", "Smeđa", "Plava", "Tamno Crvena", "Tamno Zelena", "Svijetlo Crvena", "Krvavo Crvena" };

            // Da se primjetiti da podset je IEnumerable komaptibilan objekt!
            IEnumerable<string> podset = from b in boje
                                         where b.Contains("Crvena")
                                         orderby b
                                         select b;
            return podset;
        }
        #endregion

        #region PRIMJER 11 - Returning LINQ Results via Immediate Execution
        // Motoda kojoj je tip string[] matrica!
        static string[] GetStringPodSetKaoArray()
        {
            string[] boje = { "Crna", "Crvena", "Svijetlo Zelena", "Žuta", "Narančasta", "Smeđa", "Plava", "Tamno Crvena", "Tamno Zelena", "Crvena", "Krvavo Crvena", "Zelena" };

            var podset = from b in boje
                         where b.Contains("Zelena")
                         orderby b
                         select b;

            // Mapiraj rezulat kao array:
            return podset.ToArray();
        }
        #endregion

        #region PRIMJER 12 - Applying LINQ Queries to Collection Objects
        // Za ovaj Primjer treba nam klasa ugnježđena u ovom slučaju, pošto ne želim da iskačem iz ove klase pravim sve na jednom mjestu.
        // Ali pretpostavimo da je ova klasa exetra klasa za ovaj primjer:
        class Auto
        {
            public string Ime { get; set; }
            public string Boja { get; set; }
            public int Brzina { get; set; }
            public string Proizvodzac { get; set; }


        }

        // Da bi pristupili objektima u List<Auto> treba nam pomoćna metoda koja mora biti definirana u Main() Metodi, koja slijedi,
        // a kao parametar mora imati tu listu koja je od tipa KLASE "Auto"!
        static void DajBrzeAute(List<Auto> brziAuti)
        {
            // Pronađi sve Aute u listi koji idu brže od 200 a manje od 300 km/h:
            var podset = from a in brziAuti
                         where a.Brzina > 200 & a.Brzina < 300
                         orderby a.Brzina
                         select a;

            foreach(var auto in podset)
            {
                Console.WriteLine("Ime: {0}\nBrzina: {1}\n", auto.Ime, auto.Brzina);
            }
        }

        // Metoda koja vraća SAMO brze BMW objekte iz liste objekata Auto:
        static void DajBrzeBMW(List<Auto> bmw)
        {
            var podset = from a in bmw
                         where a.Brzina > 200 && a.Proizvodzac == "BMW"
                         orderby a.Brzina
                         select a;

            Console.WriteLine("Samo Brzi BMW Auti:");
            foreach(var auto in podset)
            {
                Console.WriteLine("Ime: {0}\n Brzina: {1}", auto.Ime, auto.Brzina);
            }
        }
        #endregion

        #region PRIMJER 13 - Applying LINQ Queries To NonGeneric Collection
        static void LINQPrekoArrayListe()
        {
            // U ovome primjeru koristimo iznimo koristnu metodu TypeOf(). 

            // Ovdje pravimo negeneričnu listu Auta:
            ArrayList auti = new ArrayList()
            {
                new Auto { Ime = "BMW 525",          Boja = "Crna",   Brzina = 260, Proizvodzac = "BMW"},
                new Auto { Ime = "BMW 735",          Boja = "Plave",  Brzina = 250, Proizvodzac = "BMW"},
                new Auto { Ime = "BMW 645",          Boja = "Crvena", Brzina = 280, Proizvodzac = "BMW"},
                new Auto { Ime = "Mercedes 230c",    Boja = "Siva",   Brzina = 220, Proizvodzac = "Mercedes"},
                new Auto { Ime = "Ferrari F50",      Boja = "Žuta",   Brzina = 360, Proizvodzac = "Ferrari"},
                new Auto { Ime = "Golf 5 TDI",       Boja = "Crna",   Brzina = 160, Proizvodzac = "Wolksvaggen"},
                new Auto { Ime = "Opel Vectra 1.6",  Boja = "Crvena", Brzina = 120, Proizvodzac = "Opel"},
                new Auto { Ime = "Buggati Vejron 2", Boja = "Zelena", Brzina = 430, Proizvodzac = "Buggati"},
                new Auto { Ime = "Lamborgini Diablo",Boja = "Žuta",   Brzina = 310, Proizvodzac = "Labmorgini"},
                new Auto { Ime = "Aston Matrin 300", Boja = "Plava",  Brzina = 290, Proizvodzac = "Aston Martin"},
            };

            // Sada TypeOf transformira ArrayList u IEnumerable<T> kompatibilan tip, što ona nije!
            var mojiAutoEnum = auti.OfType<Auto>();

            // Kreiramo upitni izraz koji traži komaptibilni tip:
            var brziAuti = from a in mojiAutoEnum
                           where a.Brzina > 200 && a.Brzina < 310
                           orderby a.Brzina
                           select a;

            foreach(var auto in brziAuti)
            {
                Console.WriteLine("\nIme: {0}\n\nBrzina: {1}", auto.Ime, auto.Brzina);
            }

        }
        #endregion

        #region PRIMJER 14 - Filtering Data Using OfType() - Filtriranje podataka Korištenjem OfType()
        static void OfTypeKaoFilter()
        {
            // Kako negenreične kolekcije mogu sadržavati mnogo objekata raznog tipa, mi možemo iskoristiti OfType kao filter da
            // nam iz takve kolekcije izvadi samo numeričke vrijednosti.
            // Evo Primjera koji uzima samo intiger iz ArrayList:
            ArrayList podatci = new ArrayList();
            podatci.AddRange(new object[] { 12, 24, true, "Aydin", "Marlena", "Filip", "Petra", 366, 678, 132, 2000, 'H', 'E', 'L', 'L', 23.5m, 456.9m });

            var samoInt = podatci.OfType<int>();
            

            Console.WriteLine("Samo Int Vrijednosti:");
            foreach(var i in samoInt)
            {
                Console.WriteLine("Int: {0}", i);
            }

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            // Sad možemo filtrirati samo "string" vrijednosti:

            var samoString = podatci.OfType<string>();
            Console.WriteLine("Samo String Vrijednosti:");
            foreach(string s in samoString)
            {
                Console.WriteLine("String: {0}", s);
            }

        }
        #endregion

        #region PRIMJER 15 - LINQ EXPRESSIONS - IZRAZI
        
        // Moramo definirati nested-ugježđenu klasu:
        class ProductInfo
        {
            public string Ime { get; set; }
            public string Opis { get; set; }
            public int BrojNaLageru { get; set; }

            public override string ToString()
            {
                return string.Format("Ime: {0}\nOpis: {1}\nBroj na Lageru: {2}\n", Ime, Opis, BrojNaLageru);
            }
        }
 
        // Razne metode koje ćemo primjeniti na ProductInfo Klasu objekata koja je sada Array objekata:

        static void SelektirajSve(ProductInfo[] produkti)
        {
            // Daj nam sve produkte:
            Console.WriteLine("Svi detalji Produkata:");
            Console.WriteLine();
            var sviProdukti = from p in produkti
                                select p;

            foreach(var prod in sviProdukti)
            {
                Console.WriteLine(prod);
            }
        }

        static void SamoImenaProdukata(ProductInfo[] produkti)
        {
            // Sada nam daj samo imena produkata:
            Console.WriteLine("Samo imena Produkata:");
            Console.WriteLine();

            var samoImena = from p in produkti
                            select p.Ime;

            foreach(var item in samoImena)
            {
                Console.WriteLine(item);
            }
        }

        static void PrekoDvadesetNaLageru(ProductInfo[] produkti)
        {
            // Daj namo one produkte koj imaju više od 20 pakala na lageru:

            Console.WriteLine("Samo oni produkti kojih ima više od 20:");
            Console.WriteLine();

            var samoPreko20 = from p in produkti
                              where p.BrojNaLageru >= 20
                              select p;

            foreach(var item in samoPreko20)
            {
                Console.WriteLine(item);
            }
        }

        static void SamoNarkotici(ProductInfo[] produkti)
        {
            // Daj Nam samo produkte koji su narkotici:

            Console.WriteLine("Samo produkti koji su Narkotici:");
            Console.WriteLine();

            var samoNarkotici = from p in produkti
                                where p.Opis.Contains("Narkotik")
                                orderby p.Ime
                                select p;

            foreach(var item in samoNarkotici)
            {
                Console.WriteLine(item);
            }
        }

        #endregion

        #region PRIMJER 16 - Projektiranje novih podatkovnih tipova - Projecting New Data Types
        static void DajImeIOpis(ProductInfo[] produkti)
        {
            Console.WriteLine("Imena i Opis:");
            Console.WriteLine();

            var imeDesc = from p in produkti
                          select new { p.Ime, p.Opis };

            foreach(var item in imeDesc)
            {
                // Mogli smo koristi "Ime" i "Opis" osobine direktno... item.Ime i item.Opis
                Console.WriteLine(item.ToString());
            }
        } 
        #endregion

        #region PRIMJER 17 - Projektriranje novih podatkovnih tipova 2
        static Array DajProjektiraniPodset(ProductInfo[] products)
        {
            var imenaDesc = from p in products
                            select new { p.Ime, p.Opis };

            // Mapiraj set od anonimnih objekata u Array Objekt:
            return imenaDesc.ToArray();
            
        } 
        #endregion

        #region PRIMJER 18 - Dobivanje Broja (Count) Preko Enumerable-a
        static void DajCountIzUpita()
        {
            string[] trenutneIgre = { "Super Mario Bros 3", "Doom", "Doom 2", "Battlefiled", "Morrowind", "Sim City 3", "Sim City 4 Rush Hour" };

            // Daj nam Count iz upita:
            int broj = (from i in trenutneIgre where i.Length >= 6 select i).Count();

            // Daj nam Count iz upita manje od 6:
            int broj2 = (from i in trenutneIgre where i.Length < 6 select i).Count();

            // Ispiši rezulatate na konzolu:
            Console.WriteLine("{0} stavki je u LINQ izrazu koji imaju više od 6 slova...", broj);

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("{0} stavki je u LINQ izrazu koji imaju manje od 6 slova...", broj2);
        }
        #endregion

        #region PRIMJER 19 - Preokretanje Rezultatnog Seta na ProductInfo[] Array objekata
        static void PreokreniSve(ProductInfo[] products)
        {
            Console.WriteLine("Produkti u Preokrenutom redosljedu:");
            Console.WriteLine();

            // U upitu samo selektiramo sve produkte:
            var sviProdukti = from p in products
                              select p;

            // Foreach evaluacija uključuje produženu metodu "reverse":
            foreach(var prod in sviProdukti.Reverse())
            {
                Console.WriteLine(prod.ToString());
            }
        } 
        #endregion

        #region PRIMJER 20 - Sortirajući Izrazi - Sorting Expressions
        static void AlfabetizirajImenaProdukata(ProductInfo[] products)
        {
            // Dobavi imena Produkata, u alfatetičnom redosljedu:
            var upit = from p in products
                       orderby p.Ime
                       select p;

            Console.WriteLine("Sortirani Alfabetički po Imenu:");
            Console.WriteLine();
            foreach(var prod in upit)
            {
                Console.WriteLine(prod.ToString());
            }
        } 
        #endregion

        #region PRIMJER 21 - LINQ kao bolji Diagramski alat - LINQ As better diagramming Tool
        static void PrikaziRazlike()
        {
            // Kreiramo Dvije liste tipa string i dodjeljujemo im po tri vrijednosti:

            List<string> mAuti = new List<string>() { "Yugo", "Aztec", "BMW" };
            List<string> tAuti = new List<string>() { "BMW", "Saab", "Aztec" };

            // Sada koristimo Except Metodu u našem LINQ upitu:

            var razAuti = (from a in mAuti select a)
                   .Except(from a2 in tAuti select a2);

            // Ispisivanje na konzolu:
            Console.WriteLine("Ovo su auti koje ja imam a ti nemaš: ");
            Console.WriteLine();

            foreach(string s in razAuti)
            {
                Console.WriteLine(s); // Ispisuje "Yugo"
            }

        }

        // Druga metoda pokazuje "Intersect()" Extension Method koja će kao rezultat prikazati zajedničke stavke u listama:

        static void PrikaziIntersekciju()
        {
            // Kreiramo Dvije liste tipa string i dodjeljujemo im po tri vrijednosti:

            List<string> mAuti = new List<string>() { "Yugo", "Aztec", "BMW" };
            List<string> tAuti = new List<string>() { "BMW", "Saab", "Aztec" };

            // Sada koristimo Intersect Metodu u našem LINQ upitu:

            var interAuti = (from a in mAuti select a).Intersect(from a2 in tAuti select a2);

            // Ispisivanje na konzolu:
            Console.WriteLine("Ovo su auti koji se pojavljuju u obje Liste auta: ");
            Console.WriteLine();

            foreach(string s in interAuti)
            {
                Console.WriteLine(s); // Ispisuje Aztec i BMW
            }
        }

        // Treća metoda pokazuje "Union()" Extension Method koja kao što se da naslutiti prikazuje sve aute iz obje liste:

        static void PrikaziUnion()
        {
            // Kreiramo Dvije liste tipa string i dodjeljujemo im po tri vrijednosti:

            List<string> mAuti = new List<string>() { "Yugo", "Aztec", "BMW" };
            List<string> tAuti = new List<string>() { "BMW", "Saab", "Aztec" };

            // Sada koristimo Union Metodu u našem LINQ upitu koja uzima sve aute iz obje liste ali ne stavlja kopije:

            var unionAuti = (from a in mAuti select a).Union(from a2 in tAuti select a2);

            // Ispisivanje na konzolu:
            Console.WriteLine("Ovo su svi auti koji postoje u obje Liste auta: ");
            Console.WriteLine();

            foreach(string s in unionAuti)
            {
                Console.WriteLine(s); // Ispisuje Aztec, BMW, Yugo, Saab
            }
        }

        // Četvrta metoda pokazuje Concat() Extension Method koja spaja obje liste kako bismo i pretpostavili da "concating" radi:
        static void PrikaziConcat()
        {  
            // Kreiramo Dvije liste tipa string i dodjeljujemo im po tri vrijednosti:

            List<string> mAuti = new List<string>() { "Yugo", "Aztec", "BMW" };
            List<string> tAuti = new List<string>() { "BMW", "Saab", "Aztec" };

            // Sada koristimo Concat Metodu u našem LINQ upitu, koja spaja obje liste:

            var concatAuto = (from a in mAuti select a).Concat(from a2 in tAuti select a2);

            // Ispisivanje na konzolu:
            Console.WriteLine("Ovo su auti koji su rezultat spajanja \"Concating-a\" Liste auta: ");
            Console.WriteLine();

            foreach(string s in concatAuto)
            {
                Console.WriteLine(s); // Ispisuje Aztec i BMW
            }
        }

        #endregion

        #region PRIMJER 22 - Uklanjanje Duplikata - Removing Duplicates
        static void PrikaziConcatBezDup()
        {
            // Kada radimo sa Concat() produženom metodom naići ćemo na dupliciranje rezulatat nekad je to baš ono što želimo,
            // ali kad to nije slučaj moramo ih se riješiti. Korištenjem "Distinct()" produžene metode u Evaluaciji u foreach petlji.
            // Evo Primjera:

            // Kreiramo Dvije liste tipa string i dodjeljujemo im po tri vrijednosti:

            List<string> mAuti = new List<string>() { "Yugo", "Aztec", "BMW" };
            List<string> tAuti = new List<string>() { "BMW", "Saab", "Aztec" };

            // Sada koristimo Concat Metodu u našem LINQ upitu:

            var concatAuti = (from a in mAuti select a).Concat(from a2 in tAuti select a2);

            // Ispisivanje na konzolu:
            Console.WriteLine("Concat metoda sa \"Distinct\" dodanom metodom da ukloni duplikate: ");
            Console.WriteLine();

            foreach(string s in concatAuti.Distinct())
            {
                Console.WriteLine(s); // Ispisuje Aztec i BMW
            }

            
        }
        #endregion

        #region PRIMJER 23 - LINQ Operacije Sakupljanja - LINQ Aggregation Operations
        static void SakupljackeOperacije()
        {
            // LINQ upiti isto tako mogu biti korišteni da naprave različite vrste sakupljanja i sakupljačkih operacija u rezultatnom setu.
            // "Count()" produžena metoda je jedan takav primjer. Druge mogućnosti uključuju dobivanje "Average()", "Max()", "Min()" ili "Sum()"
            // članova Enumerable klase. Evo primjera:

            double[] zimskeTemp = { 2.0, -21.3, -12.6, 4, -8.1, 0, 12.1, -9.2 };

            // Razni Agregatni Primjeri:
            Console.WriteLine();
            Console.WriteLine("Maximalna Temperatura: {0}", (from t in zimskeTemp select t).Max()); // Ispisuje Maximalne temperature...

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("Minimalne Temperature: {0}", (from t in zimskeTemp select t).Min()); // Ispisuje Minimalne temperature...

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("Prosječne Temperature: {0}", (from t in zimskeTemp select t).Average()); // Ispisuje Projesčne Temperature...

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            Console.WriteLine("Suma svih Temperatura: {0}", (from t in zimskeTemp select t).Sum()); // Sumira sve vrijednosti...
        }
        #endregion

        #region PRIMJER 24 - Interna Reprezentacija LINQ upitnih izraza - The internal Representation of LINQ query Statements

        #endregion
    }
}
