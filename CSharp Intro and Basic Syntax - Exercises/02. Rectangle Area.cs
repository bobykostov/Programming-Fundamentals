using System;

namespace Pr2RectArea
{
    class Pr2RectArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"{width * height:F2}");
        }
    }
}