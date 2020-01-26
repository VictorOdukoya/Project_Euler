using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //O(n) an O(1)
            //Console.WriteLine(getSumOfDivisibleBy3_5(1000));
            Console.WriteLine(sumDivisibleBy(3, 999) + sumDivisibleBy(5, 999) - sumDivisibleBy(15, 999));
        }

        private static int getSumOfDivisibleBy3_5(int limit)
        {
            int result = 0;
            for (int i = 1; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        // 3+6+9+12+...+999 = 3*(1+2+3+4...+333)
        // Summe durch die Gaußsche Summenformel berechnen
        // (n*(n+1))/2 = 1+2+3+4...+n
        private static int sumDivisibleBy(int n, int p)
        {
            // since we are using integers
            return n * (p / n) * ((p / n + 1)) / 2;
        }
    }
}
