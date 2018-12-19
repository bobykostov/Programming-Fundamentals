using System;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            foreach (char c in input)
            {
                Console.Write($"\\u{(int)c:x4}");
            }
        }
    }
}