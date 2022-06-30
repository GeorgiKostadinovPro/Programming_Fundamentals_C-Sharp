using System;

namespace _01_IntegerOperations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            b += a;
            b /= c;
            b *= d;

            Console.WriteLine(b);
        }
    }
}
