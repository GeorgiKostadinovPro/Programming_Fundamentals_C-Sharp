using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_DestinationMapper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"([=\/]{1})([A-Z]{1}[A-Za-z]{2,})\1");

            MatchCollection matches = regex.Matches(text);

            var destinations = new List<string>();

            int points = 0;

            foreach (Match match in matches)
            {
                string location = match.Groups[2].ToString();

                destinations.Add(location);

                points += location.Length;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}