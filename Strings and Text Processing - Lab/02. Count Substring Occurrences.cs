using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string search = Console.ReadLine().ToLower();

            int counter = 0;
            int index = input.IndexOf(search);

            while (index != -1)
            {
                counter++;
                index = input.IndexOf(search, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}