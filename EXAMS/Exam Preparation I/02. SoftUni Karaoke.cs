using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participants = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> songlist = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var awards = new Dictionary<string, HashSet<string>>();

            string input = string.Empty;
            while (!"dawn".Equals(input = Console.ReadLine()))
            {
                string[] participant = input
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string part = participant[0];
                string song = participant[1];
                string award = participant[2];

                if (participants.Contains(part) && 
                    songlist.Contains(song))
                {
                    if (!awards.ContainsKey(part))
                        awards[part] = new HashSet<string>{ award };
                    else
                        awards[part].Add(award);
                }
            }

            int awardCount = 0;
            foreach (var awList in awards.Values)
            {
                awardCount += awList.Count;
            }

            if (awardCount == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (string part in awards.Keys
                .OrderByDescending(i => awards[i].Count).ThenBy(i => i))
            {
                Console.WriteLine($"{part}: {awards[part].Count} awards");

                foreach (string award in awards[part].OrderBy(i => i))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
