using System;
using System.Text.RegularExpressions;

namespace _02_FancyBarcodes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string validator = "@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+";

            Regex regex = new Regex(validator);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();

                if (regex.IsMatch(str))
                {
                    Match match = regex.Match(str);

                    string innerGroup = match.Groups[1].ToString();

                    string groupOfGigits = string.Empty;

                    for (int j = 0; j < innerGroup.Length; j++)
                    {
                        if (char.IsDigit(innerGroup[j]))
                        {
                            groupOfGigits += innerGroup[j];
                        }
                    }

                    if (groupOfGigits.Length > 0)
                    {
                        Console.WriteLine($"Product group: {groupOfGigits}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}