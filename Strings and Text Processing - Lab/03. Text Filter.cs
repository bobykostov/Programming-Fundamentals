using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine()
                .Split(", ")
                .ToArray();

            string text = Console.ReadLine();

            foreach (string word in banned)
            {
                text = text.Replace(word, new string('*', word.Length));
            }

            Console.WriteLine(text);
        }
    }
}