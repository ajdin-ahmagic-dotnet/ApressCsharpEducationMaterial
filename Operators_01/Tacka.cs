using System;
using System.Collections.Generic;
using System.Linq;

namespace Operators_01
{
    /// <summary>
    /// Za sada samo još jedna svakodnevna C# klasa...
    /// Dok ne dodamo overload operatora! Ovo je overloadiranje binarnih operatora.
    /// Oveloadiranje binarnih te unarnih operatora se mora isključivo raditi sa static i operator ključnim riječima!
    /// Iako je trivijalo ovo overloadiranje operatora moramo ga primjerniti...
    /// </summary>
    class Tacka : IComparable<Tacka>
    {
        // Osobine:
        public int X { get; set; }
        public int Y { get; set; }

        // Konstruktori:
        public Tacka(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }

        public Tacka() { }

        // Overloadiranje operatora:
        // Za zbrajanje tacaka X i Y:
        public static Tacka operator + (Tacka t1, Tacka t2)
        {
            return new Tacka(t1.X + t2.X, t1.Y + t2.Y);
        }

        // Za oduzimanje tacaka X i Y:
        public static Tacka operator -(Tacka t1, Tacka t2)
        {
            return new Tacka(t1.X - t2.X, t1.Y - t2.Y);
        }

        // Kada overloadiramo binarne operatore ne moramo prosljediti dva ista parametra.
        // Evo Primjera:
        public static Tacka operator + (Tacka t1, int promjena)
        {
            return new Tacka(t1.X + promjena, t1.Y + promjena);
        }

        public static Tacka operator + (int promjena, Tacka t1)
        {
            return new Tacka(t1.X + promjena, t1.Y + promjena);
        }

        // Primjer overloadiranje unarnih operatora ++ i -- :
        public static Tacka operator ++(Tacka t1)
        {
            return new Tacka(t1.X + 1, t1.Y + 1);
        }

        public static Tacka operator --(Tacka t1)
        {
            return new Tacka(t1.X - 1, t1.Y - 1);
        }

        // System.Equals ako se sjetimo se isto može overajdirati, ali je trivijalno
        // ali ipak evo primjera:
        public override bool Equals(object o)
        {
            return o.ToString() == this.ToString();

        }
        // Override Equals metodnog == operatora:
        public static bool operator ==(Tacka t1, Tacka t2)
        {
            return t1.Equals(t2);
        }

        public static bool operator !=(Tacka t1, Tacka t2)
        {
            return !t1.Equals(t2);
        }

        // Overide GetHashCode:
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        


        // String overide metoda:
        public override string ToString()
        {
            return string.Format("[{0}, {1}]", X, Y);
        }

        #region IComparable<Tacka> Interface Implementacija zajedno sa overloariraim usporednim operatorima

        public int CompareTo(Tacka other)
        {
            if(this.X > other.X && this.Y > other.Y)
            {
                return 1;
            }
            if(this.X < other.X && this.Y < other.Y)
            {
                return -1;
            }
            else
                return 0;
        }

        // Ako overloadiramo "<" u C#-pu to znači da moramo overloadirati i ">" njegov ekvivalent. 
        public static bool operator <(Tacka t1, Tacka t2)
        {
            return (t1.CompareTo(t2) < 0);
        }

        public static bool operator >(Tacka t1, Tacka t2)
        {
            return (t1.CompareTo(t2) > 0);
        }

        public static bool operator <=(Tacka t1, Tacka t2)
        {
            return (t1.CompareTo(t2) <= 0);            	
        }

        public static bool operator >=(Tacka t1, Tacka t2)
        {
            return (t1.CompareTo(t2) >= 0);
        }
        #endregion
    }
}
