using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_Nullable
{
    public class Vector
    {
        // Polja:
        public double? R = null;
        public double? Theta = null;

        // Osobine:
        public double? ThetaRadians
        {
            get
            {
                // Pretvori stupnjeve u radijane:
                return (Theta * Math.PI / 180.0);
            }
        }

        // Konstruktor:
        public Vector(double? r, double? theta)
        {
            // Normaliziraj:
            if(r < 0)
            {
                r = -r;
                theta += 180;
            }
            theta = theta % 360;

            // Dodjeli polja:
            R = r;
            Theta = theta;
        }

        public static Vector operator +(Vector op1, Vector op2)
        {
            try
            {
                // Dobavi (x,y) koordinate za novi vektor.
                double newX = op1.R.Value * Math.Sin(op1.ThetaRadians.Value)
                    + op2.R.Value * Math.Sin(op2.ThetaRadians.Value);
                double newY = op1.R.Value * Math.Sin(op1.ThetaRadians.Value)
                    + op2.R.Value * Math.Sin(op2.ThetaRadians.Value);

                // Pretvori u (r, theta)
                double newR = Math.Sqrt(newX * newX + newY * newY);
                double newTheta = Math.Atan2(newX, newY) * 180.0 / Math.PI;

                // Vrati rezultat:
                return new Vector(newR, newTheta);
            }
            catch
            {
                // Varti "null" vektor:
                return new Vector(null, null);
            }
        }

        public static Vector operator -(Vector op1)
        {
            return new Vector(-op1.R, op1.Theta);
        }

        public static Vector operator -(Vector op1, Vector op2)
        {
            return op1 + (-op2);
        }

        // Override string metoda:
        public override string ToString()
        {
            // Dobavi string reprezenaciju koordinata:
            string rString = R.HasValue ? R.ToString(): "null";
            string thetaString = Theta.HasValue ? Theta.ToString(): "null";


            return string.Format("({0}, {1})", rString, thetaString);
        }
    }
}
