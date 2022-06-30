﻿using System;

namespace _04_SumOfChars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char c = char.Parse(Console.ReadLine());
                sum += (int)c;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}