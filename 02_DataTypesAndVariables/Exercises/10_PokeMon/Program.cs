using System;

namespace _10_PokeMon
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            double fiftyPercent = n * 0.5;
            int totalPoked = 0;

            while (n >= m)
            {
                n -= m;
                totalPoked++;

                if (n == fiftyPercent && y != 0)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(totalPoked);
        }
    }
}
