using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleProgram
{
    public class MyClass
    {
        public void PokaziEnviromentDetalje()
        {
            foreach(var drive in Environment.GetLogicalDrives())
            {
                Console.WriteLine("Drive: {0}", drive);
            }


            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Broj Procesora: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Verzija: {0}", Environment.Version);
            Console.WriteLine("Trenutni korisnik: {0}", Environment.UserName);
            Console.WriteLine("Ime Mašine: {0}", Environment.MachineName);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            mc.PokaziEnviromentDetalje();

            Console.ReadKey();
        }
    }
}
