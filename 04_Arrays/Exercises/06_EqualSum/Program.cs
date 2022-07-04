using System;
using System.Linq;

namespace _06_EqualSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = numbers.Skip(i + 1).Sum();
                int leftSum = numbers.Take(i).Sum();

                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}