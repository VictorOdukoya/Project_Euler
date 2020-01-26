using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_2
{
    class Program
    {

        static IDictionary<int, int> cache = new Dictionary<int, int>();

        static void Main(string[] args)
        {

            int result = 0;
            for(int i = 1; i < 100; i++)
            {
                int fibNumber = fibonacci(i);
                if(fibNumber > 4000000)
                {
                    break;
                }
                else
                {
                    if (fibNumber % 2 == 0)
                    {
                        result += fibNumber;
                    }
                }
                
            }
            Console.WriteLine(result);
            
        }

        static int fibonacci(int n)
        {
            if(cache.ContainsKey(n))
            {
                return cache[n];
            }

            int fibNumer = 0;
            if(n == 1 || n == 2)
            {
                return 1;
            } else
            {
                fibNumer = fibonacci(n - 1) + fibonacci(n - 2);
                cache.Add(new KeyValuePair<int, int>(n, fibNumer));
                return fibNumer;
            }
        }
    }
}
