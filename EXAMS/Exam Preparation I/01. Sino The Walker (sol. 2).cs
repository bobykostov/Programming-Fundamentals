using System;
using System.Globalization;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            TimeSpan time = TimeSpan.ParseExact(Console.ReadLine(), @"hh\:mm\:ss", CultureInfo.InvariantCulture);
            long steps = long.Parse(Console.ReadLine());
            long stepTime = long.Parse(Console.ReadLine());
            long timeWalked = (steps * stepTime) % 86400;

            time += TimeSpan.FromSeconds(timeWalked);

            Console.WriteLine($"Time Arrival: {time.ToString(@"hh\:mm\:ss")}");
        }
    }
}