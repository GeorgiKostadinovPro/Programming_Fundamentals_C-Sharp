using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04_SantasSecretHelper
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());

            Regex regex = new Regex(@"@([A-Za-z]+)[^@\-!:>]+!([GN])!");

            List<string> goodChildren = new List<string>();

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "end")
            {
                string message = line;
                string decryptedMessage = string.Empty;

                for (int i = 0; i < message.Length; i++)
                {
                    int currCharCode = message[i];
                    currCharCode -= key;
                    char newChar = Convert.ToChar(currCharCode);

                    decryptedMessage += newChar;
                }

                Match match = regex.Match(decryptedMessage);

                if (match.Success && match.Groups[2].ToString() == "G")
                {
                    string name = match.Groups[1].ToString();
                    goodChildren.Add(name);
                }
            }

            foreach (var child in goodChildren)
            {
                Console.WriteLine(child);
            }
        }
    }
}