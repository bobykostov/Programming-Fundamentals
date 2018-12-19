using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExamFirstAttempt
{
    class Pr1
    {
        static void Main(string[] args)
        {
            double ivanMoney = double.Parse(Console.ReadLine());
            int numberStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double freeBelts = numberStudents / 6;
            double extraSabers = numberStudents * 0.1;

            double totalSaberPrice = (numberStudents + Math.Ceiling(extraSabers)) * lightsaberPrice;
            double totalRobePrice = robePrice * numberStudents;
            double totalBeltPrice = beltPrice * (numberStudents - Math.Floor(freeBelts));
            double totalPrice = totalSaberPrice + totalRobePrice + totalBeltPrice;

            if (totalPrice > ivanMoney)
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - ivanMoney:F2}lv more.");
            }
            else
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
        }
    }
}