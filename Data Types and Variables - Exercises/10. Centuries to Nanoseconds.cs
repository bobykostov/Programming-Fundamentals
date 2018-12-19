using System;

namespace DataTypesExercise
{
    class Pr1Integers
    {
        static void Main(string[] args)
        {
            byte centuries = byte.Parse(Console.ReadLine());
            uint years = Convert.ToUInt32(centuries * 100);
            double days = Math.Floor(years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;
            double seconds = minutes * 60;
            double milliseconds = seconds * 1000;
            decimal microseconds = Convert.ToDecimal(milliseconds * 1000);
            string nanoseconds = Convert.ToString(microseconds * 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}