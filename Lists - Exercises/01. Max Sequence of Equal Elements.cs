using System;
using System.Linq;
using System.Collections.Generic;

namespace Pr1Redo
{
    class Pr1Redo
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int counter = 1;
            int counterBest = 0;
            int bestNum = 0;

            for (int i = 0; i < num.Count - 1; i++)
            {
                if (num[i] == num[i + 1])
                {
                    counter++;

                    if (counter > counterBest)
                    {
                        counterBest = counter;
                        bestNum = num[i];
                    }
                }
                else
                {
                    counter = 1;
                }

                if (counter > counterBest)
                {
                    counterBest = counter;
                    bestNum = num[i];
                }
            }

            for (int i = 0; i < counterBest; i++)
            {
                Console.Write(bestNum + " ");
            }
        }
    }
}