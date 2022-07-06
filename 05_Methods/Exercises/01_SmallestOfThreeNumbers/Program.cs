using System;

namespace _01_SmallestOfThreeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine()); 
            int third = int.Parse(Console.ReadLine());

            SmallestNumber(first, second, third);
        }

        private static void SmallestNumber(int first, int second, int third)
        {
            Console.WriteLine(Math.Min(first, Math.Min(second, third)));
        }
    }
}