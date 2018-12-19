using System;

namespace Pr1
{
    class Pr1
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int keyCounter = 0;
            int displayCounter = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    ++keyCounter;

                    if (keyCounter % 2 == 0)
                    {
                        ++displayCounter;
                    }
                }
            }

            int timesHeadset = lostGames / 2;
            double headsetCost = timesHeadset * headsetPrice;
            int timesMouse = lostGames / 3;
            double mouseCost = timesMouse * mousePrice;
            double keyCost = keyCounter * keyPrice;
            double displayCost = displayCounter * displayPrice;

            double totalCost = headsetCost + mouseCost + keyCost + displayCost;

            Console.WriteLine($"Rage expenses: {totalCost:F2} lv.");
        }
    }
}