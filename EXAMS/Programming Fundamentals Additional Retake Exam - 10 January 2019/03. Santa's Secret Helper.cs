using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FundamentalsCatchup
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            List<string> toDecode = new List<string>();

            string input = string.Empty;
            while (!"end".Equals(input = Console.ReadLine()))
            {
                toDecode.Add(input);
            }

            List<string> good = new List<string>();
            Regex reg = new Regex(@"@([a-zA-Z]+)[^@\-!:>]+!(G|N)!");
            foreach (string line in toDecode)
            {
                string decoded = string.Empty;
                foreach (char ch in line)
                {
                    decoded += Convert.ToChar(ch - n);
                }

                Match match = reg.Match(decoded);
                if (match.Success)
                {
                    string name = match.Groups[1].Value;
                    string gOrN = match.Groups[2].Value;

                    if ("G".Equals(gOrN))
                        good.Add(name);
                }
            }

            foreach (string kid in good)
            {
                Console.WriteLine(kid);
            }
        }
    }
}