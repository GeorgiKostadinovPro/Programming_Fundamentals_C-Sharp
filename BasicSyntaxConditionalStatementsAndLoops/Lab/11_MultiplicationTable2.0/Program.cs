﻿using System;

namespace _11_MultiplicationTable2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            if (m > 10)
            {
                Console.WriteLine($"{n} X {m} = {n * m}");
                return;
            }

            for (int i = m; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n * i}");
            }
        }
    }
}
