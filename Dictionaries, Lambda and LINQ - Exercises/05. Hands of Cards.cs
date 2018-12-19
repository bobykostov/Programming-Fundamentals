using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var players = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "JOKER")
            {
                string personName = input.Split(": ").First();
                string[] cards = input.Split(": ").Last()
                    .Split(", ").Distinct().ToArray();

                if (!players.ContainsKey(personName))
                {
                    players.Add(personName, new List<string>());
                }

                foreach (string card in cards)
                {
                    players[personName].Add(card);
                }
            }

            foreach (var hand in players)
            {
                int score = 0;

                foreach (string card in hand.Value.Distinct())
                {
                    int power = 0;
                    char type = card.ToCharArray().Last();
                    bool isNum = int.TryParse(card.Substring(0, card.Length - 1), out power);

                    if (!isNum)
                    {
                        switch (card.Substring(0, card.Length - 1))
                        {
                            case "J": power = 11; break;
                            case "Q": power = 12; break;
                            case "K": power = 13; break;
                            case "A": power = 14; break;
                            default: break;
                        }
                    }

                    switch (type)
                    {
                        case 'S': score += power * 4; break;
                        case 'H': score += power * 3; break;
                        case 'D': score += power * 2; break;
                        case 'C': score += power; break;
                        default: break;
                    }
                }

                Console.WriteLine($"{hand.Key}: {score}");
            }
        }
    }
}