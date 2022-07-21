using System;

namespace _02_AsciiSumator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currCharValue = input[i];

                if (currCharValue > (int)firstChar && currCharValue < (int)secondChar)
                {
                    sum += currCharValue;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
