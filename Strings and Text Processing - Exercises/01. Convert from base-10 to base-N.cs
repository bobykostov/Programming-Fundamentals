using System;
using System.Linq;
using System.Numerics;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            BigInteger[] base10 = Console.ReadLine()
                .Split(' ')
                .Select(BigInteger.Parse)
                .ToArray();
            BigInteger baseN = base10[0];
            BigInteger num = base10[1];

            string converted = string.Empty;

            while (num > 0)
            {
                BigInteger rem = num % baseN;
                converted += rem;
                num = num / baseN;
            }

            Console.WriteLine(string.Join("", converted.Reverse()));
        }
    }
}