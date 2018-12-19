using System;
using System.Linq;

namespace Pr1Redo
{
    class Pr1Redo
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine()
                .Split(' ')
                .ToArray();
            string[] arr2 = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int countLeft = 0;
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] == arr2[i])
                    countLeft++;
            }

            int countRight = 0;
            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                    countRight++;
            }

            if (countLeft >= countRight) Console.WriteLine(countLeft);
            else Console.WriteLine(countRight);
        }
    }
}