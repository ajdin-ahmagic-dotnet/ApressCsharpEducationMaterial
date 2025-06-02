using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Interfaces1_Ilu_2012
{
    class Inter_Ilu_1_Prog
    {
        /// <summary>
        /// INTERFACES ILUSTARATED 2012. DODATAK.
        /// </summary>
        static void Main()
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                --- DOBRODOŠLI U: INTERFACES SA KOLEKCIJAMA ---                 ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);


           


            Console.Write("Da li želite vidjeti uposlenike: DA/NE: ");
            string odg = Console.ReadLine();
            if(odg.ToLower() == "da")
            {
                Console.WriteLine("        --Name--            --Age--        --Pay--                 --Started--");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                ClassA claA = new ClassA(firstName: "Aydin", lastName: "Rose", personalAge: 30, pay: 4500.0m, started: DateTime.Parse("06/07/2006"));
                ClassB claB = new ClassB(name: "Edin Džafić", age: 47, pay: 11800.0m, started: DateTime.Parse("04/07/1991"));

                PrintInfo(claA);
                PrintInfo(claB);

                // A sada jedan primjer kolekcije klase ClassB:
                List<ClassB> list = new List<ClassB>()
                {
                    new ClassB(name: "Marlena G.Ahmagić", age: 37, pay: 6200.0m, started: DateTime.Parse("22/01/2000")),
                    new ClassB(name: "Edina Mehmedalić",  age: 55, pay: 4500.0m, started: DateTime.Parse("18/08/1984")),
                    new ClassB(name: "Jusuf Džafić",      age: 86, pay: 7200.0m, started: DateTime.Parse("12/03/1954")),
                    new ClassB(name: "Dževida Džafić",    age: 84, pay: 1200.0m, started: DateTime.Parse("11/09/1957")),
                    new ClassB(name: "Adi Mehmedalić",    age: 22, pay:    0.0m, started: DateTime.Parse("09/01/2009")),
                    new ClassB(name: "Tahir Mehmedalić",  age: 69, pay: 3800.0m, started: DateTime.Parse("15/06/1969")),
                    new ClassB(name: "Fadila Alibegović", age: 79, pay: 2200.0m, started: DateTime.Parse("13/08/1958")),
                };
               
                foreach(ClassB cla in list)
                {
                    Console.WriteLine(cla);
                    Console.Beep();
                    
                }
                
                Console.Write("Da li želite spremiti trenutnu listu osoba DA/NE: ");
                string odg2 = Console.ReadLine();
                if(odg2.ToLower() == "da")
                {
                    SpremiUTxt(list);
                }
                else
                {
                    Console.WriteLine("Lista osoba nije spremljena.");
                }


                Console.Write("Da li želite Pretražiti Listu DA/NE: ");
            string odg5 = Console.ReadLine();
            if(odg5.ToLower() == "da")
            {
                // Pretraživanje objekata korištenjem LAMBDA Izraza dolje a kroz Metodu Find od List<T> kolekcije:
                Console.Write("Unesite ime tražene osobe: ");
                string trOsoba = Console.ReadLine();
                ClassB trazi = list.Find((ClassB o) => { return o.Name == trOsoba; });
                Console.WriteLine("Name: {0}\nAge: {1}\nPay: {2}\nStarted: {3}", trazi.Name, trazi.Age, trazi.Pay, trazi.Started);
                Console.Beep();
            }
            }
            else
            {
                Console.WriteLine("Možda neki drugi put...");
            }
            




            Console.Write("Da li želite dodati zaposlenike u listu i kreirati .txt osoba DA/NE: ");
            string odg3 = Console.ReadLine();
            if(odg3.ToLower() == "da")
            {
                using(var writer = new StreamWriter(new FileStream("Osobe.txt", FileMode.Append, FileAccess.Write), Encoding.Default))
                {
                    int counter = 0;

                    while(counter != -1)
                    {

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Pay: ");
                        decimal pay = Convert.ToDecimal(Console.ReadLine());

                        Console.Write("Started: ");
                        DateTime started = Convert.ToDateTime(Console.ReadLine());

                        Prikazi(name, age, pay, started);

                        Console.Write("Za prekid unosa -1 za nastvak 1: ");
                        counter = Convert.ToInt32(Console.ReadLine());

                        writer.WriteLine("| Name: {0,-17:} | Age: {1} | Pay: {2,-13  :C2} | Started: {3,-18} |", name, age, pay, started);
                    }
                    writer.Close();
                }  
            }
            else if(odg3.ToLower() == "ne")
            {
                Console.WriteLine("Možda neki drugi put...");
            }

            Console.Write("Da li želiti pogledati ažuriranu .txt Datoteku DA/NE: ");
            string odg4 = Console.ReadLine();
            if(odg4.ToLower() == "da")
            {
                PrikaziTxt();
                Console.Beep();
            }
            else
            {
                Console.WriteLine("Odlučili ste ne prikazati listu.");
            }

            Console.Write("Da li želite izvući iz .txt file određenu osobu DA/NE: ");
            string izOsobu = Console.ReadLine();
            if(izOsobu.ToLower() == "da")
            {
                Console.Write("Unesite ime Osobe: ");
                var ime = Console.ReadLine();

                StreamReader datoteka = new StreamReader("Osobe.txt", Encoding.Default);
                string linija = "";
                int counter = 0;
                while((linija = datoteka.ReadLine()) != null)
                {
                    if(linija.Contains(ime))
                    {
                        break;
                    }
                    counter++;
                }

                if(datoteka.ReadToEnd() == "")
                {
                    Console.WriteLine("Ne postoji takav zapis!");
                }
                else
                {
                    Console.WriteLine("Traženo ime je:\n{0} ", linija);
                    Console.Beep();
                }
            }





            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

      
        // Metoda koja uzima interface kao parametar:
        static void PrintInfo(IInfo info)
        {
            Console.WriteLine("| Name: {0,-17:} | Age: {1} | Pay: {2,-13  :C2} | Started: {3,-18} |", info.GetName(), info.GetAge(), info.GetPay(), info.GetStarted());
        }

        // Prikaži kako izgleda osoba u kartoteci koju si napravio.
        static void Prikazi(string name, int age, decimal pay, DateTime started)
        {
            Console.WriteLine("| Name: {0,-17:} | Age: {1} | Pay: {2,-13  :C2} | Started: {3,-18} |", name, age, pay, started);
        }

        // Spremi već definiranu listu iz memorije u .txt file.
        private static void SpremiUTxt(List<ClassB> osobe)
        {
            using(StreamWriter strWr = new StreamWriter(new FileStream("Osobe.txt", FileMode.Create, FileAccess.Write), Encoding.Default))
            {
                foreach(ClassB osoba in osobe)
                {
                    strWr.WriteLine(osoba.ToString());
                }
                strWr.Close();
            }
            
        }

        // Prikaži sve osobe iz .txt file-a.
        static void PrikaziTxt()
        {
            string[] linije = File.ReadAllLines("Osobe.txt", Encoding.Default);
            foreach(var linija in linije)
            {
                Console.WriteLine(linija);
            }
        }


        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
