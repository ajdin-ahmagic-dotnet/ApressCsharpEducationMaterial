using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Employee_Simulation
{
    class EmployeeSimulation
    {
        static void Main()
        {
            #region PRIMJER - NSLJEĐIVANJE KLASA
            Console.WriteLine("=> PRIMJER NASLJEĐIVANJA:");
            Console.WriteLine();

            SalesPerson ajdin = new SalesPerson();
            ajdin.Name = "Aydin Rose";
            ajdin.ID = 10;
            ajdin.Age = 30;
            ajdin.SalesNumber = 120;
            ajdin.SSN = "2811983181509";
            ajdin.Pay = 20000;
            ajdin.GiveBonus(6000);
            ajdin.DisplayStatus();
           

            #endregion// PRIMJER - NSLJEĐIVANJE KLASA

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER Employee Klase 
            Console.WriteLine("=> EMPLOYEE KLASA SA POVEZANOM BENEFIPACGAKE KLASOM:");
            Console.WriteLine();

            Menager edin = new Menager("Edin Džafić", 20, 47, 80000, "0808966131222", 9000);
            edin.GiveBonus(4000);
            double cost = edin.GetBenefitCost();
            edin.DisplayStatus();

            #endregion

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region PRIMJER - Ugnježđivanje klasa
            Console.WriteLine("=> PRIMJER UGNJEŽĐIVANJA KLASA:");
            Console.WriteLine();

            // Dodjeljujemo ugnježđenoj klasi te ugnježđenoj enumeraciji njenu vrijednost.
            EmployeeProp.NestedBenefitPackage.BenefitPackageLevel mojBenefitLevel =
                EmployeeProp.NestedBenefitPackage.BenefitPackageLevel.Platinum;

            // Pozivamo klasu, ne idemo sve do enumeracije jer smo joj već pozvali vrijednost
            // nego samo klasu, te pozivamo metodu koja uzima tu vrijednost kao parametar i 
            // ispisuje je na konzolu da možemo vidjeti:
            EmployeeProp.NestedBenefitPackage mojBenefit = new EmployeeProp.NestedBenefitPackage();
            mojBenefit.DisplayStatus2(mojBenefitLevel);

            #endregion

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }
    }
}
