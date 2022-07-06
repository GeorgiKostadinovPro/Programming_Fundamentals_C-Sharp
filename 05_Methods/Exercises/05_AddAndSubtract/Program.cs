using System;

namespace _05_AddAndSubtract
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Add(first, second);
            int subtraction = Subtract(sum, third);

            Console.WriteLine(subtraction);
        }

        private static int Subtract(int sum, int third)
        {
            return sum - third; 
        }

        private static int Add(int first, int second)
        {
            return first + second;
        }
    }
}