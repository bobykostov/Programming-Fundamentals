using System;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            char[] sep = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };

            string[] shorts = Console.ReadLine()
                .ToLower()
                .Split(sep, StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct()
                .ToArray();

            Console.WriteLine(String.Join(", ", shorts));
        }
    }
}