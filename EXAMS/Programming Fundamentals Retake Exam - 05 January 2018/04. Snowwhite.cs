using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dwarves = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while (!"Once upon a time".Equals(input = Console.ReadLine()))
            {
                string[] dwarf = input
                    .Split(new char[] { '<', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string dwarfName = dwarf[0];
                string dwarfHatColor = dwarf[1];
                int dwarfPhysics = int.Parse(dwarf[2]);
                
                if (!dwarves.ContainsKey(dwarfHatColor))
                {
                    dwarves[dwarfHatColor] = new Dictionary<string, int>();
                }
                if (!dwarves[dwarfHatColor].ContainsKey(dwarfName) ||
                    dwarves[dwarfHatColor][dwarfName] < dwarfPhysics)
                {
                    dwarves[dwarfHatColor][dwarfName] = dwarfPhysics;
                }
            }

            List<string> toSort = new List<string>();
            foreach (string color in dwarves.Keys)
            {
                foreach (string name in dwarves[color].Keys)
                {
                    toSort.Add($"{color} {name} {dwarves[color][name]}");
                }
            }

            foreach (string dw in toSort
                .OrderByDescending(d => d.Split(' ')[2])
                .ThenByDescending(d => dwarves[d.Split(' ')[0]].Keys.Count))
            {
                string[] parts = dw.Split(' ').ToArray();
                Console.WriteLine($"({parts[0]}) {parts[1]} <-> {parts[2]}");
            }
        }
    }
}
