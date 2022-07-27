using System;
using System.Collections.Generic;

namespace _03_Pirates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Sail")
            {
                string[] city = line
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);

                string name = city[0];
                int population = int.Parse(city[1]);
                int gold = int.Parse(city[2]);

                if (!cities.ContainsKey(name))
                {
                    cities.Add(name, new List<int>() { population, gold });
                }
                else
                {
                    cities[name][0] += population;
                    cities[name][1] += gold;
                }
            }

            string newLine = string.Empty;

            while ((newLine = Console.ReadLine()) != "End")
            {
                string[] cmds = newLine
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmds[0];

                if (cmd == "Plunder")
                {
                    string town = cmds[1];
                    int people = int.Parse(cmds[2]);
                    int gold = int.Parse(cmds[3]);

                    cities[town][0] -= people;
                    cities[town][1] -= gold;

                    Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

                    if (cities[town][0] <= 0 || cities[town][1] <= 0)
                    {
                        cities.Remove(town);
                        Console.WriteLine($"{town} has been wiped off the map!");
                    }
                }
                else if (cmd == "Prosper")
                {
                    string town = cmds[1];
                    int gold = int.Parse(cmds[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cities[town][1] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {cities[town][1]} gold.");
                    }

                }
            }


            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
