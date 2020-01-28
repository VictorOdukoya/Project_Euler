using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_3
{
    class Program
    {
        /*
        The prime factors of 13195 are 5, 7, 13 and 29.
        What is the largest prime factor of the number 600851475143 ?
        */
       
        static void Main(string[] args)
        {
            getPrimeFactorsOf(600851475143);
        }

        // kinda messy but it works since we reduce 600851475143 to its largest factor and continue calculations with this factor
        static void getPrimeFactorsOf(long n)
        {
            List<int> lstPrimeNumbers = new List<int>();
            lstPrimeNumbers.Add(2);
            // check manually for 2, since we already know 2 is prime
            if(n % 2 == 0)
            {
                Console.WriteLine(2);
                n = n / 2;
            }
            // generate list of primes while factoring n with a prime e.g:
          //      28
          //     /  \
          //    2   14
          //       /  \
          //      2    7
          //             result: largest prime factor is 7
            for(int i = 3; i <= n; i++)
            {
                for(int j = 0; j < lstPrimeNumbers.Count; j++)
                {
                    if(i % lstPrimeNumbers[j] == 0)
                    {
                        //not a prime number
                        break;
                    } else if(j == lstPrimeNumbers.Count -1)
                    {
                        // i is a prime number
                        lstPrimeNumbers.Add(i);
                        // check if n is divisible by the prime number. If it is, keep calculating with the larger factor (look at above example)
                        if(n % i == 0)
                        {
                            Console.WriteLine(i);
                            n = n / i;
                        }
                        break;
                    }
                }
            }
            
        }

    }
}
