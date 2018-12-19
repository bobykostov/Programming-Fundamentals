using System;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string pattern = @"[^A-Za-z0-9]+\n[0-9_]+\n"+
                "([^A-Za-z0-9]+)([0-9_]+)(?<core>[A-Za-z]+)([0-9_]+)([^A-Za-z0-9]+)\n"+
                "[0-9_]+\n[^A-Za-z0-9]+";

            for (int i = 1; i <= 5; i++)
            {
                input += Console.ReadLine() + '\n';
            }

            Match m = Regex.Match(input, pattern);

            if (!m.Success)
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                Console.WriteLine($"Valid\n{m.Groups["core"].ToString().Length}");
            }
        }
    }
}