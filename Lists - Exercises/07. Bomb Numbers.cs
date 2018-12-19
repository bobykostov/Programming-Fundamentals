using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr7Redo
{
    class Pr7Redo
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            int[] bomb = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int special = bomb[0];
            int power = bomb[1];

            bool isBomb = num.Contains(special);
            while (isBomb)
            {
                int bombIndex = num.IndexOf(special);
                int lastIndex = num.Count() - 1;

                if (bombIndex - power >= 0 &&
                    bombIndex + power <= lastIndex)
                {
                    num.RemoveRange(bombIndex - power,
                        2 * power + 1);
                }
                if (bombIndex - power < 0 ||
                    bombIndex + power > lastIndex)
                {
                    if (bombIndex + power <= lastIndex)
                    {
                        num.RemoveRange(0,
                        bombIndex + 1 + power);
                    }
                    else if (bombIndex - power >= 0)
                    {
                        num.RemoveRange(bombIndex - power,
                        lastIndex + 1 - (bombIndex - power));
                    }
                    else
                    {
                        num.RemoveRange(0, lastIndex + 1);
                    }
                }
                
                isBomb = num.Contains(special);
            }

            Console.WriteLine(num.Sum());
        }
    }
}