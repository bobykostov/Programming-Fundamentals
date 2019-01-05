using System;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string word1 = input[0];
            string word2 = input[1];

            long sum = word1
                .Zip(word2, (ch1, ch2) => ch1 * ch2).Sum();

            if (word1.Length > word2.Length)
            {
                sum += word1.TakeLast(word1.Length - word2.Length)
                    .Select(a => (int)a).Sum();
            }
            else if (word2.Length > word1.Length)
            {
                sum += word2.TakeLast(word2.Length - word1.Length)
                    .Select(a => (int)a).Sum();
            }

            Console.WriteLine(sum);
        }
    }
}
