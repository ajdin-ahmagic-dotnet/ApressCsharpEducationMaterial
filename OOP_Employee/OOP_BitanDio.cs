using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee
{
    class OOP_BitanDio
    {
        static void Main(string[] args)
        {
            // Stvaranje bufera za konzolu.
            Console.SetBufferSize(136, 100);

            #region PRIMJER ENKAPSULACIJA
            Console.WriteLine("=> PRIMJER ENKAPSULACIJE SA METODAMA:");
            Console.WriteLine();

            Employee emp = new Employee("Aydin",1,30, 40000);
            emp.GiveBonus(1000);
            emp.DisplayStatus();

            // Utradicionalom principu sa metodama kad bi htjeli 
            // da promjenimo starost zaposlenika morali bi to učiniti ovako:
            emp.SetAge(emp.GetAge() + 1);

            
            // Koristi Get/Set Metode da napraviš interakciju sa objektom ime.
            emp.SetName("Ajdo");
            Console.WriteLine("Zaposlenik se zove: {0}.", emp.GetName());
            Console.WriteLine();

            Console.WriteLine("Poslje promjene zapslenik je star: {0}.", emp.GetAge());


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER ENKAPSULACIJA 2
            Console.WriteLine("=> PRIMJER ENKAPSULACIJE SA 'PROPERIES':");
            Console.WriteLine();

            EmployeeProp emp2 = new EmployeeProp("Edin",2,47, 50000);
            emp2.GiveBonus(2000);
            emp2.DisplayStatus();

            // Kod properites je puno jednostavnije:
            emp2.Age++;

            emp2.Name = "Edo";
            Console.WriteLine("Zaposlenik se zove: {0}.", emp2.Name);
            Console.WriteLine();
            Console.WriteLine("Poslje promjene zapslenik je star: {0}.", emp2.Age);


            #endregion
            
            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POSJET STEDNOMRACUNU SA OSOBINAMA
            Console.WriteLine("=> POSJET STEDNOMRACUNU SA OSOBINAMA:");
            Console.WriteLine();

            StedniRacun st = new StedniRacun(100.0);
            // Ipsiši stanje u klasi kamatne stope:
            Console.WriteLine("Trenutna kamata je: {0}.", StedniRacun.Kamata);

            // Zadaj novu kamtnu stopu:
            StedniRacun.PostaviKamatnuStopu(0.09);
            
            // Ispiši novo stanje kamatne stope:
            Console.WriteLine("Trenutna kamata je: {0}.", StedniRacun.Kamata);
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region POSJET AUTO-KLASI SA AUTO-IMPLEMENTIRANIM OSOBINAMA
            Console.WriteLine("=> POSJET AUTO-KLASI SA AUTO-IMPLEMENTIRANIM OSOBINAMA:");
            Console.WriteLine();

            Auto bmw = new Auto();
            bmw.Ime = "BMW 525i";
            bmw.Brzina = "230 km/h";
            bmw.Boja = "Crna Metalik";

            Console.WriteLine("Ime Auta je: {0}", bmw.Ime);
            bmw.IspisiStanje();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region KLASA GARAZA
            Console.WriteLine("=> KLASA GARAŽA SA LISTOM AUTA:");
            Console.WriteLine();

            List<Auto> auti = new List<Auto>()
            {
                new Auto(ime: "BMW 525i", brzina: "230 km/h", boja: "Crna"),
                new Auto(ime: "BMW 320i", brzina: "170 km/h", boja: "Crvena"),
                new Auto(ime: "BMW 430",  brzina: "245 km/h", boja: "Žuta"),
                new Auto(ime: "BMW 635i", brzina: "260 km/h", boja: "Zelena"),
                new Auto(ime: "BMW 735",  brzina: "265 km/h", boja: "Bijela"),
                new Auto(ime: "BMW 850",  brzina: "270 km/h", boja: "Plava"),
            };
            Garaza gar = new Garaza();
            gar.MojAuto = auti;
            
            foreach(var a in auti)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine();
            Console.WriteLine("Broj auta je: {0}.", gar.MojAuto.Count);
            

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - Inijalizacija Obajekata
            Console.WriteLine("=> INICIJALIZACIJA OBJEKATA:");
            Console.WriteLine();

            // Osnovna inicijalizacija.
            Tacka t1 = new Tacka();
            t1.X = 10;
            t1.Y = 10;
            t1.PrikaziPodatke();
            
            // Razdvaja linije na kozoli.
            Console.WriteLine();

            // Tacka sa konstruktor inicijalizacijom.
            Tacka t2 = new Tacka(20, 20);
            t2.PrikaziPodatke();


            // Razdvaja linije na kozoli.
            Console.WriteLine();

            // Tacka sa direktrom init sintaksom.
            // Ovo je pozivanje preko osnovnog konstruktora eksplicitno osobinu po osobinu.
            Tacka t3 = new Tacka { X = 30, Y = 30 };
            t3.PrikaziPodatke();

            // Razdvaja linije na kozoli.
            Console.WriteLine();

            // Sada ima smisla zvati i osnovni i manualno konstruirani konstruktor.
            Tacka t4 = new Tacka(BojaIspisa.SvijetloPlava) { X = 90, Y = 30 };
            t4.PrikaziPodatke();


            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER KLASA PRAVOKUTNIK
            Console.WriteLine("=> KLASA PRAVOKUTNIK:");
            Console.WriteLine();

            Pravokutnik mojPravokutnik = new Pravokutnik
            {
                NajLijevo = new Tacka { X = 10, Y = 10, Boja = BojaIspisa.Zlatna},
                DoleDesno = new Tacka { X = 200, Y = 200, Boja = BojaIspisa.KrvavoCrvena }
            };
            mojPravokutnik.PrikaziPodatke();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER PARCIJALNE KLASE EMPLOYEEPARTIAL
            Console.WriteLine("=> PRIMJER PARCIJALNIH KLASA:");
            Console.WriteLine();

            EmployeePartial empPart = new EmployeePartial("Aydin", 10, 30, 45000);
            empPart.GiveBonus(3000);
            empPart.DisplayStatus();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion



            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();

        }
    }
}
