using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokedex = new Dictionary<string, List<string>>();
            string input = string.Empty;

            while (!"wubbalubbadubdub".Equals(input = Console.ReadLine()))
            {
                if (input.Contains(" -> "))
                {
                    string[] info = input.Split(" -> ").ToArray();

                    string pokemon = info[0];
                    string evoType = info[1];
                    int evoIndex = int.Parse(info[2]);

                    if (!pokedex.ContainsKey(pokemon))
                    {
                        pokedex[pokemon] = new List<string>();
                        pokedex[pokemon].Add($"{evoType} <-> {evoIndex}");
                    }
                    else
                    {
                        pokedex[pokemon].Add($"{evoType} <-> {evoIndex}");
                    }
                }
                else
                {
                    if (pokedex.ContainsKey(input))
                    {
                        Console.WriteLine($"# {input}");

                        foreach (string evo in pokedex[input])
                        {
                            Console.WriteLine(evo);
                        }
                    }
                }
            }

            foreach (string pokemon in pokedex.Keys)
            {
                Console.WriteLine($"# {pokemon}");

                foreach (string evo in pokedex[pokemon].OrderByDescending(x => 
                    int.Parse(x.Split("> ")[1])))
                {
                    Console.WriteLine(evo);
                }
            }
        }
    }
}
