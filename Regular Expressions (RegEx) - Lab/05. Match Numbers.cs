using System;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string reg = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";
            string input = Console.ReadLine();

            MatchCollection nums = Regex.Matches(input, reg);

            foreach (Match num in nums)
            {
                Console.Write(num.Value + " ");
            }
        }
    }
}