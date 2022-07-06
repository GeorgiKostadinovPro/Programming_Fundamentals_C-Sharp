using System;

namespace _09_PalindromeIntegers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "END")
            {
                IsPalindrome(line);
            }
        }

        private static void IsPalindrome(string line)
        {
            string str = string.Empty;

            for (int i = line.Length - 1; i >= 0; i--)
            {
                str += line[i];
            }

            if (line == str)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}