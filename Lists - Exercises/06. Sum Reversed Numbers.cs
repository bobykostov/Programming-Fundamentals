using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr6Redo
{
    class Pr6Redo
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            for (int i = 0; i < num.Count; i++)
            {
                List<char> reversed = num[i]
                    .ToString()
                    .Reverse()
                    .ToList();
                int toint = int.Parse(string.Join("", reversed));

                sum += toint;
            }

            Console.WriteLine(sum);
        }
    }
}