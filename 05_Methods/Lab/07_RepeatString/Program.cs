using System;

namespace _07_RepeatString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(str, n);
            Console.WriteLine(result);
        }

        private static string RepeatString(string str, int times)
        {
            string result = string.Empty;

            for (int i = 0; i < times; i++)
            {
                result += str;
            }

            return result;
        }
    }
}
