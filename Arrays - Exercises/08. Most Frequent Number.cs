using System;
using System.Linq;

namespace Pr8
{
    class Pr8
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int[] count = new int[arr.Length];
            int countMax = 0;
            int bestInt = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count[i]++;

                        if (count[i] > countMax)
                        {
                            countMax = count[i];
                            bestInt = arr[i];
                        }
                    }
                }
            }

            Console.WriteLine(bestInt);
        }
    }
}