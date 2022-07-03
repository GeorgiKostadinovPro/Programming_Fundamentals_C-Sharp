using System;
using System.Linq;

namespace _04_ReverseArrayOfStrings
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Array.Reverse(nums);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
