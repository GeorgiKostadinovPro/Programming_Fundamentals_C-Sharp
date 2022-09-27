using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonArmy
{
    public class Dragon
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public double Damage { get; set; }

        public double Health { get; set; }

        public double Armor { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<Dragon>> dragons = new Dictionary<string, List<Dragon>>();

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

                double dragonDamage = damage != "null" ? double.Parse(damage) : 45;
                double dragonHealth = health != "null" ? double.Parse(health) : 250;
                double dragonArmor = armor != "null" ? double.Parse(armor) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new List<Dragon>());
                }

                Dragon dragon = dragons[type].FirstOrDefault(d => d.Name == name);

                if (dragon != null)
                {
                    dragon.Damage = dragonDamage;
                    dragon.Health = dragonHealth;
                    dragon.Armor = dragonArmor;
                    continue;
                }

                dragon = new Dragon
                {
                    Type = type,
                    Name = name,
                    Damage = dragonDamage,
                    Health = dragonHealth,
                    Armor = dragonArmor,
                };

                dragons[type].Add(dragon);
            }

            foreach (var type in dragons)
            {
                Console.WriteLine($"{type.Key}::({type.Value.Average(d => d.Damage):f2}" +
                    $"/{type.Value.Average(d => d.Health):f2}/{type.Value.Average(d => d.Armor):f2})");

                foreach (var dragon in type.Value.OrderBy(d => d.Name))
                {
                    Console.WriteLine($"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}");
                }
            }
        }
    }
}