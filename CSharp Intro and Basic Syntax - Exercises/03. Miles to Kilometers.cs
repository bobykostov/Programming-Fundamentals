using System;

namespace Pr3mi2km
{
    class Pr3mi2km
    {
        static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());

            Console.WriteLine($"{miles*1.60934:F2}");
        }
    }
}