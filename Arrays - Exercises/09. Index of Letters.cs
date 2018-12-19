using System;
using System.Linq;

namespace Pr9
{
    class Pr9
    {
        static void Main(string[] args)
        {
            char[] alph = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
             'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q',
             'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',};

            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} -> {Array.IndexOf(alph, arr[i])}");
            }
        }
    }
}