using System;
using System.Text.RegularExpressions;

namespace _02_MatchPhoneNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Regex regex = new Regex(@"\+359([ -])2\1[0-9]{3}\1[0-9]{4}\b");

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}