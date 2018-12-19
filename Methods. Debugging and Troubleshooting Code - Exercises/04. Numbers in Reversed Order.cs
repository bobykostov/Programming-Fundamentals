using System;
using System.Linq;

namespace Pr4NumbersReversedOrder
{
    class Pr4NumbersReversedOrder
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());

            PrintsDigits(number);
        }

        private static void PrintsDigits(decimal number)
        {
            string numStr = number.ToString();
            for (int i = numStr.Length - 1; i >= 0; i--)
            {
                Console.Write(numStr[i]);
            }
        }
    }
}