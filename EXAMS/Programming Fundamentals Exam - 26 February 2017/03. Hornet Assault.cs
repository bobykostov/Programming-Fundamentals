using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine()
                .Split(' ').Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                    break;

                long hornetPower = hornets.Sum();

                if (beehives[i] >= hornetPower)
                {
                    beehives[i] -= hornetPower;
                    hornets.RemoveAt(0);
                }
                else
                    beehives[i] = 0;
            }

            beehives = beehives.Where(b => b > 0).ToList();
            if (beehives.Count > 0)
                Console.WriteLine(string.Join(" ", beehives));
            else
                Console.WriteLine(string.Join(" ", hornets));
        }
    }
}
