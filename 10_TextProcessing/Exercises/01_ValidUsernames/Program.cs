using System;
using System.Text.RegularExpressions;

namespace _01_ValidUsernames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Regex regex = new Regex("^[A-Za-z0-9-_]{3,16}$");

            for (int i = 0; i < usernames.Length; i++)
            {
                string currUsername = usernames[i];

                if (regex.IsMatch(currUsername))
                {
                    Console.WriteLine(currUsername);
                }
            }
        }
    }
}