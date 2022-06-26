using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_EncryptingPassword
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"([\S]+)>([0-9]{3})\|([a-z]{3})\|([A-Z]{3})\|([^<>]{3})<\1");

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                if (regex.IsMatch(input))
                {
                    Match match = regex.Match(input);

                    string encryptedPass = string.Empty;

                    string numbers = match.Groups[2].ToString();
                    string lowerLetters = match.Groups[3].ToString();
                    string upperLetters = match.Groups[4].ToString();
                    string symbols = match.Groups[5].ToString();

                    encryptedPass = numbers + lowerLetters + upperLetters + symbols;


                    Console.WriteLine($"Password: {encryptedPass}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}