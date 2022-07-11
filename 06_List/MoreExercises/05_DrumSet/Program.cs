using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_DrumSet
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());

            List<int> drumSet = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> previousDrumsQuality = drumSet.ToList();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(line);

                for (int i = 0; i < drumSet.Count; i++)
                {
                    drumSet[i] -= hitPower;

                    if (drumSet[i] <= 0)
                    {
                        int cost = previousDrumsQuality[i] * 3;

                        if (savings >= cost)
                        {
                            drumSet[i] = previousDrumsQuality[i];
                            savings -= cost;
                        }
                        else
                        {
                            drumSet.RemoveAt(i);
                            previousDrumsQuality.RemoveAt(i);

                            if (i == drumSet.Count)
                            {
                                break;
                            }

                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", drumSet));
            Console.WriteLine($"Gabsy has {savings:f2}lv.");
        }
    }
}