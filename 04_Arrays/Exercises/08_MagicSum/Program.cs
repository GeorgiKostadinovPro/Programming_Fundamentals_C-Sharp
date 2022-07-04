using System;
using System.Linq;

namespace _08_MagicSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int firstElement = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int secondElement = numbers[j];
                    int sum = firstElement + secondElement;

                    if (sum == number)
                    {
                        Console.WriteLine(firstElement + " " + secondElement);
                    }
                }
            }
        }
    }
}