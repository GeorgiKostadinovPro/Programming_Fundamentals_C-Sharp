using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_RemoveNegativesAndReverse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries) 
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(x => x < 0);

            string result = numbers.Count > 0 ? string.Join(" ", numbers.Reverse<int>()) : "empty";
            Console.WriteLine(result);
        }
    }
}