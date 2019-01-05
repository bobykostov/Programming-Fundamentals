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

            if (baseN >= 2 && baseN <= 10)
            {
                BigInteger converted = new BigInteger(0);
                for (int i = 0; i < num.Length; i++)
                {
                    BigInteger digit = BigInteger.Parse(num[i].ToString());
                    BigInteger exponent = BigInteger.Pow(baseN, num.Length - i - 1);
                    BigInteger pow = BigInteger.Multiply(digit, exponent);
                    converted = BigInteger.Add(converted, pow);
                }

                Console.WriteLine(converted);
            }
        }
    }
}
