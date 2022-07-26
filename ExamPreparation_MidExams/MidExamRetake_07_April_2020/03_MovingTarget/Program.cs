using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MovingTarget
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var targets = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                var cmds = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string command = cmds[0];
                int index = int.Parse(cmds[1]);

                if (targets.Count <= 0)
                {
                    break;
                }

                if (command == "Shoot")
                {
                    int power = int.Parse(cmds[2]);

                    if (IsValidIndex(targets, index))
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(cmds[2]);

                    if (IsValidIndex(targets, index))
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(cmds[2]);
                    int leftBorder = index - radius;
                    int rightBorder = index + radius;
                    radius = 1 + (radius * 2);

                    if (leftBorder >= 0 && rightBorder < targets.Count)
                    {
                        targets.RemoveRange(leftBorder, radius);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
        private static bool IsValidIndex(List<int> targets, int index)
        {
            return index >= 0 && index < targets.Count;
        }
    }
}
