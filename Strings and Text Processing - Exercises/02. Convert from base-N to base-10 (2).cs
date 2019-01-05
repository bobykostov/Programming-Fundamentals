using System;
using System.Linq;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numBase = Console.ReadLine()
                .Split(' ').ToArray();
            byte baseN = byte.Parse(numBase[0]);
            char[] num = numBase[1].ToCharArray();

            BigInteger converted = new BigInteger(0);
            for (int i = 0; i < num.Length; i++)
            {
                byte digit = (byte)Char.GetNumericValue(num[i]);
                converted += digit * BigInteger.Pow(baseN, num.Length - i - 1);
            }

            Console.WriteLine(converted);
        }
    }
}
