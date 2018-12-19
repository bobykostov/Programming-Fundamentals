using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string numMatch = @"\+359( |-)2(\1)\d{3}(\1)\d{4}\b";

            MatchCollection nums = Regex.Matches(input, numMatch);

            var matched = nums
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();

            Console.WriteLine(String.Join(", ", matched));
        }
    }
}