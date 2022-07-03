using System;

namespace _02_PrintNumbersInReverseOrder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];

            while (n > 0)
            {
                int num = int.Parse(Console.ReadLine());
                nums[n - 1] = num;
                n--;
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
