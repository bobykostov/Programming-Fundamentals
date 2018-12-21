using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if ("aeiou".IndexOf(input) >= 0)
                Console.WriteLine("vowel");
            else if (char.IsDigit(input))
                Console.WriteLine("digit");
            else
                Console.WriteLine("other");
        }
    }
}