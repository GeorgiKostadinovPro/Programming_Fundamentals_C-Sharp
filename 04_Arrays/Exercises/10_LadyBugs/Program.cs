using System;
using System.Linq;

namespace _10_LadyBugs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] ladybugsStartPositions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] field = new int[size];

            for (int i = 0; i < ladybugsStartPositions.Length; i++)
            {
                int currentIndex = ladybugsStartPositions[i];

                if (IsIndexValid(size, currentIndex))
                {
                    field[currentIndex] = 1;
                }
            }

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end") 
            {
                string[] cmdArgs = line
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int ladybugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLength = int.Parse(cmdArgs[2]);

                if (!IsIndexValid(size, ladybugIndex) || field[ladybugIndex] == 0)
                {
                    continue;
                }
                
                field[ladybugIndex] = 0;

                if (direction == "right")
                {
                    ladybugIndex += flyLength;

                    while (ladybugIndex < size)
                    {
                        if (field[ladybugIndex] != 1)
                        {
                            field[ladybugIndex] = 1;
                            break;
                        }

                        ladybugIndex += flyLength;
                    }
                }
                else if (direction == "left")
                {
                    ladybugIndex -= flyLength;

                    while (ladybugIndex >= 0)
                    {
                        if (field[ladybugIndex] != 1)
                        {
                            field[ladybugIndex] = 1;
                            break;
                        }

                        ladybugIndex -= flyLength;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", field));
        }

        private static bool IsIndexValid(int size, int currentIndex)
        {
            return currentIndex >= 0 && currentIndex < size;
        }
    }
}