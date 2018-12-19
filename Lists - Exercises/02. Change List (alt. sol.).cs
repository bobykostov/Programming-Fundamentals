using System;
using System.Collections.Generic;
using System.Linq;

namespace Pr2Redo
{
    class Pr2Redo
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string com = Console.ReadLine();

            while (com != "Odd" && com != "Even")
            {
                string[] comarr = com.Split(' ').ToArray();

                if (comarr[0] == "Delete")
                {
                    int number = Convert.ToInt32(comarr[1]);
                    num.RemoveAll(element => element == number);
                }
                else if (comarr[0] == "Insert")
                {
                    int number = Convert.ToInt32(comarr[1]);
                    int pos = Convert.ToInt32(comarr[2]);
                    num.Insert(pos, number);
                }

                com = Console.ReadLine();
            }

            if (com == "Odd")
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i] % 2 != 0)
                    {
                        Console.Write(num[i] + " ");
                    }
                }
            }
            else if (com == "Even")
            {
                for (int i = 0; i < num.Count; i++)
                {
                    if (num[i] % 2 == 0)
                    {
                        Console.Write(num[i] + " ");
                    }
                }
            }
        }
    }
}