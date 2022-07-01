using System;

namespace _02_FromLeftToTheRight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                long firstNum = long.Parse(input[0]);
                long secondNum = long.Parse(input[1]);
                long sum = 0;

                if (firstNum > secondNum)
                {
                    while (firstNum != 0)
                    {
                        sum += Math.Abs(firstNum % 10);
                        firstNum /= 10;
                    }
                }
                else 
                {
                    while (secondNum != 0)
                    {
                        sum += Math.Abs(secondNum % 10);
                        secondNum /= 10;
                    }
                }

                Console.WriteLine(sum);
            }
        }
    }
}
