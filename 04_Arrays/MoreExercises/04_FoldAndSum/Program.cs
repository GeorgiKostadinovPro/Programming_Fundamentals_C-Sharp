using System;
using System.Linq;

namespace _04_FoldAndSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int foldPoint = numbers.Length / 4;

            int[] resultArr = new int[foldPoint * 2];

            for (int i = 0; i < foldPoint; i++)
            {
                resultArr[i] = numbers[i + foldPoint] + numbers[foldPoint - 1 - i];
                resultArr[i + foldPoint] = numbers[i + 2 * foldPoint] + numbers[numbers.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", resultArr));
        }
    }
}
