using System;

namespace ConditionsAndLoopsExercises
{
    class Pr6IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int cheeseCalories = 500;
            int tomatoSauceCalories = 150;
            int salamiCalories = 600;
            int pepperCalories = 50;

            int numberOfIngredients = int.Parse(Console.ReadLine());
            int i = 0;
            int calorieCounter = 0;
            while (i != numberOfIngredients)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": calorieCounter += cheeseCalories; break;
                    case "tomato sauce": calorieCounter += tomatoSauceCalories; break;
                    case "salami": calorieCounter += salamiCalories; break;
                    case "pepper": calorieCounter += pepperCalories; break;
                    default: break;
                }
                ++i;
            }
            Console.WriteLine($"Total calories: {calorieCounter}");
        }
    }
}