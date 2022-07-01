using System;

namespace _09_SpiceMustFlow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int collect = 0;
            int days = 0;

            if (yield >= 100)
            {
                while (yield >= 100)
                {
                    days++;
                    collect += yield;
                    yield -= 10;

                }
                collect -= (days + 1) * 26;
                Console.WriteLine(days);
                Console.WriteLine(collect);
            }
            else
            {
                Console.WriteLine(days);
                Console.WriteLine(collect);
            }
        }
    }
}
