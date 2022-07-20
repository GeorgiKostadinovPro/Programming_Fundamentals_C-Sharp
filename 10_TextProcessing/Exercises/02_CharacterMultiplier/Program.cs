using System;

namespace _02_CharacterMultiplier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string firstStr = strings[0];
            string secondStr = strings[1];

            int sum = 0;

            int length = firstStr.Length > secondStr.Length ? secondStr.Length : firstStr.Length;
                
            for (int i = 0; i < length; i++)
            {
                int firstStrChar = firstStr[i];
                int secondStrChar = secondStr[i];

                sum += firstStrChar * secondStrChar;
            }

            if (length == firstStr.Length)
            {
                for (int i = length; i < secondStr.Length; i++)
                {
                    sum += secondStr[i];
                }
            }
            else if (length == secondStr.Length)
            {
                for (int i = length; i < firstStr.Length; i++)
                {
                    sum += firstStr[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}