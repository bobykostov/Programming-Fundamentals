using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var forcebook = new Dictionary<string, List<string>>();
            var userSide = new Dictionary<string, string>();

            string input = string.Empty;
            while (!"Lumpawaroo".Equals(input = Console.ReadLine()))
            {
                string[] force = input
                    .Split(new[] { " | ", " -> "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string forceSide = string.Empty;
                string forceUser = string.Empty;

                if (input.Contains(" | "))
                {
                    forceSide = force[0];
                    forceUser = force[1];

                    if (!userSide.ContainsKey(forceUser))
                    {
                        userSide[forceUser] = forceSide;
                    }
                }
                else if (input.Contains(" -> "))
                {
                    forceSide = force[1];
                    forceUser = force[0];

                    userSide[forceUser] = forceSide;

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            foreach (string user in userSide.Keys)
            {
                if (!forcebook.ContainsKey(userSide[user]))
                {
                    forcebook[userSide[user]] = new List<string>();
                }
                forcebook[userSide[user]].Add(user);
            }

            foreach (string side in forcebook.Keys
                .Where(s => forcebook[s].Count > 0)
                .OrderByDescending(s => forcebook[s].Count)
                .ThenBy(s => s))
            {
                Console.WriteLine($"Side: {side}, Members: {forcebook[side].Count}");

                foreach (string member in forcebook[side].OrderBy(m => m))
                {
                    Console.WriteLine($"! {member}");
                }
            }
        }
    }
}
