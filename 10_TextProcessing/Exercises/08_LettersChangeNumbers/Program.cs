using System;

namespace _08_LettersChangeNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string currWord = words[i];

                char firstLetter = currWord[0];
                char secondLetter = currWord[currWord.Length - 1];
                double number = double.Parse(currWord.Substring(1, currWord.Length - 2));

                int firstLetterAlphabetPosition = char.IsUpper(firstLetter) ? firstLetter - '@' : firstLetter - '`';
                int secondLetterAlphabetPosition = char.IsUpper(secondLetter) ? secondLetter - '@' : secondLetter - '`';

                if (char.IsUpper(firstLetter))
                {
                    number /= firstLetterAlphabetPosition;
                }
                else
                {
                    number *= firstLetterAlphabetPosition;
                }

                if (char.IsUpper(secondLetter))
                {
                    number -= secondLetterAlphabetPosition;
                }
                else
                {
                    number += secondLetterAlphabetPosition;
                }

                sum += number;
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
}