using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = nums.Length / 4;

            int[] row1 = nums.Take(k).Reverse().ToArray();
            row1 = row1.Concat(nums.Reverse().Take(k)).ToArray();

            int[] row2 = nums.Skip(k).Take(2*k).ToArray();

            int[] sum = row1.Select((x, index) => x + row2[index]).ToArray();

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}