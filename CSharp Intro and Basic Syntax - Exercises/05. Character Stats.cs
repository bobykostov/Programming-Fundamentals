using System;

namespace Pr5characterStats
{
    class Pr5characterStats
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}" + Environment.NewLine +
                $"Health: |{new string ('|', currentHealth)}{new string('.', maxHealth - currentHealth)}|" + Environment.NewLine +
                $"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}| ");
        }
    }
}