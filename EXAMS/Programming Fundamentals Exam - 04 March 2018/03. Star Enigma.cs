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
            byte n = byte.Parse(Console.ReadLine());

            var attacked = new List<string>();
            var destroyed = new List<string>();

            Regex starReg = new Regex(@"[starSTAR]");
            string mPattern = @"@(?<name>[a-zA-z]+)([^@\-!:>]+)?:(\d+)([^@\-!:>]+)?!(?<attack>A|D)!([^@\-!:>]+)?->(\d+)";
            Regex messageReg = new Regex(mPattern);

            while (n-- > 0)
            {
                string message = Console.ReadLine();

                MatchCollection starMatch = starReg.Matches(message);
                string decrypted = string.Empty;
                foreach (char ch in message.ToCharArray())
                {
                    decrypted += Convert.ToChar(ch - starMatch.Count);
                }

                Match messageMatch = messageReg.Match(decrypted);
                if (messageMatch.Success)
                {
                    string name = messageMatch.Groups["name"].Value;
                    char attkType = char.Parse(messageMatch
                        .Groups["attack"].Value);

                    if (attkType == 'A')
                        attacked.Add(name);
                    else if (attkType == 'D')
                        destroyed.Add(name);
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (string pl in attacked.OrderBy(a => a))
            {
                Console.WriteLine($"-> {pl}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (string pl in destroyed.OrderBy(a => a))
            {
                Console.WriteLine($"-> {pl}");
            }
        }
    }
}
