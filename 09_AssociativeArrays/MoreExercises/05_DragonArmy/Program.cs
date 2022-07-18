using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_DragonArmy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<double>>> dragons =
                new Dictionary<string, Dictionary<string, List<double>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string type = input[0];
                string name = input[1];
                string damage = input[2];
                string health = input[3];
                string armor = input[4];

                double dragonDamage = 0.0;
                double dragonHealth = 0.0;
                double dragonArmor = 0.0;

                if (damage == "null")
                {
                    dragonDamage = 45;
                }
                else
                {
                    dragonDamage = double.Parse(damage);
                }


                if (health == "null")
                {
                    dragonHealth = 250;
                }
                else
                {
                    dragonHealth = double.Parse(health);
                }


                if (armor == "null")
                {
                    dragonArmor = 10;
                }
                else
                {
                    dragonArmor = double.Parse(armor);
                }

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new Dictionary<string, List<double>>());
                }

                if (dragons[type].Any(d => d.Key.Equals(name)))
                {
                    dragons[type].Remove(name);
                    dragons[type].Add(name, new List<double>() { dragonDamage, dragonHealth, dragonArmor });
                }
                else
                {
                    dragons[type].Add(name, new List<double>() { dragonDamage, dragonHealth, dragonArmor });
                }
            }

            foreach (var type in dragons)
            {
                double averageDamage = 0.0;
                double averageHealth = 0.0;
                double averageArmor = 0.0;

                foreach (var dragon in type.Value)
                {
                    averageDamage += dragon.Value[0];
                    averageHealth += dragon.Value[1];
                    averageArmor += dragon.Value[2];
                }

                int count = type.Value.Count;

                averageDamage /= count;
                averageHealth /= count;
                averageArmor /= count;

                Console.WriteLine($"{type.Key}::({averageDamage:f2}" +
                    $"/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in type.Value.OrderBy(d => d.Key))
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}