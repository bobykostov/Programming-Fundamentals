using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();
            string line = Console.ReadLine();
            int skip = first[0];
            int take = first[1];

            string pattern = @"\|<(?:\w{" + skip + 
                @"})(\w{0," + take + @"})";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(line);

            List<string> m = new List<string>();
            foreach (Match match in matches)
                m.Add(match.Groups[1].ToString());
            Console.WriteLine(string.Join(", ", m));
        }
    }
}
