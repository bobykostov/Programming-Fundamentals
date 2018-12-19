using System;

namespace Exam2Pr1
{
    class Exam2Pr1
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            uint runners = uint.Parse(Console.ReadLine());
            int averageLaps = int.Parse(Console.ReadLine());
            uint trackLength = uint.Parse(Console.ReadLine());
            int trackCapacity = int.Parse(Console.ReadLine());
            decimal donationPerKm = decimal.Parse(Console.ReadLine());

            uint maxRunners = Convert.ToUInt32(trackCapacity * days);
            if (maxRunners > runners)
                maxRunners = runners;

            long meters = trackLength * averageLaps * maxRunners;
            decimal km = meters / 1000;
            decimal moneyRaised = km * donationPerKm;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}