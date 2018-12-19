using System;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {nums.Sum()}\n" +
                $"Min = {nums.Min()}\n" +
                $"Max = {nums.Max()}\n" +
                $"Average = {nums.Average()}\n");
        }
    }
}