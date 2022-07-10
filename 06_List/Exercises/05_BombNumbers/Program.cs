using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_BombNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int[] specialBomb = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialBomb[0])
                {
                    int start = i - specialBomb[1];

                    if (start < 0)
                    {
                        start = 0;
                    }

                    int finish = i + specialBomb[1] + 1;

                    if (finish > numbers.Count)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }
    }
}