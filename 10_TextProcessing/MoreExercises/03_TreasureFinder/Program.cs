using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_TreasureFinder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] key = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<string> decryptedMessages = new List<string>();

            string treasurePattern = "&([A-Za-z]+)&";
            string coordinatesPattern = "<([A-Za-z0-9]+)>";

            string line = string.Empty;

            while ((line = Console.ReadLine()) != "find")
            {
                string text = line;
                string message = string.Empty;
                int keyIdx = 0;

                for (int i = 0; i < text.Length; i++)
                {
                    if (keyIdx == key.Length)
                    {
                        keyIdx = 0;
                    }

                    int currCharAsciiCode = text[i];
                    currCharAsciiCode -= key[keyIdx];
                    char newChar = Convert.ToChar(currCharAsciiCode);

                    message += newChar;
                    keyIdx++;
                }

                decryptedMessages.Add(message);
            }

            foreach (var message in decryptedMessages)
            {
                Match treasureMatch = Regex.Match(message, treasurePattern);
                Match coordinatesMatch = Regex.Match(message, coordinatesPattern);

                string treasure = treasureMatch.Groups[1].ToString();
                string coordinates = coordinatesMatch.Groups[1].ToString();

                if (string.IsNullOrWhiteSpace(treasure) || string.IsNullOrWhiteSpace(coordinates))
                {
                    continue;
                }

                Console.WriteLine($"Found {treasure} at {coordinates}");
            }
        }
    }
}
