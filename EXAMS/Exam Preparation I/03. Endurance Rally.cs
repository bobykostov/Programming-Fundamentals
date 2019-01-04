using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(' ').ToArray();
            double[] track = Console.ReadLine().Split(' ')
                .Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split(' ')
                .Select(int.Parse).ToArray();

            foreach (string name in names)
            {
                double charNum = name[0];
                int reached = 0;

                for (int i = 0; i < track.Length; i++)
                {
                    if (checkpoints.Contains(i))
                        charNum += track[i];
                    else
                        charNum -= track[i];

                    if (charNum <= 0)
                    {
                        reached = i;
                        break;
                    }
                }

                if (charNum > 0)
                    Console.WriteLine($"{name} - fuel left {charNum:F2}");
                else
                    Console.WriteLine($"{name} - reached {reached}");
            }
        }
    }
}
