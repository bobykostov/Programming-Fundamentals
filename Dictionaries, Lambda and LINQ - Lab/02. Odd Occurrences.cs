using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToArray();

            var dict = new Dictionary<string, int>();

            foreach (string s in input)
            {
                if(dict.ContainsKey(s))
                {
                    dict[s]++;
                }
                else
                {
                    dict[s] = 1;
                }
            }

            List<string> odds = new List<string>();

            foreach (var kvp in dict)
            {
                if (kvp.Value % 2 != 0)
                {
                    odds.Add(kvp.Key);
                }
                else continue;
            }

            Console.WriteLine(String.Join(", ", odds));
        }
    }
}