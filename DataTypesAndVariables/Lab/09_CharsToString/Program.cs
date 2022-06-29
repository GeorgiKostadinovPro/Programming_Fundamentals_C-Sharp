using System;

namespace _09_CharsToString
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());

            string str = string.Empty;
            str += first;
            str += second;
            str += third;

            Console.WriteLine(str);
        }
    }
}
