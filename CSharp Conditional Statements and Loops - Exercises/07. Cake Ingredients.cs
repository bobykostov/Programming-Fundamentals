using System;

namespace ConditionsAndLoopsExercises
{
    class Pr6IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            string ingredient = Console.ReadLine();
            int sum = 0;

            while (ingredient != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                ++sum;
                ingredient = Console.ReadLine();
            }
            if (ingredient == "Bake!")
            {
                Console.WriteLine($"Preparing cake with {sum} ingredients.");
            }
        }
    }
}