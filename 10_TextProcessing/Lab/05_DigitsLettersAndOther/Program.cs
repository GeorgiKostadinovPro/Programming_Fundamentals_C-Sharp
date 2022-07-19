using System;

namespace _05_DigitsLettersAndOther
{
    public class Program
    {
        public static void Main(string[] args)
        {
             string str = Console.ReadLine();

             string digits = string.Empty;
             string letters = string.Empty;
             string other = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                char currChar = str[i];

                if (char.IsDigit(currChar))
                {
                    digits += currChar;
                }
                else if (char.IsLetter(currChar))
                {
                    letters += currChar;
                }
                else 
                {
                    other += currChar;
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(other);
        }
    }
}