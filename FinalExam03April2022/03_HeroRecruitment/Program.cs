using System;
using System.Collections.Generic;

namespace HeroRecruitment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] commandArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = commandArgs[0];
                string heroName = commandArgs[1];

                if (command == "Enroll")
                {
                    if (!heroes.ContainsKey(heroName))
                    {
                        heroes.Add(heroName, new List<string>());
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} is already enrolled.");
                    }
                }
                else if (command == "Learn")
                {
                    string spellName = commandArgs[2];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (!heroes[heroName].Contains(spellName))
                        {
                            heroes[heroName].Add(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} has already learnt {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                    
                }
                else if (command == "Unlearn")
                {
                    string spellName = commandArgs[2];

                    if (heroes.ContainsKey(heroName))
                    {
                        if (heroes[heroName].Contains(spellName))
                        {
                            heroes[heroName].Remove(spellName);
                        }
                        else
                        {
                            Console.WriteLine($"{heroName} doesn't know {spellName}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} doesn't exist.");
                    }
                }
            }

            Console.WriteLine("Heroes:");

            foreach (var hero in heroes)
            {
                Console.WriteLine($"== {hero.Key}: {string.Join(", ", hero.Value)}");
            }
        }
    }
}
