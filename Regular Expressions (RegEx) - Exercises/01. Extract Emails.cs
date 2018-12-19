using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))(?<user>[a-z0-9]+([\-._][a-z0-9]+)*)@(?<host>[a-z]+([-][a-z]+)*([.][a-z]+)([.][a-z]+)?)";
            string input = Console.ReadLine();

            MatchCollection emails = Regex.Matches(input, pattern);

            foreach (Match m in emails)
            {
                Console.WriteLine(m.ToString());
            }
        }
    }
}