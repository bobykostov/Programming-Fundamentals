using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = new List<string>();
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();

            string input = string.Empty;
            while (!"Hornet is Green".Equals(input = Console.ReadLine()))
            {
                inputs.Add(input);
            }

            foreach (string line in inputs)
            {
                string[] queries = Regex.Split(line, @" <-> ");

                if (queries.Length != 2)
                    continue;

                string firstQ = queries[0];
                string secondQ = queries[1];

                if (Regex.IsMatch(firstQ, @"^\d+$") &&
                    Regex.IsMatch(secondQ, @"^[a-zA-Z\d]+$"))
                {
                    string firQnew = string.Empty;
                    for (int i = firstQ.Length - 1; i >= 0; i--)
                    {
                        firQnew += firstQ[i];
                    }
                    messages.Add($"{firQnew} -> {secondQ}");
                }
                if (Regex.IsMatch(firstQ, @"^[^\d]+$") &&
                    Regex.IsMatch(secondQ, @"^[a-zA-Z\d]+$"))
                {
                    string secQnew = string.Empty;
                    for (int i = 0; i < secondQ.Length; i++)
                    {
                        if (Char.IsUpper(secondQ[i]))
                            secQnew += Char.ToLower(secondQ[i]);
                        else if (Char.IsLower(secondQ[i]))
                            secQnew += Char.ToUpper(secondQ[i]);
                        else
                            secQnew += secondQ[i];
                    }
                    broadcasts.Add($"{secQnew} -> {firstQ}");
                }
            }

            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count > 0)
            {
                foreach (string broadcast in broadcasts)
                    Console.WriteLine(broadcast);
            }
            else
                Console.WriteLine("None");

            Console.WriteLine("Messages:");
            if (messages.Count > 0)
            {
                foreach (string message in messages)
                    Console.WriteLine(message);
            }
            else
                Console.WriteLine("None");
        }
    }
}
