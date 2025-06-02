using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace KolekcijeListDemo
{
    class ArrayListDemoProgram
    {
        static void Main(string[] args)
        {
            // Kreiramo ArrayList kolekciju i dajemo joj inicijalnu vrijednost kapaciteta
            // od 10 iako joj dodajemo samo 5 indexa, onda poziva metodu "TrimToSize()" koja
            // ju smanjuje do potrebne veličine...
            // Onda ipisujemo kapacitet kroz property ".Capacity"
            ArrayList aDemo = new ArrayList(10);
            aDemo.Add("Prvi");
            aDemo.Add("Drugi");
            aDemo.Add("Treći");
            // Možemo korisiti metodu insert da ubacimo neki novi objekt, prvo pišemo index a onda vrijednost:
            aDemo.Insert(3, "Sedmi");
            aDemo.Add("Četvrti");
            aDemo.Add("Peti");
            // Isto tako možemo pozvati removeAt metodu da na danom indexu izbrišemo stvaku:
            aDemo.RemoveAt(3);
            aDemo.TrimToSize();
            aDemo.Add("Šesti");

            // Možemo pozvati Sort metodu na arraylist koja će posložiti po ascending redu:
            aDemo.Sort();
            // Isto tako možemo pozvati metodu reverse i biće descending...
            aDemo.Reverse();
            Console.WriteLine("Kapacitet kolekcije je: {0}", aDemo.Capacity);

            #region DELIMITER

            // Delimiter
            Console.WriteLine();
            // Delimiter

            #endregion

            Console.WriteLine("Broj stvaki u kolekciji je: {0}.", aDemo.Count);

            #region DELIMITER

            // Delimiter
            Console.WriteLine();
            // Delimiter

            #endregion

            // Foreach nam daje imena koje sadrži sama kolekcija.
            foreach(var Item in aDemo)
            {
                Console.WriteLine("Stavke iz ArrayList kolecije su: {0}", Item);
            }

            #region DELIMITER
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion

            // Iz kolekcije arraylist možemo izvući podatak kroz index.
            Console.WriteLine("Poziv jednoj stavki kroz index: {0}", aDemo[3].ToString()); // 


            #region DELIMITER
            // Delimiter
            Console.WriteLine();
            // Delimiter
            #endregion


            // Koji isto možemo pozvati i ovako:
            string str = aDemo[4].ToString(); // Možemo i implicitno sa ključnom riječi "var".
            Console.WriteLine("Poziv drugoj stavki kroz index: {0}", str);
            

            Console.ReadKey();
        }
    }

    class HashTableDemoProgram
    {
        public static void Main()
        {
            // HashTable nikad ne koristi index pozicioniranje i prema njemu se 
            // orijentiramo kao kod arraylist kolekcije, nego po key-value
            Hashtable hsDemo = new Hashtable();
            hsDemo.Add(1, "Prvi");
            hsDemo.Add(2, "Drugi");
            hsDemo.Add(3, "Treći");
            hsDemo.Add(4, "Četvrti");
            hsDemo.Add(5, "Peti");
            // Remove metoda...
            hsDemo.Remove(4);
           
            string str = hsDemo[2].ToString();
            Console.WriteLine("HashTable na indexu: {0}", str);

            // foreach za vrijednosti i ključeve...
            foreach(DictionaryEntry Item in hsDemo)
            {
                int kljuc = (int)Item.Key;
                string vrijednost = Item.Value.ToString();
                Console.WriteLine(String.Format("{0} {1}", kljuc, vrijednost));


            }

            // Delimiter
            Console.WriteLine();
            // Delimiter



            // foreach za ključeve samo...
            foreach(var kljuc in hsDemo.Keys)
            {
                Console.WriteLine(kljuc);
            }


            // Delimiter
            Console.WriteLine();
            // Delimiter



            // foreach samo za vriejdnosti...
            foreach(var vrijednost in hsDemo.Values)
            {
                Console.WriteLine(vrijednost);
            }

            Console.ReadKey();
        }
    }

    class Student : IComparable
    {
        public int ID;
        public string Ime;

        public Student(int _ID, string _Ime)
        {
            ID = _ID;
            Ime = _Ime;
        }

        #region IComparable Members

        //Implemetacija interfejsa koji će nam posložiti objekte "student" od 1-7
        // BubleSort Algoritam...
        public int CompareTo(object obj)
        {
            // Ova kompracija je za ID.
            Student drugi = (Student)obj;
            if(this.ID < drugi.ID)
            {
                return -1;
            }
            else if(this.ID > drugi.ID)
            {
                return 1;
            }
            else
                return 0;

            
        }

        #endregion
    }


    class StudentArrayListProgram
    {
        public static void Main()
        {
            ArrayList alStudent = new ArrayList();
            alStudent.Add(new Student(1, "Ajdin"));
            alStudent.Add(new Student(6, "Mato"));
            alStudent.Add(new Student(5, "Pero"));
            alStudent.Add(new Student(4, "Tunjo"));
            alStudent.Add(new Student(2, "Ivo"));
            alStudent.Add(new Student(7, "Stipe"));
            alStudent.Add(new Student(3, "Marko"));

            // Ovo neće raditi ukoliko klasa "Student" ne bude primjenila 
            // interfejs "IComparable"...
            alStudent.Sort();

            foreach(Student item in alStudent)
            {
                Console.WriteLine(String.Format("|ID: {0} | Ime: {1}", item.ID, item.Ime));
            }


            // Delimiter
            Console.WriteLine();
            // Delimiter


            // Sve kolekcije nasljeđuju od IEnumerator-a Koji ima IEnumerorator sa metodom GetEnumerator
            // foreach koristi IEnumerator da bi prošao kroz kolekciju i implentira ga pa je lakši za korištenje 
            // nego ovaj primjer koji daje iste rezultate...
            IEnumerator eNum = alStudent.GetEnumerator();
            // Sad pravimo petlju kroz koju će enumerator proći i iprintati vrijednosti.
            while(eNum.MoveNext())
            {
                Student stu = (Student)eNum.Current;
                Console.WriteLine(String.Format("| ID: {0} | Ime: {1}", stu.ID, stu.Ime));
            }

            Console.ReadKey();
        }
    }
}
