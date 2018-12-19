using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] revd = input.ToCharArray().Reverse().ToArray();

            Console.WriteLine(String.Join("", revd));
        }
    }
}