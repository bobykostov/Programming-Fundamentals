using System;

namespace Pr5FibonacciNumbers
{
    class Pr5FibonacciNumbers
    {
        static void Fib(int n)
        {
            int fibprev = 0;
            int fibcurr = 1;
            for (int i = 0; i <= n; i++)
            {
                fibcurr += fibprev;
                fibprev = fibcurr - fibprev;
                if (i == n - 1 && n != 0)
                {
                    Console.WriteLine(fibcurr);
                }
                else if (i == n && n == 0)
                {
                    Console.WriteLine(fibcurr);
                }
            }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nAbs = Math.Abs(n);

            Fib(nAbs);
        }
    }
}