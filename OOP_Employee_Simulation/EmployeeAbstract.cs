using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee_Simulation
{
   abstract class EmployeeAbstract
    {
   
           #region Nesting - Ugnježđivanje klasa.

           // Ugnježđivanje klasa.
           public class NestedBenefitPackage
           {
               public enum BenefitPackageLevel
               {
                   Standard,
                   Gold,
                   Platinum
               }

               public void DisplayStatus2(BenefitPackageLevel benefit)
               {
                   Console.WriteLine("Koji je Level Benefita: {0}.", benefit);
               }

               public double NestedComputePayDeducation()
               {
                   return 125.0;
               }
           }

           #endregion

           #region Funkcionalnosti iz BenefitPackage Klase

           // Sadržava BenefitPackage objekt.
           // Do ove tačke smo uspješno "contained" (zauzadali) objekt...
           // Ali da bi izložili njegovu funkcionalnost moramo koristi delegate.
           protected BenefitPackage empBenefits = new BenefitPackage();

           // Da bi iložili funkcionlnosti objekta možemo to kroz osobine i metode...
           public double GetBenefitCost()
           {
               return empBenefits.ComputePayDeducation();
           }

           // Sada ilažemo funkcionalnost kroz osobine.
           public BenefitPackage Benefits
           {
               get { return empBenefits; }
               set { empBenefits = value; }
           }

           #endregion

           #region Polja - Fileds

           // Polja.
           // Kada su polja označena sa protected samo derivirane klase mogu vidjeti ta polja.
           // pri kreiranju nove instance klase-objekta nije moguće pristupiti ovim poljima!
           protected string empName;
           protected int empID;
           protected float currPay;
           protected int empAge;
           protected string empSSN;

           #endregion

           #region Osobine- Properties

           // Properies - Osobine.
           public int Age
           {
               get
               {
                   return empAge;
               }
               set
               {
                   empAge = value;
               }
           }
           // GET i SET Metode su zamjenjene sa
           // C# osobinama eng. "properies"
           public string Name
           {
               get { return empName; }
               set
               {
                   if(value.Length > 15)
                   {
                       Console.WriteLine("Greška!  Ime mora biti manje od 16 slova!");
                   }
                   else
                       empName = value;

               }
           }

           // Mi možemo dodati još puno poslovnih restrikcija za EmployeeProp klasu
           // ali za sada to nije potrebno.
           public int ID
           {
               get { return empID; }
               set { empID = value; }
           }

           // 'float' tip mora biti istog tipa koje je polje koje enkapsulira.
           // te mora sadržavati deklarativno ime tog polja "currPay".
           public float Pay   // Primjetite nedostatak zagrada, za razliku od metoda...
           {
               get
               { return currPay; }
               set
               { currPay = value; }
           }

           // Jedna dodana restrikcija u vezi jmbg-a u ovo osobini za emp klasu...
           public string SSN
           {
               get
               {
                   return empSSN;
               }
               set
               {
                   empSSN = value;
                   if(empSSN.Length > 13)
                   {
                       Console.WriteLine("Greška! JMBG Mora biti u rangu od 13-14 brojava!");
                   }
                   else
                   {
                       empSSN = value;
                   }
               }
           }

           #endregion

           #region Konstruktori

           // Kontruktori. 
           public EmployeeAbstract() { } // Default-Osnovni konstruktor.


           // Ažuriran konstruktor u odnosu na novo polje i property "empAge".
           public EmployeeAbstract(string name, int id, float pay, string ssn)
               : this(name, id, 0, pay, ssn)
           { }


           /// <summary>
           /// Initializes a new instance of the EmployeeProp class.
           /// Ažurirani konstruktor u odnosu na novo polje"empAge".
           /// </summary>
           /// <param name="name"></param>
           /// <param name="id"></param>
           /// <param name="pay"></param>
           public EmployeeAbstract(string name, int id, int age, float pay, string ssn)
           {
               #region Važno je znati...

               // Pošto konstruktor uzima dolazeće parametre, provjerava da li su podatci ispravni
               // i pravi dodjele privatnim poljima, on trenutno ne provjerava da li je ime duže od 
               // 15 slova tako da i njega možemo ažurirati da provjeri...
               // Ali to je samo u slučaju kada radimo sa metodama! Kada koristimo properties
               // ne moramo praviti ovaj dupli check u konstruktoru!
               //if(name.Length > 9)    // S obzirom da ovje smanjujemo sa 16 na 10 slova!
               //{
               //    Console.WriteLine("Greška!  Ime mora biti manje od 10 slova!");
               //}
               //else
               //{
               //    empName = name;
               //}

               #endregion

               #region Stari način u konstruktoru...

               // Sada kada koristimo properties ovaj dio postaje drugačiji i veže se na osobine.
               //empName = name;
               //empID = id;
               //empAge = age;
               //currPay = pay;
               #endregion

               // Pozivanje na osobine:
               Name = name;
               ID = id;
               Age = age;
               Pay = pay;
               SSN = ssn;

           }

           #endregion

           #region Metode

           #region Objašnjenje
           // Do sada u ostalim primjerima ove klase ova metoda je više manje bila zanemarena.
           // Jedna od značajki polimorfizma je ta da u baznim klasama sve metode mogu biti 
           // označene sa ključnom riječju "virtual" ukoliko bi mogle a ne moraju biti prepravljene
           // tj. override-irane od strane derivirane klase. Pa će mo u ovom primjeru ovu metodu označiti
           // kao virtualnu metodu da bi se mogla prepraviti u svim nasljeđenim deeriviranim klasama
           #endregion
           public virtual void GiveBonus(float amount)
           {
               Pay += amount;
           }

           // Ažurirana metoda da podrži nasljeđivanje - virtual ključna riječ je dodana...
           public virtual void DisplayStatus()
           {
               Console.WriteLine("|Ime: {0,14:}|", empName);
               Console.WriteLine("|ID: {0,15:}|", empID);
               Console.WriteLine("|Starost: {0,10:}|", empAge);
               Console.WriteLine("|Plaća: {0,12:}|", currPay);
               Console.WriteLine("|JMBG: {0,-10}|", empSSN);
           }
           #endregion

       
    }
}
