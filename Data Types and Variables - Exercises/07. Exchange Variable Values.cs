using System;

namespace DataTypesExercise
{
    class Pr1Integers
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = 0;

            Console.WriteLine($"Before: \na = {a}\nb = {b}");

            c = a;
            a = b;
            b = c;

            Console.WriteLine($"After: \na = {a}\nb = {b}");
        }
    }
}