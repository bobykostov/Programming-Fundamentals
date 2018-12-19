using System;

namespace Pr3EnglishNameLastDigit
{
    class Pr3EnglishNameLastDigit
    {
        static string EnglishName(long fuckyou)
        {
            long lastFuckingDigit = Math.Abs(fuckyou) % 10;
            string fuckingName = "";
            switch (lastFuckingDigit)
            {
                case 0: fuckingName = "zero"; break;
                case 1: fuckingName = "one "; break;
                case 2: fuckingName = "two"; break;
                case 3: fuckingName = "three"; break;
                case 4: fuckingName = "four"; break;
                case 5: fuckingName = "five"; break;
                case 6: fuckingName = "six"; break;
                case 7: fuckingName = "seven"; break;
                case 8: fuckingName = "eight"; break;
                case 9: fuckingName = "nine"; break;
            }
            return fuckingName;
        }

        static void Main(string[] args)
        {
            long fuckingValue = long.Parse(Console.ReadLine());

            Console.WriteLine(EnglishName(fuckingValue));
        }
    }
}