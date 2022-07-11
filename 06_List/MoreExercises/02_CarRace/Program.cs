using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_CarRace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int midIdx = numbers.Count / 2;

            double firstRacerTime = 0.0D;
            double secondRacerTime = 0.0D;

            for (int i = 0; i < midIdx; i++)
            {
                firstRacerTime += numbers[i];

                if (numbers[i] == 0)
                {
                    firstRacerTime -= firstRacerTime * 0.2;
                }
            }

            for (int i = numbers.Count - 1; i > midIdx; i--)
            {
                secondRacerTime += numbers[i];

                if (numbers[i] == 0)
                {
                    secondRacerTime -= secondRacerTime * 0.2;
                }
            }

            if (firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(firstRacerTime, 1)}");
            }
            else 
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(secondRacerTime, 1)}");
            }
        }
    }
}