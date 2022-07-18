using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Snowwhite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Once upon a time")
            {
                string[] cmdArgs = line
                    .Split(" <:> ", StringSplitOptions.None);

                string name = cmdArgs[0];
                string color = cmdArgs[1];
                int physics = int.Parse(cmdArgs[2]);

                string dwarfID = name + ":" + color;

                if (!dwarfs.ContainsKey(dwarfID))
                {
                    dwarfs.Add(dwarfID, physics);
                }
                else
                {
                    dwarfs[dwarfID] = Math.Max(dwarfs[dwarfID], physics);
                }
            }

            foreach (var dwarf in dwarfs
                .OrderByDescending(d => d.Value)
                .ThenByDescending(d => dwarfs.Where(y => y.Key.Split(':')[1] == d.Key.Split(':')[1])
                                             .Count()))
            {
                Console.WriteLine($"({dwarf.Key.Split(':')[1]}) {dwarf.Key.Split(':')[0]} <-> {dwarf.Value}");
            }
        }
    }
}