using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte length = byte.Parse(Console.ReadLine());
            string input = string.Empty;

            List<string> sequences = new List<string>();

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                sequences.Add(input);
            }

            string bestSample = string.Empty;
            int bestSeqLength = 0;
            int bestSeqIndex = int.MaxValue;
            int bestSequenceIndex = -1;
            int bestSum = 0;

            foreach (string seq in sequences)
            {
                int[] dna = seq
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int seqLength = 1;
                int bestLength = 1;
                int bestIndex = 0;

                for (int i = 0; i < dna.Length - 1; i++)
                {
                    if (dna[i] == 1 && dna[i + 1] == 1)
                        seqLength++;
                    else
                        seqLength = 1;

                    if (seqLength > bestLength)
                    {
                        bestLength = seqLength;
                        bestIndex = i;
                    }
                }

                if (bestLength > bestSeqLength)
                {
                    bestSeqLength = bestLength;
                    bestSeqIndex = bestIndex;
                    bestSample = string.Join(" ", dna);
                    bestSequenceIndex = sequences.IndexOf(seq) + 1;
                    bestSum = dna.Sum();
                }
                else if (bestLength == bestSeqLength && bestIndex < bestSeqIndex)
                {
                    bestSeqIndex = bestIndex;
                    bestSample = string.Join(" ", dna);
                    bestSequenceIndex = sequences.IndexOf(seq) + 1;
                    bestSum = dna.Sum();
                }
                else if (dna.Sum() > bestSum)
                {
                    bestSample = string.Join(" ", dna);
                    bestSequenceIndex = sequences.IndexOf(seq) + 1;
                    bestSum = dna.Sum();
                }
            }

            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSum}.");
            Console.WriteLine(bestSample);
        }
    }
}