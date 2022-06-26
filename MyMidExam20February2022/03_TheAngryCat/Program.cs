using System;
using System.Linq;

namespace _03_TheAngryCat
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var priceRatings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int entryPoint = int.Parse(Console.ReadLine());

            int entryPointItemPrice = priceRatings[entryPoint];

            int leftSum = 0;
            int rightSum = 0;

            string type = Console.ReadLine();

            for (int i = entryPoint + 1; i < priceRatings.Count; i++)
            {
                if (type == "cheap")
                {
                    if (priceRatings[i] < entryPointItemPrice)
                    {
                        rightSum += priceRatings[i];
                        priceRatings[i] = 0;
                    }
                }
                else if (type == "expensive")
                {
                    if (priceRatings[i] >= entryPointItemPrice)
                    {
                        rightSum += priceRatings[i];
                        priceRatings[i] = 0;
                    }
                }
            }

            for (int i = 0; i < entryPoint; i++)
            {
                if (type == "cheap")
                {
                    if (priceRatings[i] < entryPointItemPrice)
                    {
                        leftSum += priceRatings[i];
                        priceRatings[i] = 0;
                    }
                }
                else if (type == "expensive")
                {
                    if (priceRatings[i] >= entryPointItemPrice)
                    {
                        leftSum += priceRatings[i];
                        priceRatings[i] = 0;
                    }
                }
            }

            if (rightSum > leftSum)
            {
                Console.WriteLine($"Right - {rightSum}");
            }
            else if (rightSum < leftSum)
            {
                Console.WriteLine($"Left - {leftSum}");
            }
            else
            {
                Console.WriteLine($"Left - {leftSum}");
            }
        }
    }
}