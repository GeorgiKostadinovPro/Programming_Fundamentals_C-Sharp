using System;
using System.Text.RegularExpressions;

namespace _06_ExtractEmails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-_][A-Za-z]+)+))(\b|(?=\s))";

            MatchCollection collection = Regex.Matches(input, pattern);

            foreach (var email in collection)
            {
                Console.WriteLine(email);
            }
        }
    }
}