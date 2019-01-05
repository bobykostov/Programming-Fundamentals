using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<char> word1 = input[0].ToCharArray().ToList();
            List<char> word2 = input[1].ToCharArray().ToList();

            BigInteger sum = word1
                .Zip(word2, (ch1, ch2) => ch1 * ch2).Sum();

            if (word1.Count > word2.Count)
            {
                sum += word1
                    .GetRange(word2.Count, word1.Count - word2.Count)
                    .Select(a => (int)a).Sum();
            }
            else if (word2.Count > word1.Count)
            {
                sum += word2
                    .GetRange(word1.Count, word2.Count - word1.Count)
                    .Select(a => (int)a).Sum();
            }

            Console.WriteLine(sum);
        }
    }
}
