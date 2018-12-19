using System;

namespace Pr2MaxMethod
{
    class Pr2MaxMethod
    {
        static int GetMax(int a, int b)
        {
            int biggest = 0;
            if (a >= b) biggest = a;
            else if (b > a) biggest = b;
            return biggest;
        }

        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            if (first > third && second > third)
            {
                int biggest = GetMax(first, second);
                Console.WriteLine(biggest);
            }
            else if (first > second && third > second)
            {
                int biggest = GetMax(first, third);
                Console.WriteLine(biggest);
            }
            else if (second > first && third > first)
            {
                int biggest = GetMax(second, third);
                Console.WriteLine(biggest);
            }
        }
    }
}