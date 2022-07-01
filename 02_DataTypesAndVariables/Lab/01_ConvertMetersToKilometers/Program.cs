using System;

namespace _01_ConvertMetersToKilometers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            double kilometers = distance / 1000.0;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
