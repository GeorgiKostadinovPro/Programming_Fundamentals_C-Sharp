using System;

namespace _06_ReversedChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            char[] chars = new char[] { first, second, third };

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                Console.Write(chars[i] + " ");
            }
        }
    }
}
