using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_CardsGame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> firstHandOfCards = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondHandOfCards = Console.ReadLine()
                 .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            while (firstHandOfCards.Count > 0 && secondHandOfCards.Count > 0)
            {
                int firstPlayerCard = firstHandOfCards[0];
                int secondPlayerCard = secondHandOfCards[0];

                firstHandOfCards.RemoveAt(0);
                secondHandOfCards.RemoveAt(0);

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstHandOfCards.Add(secondPlayerCard);
                    firstHandOfCards.Add(firstPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondHandOfCards.Add(firstPlayerCard);
                    secondHandOfCards.Add(secondPlayerCard);
                }
            }

            if (firstHandOfCards.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstHandOfCards.Sum()}");
            }
            else
            { 
                Console.WriteLine($"Second player wins! Sum: {secondHandOfCards.Sum()}");
            }
        }
    }
}