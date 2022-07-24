using System;
using System.Text.RegularExpressions;

namespace _03_SoftUniBarIncome
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"%([A-Z][a-z]+)%[^|$%.]*?<(\w+)>[^|$%.]*?\|([0-9]+)\|[^|$%.]*?([0-9]+.?[0-9]*)\$");

            string line = Console.ReadLine();

            double total = 0.0;

            while (line != "end of shift")
            {
                if (regex.IsMatch(line))
                {
                    Match match = regex.Match(line);

                    string customer = match.Groups[1].ToString();
                    string product = match.Groups[2].ToString();

                    double totalPrice = double.Parse(match.Groups[3].ToString()) * double.Parse(match.Groups[4].ToString());

                    total += totalPrice;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }


                line = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}