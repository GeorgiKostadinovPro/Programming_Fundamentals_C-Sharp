using System;

namespace _02_CenterPoint
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            ClosestPoint(x1, y1, x2, y2);
        }

        private static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double centerX = 0;
            double centerY = 0;

            double firstPointDistance = Math.Sqrt(Math.Pow(x1 - centerX, 2) + Math.Pow(y1 - centerY, 2));
            double secondPointDistance = Math.Sqrt(Math.Pow(x2 - centerX, 2) + Math.Pow(y2 - centerY, 2));

            if (firstPointDistance <= secondPointDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
               Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}