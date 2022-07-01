using System;

namespace _05_MonthPrinter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());

            if (month > 0 && month <= 12)
            {
                DateTime dt = new DateTime(1, month, 1);
                Console.WriteLine(dt.ToString("MMMM"));
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
