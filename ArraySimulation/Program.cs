using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] godine = { 22, 54, 68, 30, 37, 11};
            IspisiMatricu(godine);
            Console.WriteLine();
            Console.WriteLine();

            string[] str = DajMiString();

            
            foreach(string s in str)
            {
                Console.WriteLine("Imena: {0}", s);
            }

            Console.WriteLine();
            Console.WriteLine();
            double[] vrijednosti = { 2.3, 3.4, 4.5, 6.9, 45.5, 42.1 };
            int[] intVrij = { 10, 20, 30, 40, 50, 60, 70 };
            IspisiDoubleMatricu(vrijednosti, intVrij);

            Console.WriteLine();
            Console.WriteLine();

            int[] intV = DajMiInt();
            foreach(int i in intV)
            {
                Console.WriteLine("Brojevi: {0}.", i);
            }

            Console.WriteLine();
            Console.WriteLine();

            double[] d1 = { 2.3, 3.4, 3.6, 5.6, 5.7, 7.4, 8.9, 12.2, 23.2 };
            double[] d2 = { 3.4, 4.5, 4.7, 4.6, 34.2, 45.3, 34.3, 24.3 };
            double[] d3 = { 3.4, 34.2, 23.3, 45.6, 65.4, 45.4, 45.2, 38.5 };
            DobaviMatrice(d1, d2, d3);

            Console.WriteLine();
            Console.WriteLine();

            decimal[] dPare = DajMiPare();
            foreach(decimal d in dPare)
            {
                Console.WriteLine("Iznos je: {0:C2}.", d);
            }

            Console.WriteLine();
            Console.WriteLine();

            decimal[] p1 = { 20.3m, 30.4m, 10.3m };
            decimal[] p2 = { 30.2m, 20.6m, 40.2m };
            decimal[] p3 = { 10.1m, 20.7m, 50.2m };
            decimal[] p4 = { 10.1m, 20.7m, 50.2m };
            DajMiPunoPara(p1, p2, p3, p4 );

            Console.ReadKey();
        }

        #region METODE

        static void IspisiMatricu(int[] mojInt)
        {
            for(int i = 0; i < mojInt.Length; i++)
            {
                Console.WriteLine("Index u Matrici: {0} Vrijednost je: {1}.", i, mojInt[i]);
            }
        }

        static string[] DajMiString()
        {
            string[] stringovi = { "ajdin", "marlena", "filip", "petra", "edin", "adi" };
            return stringovi;
        }

        static void IspisiDoubleMatricu(double[] mojDouble, int[] mojInt)
        {
            for(int i = 0; i < mojDouble.Length; i++)
            {
                Console.WriteLine("Vrijednosti su: {0}.", mojDouble[i]);
            }

            for(int j = 0; j < mojInt.Length; j++)
            {
                Console.WriteLine("Vrijednosti su: {0}.", mojInt[j]);
            }
        }

        static int[] DajMiInt()
        {
            int[] brojevi = { 101, 202, 303, 404, 505, 606, 707, 808, 909 };
            return brojevi;
        }

        static void DobaviMatrice(double[] d1, double[] d2, double[] d3)
        {
            for(int i = 0; i < d1.Length; i++)
            {
                Console.WriteLine("d1 Vrijednosti su: {0}", d1[i]);
            }
            for(int i = 0; i < d2.Length; i++)
            {
                Console.WriteLine("d2 Vrijednosti su: {0}", d2[i]);
            }
            for(int i = 0; i < d3.Length; i++)
            {
                Console.WriteLine("d3 Vrijednosti su: {0}", d3[i]);
            }
        }

        static decimal[] DajMiPare()
        {
            decimal[] pare = { 2.3m, 2.44m, 23.3m, 34.3m, 56.54m, 67.4m, 123.22m };
            return pare;
        }

        #endregion

        static void DajMiPunoPara(decimal[] pare1, decimal[] pare2, decimal[] pare3, decimal[] suma)
        {
            int i;
            int j;
            int k;
            for(i = 0; i < pare1.Length; i++)
            {
                Console.WriteLine("Iznos je: {0}.", pare1[i]);
            }
            for(j = 0; j < pare2.Length; j++)
            {
                Console.WriteLine("Iznos je: {0}.", pare2[j]);
            }
            for(k = 0; k < pare3.Length; k++)
            {
                Console.WriteLine("Iznos je: {0}.", pare3[k]);
            }
            for(int l = 0; l < suma.Length; l++)
            {
                 Console.WriteLine("Iznos je: {0}.", suma[l]);
            }
           
        }

        //static decimal[] SaberiPare()
        //{
            
            
        //    return
        //}

     
    }
}
