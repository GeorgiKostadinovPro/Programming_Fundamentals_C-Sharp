using System;
using System.Text.RegularExpressions;

namespace _03_MatchDates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b(?<day>[0-9]{2})(?<separator>[\/.-])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})\b");

            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}