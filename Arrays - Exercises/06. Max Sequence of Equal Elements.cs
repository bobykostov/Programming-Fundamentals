using System;
using System.Linq;

namespace Pr6
{
    class Pr6
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int len = 1;
            int bestLen = 0;
            int start = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i-1] == arr[i])
                {
                    len++;

                    if (len > bestLen)
                    {
                        bestLen = len;
                        start = i - bestLen;
                    }
                }
                else
                {
                    len = 1;
                }
            }

            if (len > bestLen) Console.WriteLine(arr[bestLen]);
            else
            {
                for (int i = 0; i < bestLen; i++)
                {
                    Console.Write(arr[start + i + 1] + " ");
                }
            }
        }
    }
}