using System;

namespace _01_SignOfIntegerNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string result = NumberSign(number);
            Console.WriteLine(result);
        }

        private static string NumberSign(int number)
        {
            if (number > 0)
            {
                return $"The number {number} is positive. ";
            }
            else if (number < 0)
            {
                return $"The number {number} is negative. ";
            }

            return $"The number {number} is zero. ";
        }
    }
}
