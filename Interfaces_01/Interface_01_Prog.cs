using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_01
{
    class Interface_01_Prog
    {
        static void Main(string[] args)
        {
            // Sve ove klase sprovode IClonable interface.
            string mojStr = "Pozdrav";
            OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
            System.Data.SqlClient.SqlConnection sqlConn = new System.Data.SqlClient.SqlConnection();

            // Tako da sve mogu biti prosljeđene u metodu koja uzima IClonable kao parametar.
            CloneMe(mojStr);
            CloneMe(unixOS);
            CloneMe(sqlConn);

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        private static void CloneMe(ICloneable c)
        {
            object klon = c.Clone();
            Console.WriteLine("Vaš klon je: {0}.", klon.GetType().Name);
        }
    }
}
