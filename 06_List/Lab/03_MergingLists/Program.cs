using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_MergingLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<double> first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            List<double> second = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(double.Parse)
               .ToList();

            List<double> result = new List<double>();

            while (first.Count > 0 && second.Count > 0)
            {
                result.Add(first[0]);
                result.Add(second[0]);
                first.RemoveAt(0);
                second.RemoveAt(0);
            }

            if (first.Count > 0)
            {
                result.AddRange(first);
            }
            else 
            {
                result.AddRange(second);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
