﻿using System;
using System.Text.RegularExpressions;

namespace _01_WinningTicket
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] ticket = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex(@"(\@{6,}|\${6,}|\^{6,}|\#{6,})");

            for (int i = 0; i < ticket.Length; i++)
            {
                if (ticket[i].Length == 20)
                {
                    Match firstHalf = regex.Match(ticket[i].Substring(0, 10));
                    Match secondHalf = regex.Match(ticket[i].Substring(10));
                    int minLength = Math.Min(firstHalf.Length, secondHalf.Length);

                    if (firstHalf.Success && secondHalf.Success)
                    {
                        string winFirstHalf = firstHalf.Value.Substring(0, minLength);
                        string winSecondHalf = secondHalf.Value.Substring(0, minLength);

                        if (winFirstHalf.Equals(winSecondHalf))
                        {
                            if (winFirstHalf.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{ticket[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}