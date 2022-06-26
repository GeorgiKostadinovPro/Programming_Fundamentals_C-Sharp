using System;

namespace _09_SumOfOddNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOfOddNumber = 1;
            int sum = 1;
            int j = 2;
            Console.WriteLine("1");

            while (true)
            {
                if (j % 2 == 1)
                {
                    Console.WriteLine($"{j}");
                    countOfOddNumber++;
                    sum += j;
                    j++;
                }
                else
                {
                    j++;
                }

                if (countOfOddNumber == n)
                {
                    break;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
