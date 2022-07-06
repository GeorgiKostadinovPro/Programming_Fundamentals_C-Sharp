using System;

namespace _10_TopNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintTopIntegers(n);
        }

        private static void PrintTopIntegers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sumOfDigits = 0;
                int oddDigitsCount = 0;

                while (number != 0)
                {
                    sumOfDigits += number % 10;

                    if ((number % 10) % 2 != 0)
                    {
                        oddDigitsCount++;
                    }

                    number /= 10;
                }

                if (sumOfDigits % 8 == 0 && oddDigitsCount > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}