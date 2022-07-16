using System;
using System.Collections.Generic;

namespace _03_WordSynonyms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!map.ContainsKey(word))
                {
                    map.Add(word, new List<string>());
                }

                map[word].Add(synonym);
            }

            foreach (var word in map)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}