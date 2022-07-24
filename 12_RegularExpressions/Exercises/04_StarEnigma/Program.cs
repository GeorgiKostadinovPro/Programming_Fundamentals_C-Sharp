using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_StarEnigma
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] letters = { "s", "t", "a", "r" };

            Regex regex = new Regex(@"@([A-Za-z]+)([^@\-!:>]*):([0-9]+)([^@\-!:>]*)!([AD]{1})!([^@\-!:>]*)->([0-9]+)([^@\-!:>]*)");

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = string.Empty;

                int charactersCount = encryptedMessage
                    .Count(c => letters.Contains(c.ToString().ToLower()));

                for (int j = 0; j < encryptedMessage.Length; j++)
                {
                    int currCharAsciiValue = encryptedMessage[j];
                    currCharAsciiValue -= charactersCount;
                    char newCharSymbol = Convert.ToChar(currCharAsciiValue);

                    decryptedMessage += newCharSymbol;
                }
                
                Match match = regex.Match(decryptedMessage);

                if (match.Success)
                {
                    string planetName = match.Groups[1].ToString();
                    string attackedOrDestroyed = match.Groups[5].ToString();

                    if (attackedOrDestroyed == "A")
                    {
                        attackedPlanets.Add(planetName);
                    }
                    else
                    { 
                        destroyedPlanets.Add((planetName));
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            foreach (var planet in attackedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            foreach (var planet in destroyedPlanets.OrderBy(p => p))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}