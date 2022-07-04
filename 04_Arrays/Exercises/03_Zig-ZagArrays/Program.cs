using System;

namespace _03_ZigZagArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstElements = new int[n];
            int[] secondElements = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int firstNumber = int.Parse(numbers[0]);
                int secondNumber = int.Parse(numbers[1]);

                if (i % 2 == 0)
                {
                    firstElements[i] = firstNumber;
                    secondElements[i] = secondNumber;
                }
                else
                {
                    firstElements[i] = secondNumber;
                    secondElements[i] = firstNumber;
                }
            }

            Console.WriteLine(string.Join(" ", firstElements));
            Console.WriteLine(string.Join(" ", secondElements));
        }
    }
}
