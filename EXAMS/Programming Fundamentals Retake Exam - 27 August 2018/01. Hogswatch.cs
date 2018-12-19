using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int initPresents = int.Parse(Console.ReadLine());
            int presents = initPresents;

            int homesVisited = 0;
            int homesRemaining = 0;
            int timesWentBack = 0;
            int additionalPres = 0;
            for (int i = 0; i < n; i++)
            {
                int children = int.Parse(Console.ReadLine());
                ++homesVisited;
                homesRemaining = n - homesVisited;

                if (children <= presents)
                {
                    presents -= children;
                }
                else if (children > presents)
                {
                    int needed = children - presents;
                    presents = (initPresents / homesVisited) * homesRemaining + needed;
                    additionalPres += presents;
                    ++timesWentBack;
                    presents -= needed;
                }
            }

            if (timesWentBack > 0)
            {
                Console.WriteLine(timesWentBack);
                Console.WriteLine(additionalPres);
            }
            else
            {
                Console.WriteLine(presents);
            }
        }
    }
}