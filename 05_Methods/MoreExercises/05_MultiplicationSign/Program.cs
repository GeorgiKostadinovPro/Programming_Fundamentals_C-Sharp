using System;

namespace _05_MultiplicationSign
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int[] numbers = new[] { first, second, third };
            IsPosititveNegativeOrZeroSign(numbers);
        }

        private static void IsPosititveNegativeOrZeroSign(int[] numbers)
        {
            int countNeg = 0;
            int countZero = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    countNeg++;
                }
                else if (numbers[i] == 0)
                {
                    countZero++;
                }
            }

            if (countZero > 0)
            {
                Console.WriteLine("zero");
                return;
            }

            if (countNeg % 2 != 0)
            {
                Console.WriteLine("negative");
                return;
            }

            Console.WriteLine("positive");
        }
    }
}