using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01_Furniture
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@">>(?<name>[A-Za-z]+)<<(?<price>[0-9]+.?[0-9]*)!(?<quantity>[0-9]+)");

            string line = string.Empty;

            var furniture = new List<string>();

            double price = 0.0;

            while ((line = Console.ReadLine()) != "Purchase")
            {
                Match match = regex.Match(line);

                if (match.Success)
                {
                    furniture.Add(match.Groups["name"].ToString());
                    price += double.Parse(match.Groups["price"].ToString()) * double.Parse(match.Groups["quantity"].ToString());
                }
            }

            Console.WriteLine("Bought furniture:");

            foreach (var name in furniture)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}