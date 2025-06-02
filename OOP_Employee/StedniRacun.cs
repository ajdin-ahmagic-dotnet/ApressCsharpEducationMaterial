using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class StedniRacun
    {
        // Instancno-leveliran podatak tj. 
        // svaka instanca ima svoju kopiju.
        public double trenutniBalans;

        // Statični podatak. Koji se djeli 
        // u memoriji za sve instance.
        public static double trenutnaKamata = 0.04;

        // Moramo napraviti i property preko kojeg ćemo pristupiti.
        // Sada možemo pristupiti preko property-a radije nego preko metode.
        public static double Kamata
        {
            get{return trenutnaKamata;}
            set { trenutnaKamata = value; }
        }

        public StedniRacun(double balans)
        {
            
            trenutniBalans = balans;
        }

        // Pravimo ažuriranje konstruktora, u statički konstruktor.
        static StedniRacun()
        {
            Console.WriteLine("U Statičkom Konstruktoru!");
            trenutnaKamata = 0.04;
        }



        // Da bi smo bolje razumjeli koncept "static" 
        // napravićemo dvije statične metode.
        // Statične metode za postavljanje/dobavljanje kamata.
        public static void PostaviKamatnuStopu(double novaKamata)
        {
            trenutnaKamata = novaKamata;    	
        }

        public static double DobaviKamatnuStopu()
        {
            return trenutnaKamata;
        }

    }
}
