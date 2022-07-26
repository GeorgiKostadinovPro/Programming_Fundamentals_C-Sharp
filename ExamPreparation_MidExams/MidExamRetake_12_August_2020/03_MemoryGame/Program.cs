using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MemoryGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string line = string.Empty;
            int moves = 0;

            bool haveWon = false;

            while ((line = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int firstIdx = int.Parse(cmdArgs[0]);
                int secondIdx = int.Parse(cmdArgs[1]);

                moves++;

                List<string> range = new List<string>
                {
                    $"-{moves}a",
                    $"-{moves}a"
                };

                int middleIdx = elements.Count / 2;

                if (IsIndexValid(elements, firstIdx) && IsIndexValid(elements, secondIdx))
                {
                    if (firstIdx == secondIdx)
                    {
                        elements.InsertRange(middleIdx, range);
                        Console.WriteLine("Invalid input! Adding additaional elements to the board");
                    }
                    else
                    {
                        if (elements[firstIdx] == elements[secondIdx])
                        {
                            string element = elements[firstIdx];
                            elements.RemoveAll(x => x == element);
                            Console.WriteLine($"Congrats! You have found matching elements - {element}!");
                        }
                        else
                        {
                            Console.WriteLine("Try again!");
                        }
                    }
                }
                else
                {
                    elements.InsertRange(middleIdx, range);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                if (elements.Count <= 0)
                {
                    haveWon = true;
                    Console.WriteLine($"You have won in {moves} turns!");
                    break;
                }
            }

            if (haveWon == false)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine($"{string.Join(" ", elements)}");
            }
        }

        private static bool IsIndexValid(List<string> elements, int idx)
        {
            return idx >= 0 && idx < elements.Count;
        }
    }
}