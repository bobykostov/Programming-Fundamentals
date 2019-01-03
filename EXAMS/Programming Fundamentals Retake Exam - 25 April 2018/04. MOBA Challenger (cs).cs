using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = new Dictionary<string, Dictionary<string, int>>();
            var totalSkill = new Dictionary<string, int>();

            string input = string.Empty;
            while (!"Season end".Equals(input = Console.ReadLine()))
            {
                if (input.Contains(" -> "))
                {
                    string[] info = input.Split(" -> ").ToArray();
                    string player = info[0];
                    string position = info[1];
                    int skill = int.Parse(info[2]);

                    if (!season.ContainsKey(player))
                    {
                        season[player] = new Dictionary<string, int>();
                    }
                    if (!season[player].ContainsKey(position) ||
                        season[player][position] < skill)
                    {
                        season[player][position] = skill;
                        totalSkill[player] = season[player].Values.Sum();
                    }
                }
                if (input.Contains(" vs "))
                {
                    string[] info = input.Split(" vs ").ToArray();
                    string player1 = info[0];
                    string player2 = info[1];

                    if (season.ContainsKey(player1) &&
                        season.ContainsKey(player2))
                    {
                        foreach (var pl in season[player1])
                        {
                            if (season[player2].ContainsKey(pl.Key))
                            {
                                if (totalSkill[player1] > totalSkill[player2])
                                {
                                    season.Remove(player2);
                                    totalSkill.Remove(player2);
                                    break;
                                }
                                else
                                {
                                    season.Remove(player1);
                                    totalSkill.Remove(player1);
                                    break;
                                }
                            }
                        }
                    }
                }
            }

            foreach (var pl in season
                .OrderByDescending(x => totalSkill[x.Key])
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pl.Key}: {totalSkill[pl.Key]} skill");

                foreach (var posSkill in pl.Value
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {posSkill.Key} <::> {posSkill.Value}");
                }
            }
        }
    }
}
