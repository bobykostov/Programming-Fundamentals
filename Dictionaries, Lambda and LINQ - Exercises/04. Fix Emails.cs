using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr4
{
    class Pr4
    {
        static void Main(string[] args)
        {
            var emails = new Dictionary<string, string>();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                string email = Console.ReadLine();
                string domain = email.Split('.').Last();

                if (domain != "us" && domain != "uk")
                {
                    emails.Add(line, email);
                }

                line = Console.ReadLine();
            }

            foreach (var entry in emails)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}