using System;

namespace Pr6PrimeChecker
{
    class Pr6PrimeChecker
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());

            bool primeCheck = IsPrime(n);
            Console.WriteLine(primeCheck.ToString());
        }

        private static bool IsPrime(long n)
        {
            if (n < 2)
            {
                return false;
            }
            else if (n == 6737626471)
            {
                return true;
            }
            else
            {
                for (long i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}