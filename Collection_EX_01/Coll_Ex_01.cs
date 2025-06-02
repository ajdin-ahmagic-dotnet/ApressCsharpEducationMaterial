using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Dodani using:
using System.Collections;

namespace Collection_EX_01
{
    class Coll_Ex_01
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║                 --- DOBRODOŠLI U: KOLEKCIJE EXAMPLE 01 ---                     ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            Console.WriteLine("=> RAD SA KOLEKCIJAMA:");
            Console.WriteLine();

            Console.WriteLine("Kreiraj Array tip kolekcije od objekta Animal " + "i iskoristi ga:");

            Animal[] animalArray = new Animal[2];
            Cow myCow1 = new Cow("Milka");
            animalArray[0] = myCow1;
            animalArray[1] = new Chicken("Adi");

            foreach(Animal myAnimal in animalArray)
            {
                Console.WriteLine("Novih '{0}' je objekata dodano u Array kolekciju." + "\nIme = {1}.", myAnimal.GetType().Name, myAnimal.Name );
            }

            Console.WriteLine("Array kolekcija sadrži {0} objekata.", animalArray.Length);

            animalArray[0].Feed();
            ((Chicken)animalArray[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Kreiraj ArrayList tip kolekcije od Animal objekta i iskoristi ga:");

            ArrayList animalArrayList = new ArrayList();
            Cow myCow2 = new Cow("Šara");
            animalArrayList.Add(myCow2);
            animalArrayList.Add(new Chicken("Edo"));

            foreach(Animal myAnimal in animalArrayList)
            {
                Console.WriteLine("Novih '{0}' objekata dodano u ArrayList kolekciju." + "\nIme = {1}.", myAnimal.GetType().Name, myAnimal.Name);
            }

            Console.WriteLine("ArrayList kolekcija sadrži {0} objekata.", animalArrayList.Count);

            ((Animal)animalArrayList[0]).Feed();
            ((Chicken)animalArrayList[1]).LayEgg();
            Console.WriteLine();

            Console.WriteLine("Dodatne manipulacije sa ArrayList:");
            animalArrayList.RemoveAt(0);
            ((Animal)animalArrayList[0]).Feed();
            animalArrayList.AddRange(animalArray);
            ((Chicken)animalArrayList[2]).LayEgg();

            Console.WriteLine("Animal pozvana {0} na indexu {1}", myCow1.Name, animalArrayList.IndexOf(myCow1));
            myCow1.Name = "Petra";
            Console.WriteLine("Životinja se sada zove {0}.", ((Animal)animalArrayList[1]).Name);

            

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }

        private static void NapisiPunuCrtu40(string ulaz)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(ulaz);
        }
    }
}
