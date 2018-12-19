using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            var phone = new Dictionary<string, string>();

            while ((input = Console.ReadLine()) != "END")
            {
                string[] info = input.Split(' ').ToArray();

                if (info[0] == "A")
                {
                    if (!phone.ContainsKey(info[1]))
                    {
                        phone.Add(info[1], info[2]);
                    }
                    else
                    {
                        phone[info[1]] = info[2];
                    }
                }
                else if (info[0] == "S")
                {
                    if (phone.ContainsKey(info[1]))
                    {
                        Console.WriteLine($"{info[1]} -> {phone[info[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {info[1]} does not exist.");
                    }
                }
                else if (input.Equals("ListAll"))
                {
                    foreach (var entry in phone.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
            }
        }
    }
}