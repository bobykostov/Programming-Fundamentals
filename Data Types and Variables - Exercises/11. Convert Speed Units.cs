using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float allHrs = hours + ((minutes * 60.0f + seconds) / 3600.0f);
            float allSecs = hours * 3600.0f + minutes * 60.0f + seconds;
            float toKm = distance / 1000.0f;
            float toMi = distance / 1609.0f;

            Console.WriteLine($"{distance / allSecs}");
            Console.WriteLine($"{toKm / allHrs}");
            Console.WriteLine($"{toMi / allHrs}");
        }
    }
}
