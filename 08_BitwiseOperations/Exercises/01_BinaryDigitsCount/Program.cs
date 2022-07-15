using System;

namespace _01_BinaryDigitsCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char digit = char.Parse(Console.ReadLine());
            
            string binaryNumber = Convert.ToString(number, 2);
            int digitCount = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                if (binaryNumber[i] == digit)
                {
                    digitCount++;
                }
            }

            Console.WriteLine(digitCount);
        }
    }
}