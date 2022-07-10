using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_AppendArrays
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> numbers = new List<string>();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                string[] elements = input[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                numbers.AddRange(elements);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}