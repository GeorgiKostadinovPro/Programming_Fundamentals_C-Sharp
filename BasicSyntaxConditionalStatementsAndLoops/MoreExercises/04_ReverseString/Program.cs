using System;

namespace _04_ReverseString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string reversed = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }

            Console.WriteLine(reversed);
        }
    }
}
