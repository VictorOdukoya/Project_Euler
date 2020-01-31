using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Math.Pow(getSumToN(100), 2) - getSumToNSquared(100);
            Console.WriteLine(result);
            int getSumToN(int n)
            {
                return (n * (n+1)) / 2;
            }

            int getSumToNSquared(int n)
            {
                return (n * (n + 1) * ((2 * n) + 1)) / 6;
            }
        }
    }
}
