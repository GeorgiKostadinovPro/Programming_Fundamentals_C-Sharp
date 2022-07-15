using System;

namespace _06_TriBitSwitch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int position = int.Parse(Console.ReadLine());

            int mask = 7 << position;
            int result = number ^ mask;

            Console.WriteLine(result);
        }
    }
}