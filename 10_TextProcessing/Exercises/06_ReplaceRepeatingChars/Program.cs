using System;

namespace _06_ReplaceRepeatingChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string cutString = string.Empty;    

            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != str[i + 1])
                {
                    cutString += str[i];
                }
            }

            cutString += str[str.Length - 1];
            Console.WriteLine(cutString);
        }
    }
}