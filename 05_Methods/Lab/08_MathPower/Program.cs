using System;

namespace _08_MathPower
{
    public class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());

            double result = MathPower(@base, power);
            Console.WriteLine(result);
        }

        private static double MathPower(double @base, double power)
        {
            return Math.Pow(@base, power);
        }
    }
}