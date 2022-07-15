using System;

namespace _02_BitAtPosition1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string binaryNumber = Convert.ToString(number, 2);
            int searchedBit = 0;

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                if (i == binaryNumber.Length - 2)
                {
                    searchedBit = binaryNumber[i] - '0';
                    break;
                }
            }

            Console.WriteLine(searchedBit);
        }
    }
}