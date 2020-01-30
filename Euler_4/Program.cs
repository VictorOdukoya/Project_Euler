using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(getlargestPalindromeOfNDigitFactor(2));
        }

        static int getlargestPalindromeOfNDigitFactor(int n)
        {
            int start = Convert.ToInt32(Math.Pow(10, n-1)); //min n digit number
            int end = (Convert.ToInt32(Math.Pow(10, n))) - 1; // max n digit number
            int product = 0;
            int largestproduct = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    product = i * j;
                    if (isPalindrome(product) && (product > largestproduct))
                    {
                        largestproduct = product;
                    }
                }
            }
            return largestproduct;
        }
        static Boolean isPalindrome(int number)
        {
            string numberString = number.ToString();
            string partA = numberString.Substring(0, numberString.Length / 2);
            string partB = numberString.Substring(Convert.ToInt32(Math.Ceiling(numberString.Length/2.0)), numberString.Length - Convert.ToInt32(Math.Ceiling(numberString.Length / 2.0)));

            // reverse the string
            char[] partBReverse = partB.ToCharArray();
            Array.Reverse(partBReverse);
            if (partA == new String(partBReverse))
            {
                return true;
            }
            return false;
        }
    }
}
