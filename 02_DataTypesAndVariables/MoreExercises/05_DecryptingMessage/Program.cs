using System;

namespace _05_DecryptingMessage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());
                char newChar = Convert.ToChar((int)c + key);
                message += newChar;
            }

            Console.WriteLine(message);
        }
    }
}