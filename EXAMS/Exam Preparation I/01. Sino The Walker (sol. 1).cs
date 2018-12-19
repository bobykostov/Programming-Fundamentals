using System;
using System.Linq;

namespace ConsoleApp1
{
    class DictLab1
    {
        static void Main(string[] args)
        {
            int[] timeLeft = Console.ReadLine()
                .Split(':')
                .Select(int.Parse)
                .ToArray();
            long stepsTaken = long.Parse(Console.ReadLine());
            long stepsTime = long.Parse(Console.ReadLine());

            long hh = timeLeft[0];
            long mm = timeLeft[1];
            long ss = timeLeft[2];
            long timeWalked = stepsTaken * stepsTime;

            ss += timeWalked;
            while (ss > 59)
            {
                mm += ss / 60;
                ss %= 60;
            }

            while (mm > 59)
            {
                hh += mm / 60;
                mm %= 60;
            }

            if (hh > 23)
            {
                hh = hh % 24;
            }

            Console.WriteLine($"Time Arrival: {hh:D2}:{mm:D2}:{ss:D2}");
        }
    }
}