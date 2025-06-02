using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Collection_Yield
{
    class Primes
    {
        // Polja:
        private long min;
        private long max;

        // Konstruktori:
        public Primes() : this(2, 100)
        {
            
        }

        public Primes(long minimum, long maximum)
        {
            if(minimum < 2)
                min = 2;
            else
                min = minimum;

            max = maximum;
        }

        public IEnumerator GetEnumerator()
        {
            for(long posiblePrime = min; posiblePrime <= max; posiblePrime++)
            {
                bool isPrime = true;
                for(long posibleFactor = 2; posibleFactor <= (long)Math.Floor(Math.Sqrt(posiblePrime)); posibleFactor++)
                {
                    long reminderAfterDivision = posiblePrime % posibleFactor;
                    if(reminderAfterDivision == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if(isPrime)
                {
                    yield return posiblePrime;
                }
            }
        }

    }
}
