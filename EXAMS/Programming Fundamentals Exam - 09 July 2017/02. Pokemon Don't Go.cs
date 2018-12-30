using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            int removed = 0;

            while (nums.Any())
            {
                int index = int.Parse(Console.ReadLine());
                int elem = 0;

                if (index < 0)
                {
                    elem = nums[0];
                    nums[0] = nums.Last();
                }
                else if (index > nums.Count() - 1)
                {
                    elem = nums.Last();
                    nums[nums.Count() - 1] = nums.First();
                }
                else
                {
                    elem = nums[index];
                    nums.RemoveAt(index);
                }

                removed += elem;

                nums = nums.Select(x =>
                {
                    if (x <= elem)
                        x += elem;
                    else if (x > elem)
                        x -= elem;

                    return x;
                }).ToList();
            }

            Console.WriteLine(removed);
        }
    }
}
