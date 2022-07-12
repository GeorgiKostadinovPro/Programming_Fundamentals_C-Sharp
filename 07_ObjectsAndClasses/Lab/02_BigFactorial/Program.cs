using System;
using System.Numerics;

namespace _02_BigFactorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger result = Factorial(n);
            Console.WriteLine(result);
        }

        private static BigInteger Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}