using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Regex symbolReg = new Regex(@"@{6,}|#{6,}|\${6,}|\^{6,}");

            foreach (string ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                string firstHalf = ticket.Substring(0, 10);
                string secondHalf = ticket.Substring(10);

                Match firstMatch = symbolReg.Match(firstHalf);
                Match secondMatch = symbolReg.Match(secondHalf);

                if (!firstMatch.Success || 
                    !secondMatch.Success || 
                    firstMatch.Value[0] != secondMatch.Value[0])
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                    continue;
                }

                string firHalfMatch = firstMatch.Value;
                string secHalfMatch = secondMatch.Value;
                int winLength = Math.Min(firHalfMatch.Length,
                        secHalfMatch.Length);

                string win = $"ticket \"{ticket}\" - " +
                        $"{winLength}" +
                        $"{firHalfMatch[0]}";
                if (firHalfMatch.Length == 10 &&
                    secHalfMatch.Length == 10)
                    win += " Jackpot!";

                Console.WriteLine(win);
            }
        }
    }
}
