using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?:0x)?[A-F0-9]+\b";
            string input = Console.ReadLine();

            string[] hex = Regex.Matches(input, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(String.Join(" ", hex));
        }
    }
}