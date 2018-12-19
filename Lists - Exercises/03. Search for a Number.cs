using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    class Pr3
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if(numbers.Take(commands[0]).Skip(commands[1]).Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}