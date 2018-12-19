using System;

namespace ConditionsAndLoopsExercises
{
    class Pr6IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 2 && j == i)
                    {
                        Console.Write(i + " \r\n");
                    }
                    else if (j == i)
                    {
                        Console.Write(i + "\r\n");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}