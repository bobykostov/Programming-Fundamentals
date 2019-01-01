using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var idEvent = new Dictionary<int, string>();
            var evPartic = new Dictionary<string, HashSet<string>>();
            string input = string.Empty;

            while (!"Time for Code".Equals(input = Console.ReadLine()))
            {
                if (!input.Contains('#') || 
                    !Char.IsDigit(input[0]))
                    continue;

                List<string> part = input
                    .Split(new char[] { ' ', '#' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                int id = int.Parse(part[0]);
                string eventName = part[1];
                part.RemoveRange(0, 2);

                if (!idEvent.ContainsKey(id))
                {
                    idEvent[id] = eventName;
                    evPartic[eventName] = new HashSet<string>();
                    part.ForEach(x => evPartic[eventName].Add(x));
                }
                else if (idEvent[id] == eventName)
                {
                    part.ForEach(x => evPartic[eventName].Add(x));
                }
            }

            foreach (string ev in evPartic.Keys
                .OrderByDescending(x => evPartic[x].Count)
                .ThenBy(x => x))
            {
                Console.WriteLine($"{ev} - {evPartic[ev].Count}");

                foreach (string participant in evPartic[ev].OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
