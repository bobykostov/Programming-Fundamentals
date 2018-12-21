using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int last = int.Parse(Console.ReadLine());
            for (int num = 2; num <= last; num++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(num); divisor++)
                {
                    if (num % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine($"{num} -> {isPrime}");
            }
        }
    }
}