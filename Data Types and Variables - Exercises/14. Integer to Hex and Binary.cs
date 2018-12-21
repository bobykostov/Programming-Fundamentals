using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine($"{input.ToString("X")}\n{Convert.ToString(input, 2)}");
        }
    }
}