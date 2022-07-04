using System;
using System.Linq;

namespace _07_MaxSequenceOfEqualElements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int count = 1;
            int theBestCount = 0;
            int element = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > theBestCount)
                {
                    theBestCount = count;
                    element = numbers[i];
                }
            }

            for (int j = 0; j < theBestCount; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}