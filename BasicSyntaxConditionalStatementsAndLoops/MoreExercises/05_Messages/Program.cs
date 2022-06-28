﻿using System;

namespace _05_Messages
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                int digitLength = digits.Length;
                int digit = digits[0] - '0';
                int offset = (digit - 2) * 3;

                if (digit == 0)
                {
                    message += (char)(digit + 32);
                    continue;
                }

                if (digit == 8 || digit == 9)
                {
                    offset++;
                }

                int letterIndex = offset + digitLength - 1;
                message += (char)(letterIndex + 97);
            }

            Console.WriteLine(message);
        }
    }
}
