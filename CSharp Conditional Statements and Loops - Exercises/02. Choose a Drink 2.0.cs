using System;

namespace ConditionsAndLoopsExercises
{
    class Pr1ChooseDrink
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantityBought = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            switch (profession)
            {
                case "Athlete":
                    totalPrice = quantityBought * 0.70;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                case "Businessman":
                    totalPrice = quantityBought * 1.00;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                case "Businesswoman":
                    totalPrice = quantityBought * 1.00;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                case "SoftUni Student":
                    totalPrice = quantityBought * 1.70;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
                default:
                    totalPrice = quantityBought * 1.20;
                    Console.WriteLine($"The {profession} has to pay {totalPrice:F2}.");
                    break;
            }
        }
    }
}