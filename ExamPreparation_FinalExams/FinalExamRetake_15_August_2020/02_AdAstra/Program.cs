using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_AdAstra
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> productsInfos = new List<string>();

            string text = Console.ReadLine();

            Regex regex = new Regex(@"([#|]+)([A-Za-z ]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]{0,10000})\1");

            MatchCollection matches = regex.Matches(text);

            int allCalories = 0;

            foreach (Match match in matches)
            {
                string name = match.Groups[2].ToString();
                string date = match.Groups[3].ToString();
                int calories = int.Parse(match.Groups[4].ToString());

                allCalories += calories;
            }

            int days = allCalories / 2000;

            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match match in matches)
            {
                string name = match.Groups[2].ToString();
                string date = match.Groups[3].ToString();
                int calories = int.Parse(match.Groups[4].ToString());

                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {calories}");
            }
        }
    }
}
