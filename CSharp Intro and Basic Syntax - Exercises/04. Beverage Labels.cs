using System;

namespace Pr4BeverageLabels
{
    class Pr4BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double totalEnergyContent = energyContent * volume / 100;
            double totalSugarContent = sugarContent * volume / 100;

            Console.WriteLine($"{volume}ml {name}:\r\n{totalEnergyContent}kcal, {totalSugarContent}g sugars");
        }
    }
}