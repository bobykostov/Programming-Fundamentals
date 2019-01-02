using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var legions = new Dictionary<string, Dictionary<string, long>>();

            while (n-- > 0)
            {
                string[] info = Console.ReadLine()
                    .Split(new char[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                long lastActivity = long.Parse(info[0]);
                string legionName = info[1];
                string soldierType = info[2];
                long soldierCount = long.Parse(info[3]);

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = new Dictionary<string, long>
                    {
                        { "lastActivity", lastActivity },
                        { soldierType, soldierCount }
                    };
                }
                else if (!legions[legionName].ContainsKey(soldierType))
                {
                    legions[legionName][soldierType] = soldierCount;
                }
                else
                {
                    legions[legionName][soldierType] += soldierCount;
                }

                if (legions[legionName]["lastActivity"] < lastActivity)
                {
                    legions[legionName]["lastActivity"] = lastActivity;
                }
            }

            string[] finalLine = Console.ReadLine().Split('\\').ToArray();
            if (finalLine.Length > 1)
            {
                int activity = int.Parse(finalLine[0]);
                string solType = finalLine[1];

                foreach (string legion in legions.Keys
                    .Where(l => legions[l].ContainsKey(solType) && legions[l]["lastActivity"] < activity)
                    .OrderByDescending(l => legions[l][solType]))
                {
                    Console.WriteLine($"{legion} -> {legions[legion][solType]}");
                }
            }
            else
            {
                foreach (string legion in legions.Keys
                    .Where(l => legions[l].ContainsKey(finalLine[0]))
                    .OrderByDescending(l => legions[l]["lastActivity"]))
                {
                    Console.WriteLine($"{legions[legion]["lastActivity"]} : {legion}");
                }
            }
        }
    }
}
