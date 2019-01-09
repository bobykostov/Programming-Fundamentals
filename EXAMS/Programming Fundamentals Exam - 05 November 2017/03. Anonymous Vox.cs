using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] values = Console.ReadLine()
                .Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Regex reg = new Regex(@"([a-zA-Z]+)(.+)(\1)");
            MatchCollection matches = reg.Matches(line);

            int minLength = Math.Min(values.Length, matches.Count);
            for (int i = 0; i < minLength; i++)
            {
                string startEnd = matches[i].Groups[1].Value;
                line = line.Replace(matches[i].Value, 
                    $"{startEnd}{values[i]}{startEnd}");
            }

            Console.WriteLine(line);
        }
    }
}
