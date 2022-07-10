using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_PokemonDoNotGo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> distances = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int sum = 0;

            while (distances.Any())
            {
                int idx = int.Parse(Console.ReadLine());

                if (idx < 0)
                {
                    int last = distances.Last();
                    int removed = distances.First();
                    distances.RemoveAt(0);
                    distances.Insert(0, last);
                    sum += removed;

                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i] <= removed)
                        {
                            distances[i] += removed;
                        }
                        else
                        {
                            distances[i] -= removed;
                        }
                    }
                }
                else if (idx > distances.Count - 1)
                {
                    int first = distances.First();
                    int removed = distances.Last();
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(first);
                    sum += removed;

                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i] <= removed)
                        {
                            distances[i] += removed;
                        }
                        else
                        {
                            distances[i] -= removed;
                        }
                    }
                }
                else
                {
                    int element = distances[idx];
                    distances.RemoveAt(idx);
                    sum += element;

                    for (int i = 0; i < distances.Count; i++)
                    {
                        if (distances[i] <= element)
                        {
                            distances[i] += element;
                        }
                        else
                        {
                            distances[i] -= element;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}