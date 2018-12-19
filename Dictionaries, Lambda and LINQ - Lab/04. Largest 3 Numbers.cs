using System;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            int[] largest = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToArray();

            Console.WriteLine(String.Join(" ", largest));
        }
    }
}