using System;

namespace _04_BitDestroyer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = ~(1 << position);
            int result = (number & mask);

            Console.WriteLine(result);
        }
    }
}