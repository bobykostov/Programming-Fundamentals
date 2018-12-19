using System;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distancePer1000flaps = double.Parse(Console.ReadLine());
            int flapsBefore5secBreak = int.Parse(Console.ReadLine());
            byte flapsPerSec = 100;

            double distance = (wingFlaps / 1000) * distancePer1000flaps;
            double rest = ((wingFlaps / flapsBefore5secBreak) * 5) + wingFlaps / flapsPerSec;

            Console.WriteLine($"{distance:F2} m.");
            Console.WriteLine($"{rest} s.");
        }
    }
}