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
            string[] demons = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> signed = new List<string>();

            foreach (string demon in demons)
            {
                int health = 0;
                Regex healthReg = new Regex(@"[^0-9+\-*\/.]");
                MatchCollection healthMatches = healthReg.Matches(demon);
                foreach (Match ch in healthMatches)
                {
                    health += char.Parse(ch.Value);
                }

                double damage = 0.00D;
                Regex damageReg1 = new Regex(@"[+-]?[0-9]+(\.[0-9]+)?");
                Regex damageReg2 = new Regex(@"[*\/]");
                MatchCollection damageMatches = damageReg1.Matches(demon);
                foreach (Match num in damageMatches)
                {
                    damage += double.Parse(num.Value);
                }
                MatchCollection alteringSymbols = damageReg2.Matches(demon);
                foreach (Match symbol in alteringSymbols)
                {
                    if (symbol.Value == "*")
                        damage *= 2;
                    else if (symbol.Value == "/")
                        damage /= 2;
                }

                signed.Add($"{demon} {health} {damage}");
            }

            foreach (string demon in signed.OrderBy(a => a.Split()[0]))
            {
                string[] stats = demon.Split();
                Console.WriteLine($"{stats[0]} - " +
                    $"{stats[1]} health, " +
                    $"{double.Parse(stats[2]):F2} damage");
            }
        }
    }
}
