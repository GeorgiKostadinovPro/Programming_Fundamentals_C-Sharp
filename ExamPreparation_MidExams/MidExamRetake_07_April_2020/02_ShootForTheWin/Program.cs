using System;
using System.Linq;

namespace _02_ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            var targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "End")
            {
                int index = int.Parse(line);

                if (index >= 0 && index < targets.Length)
                {
                    int current = targets[index];

                    if (current != -1)
                    {
                        targets[index] = -1;
                    }
                    else
                    {
                        continue;
                    }

                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] != -1)
                        {
                            if (targets[i] <= current)
                            {
                                targets[i] += current;
                            }
                            else
                            {
                                targets[i] -= current;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Shot targets: {targets.Where(t => t == -1).Count()} -> {string.Join(" ", targets)}");
        }
    }
}