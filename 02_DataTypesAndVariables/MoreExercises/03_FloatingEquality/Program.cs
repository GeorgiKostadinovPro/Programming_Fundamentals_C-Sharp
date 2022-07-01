using System;

namespace _03_FloatingEquality
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double eps = 0.000001D;
            double first = 0.0D;
            double second = 0.0D;

            first = double.Parse(Console.ReadLine());
            second = double.Parse(Console.ReadLine());
            bool isEqual = Math.Abs(first - second) < eps;

            if (isEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
