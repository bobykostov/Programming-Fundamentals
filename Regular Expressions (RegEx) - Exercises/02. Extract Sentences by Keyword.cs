using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split('.', '!', '?')
                .ToArray();
            string pattern = $@"\b{term}\b";

            foreach (string sent in text)
            {
                if (Regex.IsMatch(sent, pattern))
                {
                    Console.WriteLine(sent.Trim());
                }
            }
        }
    }
}