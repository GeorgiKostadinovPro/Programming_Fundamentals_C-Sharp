using System;

namespace _01_Train
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] train = new int[n];
            int totalPassengers = 0;

            for (int i = 0; i < n; i++)
            {
                int numberOfPeople = int.Parse(Console.ReadLine());
                train[i] += numberOfPeople;
                totalPassengers += numberOfPeople;
            }

            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(totalPassengers);
        }
    }
}
