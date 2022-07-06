using System;

namespace _08_FactorialDivision
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());

            double firstFactorial = Factorial(first);
            double secondFactorial = Factorial(second);

            double result = firstFactorial / secondFactorial;
            Console.WriteLine($"{result:f2}");
        }

        private static double Factorial(double n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}