using System;
using System.Text.RegularExpressions;

namespace _01_ExtractPersonInformation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string matchName = @"@([A-Z{,1}a-z]+)\|";
            string matchAge = @"#([0-9]+)\*";

            for (int i = 0; i < n; i++)
            {
                string personInfo = Console.ReadLine();
                Match nameMatch = Regex.Match(personInfo, matchName);
                Match ageMatch = Regex.Match(personInfo, matchAge);

                string personName = nameMatch.Groups[1].ToString();
                string personAge = ageMatch.Groups[1].ToString();

                Console.WriteLine($"{personName} is {personAge} years old.");
            }
        }
    }
}
