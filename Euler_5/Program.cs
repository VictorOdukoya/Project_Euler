using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstPrimeFactors = new List<int>();
            lstPrimeFactors.Add(1);

            for(int i = 1; i <= 20; i++)
            {
                lstPrimeFactors = mergePrimeFactors(lstPrimeFactors, getPrimeFactors(i));
            }

            int product = 1;
            foreach (int number in lstPrimeFactors)
            {
                product = product * number;
            }
            Console.WriteLine(product);

        }

        static List<int> mergePrimeFactors(List<int> lst1, List<int> lst2)
        {
            List<int> lstMergedList = new List<int>(lst1); //new List<int>();


            int i = 0;
            int j = 0;
            int originalSize = lstMergedList.Count;
            while (i < lst1.Count)
            {
                while (j < lst2.Count)
                {
                    if (lstContains(lst1, lst2[j], i) >= 0)
                    {
                        i = lstContains(lst1, lst2[j], i);
                        j++;
                        break;
                    }
                    else
                    {
                        lstMergedList.Add(lst2[j]);
                        j++;
                        break;
                    }
                }
                i++;
            }
            return lstMergedList;
        }

        static int lstContains(List<int> lstOfNumbers, int number, int startposition)
        {
            for(int i = startposition; i < lstOfNumbers.Count; i++)
            {
                if(number == lstOfNumbers[i])
                {
                    return i;
                }
            }
            return -1;
        }

        static List<int> getPrimeFactors(int n)
        {
            List<int> lstPrimeFactors = new List<int>();
            int i = 2;
            while (i <= n)
            {
                if(n % i == 0)
                {
                    n = n / i;
                    lstPrimeFactors.Add(i);
                } else
                {
                    i++;
                }
            }
            return lstPrimeFactors;
        }

    }
}
