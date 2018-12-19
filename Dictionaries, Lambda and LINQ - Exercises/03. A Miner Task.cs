using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;

            var mine = new Dictionary<string, int>();

            while ((resource = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                
                if (!mine.ContainsKey(resource))
                {
                    mine.Add(resource, quantity);
                }
                else
                {
                    mine[resource] += quantity;
                }
            }

            foreach (var res in mine)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}