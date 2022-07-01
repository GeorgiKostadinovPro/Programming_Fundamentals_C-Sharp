using System;

namespace _11_Orders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            decimal total = 0M;

            for (int i = 0; i < count; i++)
            {
                 decimal price = decimal.Parse(Console.ReadLine());
                 int days = int.Parse(Console.ReadLine());
                 int capsulesCount = int.Parse(Console.ReadLine());
            
                 decimal currPrice = (days * capsulesCount) * price;
                 total+=currPrice;
                 Console.WriteLine($"The price for the coffee is: ${currPrice:f2}");
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}