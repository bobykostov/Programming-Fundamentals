using System;
using System.Linq;

namespace Pr2RotateAndSum
{
    class Pr2RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int numberOfRotations = int.Parse(Console.ReadLine());
            int[] sum = new int[numbers.Length];

            for (int i = 0; i < numberOfRotations; i++)
            {
                numbers = Rotate(numbers);
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }

            Console.WriteLine(string.Join(" ", sum));
        }

        private static int[] Rotate(int[] numbers)
        {
            int[] rotated = new int[numbers.Length];
            int last = numbers[numbers.Length - 1];
            rotated[0] = last;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                rotated[i+1] = numbers[i];
            }
            return rotated;
        }
    }
}