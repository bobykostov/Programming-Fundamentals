using System;
using System.Linq;

namespace Pr2Redo
{
    class Pr2Redo
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = int.Parse(Console.ReadLine());

            int n = nums.Length;
            int[] rotatedNums = new int[n];
            int[] sum = new int[n];
            for (int i = 0; i < k; i++)
            {
                int lastone = nums[n - 1];
                rotatedNums[0] = lastone;

                int[] firstcouple = new int[n - 1];
                for (int m = 0; m < nums.Length - 1; m++)
                {
                    rotatedNums[m+1] = nums[m];
                }

                for (int j = 0; j < n; j++)
                {
                    sum[j] += rotatedNums[j];
                }

                nums = rotatedNums.ToArray();
            }

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}