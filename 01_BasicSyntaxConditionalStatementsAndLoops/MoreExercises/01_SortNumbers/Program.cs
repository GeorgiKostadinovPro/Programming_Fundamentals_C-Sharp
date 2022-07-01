using System;
using System.Linq;

namespace _01_SortNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double[] arr = { a, b, c};

            foreach (var item in arr.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }
        }
    }
}
