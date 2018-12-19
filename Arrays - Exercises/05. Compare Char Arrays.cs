using System;
using System.Linq;

namespace Pr5
{
    class Pr5
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            char[] arr2 = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            string first = string.Join("", arr1);
            string second = string.Join("", arr2);

            int alpha = string.Compare(first, second);

            if (alpha == -1) Console.WriteLine(first + "\n" + second);
            else Console.WriteLine(second + "\n" + first);
        }
    }
}