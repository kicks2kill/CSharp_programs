using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_folder2
{
    class NaivePrimeGenerator
    {
        public static int[] GeneratePrimeNumbers(int maxValue)
        {
            if (maxValue >= 2) //only valid case
            {
                //declarations
                int s = maxValue + 1; //size of array
                bool[] f = new bool[s];
                int i;

                //init array to true
                for (i = 0; i < s; i++)
                    f[i] = true;

                //get rid of non-primes
                f[0] = f[1] = false;

                //sieve
                int j;
                for (i = 2; i < Math.Sqrt(s) + 1; i++)
                {
                    if (f[i]) //if i is uncrossed, cross its multiples
                    {
                        for (j = 2 * i; j < s; j += i)
                            f[j] = false; //multiple is not prime
                    }
                }

                //how many primes are there?
                int count = 0;
                for (i = 0; i < s; i++)
                {
                    if (f[i])
                        count++; //bump count
                }
                int[] primes = new int[count];

                //move the primes into the result

                for (i = 0, j = 0; i < s; i++) //if prime
                {
                    if (f[i])
                        primes[j++] = i;
                }
                return primes;
            }
            else //maxValue < 2
                return new int[0];
        }
    }
}
