using System;

namespace Euler_10
{
    class Program
    {
        static void Main(string[] args)
        {

            double c = 0;
            double result = 0;

            for (int a = 1; a < 1000; a++)
            {
                for (int b = 1; b <= 1000; b++)
                {
                    c = Math.Pow(a, 2) + Math.Pow(b, 2);
                    if ((Math.Sqrt(c) % 1 == 0))
                    {
                        result = a + b + Math.Sqrt(c);
                        if (result > 1000)
                        {
                            break;
                        }

                        if (result == 1000)
                        {
                            Console.WriteLine(a * b * Math.Sqrt(c));
                            Console.ReadKey();
                            break;
                        }
                    }


                }
            }
        }
    }
}
