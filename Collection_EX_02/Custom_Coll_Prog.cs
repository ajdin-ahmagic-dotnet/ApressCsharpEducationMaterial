using System;
using System.Collections.Generic;
using System.Linq;
// Dodano za ovaj primjer:
using System.Collections;

namespace Collection_EX_02
{
    class Custom_Coll_Prog
    {
        static void Main(string[] args)
        {
            NapisiPunuCrtu40("╔════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            NapisiPunuCrtu40("║                         ╔════════════════════════════════════════════════════════════════════════════════╗                         ║");
            NapisiPunuCrtu40("║                         ║        --- DOBRODOŠLI U: KOLEKCIJE - IMPLMENTIRANJE CUSTOM KOLEKCIJE ---       ║                         ║");
            NapisiPunuCrtu40("║                         ╚════════════════════════════════════════════════════════════════════════════════╝                         ║");
            NapisiPunuCrtu40("╚════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.Green; Console.SetBufferSize(134, 100);

            // Rad sa jako-tipiranim kolekcijama tj. custom napravljenim kolekcijama 
            // posebno za rad sa objektima po mojoj želji:
            Animals animalsCollection = new Animals();
            animalsCollection.Add(new Cow("Milka"));
            animalsCollection.Add(new Cow("Živka"));
            animalsCollection.Add(new Chicken("Pero"));
            animalsCollection.Add(new Chicken("Jozo"));

            foreach(Animal myAnimal in animalsCollection)
            {
                myAnimal.Feed();
            }

            // AnimalDict kolekcija sa Dictionary prefiksom:
            AnimalsDict animalsDictColl = new AnimalsDict();
            animalsDictColl.Add("1", new Cow("Šarka"));
            animalsDictColl.Add("2", new Cow("Darka"));
            animalsDictColl.Add("3", new Chicken("Kata"));
            animalsDictColl.Add("4", new Chicken("Zlata"));

            foreach(Animal myAnimal in animalsDictColl)
            {
                myAnimal.Feed();
            }



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
