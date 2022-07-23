using System;
using System.Text.RegularExpressions;

namespace _01_MatchFullName
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";

            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, regex);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }

            Console.WriteLine();
        }
    }
}