using System;
using System.Collections.Generic;
using System.Linq;

namespace FundamentalsCatchup
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = new Dictionary<string, Dictionary<string, int>>();
            var toys = new Dictionary<string, int>();

            string input = string.Empty;
            while (!"END".Equals(input = Console.ReadLine()))
            {
                string[] info = input.Split("->");

                if (info.Length == 3)
                {
                    string name = info[0];
                    string toy = info[1];
                    int amount = int.Parse(info[2]);

                    if (!kids.ContainsKey(name))
                    {
                        kids[name] = new Dictionary<string, int>();
                    }
                    if (!kids[name].ContainsKey(toy))
                    {
                        kids[name][toy] = 0;
                    }
                    kids[name][toy] += amount;

                    if (!toys.ContainsKey(toy))
                    {
                        toys[toy] = 0;
                    }
                    toys[toy] += amount;
                }
                else if (info.Length == 2 && info[0] == "Remove")
                {
                    if (kids.ContainsKey(info[1]))
                        kids.Remove(info[1]);
                }
            }

            Console.WriteLine("Children:");
            foreach (var kidToy in kids
                .OrderByDescending(kv => kv.Value.Values.Sum())
                .ThenBy(kv => kv.Key))
            {
                Console.WriteLine($"{kidToy.Key} -> " +
                    $"{kidToy.Value.Values.Sum()}");
            }

            Console.WriteLine("Presents:");
            foreach (var toy in toys)
            {
                Console.WriteLine($"{toy.Key} -> {toy.Value}");
            }
        }
    }
}