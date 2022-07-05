using System;

namespace _06_CalculateRectangleArea
{
    public class Program
    {
        public static void Main(string[] args)
        {
           double width = double.Parse(Console.ReadLine());   
           double height = double.Parse(Console.ReadLine());

           double result = GetArea(width, height);
           Console.WriteLine(result);
        }
        private static double GetArea(double width, double height)
        {
           return width * height;
        }
    }
}
