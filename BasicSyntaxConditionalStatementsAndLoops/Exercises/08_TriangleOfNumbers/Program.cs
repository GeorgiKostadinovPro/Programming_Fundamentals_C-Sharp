using System;

namespace _08_TriangleOfNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int curr = i;
                while (curr > 0)
                {
                    Console.Write(i + " ");
                    curr--;
                }

                Console.WriteLine();    
            }
        }
    }
}