using System;

namespace Exam1Pr1
{
    class Exam1Pr1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double half = n * 0.5;

            int nRemain = 0;
            int count = 0;
            while (n >= m)
            {
                n -= m;
                if (n == half && y > 0)
                {
                    n /= y;
                }

                nRemain = n;
                count++;
            }

            Console.WriteLine(nRemain + "\n" + count);
        }
    }
}