using System;
using System.Numerics;

namespace _05_MultiplyBigNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            BigInteger firstNumberParsed = BigInteger.Parse(firstNumber);
            BigInteger product = firstNumberParsed * secondNumber;

            Console.WriteLine(product);
        }
    }
}