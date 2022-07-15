using System;
using System.Linq;

namespace _05_OddTimes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int result = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                result ^= numbers[i];
            }

            Console.WriteLine(result);
        }
    }
}