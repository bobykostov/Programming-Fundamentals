using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var counts = new SortedDictionary<double, int>();

            foreach (double num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                }
                else
                {
                    counts[num] = 1;
                }
            }

            foreach (double num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }
        }
    }
}