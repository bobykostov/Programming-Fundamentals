using System;

namespace Pr5WordInPlural
{
    class Pr5WordInPlural
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            string y = "y";
            string o = "o";
            string ch = "ch";
            string s = "s";
            string sh = "sh";
            string x = "x";
            string z = "z";

            if (word.EndsWith("y"))
            {
                string newWord = word.Remove(word.Length - 1);
                newWord = newWord.Insert(newWord.Length, "ies");
                Console.WriteLine(newWord);
            }
            else if (word.EndsWith("o") || word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z") || word.EndsWith("ch") || word.EndsWith("sh"))
            {
                string newWord = word.Insert(word.Length, "es");
                Console.WriteLine(newWord);
            }
            else
            {
                string newWord = word.Insert(word.Length, "s");
                Console.WriteLine(newWord);
            }
        }
    }
}