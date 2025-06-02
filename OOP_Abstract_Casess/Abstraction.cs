using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Abstract_Casess;

namespace Interface_02
{
    class Abstraction
    {
        static void Main()
        {
            #region PRIMJER - ABSTRAKCIJA HEXAGON
            Console.WriteLine("=> HEXAGON PRIMJER:");
            Console.WriteLine();

            Hexagon hex = new Hexagon("Aydin");
            hex.Draw();
            hex.DrawAbstract();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - Circle Klasa
            Console.WriteLine("=> CIRCLE PRIMJER:");
            Console.WriteLine();

            // Circle posziva baznu implementaciju metode Draw().
            Circle cir = new Circle("Marlena");
            cir.Draw();
            cir.DrawAbstract();
            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - PRAVIMO ARRAY SVIH KOMATIBILNIH OBLIKA
            Console.WriteLine("=> ARRAY SVIH KOMATIBILNIH OBLIKA:");
            Console.WriteLine();

            Shape[] myShapes = {new Hexagon(), new Circle(), new Hexagon("Edin"), 
                                   new Circle("Jusuf"), new Hexagon("Aydin")};

            // Prođi petljom kroz svaki objekt i djeluj međusobno sa
            // polimorfičnim interfejsom.
            foreach(Shape s in myShapes)
            {
                s.DrawAbstract();
            }

            ThreeDCircle threeD = new ThreeDCircle("Marlena");
            threeD.DrawAbstract();

            // Ovako bi pozvali DrawAbstrakt() Metodu od bazne klase Circle:
            ((Circle)threeD).DrawAbstract();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - Vraćanje na Employee 

            Console.WriteLine("=> VRAĆAMO SE NA KLASU EMPLOYEE:");
            Console.WriteLine();
            // Uzeći u obzir da u C#-pu ultimativna bazna klasa je System.Object i da
            // sve ima "is-an" object odnos i tretiran je kao takav. legalno je pohraniti
            // instancu bilo kojeg tipa u object varijablu.
            // Za ove "cast"-ove možemo reći da su implicitni pošto su na "is-a" odnosu.

            // Menager je "is-a" System.Object, pa slobodno možemo:
            object zappa = new Menager("Frank Zappa", 9, 78, 40000, "2708946209202", 5);
            // pošto je zappa pohranjen sada u system.object referenci nismo u mogućnosti da dirktno pozovemo 
            // metodu na njega, jer bi dobili grešku. Zato što je object više u hijerarhiji i i kompajler neće 
            // dozvoliti implicitni "cast". Zato ćemo morati napraviti explicitni "cast".
            GivePromotion((Menager)zappa);
            
            // Employee je "is-an" Employee isto.
            EmployeeAbstract frank = new Menager("Dweezil Zappa", 10, 45, 6000, "2605968191723", 20);
            frank.DisplayStatus(); // sada možemo pozvati i status...
            GivePromotion(frank);

            // PTSalesPerson je "is-a" SalesPerson pa možemo:
            SalesPerson edina = new PTSalesPreson("Edina", 67, 54, 20000, "2705959121340", 90);
            edina.DisplayStatus();
            GivePromotion(edina);

            #endregion// PRIMJER - Vraćanje na Employee


            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        // Pošto je parametar u metodi cijeli objekt možemo efektivno prosljediti sve potomke ove klase
        // u metodu direktno, pošt je odnos "is-a"!
        static void GivePromotion(EmployeeAbstract emp)
        {
            // C# nam daje "is" ključnu riječ koju možemo iskoristiti da vidimo kojeg su 
            // Employee podklase tipa.
            Console.WriteLine("{0} je promaknut!", emp.Name);

            // A tu koristimo i "casting"...
            if(emp is SalesPerson)
            {
                Console.WriteLine("{0} je napravio {1} prodaje!", emp.Name, ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if(emp is Menager)
            {
                Console.WriteLine("{0} je imao {1} stock opcija...", emp.Name, ((Menager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    }
}
