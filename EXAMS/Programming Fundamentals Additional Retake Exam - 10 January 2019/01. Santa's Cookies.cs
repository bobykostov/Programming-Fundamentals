using System;

namespace FundamentalsCatchup
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());

            int totalBoxes = 0;

            while (batches-- > 0)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / 140;
                int sugarSpoons = sugar / 20;
                int cocoaSpoons = cocoa / 10;

                if (flourCups <= 0 ||
                    sugarSpoons <= 0 ||
                    cocoaSpoons <= 0)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                    continue;
                }

                double cookiesPerBake = (140 + 10 + 20) *
                    Math.Min(flourCups, Math.Min(sugarSpoons, cocoaSpoons)) /
                    25;

                int boxesPerBatch = (int)Math.Floor(cookiesPerBake) / 5;
                totalBoxes += boxesPerBatch;

                Console.WriteLine($"Boxes of cookies: {boxesPerBatch}");
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}