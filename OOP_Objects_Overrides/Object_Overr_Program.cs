using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Objects_Overrides
{
    class Object_Overr_Program
    {
        static void Main(string[] args)
        {
            #region PRIMJER - System.Object Metoda
            Console.WriteLine("=> System.Object Overrides Primjeri:");
            Console.WriteLine();

            // Inicijalizacija klase Person.
            Person p1 = new Person();
            
            // Iskoristi nasljedne članove od System.Object-a.
            Console.WriteLine("ToString: {0}", p1.ToString());
            Console.WriteLine("HashCode: {0}", p1.GetHashCode());
            Console.WriteLine("Type:     {0}", p1.GetType());
            
            // Napravi još referenci prema p1
            Person p2 = p1;
            object o = p2;

            // Dali reference pokazuju na isti lokaciju u memoriji?
            if(o.Equals(p1) && p2.Equals(o))
            {
                Console.WriteLine("Ista instanca!");
            }
            else
                Console.WriteLine("Druga instanca!");

            

            #endregion// PRIMJER - System.Object Metoda

            #region DELIMITER
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region TESTIRANJE OVERAJDIRANH METODA U PERSON KLASI
            Console.WriteLine("=> TESTIRANJE OVERAJDIRANIH METODA U PERSON KLASI:");
            Console.WriteLine();

            // Ova dva objeka namjerno su ista da bi testirali "Equals()" i "GetHashCode()" metode.
            Person p3 = new Person("Homer", "Simpson", 50);
            Person p4 = new Person("Homer", "Simpson", 50);

            // Dobavi string polja verzije objekata.
            Console.WriteLine("p3.ToString() = {0}.", p3.ToString());
            Console.WriteLine("p4.ToString() = {0}.", p4.ToString());

            // Testiraj overajdirani Equals().
            Console.WriteLine("p3 = p4? : {0}.", p3.Equals(p4));

            // Testiraj Hash kodove.
            Console.WriteLine("Isti Hash Kode? : {0}.", p3.GetHashCode() == p4.GetHashCode());
            Console.WriteLine();

            // Promjeni Starost od p4 i testiraj opet.
            p4.Starost = 45;
            Console.WriteLine("p3.ToString() = {0}.", p3.ToString());
            Console.WriteLine("p4.ToString() = {0}.", p4.ToString());
            Console.WriteLine("p3 = p4? : {0}.", p3.Equals(p4));
            Console.WriteLine("Isti Hash Kode? : {0}.", p3.GetHashCode() == p4.GetHashCode());
            #endregion

            // Poziv statičnoj metodi za jednakost:
            StaticMembersOfObject();

            Console.WriteLine();
            Console.WriteLine("Pritisnite bilo koju tipku za izlaz...");
            Console.ReadKey();
        }

        // Možemo još spomenuti statičnog člana koji može da testira vrijednosne tipove ili referencne tipove
        // za jednakost u statičnom obliku.
        static void StaticMembersOfObject()
        {
            // Statični članovi System.Objekt-a
            Person p5 = new Person("Aydin", "Rose", 30);
            Person p6 = new Person("Aydin", "Rose", 30);
            Console.WriteLine("Da li - P5 i P6 - imaju isto stanje: {0}.", object.Equals(p5, p6));
            Console.WriteLine("Da li - P5 i P6 - pokazuju na isti objekt: {0}.", object.ReferenceEquals(p5, p6));
        }
    }
}
