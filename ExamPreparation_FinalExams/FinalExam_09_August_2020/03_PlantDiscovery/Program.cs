using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_PlantsDiscovery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, List<int>> plants = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] plantsInfo = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plant = plantsInfo[0];
                int rarity = int.Parse(plantsInfo[1]);

                if (!plants.ContainsKey(plant))
                {
                    plants.Add(plant, new List<int>() { rarity });
                }
                else
                {
                    plants[plant][0] = rarity;
                }

            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdArgs = line
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);

                string cmd = cmdArgs[0];

                string[] arguments = cmdArgs[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                string plant = arguments[0];

                if (cmd == "Rate")
                {
                    int rating = int.Parse(arguments[1]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "Update")
                {
                    int newRarity = int.Parse(arguments[1]);

                    if (plants.ContainsKey(plant))
                    {
                        plants[plant][0] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd == "Reset")
                {
                    if (plants.ContainsKey(plant))
                    {
                        int count = plants[plant].Count;
                        plants[plant].RemoveRange(1, count - 1);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var plant in plants)
            {
                double average = plant.Value.Count > 1 ? plant.Value.Skip(1).Average() : 0.0;

                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value[0]}; Rating: {average:f2}");
            }
        }
    }
}
