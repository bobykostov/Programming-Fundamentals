using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int studioPrice = 0;
            int doublePrice = 0;
            int suitePrice = 0;

            int studioNights = nights;
            double studioDisc = 1;
            double doubleDisc = 1;
            double suiteDisc = 1;

            if (month.Equals("May") || month.Equals("October"))
            {
                studioPrice += 50;
                doublePrice += 65;
                suitePrice += 75;

                if (nights > 7)
                {
                    studioDisc = 0.95;

                    if (month.Equals("October"))
                        studioNights -= 1;
                }
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                studioPrice += 60;
                doublePrice += 72;
                suitePrice += 82;

                if (month.Equals("September") && nights > 7)
                    studioNights -= 1;

                if (nights > 14)
                {
                    doubleDisc = 0.9;
                }
            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                studioPrice += 68;
                doublePrice += 77;
                suitePrice += 89;

                if (nights > 14)
                {
                    suiteDisc = 0.85;
                }
            }

            double studioCost = studioPrice * studioDisc * studioNights;
            double doubleCost = doublePrice * doubleDisc * nights;
            double suiteCost = suitePrice * suiteDisc * nights;

            Console.WriteLine($"Studio: {studioCost:F2} lv.");
            Console.WriteLine($"Double: {doubleCost:F2} lv.");
            Console.WriteLine($"Suite: {suiteCost:F2} lv.");
        }
    }
}
