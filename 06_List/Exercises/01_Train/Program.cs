using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Train
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (cmdArgs.Length == 2)
                {
                    int passengers = int.Parse(cmdArgs[1]);
                    wagons.Add(passengers);
                }
                else 
                {
                    int passengers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}