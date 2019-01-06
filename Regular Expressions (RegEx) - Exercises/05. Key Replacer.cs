using System;
using System.Text.RegularExpressions;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyStr = Console.ReadLine();
            string textStr = Console.ReadLine();
            string result = string.Empty;

            string keyPattern = @"^([A-Za-z]+)(<|\\|\|).*(<|\\|\|)([A-Za-z]+)$";
            Regex keyReg = new Regex(keyPattern);

            Match keyMatch = keyReg.Match(keyStr);
            string startKey = keyMatch.Groups[1].Value;
            string endKey = keyMatch.Groups[4].Value;

            string textPattern = startKey + @"(.*?)" + endKey;
            Regex textReg = new Regex(textPattern);

            MatchCollection matches = textReg.Matches(textStr);

            foreach (Match m in matches)
            {
                result += m.Groups[1].Value;
            }

            if (result != "")
                Console.WriteLine(result);
            else
                Console.WriteLine("Empty result");
        }
    }
}
