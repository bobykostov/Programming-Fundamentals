using System;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            while((input = Console.ReadLine()) != "end")
            {
                string reg = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replacement = @"[URL href=$1]$2[/URL]";

                string replaced = Regex.Replace(input, reg, replacement);

                Console.WriteLine(replaced);
            }
        }
    }
}