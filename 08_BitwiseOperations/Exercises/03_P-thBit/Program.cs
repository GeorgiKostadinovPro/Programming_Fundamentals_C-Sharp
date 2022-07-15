using System;

namespace _03_PthBit
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int bit = (number >> position) & 1;

            Console.WriteLine(bit);
        }
    }
}