using System;
using System.Collections.Generic;

namespace _02_OddOccurrences
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> map = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i].ToLower();

                if (!map.ContainsKey(word))
                {
                    map.Add(word, 0);
                }

                map[word]++; 
            }

            foreach (var word in map)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
        }
    }
}