using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_GaussTrick
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == numbers.Count - 1)
                {
                    break;
                }

                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}