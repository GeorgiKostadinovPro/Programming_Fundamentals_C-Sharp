using System;
using System.Collections.Generic;

namespace _02_AMinerTask
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> mine = new Dictionary<string, int>();

            string line = Console.ReadLine();

            while (line != "stop")
            {
                int amount = int.Parse(Console.ReadLine());

                if (!mine.ContainsKey(line))
                {
                    mine.Add(line, 0);
                }

                mine[line] += amount;

                line = Console.ReadLine();
            }

            foreach (var recourse in mine)
            {
                Console.WriteLine($"{recourse.Key} -> {recourse.Value}");
            }
        }
    }
}