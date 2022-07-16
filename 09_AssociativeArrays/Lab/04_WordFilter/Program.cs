using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_WordFilter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            words = words
                .Where(w => w.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}