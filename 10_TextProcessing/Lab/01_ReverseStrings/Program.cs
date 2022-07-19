using System;

namespace _01_ReverseStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end") 
            {
                string str = line;
                string reversedStr = string.Empty;

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    reversedStr += str[i];
                }

                Console.WriteLine($"{str} = {reversedStr}");
            }
        }
    }
}
