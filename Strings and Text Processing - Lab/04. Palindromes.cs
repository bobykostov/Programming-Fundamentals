using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiters = { ' ', ',', '.', '?', '!' };
            string[] words = Console.ReadLine()
                .Split(delimiters, StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .ToArray();

            List<string> palindromes = new List<string>();

            foreach (string word in words)
            {
                char[] tochars = word.ToCharArray().Reverse().ToArray();
                string revd = String.Join("", tochars);

                if (word.Equals(revd))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(String.Join(", ", palindromes.OrderBy(s => s)));
        }
    }
}
