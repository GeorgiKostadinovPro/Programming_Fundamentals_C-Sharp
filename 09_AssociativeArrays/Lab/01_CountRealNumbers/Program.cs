using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountRealNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> map = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double key = numbers[i];

                if (!map.ContainsKey(key))
                {
                    map.Add(key, 0);
                }

                map[key]++;
            }

            foreach (var number in map.OrderBy(n => n.Key))
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}