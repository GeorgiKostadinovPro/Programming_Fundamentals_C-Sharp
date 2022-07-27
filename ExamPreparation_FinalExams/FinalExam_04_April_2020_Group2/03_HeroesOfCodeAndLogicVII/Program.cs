using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HeroesOfCodeAndLodicVII
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<int>> heroes = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] heroesInfo = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (!heroes.ContainsKey(heroesInfo[0]))
                {
                    heroes.Add(heroesInfo[0], new List<int>() { int.Parse(heroesInfo[1]), int.Parse(heroesInfo[2]) });
                }
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = line.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string heroName = cmdArgs[1];

                if (cmdArgs[0] == "CastSpell")
                {
                    int mpNeeded = int.Parse(cmdArgs[2]);
                    string spellName = cmdArgs[3];

                    if (heroes[heroName][1] >= mpNeeded)
                    {
                        heroes[heroName][1] -= mpNeeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName][1]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (cmdArgs[0] == "TakeDamage")
                {
                    int damage = int.Parse(cmdArgs[2]);
                    string attacker = cmdArgs[3];

                    heroes[heroName][0] -= damage;

                    if (heroes[heroName][0] > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName][0]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                        heroes.Remove(heroName);
                    }
                }
                else if (cmdArgs[0] == "Recharge")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    int recharged = heroes[heroName][1] + amount;

                    if (recharged > 200)
                    {
                        amount = 200 - heroes[heroName][1];
                        heroes[heroName][1] = 200;
                    }
                    else
                    {
                        heroes[heroName][1] += amount;
                    }

                    Console.WriteLine($"{heroName} recharged for {amount} MP!");
                }
                else if (cmdArgs[0] == "Heal")
                {
                    int amount = int.Parse(cmdArgs[2]);

                    int reHealed = heroes[heroName][0] + amount;

                    if (reHealed > 100)
                    {
                        amount = 100 - heroes[heroName][0];
                        heroes[heroName][0] = 100;
                    }
                    else
                    {
                        heroes[heroName][0] += amount;
                    }

                    Console.WriteLine($"{heroName} healed for {amount} HP!");
                }
            }

            foreach (var hero in heroes/*.OrderByDescending(h => h.Value[0]).ThenBy(h => h.Key)*/)
            {
                Console.WriteLine($"{hero.Key}");

                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }
    }
}
