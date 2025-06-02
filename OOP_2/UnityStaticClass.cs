using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
   static class UnityStaticClass
    {
       public static void IspisiVrijeme()
       {
           Console.WriteLine(DateTime.Now.ToShortTimeString());
       }

       public static void IspsiDatum()
       {
           Console.WriteLine(DateTime.Now.ToShortDateString());
       }
    }
}
