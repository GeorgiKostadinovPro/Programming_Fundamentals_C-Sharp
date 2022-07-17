using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_LegendaryFarming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var keyMaterials = new Dictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["motes"] = 0;
            keyMaterials["fragments"] = 0;

            var junkMaterials = new Dictionary<string, int>();
            bool hasToBreak = false;
            string legendaryItem = string.Empty;

            while (!hasToBreak)
            {
                string[] input = Console.ReadLine().ToLower().Split(' ');

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];

                    if (keyMaterials.ContainsKey(material))
                    {
                        keyMaterials[material] += quantity;

                        if (keyMaterials[material] >= 250)
                        {
                            if (material == "shards")
                            {
                                legendaryItem = "Shadowmourne";
                            }

                            else if (material == "fragments")
                            {
                                legendaryItem = "Valanyr";
                            }
                            else
                            {
                                legendaryItem = "Dragonwrath";
                            }

                            keyMaterials[material] -= 250;
                            hasToBreak = true;
                            Console.WriteLine($"{legendaryItem} obtained!");
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }

                        junkMaterials[material] += quantity;
                    }
                }
            }

            foreach (var material in keyMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }

            foreach (var material in junkMaterials)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}