using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_HeartDelivery
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> neighbourhoods = Console.ReadLine()
                .Split('@', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int currPos = 0;
            string input;

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] command = input.Split().ToArray();

                int length = int.Parse(command[1]);
                currPos += length;

                if (currPos > neighbourhoods.Count - 1)
                {
                    currPos = 0;
                }

                if (neighbourhoods[currPos] > 0)
                {
                    neighbourhoods[currPos] -= 2;

                    if (neighbourhoods[currPos] == 0)
                    {
                        Console.WriteLine($"Place {currPos} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currPos} already had Valentine's day.");
                }
            }

            Console.WriteLine($"Cupid's last position was {currPos}.");

            int counter = neighbourhoods
                .Count(h => h > 0);

            if (neighbourhoods.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}