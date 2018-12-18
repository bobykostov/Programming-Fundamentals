using System;

namespace BasicsExercises
{
    class Pr1DebitCardNum
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int forth = int.Parse(Console.ReadLine());

            Console.WriteLine($"{first:D4} {second:D4} {third:D4} {forth:D4}");
        }
    }
}
