using System;
using System.Linq;

namespace _08_CondenseArrayToNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var count = nums.Length;

            while (count > 1)
            {
                for (int i = 0; i < count - 1; i++)
                {
                    nums[i] = nums[i] + nums[i + 1];
                }

                count--;
            }

            Console.WriteLine(nums[0]);
        }
    }
}
