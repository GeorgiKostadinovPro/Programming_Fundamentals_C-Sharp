using System;

namespace _10_LowerOrUpper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char character = char.Parse(Console.ReadLine());
            string result = char.IsUpper(character) ? "upper-case" : "lower-case";
            Console.WriteLine(result);
        }
    }
}
