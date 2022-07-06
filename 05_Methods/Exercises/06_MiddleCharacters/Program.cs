using System;

namespace _06_MiddleCharacters
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();

            PrintMiddleCharacters(str);
        }

        private static void PrintMiddleCharacters(string str)
        {
            string result = string.Empty;
            int middle = str.Length / 2;

            if (str.Length % 2 != 0)
            {
                result += str[middle];
            }
            else
            {
                result += str[middle - 1];
                result += str[middle];
            }

            Console.WriteLine(result);
        }
    }
}