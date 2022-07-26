using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            double averageNum = nums.Average();

            int[] tops = nums
                .Where(n => n > averageNum)
                .OrderByDescending(n => n)
                .Take(5)
                .ToArray();

            if (!tops.Any())
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", tops));
            }
        }
    }
}