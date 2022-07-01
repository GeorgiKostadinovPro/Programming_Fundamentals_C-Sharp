using System;

namespace _05_PrintPartOfASCIITable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                Console.Write(Convert.ToChar(i) + " ");
            }
        }
    }
}
