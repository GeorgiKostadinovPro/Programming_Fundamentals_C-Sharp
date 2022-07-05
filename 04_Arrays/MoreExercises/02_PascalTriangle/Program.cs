using System;

namespace _02_PascalTriangle
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] pascalTriangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                pascalTriangle[i] = new long[i + 1];
                pascalTriangle[i][0] = 1;
                pascalTriangle[i][^1] = 1;

                for (int j = 1; j < i; j++)
                {
                    pascalTriangle[i][j] = pascalTriangle[i - 1][j - 1] + pascalTriangle[i - 1][j];
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(string.Join(" ", pascalTriangle[i]));
            }
        }
    }
}
