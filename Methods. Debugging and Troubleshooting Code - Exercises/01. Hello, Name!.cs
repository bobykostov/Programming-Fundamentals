using System;

namespace MethodsExercises
{
    class Pr1HelloName
    {
        static void PrintName(string name)
        {
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName($"Hello, {name}!");
        }
    }
}