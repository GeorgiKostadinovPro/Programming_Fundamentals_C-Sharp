using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_TreasureHunt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var initialLoot = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Yohoho!")
            {
                var commands = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var command = commands[0];

                if (command == "Loot")
                {
                    var items = commands.Skip(1).Take(commands.Length - 1).ToArray();

                    foreach (var item in items)
                    {
                        if (!initialLoot.Contains(item))
                        {
                            initialLoot.Insert(0, item);
                        }
                    }
                }
                else if (command == "Drop")
                {
                    var index = int.Parse(commands[1]);

                    if (index >= 0 && index < initialLoot.Count)
                    {
                        string item = initialLoot[index];
                        initialLoot.RemoveAt(index);
                        initialLoot.Add(item);
                    }
                }
                else
                {
                    var count = int.Parse(commands[1]);
                    List<string> stolenItems = new List<string>();
                    count = Math.Min(initialLoot.Count, count);

                    for (int i = initialLoot.Count - count; i < initialLoot.Count; i++)
                    {
                        stolenItems.Add(initialLoot[i]);
                    }

                    initialLoot.RemoveRange(initialLoot.Count - count, count);
                    Console.WriteLine(string.Join(", ", stolenItems));
                }
            }

            if (initialLoot.Count > 0)
            {
                double sum = 0.0;

                foreach (var item in initialLoot)
                {
                    sum += item.Length;
                }

                sum /= initialLoot.Count;

                Console.WriteLine
                    ($"Average treasure gain: {sum:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
