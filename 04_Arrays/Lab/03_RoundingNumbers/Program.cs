using System;
using System.Linq;

namespace _03_RoundingNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < nums.Length; i++)
            {
                double roundedNumber = Math.Round(nums[i], 0, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {Convert.ToDecimal(roundedNumber)}");
            }
        }
    }
}
