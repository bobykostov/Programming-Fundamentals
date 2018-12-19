using System;
using System.Linq;

namespace Pr2REDO
{
    class Pr2REDO
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string full = " ";
            while ((input = Console.ReadLine()) != "Visual Studio crash")
            {
                full = full + input + ' ';
            }

            string[] split = full
                .Replace(" 0", "")
                .Trim()
                .Split("32656 19759 32763", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (string coded in split)
            {
                int[] nums = coded
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                char[] word = new char[nums[0]];

                for (int i = 1; i < nums.Length; i++)
                {
                    word[i - 1] = (char)nums[i];
                }

                Console.WriteLine(string.Join("", word));
            }
        }
    }
}