﻿using System;
using System.Linq;

namespace _06_EvenAndOddSubtraction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0; 

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    evenSum += nums[i];
                }
                else 
                {
                    oddSum += nums[i];
                }
            }

            Console.WriteLine(evenSum - oddSum);
        }
    }
}
